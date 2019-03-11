using System;

/*
	Author       : Evan Young
	Comment      : Comment here
	Date Created : 2018-08-23
	Date Updated : 2018-08-23
*/

namespace ChangeCalculator
{
	public class Coin
	{
		public Coin(string name, decimal value)
		{
			Name = name;
			Value = value;
			Count = 0;
		}
		public Coin(string name, decimal value, int count)
		{
			Name = name;
			Value = value;
			Count = count;
		}

		public string Name { get; }
		public decimal Value { get; }
		public int Count { get; set; }
	}

	class Program
	{
		static string WriteReadLine(string msg)
		{
			Console.Write(msg);
			return Console.ReadLine();
		}

		static void Exit(int exitCode)
		{
			Console.WriteLine("Press any key to continue. . .");
			Console.ReadKey();
			Environment.Exit(exitCode);
		}
		static void Main(string[] args)
		{
			string inputCost = WriteReadLine("Sale Cost: ");
			string inputPayment = WriteReadLine("Payment: ");

			try
			{ // Try to convert the inputs to decimals
				Convert.ToDecimal(inputCost);
				Convert.ToDecimal(inputPayment);
			}
			catch (Exception)
			{ // Report error and end program
				Console.WriteLine("Invalid cost a/o payment.");
				throw;
			}
			decimal cost = Convert.ToDecimal(inputCost); // Total cost
			decimal payment = Convert.ToDecimal(inputPayment); // Payment
			decimal diff = payment - cost; // End diff change to print
			decimal iterDiff = payment - cost; // Diff to alter during iteration
			Coin[] retCoins = new Coin[]
			{
				new Coin("Half", 0.50M),
				new Coin("Quarter", 0.25M),
				new Coin("Dime", 0.10M),
				new Coin("Nickel", 0.05M),
				new Coin("Penny", 0.01M),
			};

			foreach (Coin coin in retCoins)
			{
				coin.Count = (int)Math.Floor(iterDiff / coin.Value);
				iterDiff -= coin.Count * coin.Value;

				Console.WriteLine($"{coin.Name,7} -- {coin.Count,2:F0} -- {coin.Count * coin.Value,6:C2}");
			}
			Console.WriteLine($"Change: {diff}");

			Exit(0);
		}
	}
}
