using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noodling.src.utility
{
    internal class create
    {
        public static List<string> cleanup(String[] input)
        {
            return input.ToList().Where(s => !s.Contains("#")).Where(s => !String.IsNullOrEmpty(s)).ToList();
        }
        public static void createWorld()
        {
            var continentsRaw = File.ReadAllLines("../../../resources/creation/continents.txt");
            var continents = cleanup(continentsRaw);

            var countriesRaw = File.ReadAllLines("../../../resources/creation/countries.txt");
            var countries = cleanup(countriesRaw);

            var citiesRaw = File.ReadAllLines("../../../resources/creation/cities.txt");
            var cities = cleanup(citiesRaw);
        }
    }
}
