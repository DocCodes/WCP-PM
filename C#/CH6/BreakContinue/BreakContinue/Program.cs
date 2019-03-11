using System;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Break and continue examples
	Date Created : 2018-09-19
	Date Updated : 2018-09-19
*/

namespace BreakContinue
{
	class Program
	{
		static void Main(string[] args)
		{
			int total = 0;
			int[] numbs = { 2, 4, 6, 8, 10 };

			Console.WriteLine("Break Statement");
			for (int i = 0; i < 10; i++)
			{
				if (i == 5)
				{
					break;
				}
				total += i;
				Console.Write($"{i}\t");
			}
			Console.WriteLine($"\nThe total is {total}");

			total = 0;
			Console.WriteLine("Continue Statement");
			for (int i = 0; i < 10; i++)
			{
				if (i == 5)
				{
					continue;
				}
				total += i;
				Console.Write($"{i}\t");
			}
			Console.WriteLine($"\nThe total is {total}");

			Console.WriteLine("For Each Statement");
			foreach (int i in numbs)
			{
				Console.Write($"{i}\t");
			}
			ConDev.FeedLine();

			ConDev.ExitStatement();
		}
	}
}
