using System;
using ConDevLib;

/*
	Author       : Evan Young
	Comment      : Profit margin calculator
	Date Created : 2018-09-10
	Date Updated : 2018-09-10
*/

namespace ProfitMargin
{
	class Program
	{
		static void Main(string[] args)
		{
			string inpProfit;
			double profit;
			double margin;
			bool success;

			do
			{
				inpProfit = ConDev.Write.ReadLine("Profits: ");
				success = double.TryParse(inpProfit, out profit);
			} while (!success || profit < 0);

			if (profit < 1000)
			{
				margin = 0.03;
			}
			else if (profit < 5000)
			{
				margin = 0.035;
			}
			else if (profit < 10000)
			{
				margin = 0.04;
			}
			else
			{
				margin = 0.045;
			}

			Console.WriteLine($"Profit Margin: {margin:P2}");
			ConDev.ExitStatement();
		}
	}
}
