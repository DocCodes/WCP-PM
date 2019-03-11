using System;
using ConDevLib;

/*
	Author       : Evan Young
	Comment      : Markup calculator
	Date Created : 2018-08-28
	Date Updated : 2018-08-28
*/

namespace MarkupCalculator
{
	class Program
	{
		/// <summary>
		/// Calculates the retail price of an item given its wholesale value and markup percentage.
		/// </summary>
		/// <param name="wholesale">The wholesale value.</param>
		/// <param name="markup">The markup precentage.</param>
		/// <returns>The retail price.</returns>
		static decimal MarkupWholesale(decimal wholesale, decimal markup)
		{
			return wholesale + (wholesale * markup);
		}

		static void Main(string[] args)
		{
			string inputWholesale = ConDev.Write.ReadLine("Wholesale Cost: ");
			string inputMarkup = ConDev.Write.ReadLine("Markup Percentage: ");
			decimal costWholesale;
			decimal costMarkup;
			decimal costRetail;

			if (!decimal.TryParse(inputWholesale, out costWholesale))
			{ // Invalid wholesale cost entered.
				Console.WriteLine("Invalid wholesale cost entered.");
				ConDev.ExitStatement(13);
			}
			if (!decimal.TryParse(inputMarkup, out costMarkup))
			{ // Invalid markup percentag entered.
				Console.WriteLine("Invalid markup percentag entered.");
				ConDev.ExitStatement(13);
			}
			costMarkup /= 100;
			costRetail = MarkupWholesale(costWholesale, costMarkup);
			Console.WriteLine($"Retail Price: {costRetail}");

			ConDev.ExitStatement(0);
		}
	}
}
