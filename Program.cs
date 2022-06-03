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
            // Runs the menu

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

