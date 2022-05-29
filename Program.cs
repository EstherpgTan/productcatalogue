using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productcatalogue
{
    internal class Catalogue
    {
        private T[] _collection = new T[1];

        public T First => _collection[0];
        public T Second => _collection[1];

        public Catalogue(T bags, T shoes)
        {
            _collection[0] = bags;
            _collection[1] = shoes;
        }

        // Number of items/products
        public static Add()
        {
                foreach (int item in Catalogue)
            {
                Console.WriteLine(i);
            }

            // Total
            Product product = new Product;
            Console.WriteLine(product.CalculateTax());
            int.Parse(Console.ReadLine());
        }

        // View a catalogue



        // Add a new product to a catalog



        // Remove a product



        // Remove a catalogue



    }
}

