using System;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Loop examples
	Date Created : 2018-09-17
	Date Updated : 2018-09-17
*/

namespace LoopEx
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 0;
			int val;
			string inpVal;

			Console.WriteLine("While Do Loop");
			while (i < 11)
			{
				Console.Write($"{i} ");
				i++;
			}
			ConDev.FeedLine(2);

			i = 0;
			Console.WriteLine("Do While Loop");
			do
			{
				Console.Write($"{i} ");
				i++;
			} while (i < 11);
			ConDev.FeedLine(2);

			Console.WriteLine("For Loop");
			for (i = 0; i < 11; i++)
			{
				Console.Write($"{i} ");
			}
			ConDev.FeedLine(2);

			Console.WriteLine("Sentinel Loop");
			Console.WriteLine("Please enter a numerical value for calculation.");
			inpVal = Console.ReadLine();
			while (inpVal != "Q")
			{
				Console.WriteLine("Enter the next value, or 'Q' to quit.");
				inpVal = Console.ReadLine();
			}
			ConDev.FeedLine(2);

			inpVal = ConDev.WriteLine.ReadLine("Please enter an integer.");
			while (!int.TryParse(inpVal, out val))
			{
				inpVal = ConDev.WriteLine.ReadLine("Invalid integer, please enter an integer.");
			}
			ConDev.FeedLine(2);

			ConDev.ExitStatement();
		}
	}
}
