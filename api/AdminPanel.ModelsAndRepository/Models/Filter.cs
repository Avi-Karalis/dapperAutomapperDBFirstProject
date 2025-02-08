namespace AdminPanel.ModelsAndRepository.Models {
    public class Filter {
        public string Field { get; set; } = string.Empty;
        public object? Value { get; set; }
        public string ConstraintOperator { get; set; } = "=";
    }
}
