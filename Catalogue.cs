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
        public Catalogue() { }

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


        // new class menu
        // display menu method
        // empty constructor
        // display  menu take in an array of options. Render each option to the console.

        //View a catalogue
        //Add a new product to a catalogue
        //Remove a product
        //Remove a catalogue

        // Inside program create a new instance of menu class, run display method on instance
        // .eg. menu.DisplayOptions pass in array of view of catalogue etc
        // Create a new instance of a catalogue

        // Console.ReadLine()
        // Switch statement
        // Use the printCollection method to print
        // If add product to catalgue : Create a new bag or shoe ? Run the new bag/shoe method

        // Remove a product
        // What product you want to remove ?
        // FInd product in catalogue list _Collection
        // Then remove it


        // Draw a diagram of e.g. remove a product
        // Do the menu






    }
}

