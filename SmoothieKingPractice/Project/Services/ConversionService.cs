using System.Text.Json;
using SmoothieKingPractice.Project.Models;


namespace SmoothieKingPractice.Project.Services;

public class ConversionService
{
    public List<CurrenciesItems> CurrenciesItemsList { get; set; } = new List<CurrenciesItems>();
    public void Serialize()
    {
        Currencies newCurrency = new Currencies()
        {
            createdBy = "Application Name",
            createdOn = "2022-02-01T22:43:05",
            lastUpdatedOn = "2022-02-01T22:43:05",
            api = "www.whatever.com/getdata",
            currencies = new List<CurrenciesItems>()
        };
        
        CurrenciesItems europe = new CurrenciesItems
        {
            currencyName = "EURO",
            currencySymbol = "EU",
            conversionRate = "1.2",
            enabled = "false"
        };
        CurrenciesItems cayman = new CurrenciesItems
        {
            currencyName = "Cayman island",
            currencySymbol = "KYD",
            conversionRate = "1.5",
            enabled = "true"
        };
        CurrenciesItemsList.Add(europe);
        CurrenciesItemsList.Add(cayman);
        
        var json = JsonSerializer.Serialize(newCurrency);
        Console.WriteLine(json);
    }

    public void Deserialize()
    {
        const string fileName =
            @"/Users/marcelreed/source/allata/smoothieKing/SmoothieKingPractice/SmoothieKingPractice/sampleJson.json";
        var currencyTest = JsonSerializer.Deserialize<Currencies>(File.ReadAllText(fileName));
        Console.WriteLine(currencyTest);
    }
}