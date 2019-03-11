using System;
using System.Collections.Generic;

/*
	Author       : Evan Young
	Comment      : Metric converter
	Date Created : 2018-08-22
	Date Updated : 2018-08-22
*/

namespace MetricConverter
{
	class Program
	{
		const double GRAMS_POUND = 453.59237;

		static void Main(string[] args)
		{
			Dictionary<string, double> Products = new Dictionary<string, double>
			{ // Collection of products for sale <Name, Price 100 grams>
				{ "Montreal Smoked Meat", 2.09 },
				{ "Peameal Bacon", 1.75 }
			};

			foreach (KeyValuePair<string, double> prod in Products)
			{ // Format and print the products in the dictionary
				Console.WriteLine($"Product: {prod.Key}");
				Console.WriteLine($"Price p. 100 grams: {prod.Value:c2}");
				Console.WriteLine($"Price p. pound: {prod.Value / 100 * GRAMS_POUND:c2}");
			}

			Console.WriteLine("\nPress any key to continue. . .");
			Console.ReadKey();
		}
	}
}
