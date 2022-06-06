using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace productcatalogue
{
    public class menu
    {
        static string productData;
        static Catalogue<product> productCatalogue;

        static string filepath = "";

        //productData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "ProductCatalogue.json"));

        Catalogue<product> ProductCatalogue = JsonSerializer.Deserialize<Catalogue<product>>(productData);


        public static void MainMenu()
        {
            // Prints to a blank screen
            Console.Clear();

            // Prints Menu
            Console.WriteLine("1. View a catalogue");
            Console.WriteLine("2. Add a new product to a catalogue");
            Console.WriteLine("3. Remove a product");
            Console.WriteLine("4. Remove a catalogue");
            Console.WriteLine("Select an option:");
        }

        public static void userChoice(Catalogue<product> catalogue, string example, bool someBoolean)
        {

            switch (example)
            {
                case "1":
                   Catalogue<product> productCatalogue = new Catalogue<product>();
                    string filepath = "";
                    ViewCatalogue(catalogue);
                    break;

                case "2":
                    AddProductToCatalogue(catalogue);
                    break;

                case "3":
                    RemoveProduct(catalogue);
                    break;

                case "4":
                    RemoveCatalogue(catalogue, someBoolean);
                    break;
            }
        }

        static void ViewCatalogue(Catalogue<product> someCatalogue)
        {

            if (someCatalogue._collection.Count > 0)
            {
                someCatalogue.printCollection();
            }
            else
            {
                Console.WriteLine("No products available, choose another option:");

            }
            Console.WriteLine("Please press any key to continue:");
            string key = Console.ReadLine();
        }

        static void AddProductToCatalogue(Catalogue<product> someCatalogue)
        {
            Console.WriteLine("Please enter the price of product:");
            double priceFromUser = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the type of product:");
            string typeFromUser = Console.ReadLine();
            Console.WriteLine("Please enter the size of product, enter in a number:");
            int sizeFromUser = int.Parse(Console.ReadLine());

            shoes PairOfShoes = new shoes(priceFromUser, typeFromUser, sizeFromUser);
            Console.WriteLine(PairOfShoes);

            someCatalogue.Add(PairOfShoes);

        
            filepath = Path.Combine(Directory.GetCurrentDirectory(), "ProductCatalogue.json");
            File.WriteAllText(filepath, stateCatalogue.serialize(productCatalogue));
        }


        static void RemoveProduct(Catalogue<product> someCatalogue)
        {

        someCatalogue.printCollection();

        Console.WriteLine("Which product would you like to remove? Please type in a number.");
        int removeProduct = int.Parse(Console.ReadLine());

        someCatalogue._collection.RemoveAt(removeProduct);

        Console.WriteLine("These are all the products in the catalogue after deletion of product");

        someCatalogue.printCollection();

        filepath = Path.Combine(Directory.GetCurrentDirectory(), "ProductCatalogue.json");
        File.WriteAllText(filepath, stateCatalogue.serialize(productCatalogue));

    }
        

        static void RemoveCatalogue(Catalogue<product> someCatalogue, bool someBoolean)
        {
            someCatalogue = null;
            Console.WriteLine("Catalogue deleted");
            someBoolean = false;
            Console.WriteLine("Press any key to exit");
            string anyKey = Console.ReadLine();
            Console.Clear();

            filepath = Path.Combine(Directory.GetCurrentDirectory(), "ProductCatalogue.json");
            File.WriteAllText(filepath, stateCatalogue.serialize(productCatalogue));

        }


    }
}

  

    


