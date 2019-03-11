using System;
using System.Collections.Generic;
using System.Linq;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Bar charter for input numbers
	Date Created : 2018-10-0
	Date Updated : 2018-10-0
*/

namespace BarChart
{
	class Program
	{
		static List<int> GetNumbers()
		{
			List<int> ret = new List<int> { };
			string inp = "";
			int add = 0;
			int min = 0;
			int max = 10;
			int oc = 74;

			Console.WriteLine($"Please enter a number {min}-{max} (each number is capped at {oc} occurrences).\nWhen you are finished type 'E'.\n");
			do
			{
				inp = ConDev.Write.ReadLine($"Enter A Number: ");

				if (int.TryParse(inp, out add) && add >= min && add <= max && ret.Where(e => e == add).Count() < oc)
				{
					ret.Add(add);
				}
			} while (inp.ToUpper() != "E");

			return ret;
		}

		static void Main(string[] args)
		{
			List<int> numbers = GetNumbers();
			List<int> counts = new List<int> { };
			Console.Clear();

			for (int i = 0; i <= 10; i++)
			{
				counts.Add(numbers.Where(e => e == i).Count());
			}

			Console.Write($"---|{new string('-', 76)}");
			for (int i = 10; i >= 0; i--)
			{
				Console.WriteLine($"{i,2} | {new string('*', counts[i])}");
         }
			Console.Write($"---|{new string('-', 76)}");

			ConDev.ExitStatement();
		}
	}
}
