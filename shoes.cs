using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productcatalogue
{
	internal class shoes: product
	{
		public static void newShoes()
		{
			Catalogue<shoes> ShoeCatalogue = new Catalogue<shoes>();
			double price = 0;
			string typeOfItem = "";
			int size = 0;
			bool x = true;
			while (x == true)
			{
				// Price
				Console.WriteLine("Price:");
				price = Int32.Parse(Console.ReadLine());

				// Type of Shoe
				Console.WriteLine("Type of shoe:");
				typeOfItem = Console.ReadLine();

				// Size
				Console.WriteLine("Size:");
				size = Int32.Parse(Console.ReadLine());

				shoes shoecreation = new shoes(price, typeOfItem, size);
				ShoeCatalogue.Add(shoecreation);
				Console.WriteLine($"Shoe added to catalogue - Price:{shoecreation.Price}, Type of shoe: {shoecreation.typeOfItem}, Size: {shoecreation.Size}");

				if (price == 0 && typeOfItem.Length == 0 && size == 0)
				{
					x = false;
				}
			}

		}

		public double Price;

		public shoes(double price)
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

