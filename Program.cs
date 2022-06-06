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

        static string productData;
        static Catalogue<product> productCatalogue;

        static void Main(string[] args)
        {
            // Runs the menu

            //productData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "ProductCatalogue.json"));
            //Catalogue<product> productCatalogue = JsonSerializer.Deserialize<Catalogue<product>>(productData);

            Catalogue<product> productCatalogue = new Catalogue<product>();

            bool runMenu = true;

            while (runMenu)
            {
               menu.MainMenu();

                string chosenNumber = Console.ReadLine();
                
                menu.userChoice(productCatalogue, chosenNumber, runMenu);
            }


        }

    }
}

