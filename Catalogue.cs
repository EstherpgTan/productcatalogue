using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace productcatalogue
{
    public class Catalogue<T> where T : product
    {
        public List<T> _collection = new List<T>();
        public string name;
        public T First => _collection[0];
        public T Second => _collection[1];
        public Catalogue() { }

        public Catalogue(string newName)
        {
            name = newName;
        }

        // Number of items/products

        public void Add(T input)
        {
            _collection.Add(input);
        }

        public void printCollection()
        {
            int index = 0;
            
            foreach (T item in _collection)
            {
                Console.WriteLine($"{index}. {item.TypeOfItem} - {item.Price}");
                index++;
            }
        }

        // Total
        public double calculateTotal() { double totalTax = 0;
            foreach (T item in _collection)
            {
                totalTax += item.CalculateTax();
            }
            return totalTax;
        }
    }
}

