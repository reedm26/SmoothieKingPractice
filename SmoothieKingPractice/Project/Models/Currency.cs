namespace SmoothieKingPractice.Project.Models
{
    public class Currency
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public decimal ConversionRate { get; set; }
        public int StoreNumber { get; set; }
    }
}