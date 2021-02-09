using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesMVC
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            Console.WriteLine("Flag Colors:");
            foreach(string color in DisplayCountry.Colors)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("_____________________________________________");
        }
    }
}
