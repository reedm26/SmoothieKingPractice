using System.Text.Json;
using SmoothieKingPractice.Project.Models;


namespace SmoothieKingPractice.Project.Services;

public class ConversionService
{
    public void Serialize()
    {
        var currency = new Currency()
        {
            Id = 1234,
            Country = "Cayman Islands",
            ConversionRate = (decimal)0.41,
            StoreNumber = 7,
        };
        var json = JsonSerializer.Serialize(currency);
        Console.WriteLine(json);
    }

    public void Deserialize()
    {
        const string fileName = @"/Users/marcelreed/source/allata/smoothieKing/SmoothieKingPractice/SmoothieKingPractice/sampleJson.json";
        var currencyTest = JsonSerializer.Deserialize<Currency>(File.ReadAllText(fileName));
        Console.WriteLine(currencyTest);
    }
}