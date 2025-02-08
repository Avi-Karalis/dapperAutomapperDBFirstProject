using AdminPanel.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RequestTransformer.Middlewares;

namespace AdminPanel.Api.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class ApiTransformController: ControllerBase {

        [HttpPost("receive-and-transform")]
        public async Task<IActionResult> ReceiveAndTransform() {
            if (!HttpContext.Items.TryGetValue("TransformedPayload", out var transformedPayloadObj) ||
                transformedPayloadObj is not OutputPayload transformedPayload) {
                return BadRequest("Payload transformation failed.");
            }

            return Ok(transformedPayload);

        }
    }
}
