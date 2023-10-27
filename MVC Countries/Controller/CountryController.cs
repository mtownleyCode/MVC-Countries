
using MVC_Countries.Models;
using MVC_Countries.Views;


namespace MVC_Countries.Controller
{
    public class CountryController
    {
        public List<string> USAandFranceColors = new List<string>()
        {
            "Red",
            "White",
            "Blue"
        };

        public List<string> JapanColors = new List<string>()
        {            
            "White",
            "Red"
        };

        public List<Country> CountryDb = new List<Country>();
        
        public CountryController()
        {
            CountryDb.Add(new Country("USA", "North America", USAandFranceColors));
            CountryDb.Add(new Country("France", "Europe", USAandFranceColors));
            CountryDb.Add(new Country("Japan", "Asia", JapanColors));
        }

        public void CountryAction(Country country)
        {            
            CountryView countryView = new CountryView(country);
            countryView.Display();
        }

        public void WelcomeAction()
        {
            int validMenuNumber;

            bool redoLoop = true;

            CountryListView countryListView = new CountryListView(CountryDb);

            Console.WriteLine("Hello, welcome to the country app.");
            
            while (redoLoop)
            {
                Console.WriteLine();

                Console.WriteLine("Please select a country from the following list:");

                countryListView.Display();

                while (!int.TryParse(Console.ReadLine(), out validMenuNumber) ||
                      (validMenuNumber < 0 && validMenuNumber > CountryListView.Countries.Count + 1))
                {
                    Console.WriteLine();

                    Console.WriteLine($"Enter a valid number.");

                }

                Console.WriteLine();

                if (validMenuNumber == CountryListView.Countries.Count + 1)
                {
                    redoLoop = false;
                }
                else
                {
                    CountryAction(CountryDb[validMenuNumber - 1]);
                }
                
            }
        
        }
    
    }

}
