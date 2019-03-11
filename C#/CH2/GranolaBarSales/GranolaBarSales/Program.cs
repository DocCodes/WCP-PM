using System;
using System.Collections.Generic;

/*
	Author       : Evan Young
	Comment      : Granola bar sales calculator
	Date Created : 2018-08-22
	Date Updated : 2018-08-22
*/

namespace GranolaBarSales
{
	class Program
	{
		const short BARS_CASE = 100;
		const decimal BAR_PRICE = 1.50M;
		const decimal CASE_PRICE = 100.00M;
		const decimal SGA_TAX = 0.10M;

		static void Main(string[] args)
		{
			const sbyte PaddingLeft = -15; // Used for string padding
			const sbyte PaddingRight = 15; // Used for string padding
			int CasesSold = 29;

			// Calculations
			decimal GrossSales = CasesSold * BARS_CASE * BAR_PRICE;
			decimal ProductCosts = CasesSold * CASE_PRICE;
			decimal SGAFees = GrossSales * SGA_TAX;
			decimal NetSales = GrossSales - ProductCosts - SGAFees;
			Dictionary<string, decimal> PrintDictionary = new Dictionary<string, decimal>
			{
				{ "Cases Sold:", CasesSold },
				{ "Gross Sales:", GrossSales },
				{ "Net Sales:", NetSales },
				{ "Product Costs:", ProductCosts },
				{ "SGA Fees:", SGAFees }
			};

			foreach (KeyValuePair<string, decimal> entry in PrintDictionary) // Pads and prints the values
			{
				if (entry.Key == "Cases Sold:") // Print as number
				{
					Console.WriteLine($"{entry.Key,PaddingLeft}{entry.Value,PaddingRight:n0}");
				}
				else // Print as currency
				{
					Console.WriteLine($"{entry.Key,PaddingLeft}{entry.Value,PaddingRight:c2}");
				}
			}

			Console.WriteLine("Press any key to continue. . .");
			Console.ReadKey();
		}
	}
}
