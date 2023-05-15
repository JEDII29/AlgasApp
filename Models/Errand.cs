namespace AlgasApp.Models
{
    public class Errand
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string ServiceType { get; set; } = string.Empty;
        public DateTime OrderTime { get; set; }
        public string Description { get; set; } = string.Empty;

        public Errand() { }

    }
}
