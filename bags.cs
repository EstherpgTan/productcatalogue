using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productcatalogue
{
	internal class bags: product

		public static void newBag()
		{
			Catalogue<bags> BagCatalogue = new Catalogue<bags>();
			double price = 0;
			string typeOfItem = "";
			int size = 0;
			bool x = true;
			while (x == true)
            {
				// Price
				Console.WriteLine("Price:");
				price = Int32.Parse(Console.ReadLine());

				// Type of Bag
				Console.WriteLine("Type of bag:");
				typeOfItem = Console.ReadLine();

				// Size
				Console.WriteLine("Size:");
				size = Int32.Parse(Console.ReadLine());

				bags bagcreation = new bags(price, typeOfItem, size);
				BagCatalogue.Add(bagcreation);
				Console.WriteLine($"Bag added to catalogue - Price:{bagcreation.Price}, Type of bag: {bagcreation.typeOfItem}, Size: {bagcreation.Size}");  

				if(price == 0 && typeOfItem.Length == 0 && size==0)
                {
					x = false;
                }
			}

		}

		public double Price;

		public bags (double price)
        {
			Price = price;
        }

		// 10% Tax
		public double CalculateTax()
        {
			double markup = Price * 0.1;
			return Price + markup;
        }

	}
}

