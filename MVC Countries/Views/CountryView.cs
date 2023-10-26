using MVC_Countries.Models;
using System.Diagnostics.Metrics;

namespace MVC_Countries.Views
{
    public class CountryView
    {
        public Country DisplayCountry;

        public CountryView(Country country)
        {
            DisplayCountry = country;
        }

        public void Display()
        {
            string color;

            Console.WriteLine("Country Info:");
            Console.WriteLine($"  Country Name: { DisplayCountry.Name }");
            Console.WriteLine($"  Country Continent: { DisplayCountry.Continent }");
            Console.WriteLine("  Country Colors: ");
            
           for (int i = 0; i < DisplayCountry.Colors.Count; i++)
           {
                if (DisplayCountry.Colors[i] == "Red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"    { DisplayCountry.Colors[i] }");
                }

                if (DisplayCountry.Colors[i] == "White")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"    { DisplayCountry.Colors[i] }");
                }

                if (DisplayCountry.Colors[i] == "Blue")
                {
                  Console.ForegroundColor = ConsoleColor.Blue;
                  Console.WriteLine($"    { DisplayCountry.Colors[i] }");
               }
           }

            Console.ForegroundColor = ConsoleColor.Gray;

        }
   
    }

}
