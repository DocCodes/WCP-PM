using System;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Loop with validation
	Date Created : 2018-09-18
	Date Updated : 2018-09-18
*/

namespace LoopValidate
{
	class Program
	{
		static void Main(string[] args)
		{
			string inpValue;
			int temp;
			int valid = 0;
			int invalid = 0;

			do
			{
				inpValue = ConDev.WriteLine.ReadLine("Please enter an integer between 0-100, 'E' to exit.");
				if (int.TryParse(inpValue, out temp) && temp <= 100 && temp >= 0)
				{
					valid++;
				}
				else
				{
					invalid++;
				}
			} while (inpValue != "E");
			invalid--;

			ConDev.FeedLine();
			Console.WriteLine($"You entered {valid} valid entries.");
			Console.WriteLine($"You entered {invalid} invalid entries.");
			ConDev.FeedLine();

			ConDev.ExitStatement();
		}
	}
}
