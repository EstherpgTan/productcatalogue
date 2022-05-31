using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace productcatalogue
{
    internal class Program {
        static void Main(string[] args)
        {
            // View catalogue
            Catalogue<bags> bagCatalogue = new Catalogue<bags>();
            Catalogue<shoes> shoeCatalogue = new Catalogue<shoes>();

            bags newBag = new bags(10);

            menu.runMenu();

            printCatalogue(_collection);

            // Add product to catalogue

            AddCatalogues;

            // Remove product


            // Remove catalogue
            DeleteCatalogue;


            // new class menu
            // display menu method
            // empty constructor
            // display menu take in an array of options. Render each option to the console.

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

        }

    }
}

