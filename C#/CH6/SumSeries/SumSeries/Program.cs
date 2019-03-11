using System;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Sums a repeated value any number of times, up to 9.
	Date Created : 2018-09-19
	Date Updated : 2018-09-19
*/

namespace SumSeries
{
	class Program
	{
		static void Main(string[] args)
		{
			int total = 0;
			int timesRepeat;
			string inpValue;
			string curTerm;

			Console.WriteLine("This program will sum a number any number of times, please enter the number of times to sum '5'.");
			do
			{
				inpValue = ConDev.WriteLine.ReadLine("Enter a number between 1 and 9.");
			} while (!(int.TryParse(inpValue, out timesRepeat) && timesRepeat <= 9 && timesRepeat >= 1));

			for (int i = 1; i < timesRepeat; i++)
			{
				curTerm = new string('5', i);
				total += int.Parse(curTerm);
				Console.Write($"{curTerm} + ");
			}
			curTerm = new string('5', timesRepeat);
			total += int.Parse(curTerm);
			Console.Write($"{curTerm} = {total}\n");
			Console.WriteLine(total);

			ConDev.ExitStatement();
		}
	}
}
