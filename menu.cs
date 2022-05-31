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
        // Console Menu
        public static void runMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                MainMenu();
                showMenu = false;
            }
        }

        static void MainMenu()
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

        public void userChoice()
        {

            switch (Console.ReadLine())
            {
                case "1":
                    ViewCatalogue();
                    break;

                case "2":
                    AddProductToCatalogue();
                    break;

                case "3":
                    RemoveProduct();
                    break;

                case "4":
                    RemoveCatalogue();
                    break;
            }
        }

        static string ViewCatalogue()
        {
            Console.WriteLine("Enter 1 to view catalogue: ");
            Console.WriteLine("Enter bags or shoes: ");
            return Console.ReadLine();
        }

        static void AddProductToCatalogue()
        {
            Console.WriteLine("Enter 2 to add a new product to a catalogue: ");
        }

        static void RemoveProduct()
        {
            Console.WriteLine("Enter 3 to remove a product: ");
        }

        static void RemoveCatalogue()
        {
            Console.WriteLine("Enter 4 to remove a catalogue: ");
        }

    }
}
        
    


