﻿using System;
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
                MainMenu();
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

        public static void userChoice(Catalogue<product> catalogue, string example)
        {

            switch (example)
            {
                case "1":
                    ViewCatalogue(catalogue);
                    break;

                case "2":
                    AddProductToCatalogue(catalogue);
                    break;

                case "3":
                    RemoveProduct(catalogue);
                    break;

                case "4":
                    RemoveCatalogue(catalogue);
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
                Console.WriteLine("No products available, choose another option");
            }
        }



        static void AddProductToCatalogue(Catalogue<product> someCatalogue)
        {
            Console.WriteLine("Please enter the price of product");
            double priceFromUser = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the type of product");
            string typeFromUser = Console.ReadLine();
            Console.WriteLine("Please enter the size of product");
            int sizeFromUser = int.Parse(Console.ReadLine());

            shoes PairOfShoes = new shoes(priceFromUser, typeFromUser, sizeFromUser);
            Console.WriteLine(PairOfShoes);

            someCatalogue.Add(PairOfShoes);

            //Console.WriteLine("Enter 2 to add a new product to a catalogue: ");
            //int AddProductToCatalogue = int.Parse(Console.ReadLine());
        }


        static void RemoveProduct(Catalogue<product> someCatalogue)
        {

            someCatalogue.printCollection();

            Console.WriteLine("Which product would you like to remove?");
            int removeProduct = int.Parse(Console.ReadLine());

            someCatalogue._collection.RemoveAt(removeProduct);

            Console.WriteLine("These are all the products in the catalogue after deletion of product");

            someCatalogue.printCollection();

        }

        static void RemoveCatalogue(Catalogue<product> someCatalogue)
        {
            Console.WriteLine("Enter 4 to remove a catalogue: ");
            int RemoveCatalogue = int.Parse(Console.ReadLine());
        }


    }
}

  

    


