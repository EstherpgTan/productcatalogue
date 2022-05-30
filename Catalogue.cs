using System;
using System.Collections.Generic;

namespace productcatalogue
{
    public class Catalogue<T> where T : product
    {
        public List<T> _collection = new List<T>();
        public string name;
        public T First => _collection[0];
        public T Second => _collection[1];
        public Catalogue() { };

        public Catalogue(string newName)
        {
            name = newName;
        }
        public Catalogue(T bags, T shoes)
        {
            _collection[0] = bags;
            _collection[1] = shoes;
        }

        // Number of items/products

        public void Add(T input)
        {
            _collection.Add(input);

        }
        public void printCollection()
        {

            foreach (T item in _collection)
            {
                Console.WriteLine(item.Name);
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
    
            
        // View a catalogue



        // Add a new product to a catalog



        // Remove a product



        // Remove a catalogue



 



		
	}
}

