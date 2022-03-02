namespace SmoothieKingPractice.Project.Models;

public class Currencies
{
    public string createdBy { get; set; }

    public string createdOn { get; set; }

    public string lastUpdatedOn { get; set; }

    public string api { get; set; }

    public List<CurrenciesItems> currencies { get; set; }
}