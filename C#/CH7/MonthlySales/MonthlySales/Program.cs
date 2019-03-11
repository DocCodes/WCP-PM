using System;
using System.Collections.Generic;
using System.Linq;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Monthly sales calculator
	Date Created : 2018-09-26
	Date Updated : 2018-09-26
*/

namespace MonthlySales
{
	class Program
	{
		static void DisplayInstructions()
		{
			Console.WriteLine("Ion Realty Sales Corporation Monthly Sales Calculator");
			Console.WriteLine("This program accepts any number to represent monthly sales.");
			Console.WriteLine("To stop entering values and generate the report, ente 'Q'.");
		}

		static void DisplayResults(List<decimal> sales)
		{
			decimal totalSales = sales.Aggregate(0M, (acc, x) => acc += x);
			Console.WriteLine("   Ion Realty Sales Corporation Sales   \n");

			foreach (decimal sale in sales)
			{
				Console.WriteLine($"{sale,-25:C2}{sale / totalSales,15:P0}");
			}

			Console.WriteLine(new string('-', 40));
			Console.WriteLine($"{totalSales,-25:C2}{1,15:P0}");
		}

		static List<decimal> GetSales()
		{
			List<decimal> ret = new List<decimal> { };
			string inpValue;
			decimal decVal;

			do
			{
				inpValue = ConDev.Write.ReadLine("Monthly Sales: ");
				if (decimal.TryParse(inpValue, out decVal))
				{
					ret.Add(decVal);
					ConDev.FeedLine();
				}
				else if (inpValue.ToUpper() == "Q")
				{
					ConDev.FeedLine(2);
					break;
				}
				else
				{
					Console.WriteLine("Invalid input, entry ignored.");
				}
				ConDev.FeedLine();
			} while (true);

			return ret;
		}

		static void Main(string[] args)
		{
			List<decimal> monthlySales = GetSales();

			Console.Clear();
			DisplayResults(monthlySales);

			ConDev.FeedLine();
			ConDev.ExitStatement();
		}
	}
}
