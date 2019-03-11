using System;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Multiplication table
	Date Created : 2018-09-18
	Date Updated : 2018-09-18
*/

namespace MultiplicationTable
{
	class Program
	{
		static void Main(string[] args)
		{
			string inpValue;
			bool success = false;
			int minValue = 0;
			int maxValue = 0;

			Console.WriteLine("Multiplication Table Generator");

			do
			{
				inpValue = ConDev.Write.ReadLine("Minimum Value: ");
				success = int.TryParse(inpValue, out minValue);

				if (success)
				{
					if (minValue < 2)
					{
						Console.WriteLine("The value which you have entered is too small, it must be 2-8.");
						success = false;
					}
					else if (minValue > 8)
					{
						Console.WriteLine("The value which you have entered is too large, it must be 2-8.");
						success = false;
					}
				}
			} while (!success);

			do
			{
				inpValue = ConDev.Write.ReadLine("Maximum Value: ");
				success = int.TryParse(inpValue, out maxValue);

				if (success)
				{
					if (maxValue > 8)
					{
						Console.WriteLine("The value which you have entered is too large, it must be 2-8.");
						success = false;
					}
					else if (maxValue < minValue)
					{
						Console.WriteLine("The value which you have entered is too small, it must be greater than or equal to the minimum value.");
						success = false;
					}

				}
			} while (!success);

			Console.Clear();
			Console.WriteLine("Multiplication Table Generator");
			Console.Write($"{"n",-10}");
			for (int i = minValue; i <= maxValue; i++)
			{
				Console.Write($"{i,-10}");
			}
			Console.WriteLine();

			for (int i = 1; i <= 25; i++)
			{
				Console.Write($"{i,-10}");
				for (int j = minValue; j <= maxValue; j++)
				{
					Console.Write($"{i * j,-10}");
				}
				Console.WriteLine();
			}

			ConDev.FeedLine(2);
			ConDev.ExitStatement();
		}
	}
}
