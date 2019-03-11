using System;
using System.Collections.Generic;
using System.Linq;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Arrays demo
	Date Created : 2018-09-26
	Date Updated : 2018-09-26
*/

namespace ArrayDemo
{
	class Program
	{
		static void DisplayInstructions()
		{
			Console.WriteLine("This application will allow you to enter any number of entries between 0 and 10");
			Console.WriteLine("When you stop entering values, a message will display the values you entered along with the number of times it was entered.");
			Console.WriteLine("To stop entering values, type -1.");
			ConDev.FeedLine();
		}

		static List<int> GetValues()
		{
			string inpValue;
			int intValue;
			List<int> entries = new List<int> { };
			do
			{
				inpValue = ConDev.Write.ReadLine("Input any number 0-10: ");
				if (int.TryParse(inpValue, out intValue))
				{
					if (intValue == -1)
					{
						break;
					}
					else if (intValue <= 10 && intValue >= 0)
					{
						entries.Add(intValue);
					}
					else
					{
						Console.WriteLine("Invalid entry, ignored.");
					}
				}
				else
				{
					Console.WriteLine("Invalid entry, ignored.");
				}
				ConDev.FeedLine();
			} while (true);

			return entries;
		}

		static void Main(string[] args)
		{
			List<int> entries = new List<int> { };
			List<int> counts = new List<int> { };

			DisplayInstructions();
			entries = GetValues();

			ConDev.FeedLine(2);
			for (int i = 0; i < 11; i++)
			{
				counts.Add(entries.Aggregate(0, (acc, x) => acc += x == i ? 1 : 0));
				Console.WriteLine($"{i}\t{counts[i]}");
			}

			ConDev.FeedLine();
			ConDev.ExitStatement();
		}
	}
}
