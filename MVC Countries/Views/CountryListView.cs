
using MVC_Countries.Models;

namespace MVC_Countries.Views
{
    public class CountryListView
    {
        public static List<Country> Countries { get; set; }

        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        public void Display()
        {

            for (int i = 0; i < Countries.Count; i++) 
            {
                Console.WriteLine($"{ i + 1 }. { Countries[i].Name }");

            }
            
            Console.WriteLine();

            Console.WriteLine($"{ Countries.Count + 1 } Exit");
            
        }

    }

}
