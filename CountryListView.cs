using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesMVC
{
    class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> Countries)
        {
            this.Countries = Countries;
        }

        public void Display()
        {
            foreach(Country country in Countries)
            {
                Console.WriteLine($"[{Countries.IndexOf(country) + 1}] {country.Name}");
            }
        }
    }
}
