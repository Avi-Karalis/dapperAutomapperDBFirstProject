using Newtonsoft.Json;
using System.Text;

namespace RequestTransformer.Middlewares {
    public class RequestTransformationMiddleware {

        private readonly RequestDelegate _next;
        private readonly ILogger<RequestTransformationMiddleware> _logger;

        public RequestTransformationMiddleware(RequestDelegate next, ILogger<RequestTransformationMiddleware> logger) {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context) {
            if (context.Request.Path.StartsWithSegments("/api/") && context.Request.Method == "POST") {
                context.Request.EnableBuffering();
                var requestBody = await new StreamReader(context.Request.Body).ReadToEndAsync();
                context.Request.Body.Position = 0;

                try {
                    // Deserialize the incoming payload
                    InputPayload incomingPayload = JsonConvert.DeserializeObject<InputPayload>(requestBody);

                    // Transform the payload dynamically
                    OutputPayload outgoingPayload = TransformPayload(incomingPayload);

                    // Store transformed payload in HttpContext.Items
                    context.Items["TransformedPayload"] = outgoingPayload;

                    // Convert transformed payload to JSON string
                    string outgoingJson = JsonConvert.SerializeObject(outgoingPayload);
                    byte[] outgoingBytes = Encoding.UTF8.GetBytes(outgoingJson);

                    // Replace the request body with transformed payload
                    context.Request.Body = new MemoryStream(outgoingBytes);
                    context.Request.ContentLength = outgoingBytes.Length;
                    context.Request.Body.Position = 0;
                } catch (Exception ex) {
                    context.Response.StatusCode = 400;
                    await context.Response.WriteAsync($"Error in request transformation: {ex.Message}");
                    return;
                }
            }

            await _next(context);
        }
        private static OutputPayload TransformPayload(InputPayload input) {
            OutputPayload output = new() {
                SortField = input.SortField,
                SortOrder = input.SortOrder ?? "asc",
                Page = 1,
                PerPage = 6,
                Filters = new List<Filter>()
            };
            foreach (var filter in input.Filters) {
                var field = filter.Key;
                var constraints = filter.Value.Constraints;
                foreach (var constraint in constraints) {
                    if (!string.IsNullOrEmpty(constraint.Value)) {
                        string constraintOperator = GetConstraintOperator(constraint.MatchMode);
                        output.Filters.Add(new Filter() {
                        Field = field,
                        Value = constraint.Value,
                        ConstraintOperator = constraintOperator});
                    }
                }
            }
            return output;
        }

        private static string GetConstraintOperator(string matchMode) {
            return matchMode switch {
            "contains" => "like*",
            "equals" => "=",
            "greaterThan" => ">",
            "lessThan" => "<",
            "greaterThanOrEqual" => ">=",
            "lessThanOrEqual" => "<=",
            _ => "="
            };
        }
    }
    public class InputPayload {
        public string SortField { get; set; }
        public string SortOrder { get; set; }
        public Dictionary<string, FilterGroup> Filters { get; set; }
    }

    public class FilterGroup {
        public string Operator { get; set; }
        public List<Constraint> Constraints { get; set; }
    }

    public class Constraint {
        public string Value { get; set; }
        public string MatchMode { get; set; }
    }

    public class OutputPayload {
        public List<Filter> Filters { get; set; }
        public int Page { get; set; }
        public int PerPage { get; set; }
        public string SortOrder { get; set; }
        public string SortField { get; set; }
    }

    public class Filter {
        public string Field { get; set; }
        public string Value { get; set; }
        public string ConstraintOperator { get; set; }
    }
}
