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
            //while(true)
            {
               menu.runMenu();
            }
           

            // View catalogue
            Catalogue<product> productCatalogue = new Catalogue<product>();
            //Catalogue<shoes> shoeCatalogue = new Catalogue<shoes>();

            bags newBag = new bags(10.00, "handbag", 2);
            shoes newShoe = new shoes(50.00, "boots", 4);

            // Add a new product
            string example = Console.ReadLine();
            menu.userChoice(productCatalogue, example);

          
              

            // Remove/delete catalogue
            
            

        }

    }
}

