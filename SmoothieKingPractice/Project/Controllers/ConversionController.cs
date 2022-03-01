using SmoothieKingPractice.Project.Services;

namespace SmoothieKingPractice.Project.Controllers;

public class ConversionController
{
    private readonly ConversionService _conversionService = new ConversionService();

    public void JsonOption()
    {
        Console.Clear();
        Console.WriteLine("Serialize or Deserialize");
        var input = Console.ReadLine().ToLower() + " ";
        var command = input.Substring(0, input.Length - 1);
        switch (command)
        {
            case "serialize":
                _conversionService.Serialize();
                break;
            case "deserialize":
                _conversionService.Deserialize();
                break;
        }
    }
}