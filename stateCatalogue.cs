using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace productcatalogue
{
	internal class stateCatalogue
	{
		public static string serialize<T>(Catalogue<T>productCatalogue) where T: product
		{
			return JsonSerializer.Serialize(productCatalogue);
		}
	}
}

