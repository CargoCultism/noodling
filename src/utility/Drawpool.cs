using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Provider;

namespace noodling.src.utility
{
    public class Drawpool<T>
    {
        private List<T> elements;

        public Drawpool(IEnumerable<T> values) 
        {
            elements = values.ToList();
        }
        
        public T draw()
        {
            if (elements.Count == 0)
                return default(T);
            Random rnd = new Random();
            var index = rnd.Next(elements.Count() - 1);
            var drawn = elements.ElementAt(index);
            elements.Remove(drawn);
            return drawn;
        }
    }
}
