using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productcatalogue
{
	internal class shoes : product
{
	shoes(double price, string typeOfItem, int size)
	{
		Price = price;
		TypeOfItem = typeOfItem;
		Size = size;
	}
	public static void newShoe(Catalogue<product> catalogue)
	{
		//Catalogue<shoes> BagCatalogue = new Catalogue<shoes>();
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

			shoes shoecreation = new shoes(price, typeOfItem, size);
			catalogue.Add(shoecreation);
			Console.WriteLine($"Shoe added to catalogue - Price:{shoecreation.Price}, Type of shoe: {shoecreation.TypeOfItem}, Size: {shoecreation.Size}");

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


