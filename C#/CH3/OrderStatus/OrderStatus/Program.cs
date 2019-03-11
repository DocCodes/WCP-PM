using System;
using System.Collections.Generic;
using ConDevLib;

/*
	Author       : Evan Young
	Comment      : Order status calculator
	Date Created : 2018-08-28
	Date Updated : 2018-08-28
*/

namespace OrderStatus
{
	class Program
	{
		const decimal PRICE = 100.00M;
		const decimal SHIP_HANDLE = 10.00M;

		/// <summary>
		/// Gets the number of spools ordered, validated to the next whole number.
		/// </summary>
		/// <returns>The number of spools ordered.</returns>
		static int GetSpoolsOrdered()
		{
			string inputValue = ConDev.Write.ReadLine("Number of Spools Ordered: ");
			double spoolsOrdered;
			if (!double.TryParse(inputValue, out spoolsOrdered))
			{
				Console.WriteLine("Invalid number of spools ordered entered.");
				ConDev.ExitStatement(13);
			}
			if (spoolsOrdered != Math.Ceiling(spoolsOrdered))
			{
				Console.WriteLine("You can only order whole spools, so we've rounded you up.");
			}

			return (int)Math.Ceiling(spoolsOrdered);
		}

		/// <summary>
		/// Gets the number of spools stocked, validated to the next whole number.
		/// </summary>
		/// <returns>The number of spools stocked.</returns>
		static int GetSpoolsStocked()
		{
			string inputValue = ConDev.Write.ReadLine("Number of Spools Stocked: ");
			double spoolsStocked;
			if (!double.TryParse(inputValue, out spoolsStocked))
			{
				Console.WriteLine("Invalid number of spools stocked entered.");
				ConDev.ExitStatement(13);
			}
			if (spoolsStocked != Math.Ceiling(spoolsStocked))
			{
				Console.WriteLine("You can only store whole spools, so we've rounded you up.");
			}

			return (int)Math.Ceiling(spoolsStocked);
		}

		/// <summary>
		/// Displays the spool data such as back-order, current stock, price, etc.
		/// </summary>
		/// <param name="ordered">The number of spools ordered.</param>
		/// <param name="stocked">The number of spools stocked.</param>
		static void DisplayData(int ordered, int stocked)
		{
			const int leftPad = 15;
			const int rightPad = 12;
			Dictionary<string, string> toWrite = new Dictionary<string, string>
			{
				{ "Stocked:", stocked.ToString() },
				{ "Back-Order:", ordered.ToString() },
				{ "Subtotal:", $"{stocked * PRICE:C2}" },
				{ "Shipping:", $"{stocked * SHIP_HANDLE:C2}" },
				{ "Total:", $"{stocked * (PRICE + SHIP_HANDLE):C2}" }
			};

			foreach (KeyValuePair<string, string> line in toWrite)
			{
				Console.WriteLine($"{line.Key,-leftPad}{line.Value,rightPad}");
			}
		}

		static void Main(string[] args)
		{
			int spoolsOrdered = GetSpoolsOrdered();
			int spoolsStocked = GetSpoolsStocked();
			DisplayData(spoolsOrdered, spoolsStocked);

			ConDev.FeedLine(2);
			ConDev.ExitStatement();
		}
	}
}
