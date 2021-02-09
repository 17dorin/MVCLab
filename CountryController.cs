using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesMVC
{
    class CountryController
    {
        List<Country> CountryDb { get; set; } = new List<Country>();

        public CountryController()
        {
            Country c1 = new Country();
            c1.Name = "Chad";
            c1.Continent = "Africa";
            c1.Colors = new List<string> { "Blue", "Gold", "Red" };

            CountryDb.Add(c1);

            Country c2 = new Country();
            c2.Name = "Germany";
            c2.Continent = "Europe";
            c2.Colors = new List<string> {"Black", "Red", "Gold" };

            CountryDb.Add(c2);
        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public void WelcomeAction()
        {

            CountryListView clv = new CountryListView(CountryDb);
            Console.WriteLine("Welcome to the country app. Please select a country from the following list:");

            while (true)
            {
                clv.Display();
                int input = int.Parse(Console.ReadLine());
                CountryAction(CountryDb[input - 1]);
                Console.WriteLine("Learn about another country? Y/N");

                if(Console.ReadKey().KeyChar == 'n')
                {
                    break;
                }
            }

        }
    }
}
