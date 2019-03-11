using System;
using ConDevLib;

/*
	Author       : Evan Young
	Comment      : Even or odd using ternary if statements
	Date Created : 2018-09-07
	Date Updated : 2018-09-07
*/

namespace Ternary
{
	class Program
	{
		static void Main(string[] args)
		{
			bool didConvert = false;
			string isEven;
			string inpVal;
			int val;

			do
			{
				inpVal = ConDev.WriteLine.ReadLine("Please enter a number.");
				didConvert = int.TryParse(inpVal, out val);
				if (!didConvert)
				{
					Console.Clear();
					Console.WriteLine("The number you entered is invalid.");
				}
			} while (!didConvert);

			isEven = val % 2 == 1 ? "odd": "even";

			Console.WriteLine($"{val} is {isEven}");

			ConDev.ExitStatement();
		}
	}
}
