// See https://aka.ms/new-console-template for more information

using SmoothieKingPractice.Project.Controllers;

namespace SmoothieKingPractice
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            ConversionController cc = new ConversionController();
            cc.JsonOption();
        }
    }
}