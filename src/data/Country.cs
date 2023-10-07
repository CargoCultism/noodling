using ABI.System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noodling.src.data
{
    public class City
    {
        public string Name { get; set; }

    }
    public class Country
    {
        public string Name { get; set; }
        public ObservableCollection<City> Cities { get; set; }

        public Country(IEnumerable<City> cities) 
        { 
            Cities = new ObservableCollection<City>();
            foreach (var c in cities)
            {
                Cities.Add(c);
            }
        }
    }

    public class Continent
    {
        public string Name { get; set; }
        public ObservableCollection<Country> Countries { get; set; }

        public Continent(IEnumerable<Country> countries)
        {
            Countries = new ObservableCollection<Country>(countries);

        }
    }
}
