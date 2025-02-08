namespace AdminPanel.ModelsAndRepository.Models {
    public class QueryParameters {
        public List<Filter>? Filters { get; set; } = new List<Filter>();
        public string? SortField { get; set; } = "id";
        public string? SortOrder { get; set; } = "asc";
        public int? Page { get; set; } = 1;
        public int? PerPage { get; set; } = 6;
    }
}
