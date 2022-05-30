using System;
namespace productcatalogue
{
	public abstract class product
	{
        public double Price { get; }
        public string TypeOfItem { get; set; }
        public int Size { get; set; }
		public string Name;
        public double CalculateTax()
        {
            double markup = Price * 0.1;
            return Price + markup;
        }
    }
	


}



