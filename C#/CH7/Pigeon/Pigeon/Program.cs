using System;
using System.Collections.Generic;
using System.Linq;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Pigeon hole sorter and fitness
	Date Created : 2018-10-15
	Date Updated : 2018-10-15
*/

namespace Pigeon
{
	class Program
	{
		static List<int> GetListInt(string prompt, int min, int max, int ln, bool unique = false)
		{
			List<int> ret = new List<int>();
			string inp;
			string[] spl;
			int buf;

			while (true)
			{
				inp = ConDev.WriteLine.ReadLine(prompt);
				spl = inp.Split(' ');
				ret = new List<int>();

				if (spl.Length != ln)
				{
					Console.WriteLine("Invalid number of items entered.\n");
					continue;
				}

				foreach (string e in spl)
				{
					if (int.TryParse(e, out buf) && buf >= min && buf <= max && !ret.Contains(buf))
					{
						ret.Add(buf);
					}
					else
					{
						Console.WriteLine("Invalid item entered.\n");
						break;
					}
				}

				if (ret.Count == ln)
				{
					break;
				}
			}

			return ret;
		}

		static bool GetFitness(List<int> pigeon, List<int> holes, out int missing)
		{
			foreach (int p in pigeon)
			{
				if (!holes.Contains(p))
				{
					missing = p;
					return false;
				}
			}
			missing = -1;
			return true;
		}

		static void DisplayResults(List<int> pigeonLi, List<int> holesLi, int missing, bool isFit)
		{
			Console.Clear();
			foreach (int e in pigeonLi)
			{
				Console.Write($"{e,3} ");
			}
			ConDev.FeedLine();
			foreach (int e in holesLi)
			{
				Console.Write($"{e,3} ");
			}
			ConDev.FeedLine();

			if (isFit)
			{
				Console.WriteLine("The Pigeons Fit!");
			}
			else
			{
				Console.WriteLine($"The Pigeons Don't Fit ({missing} is missing)!");
			}
		}

		static void Main(string[] args)
		{
			List<int> pigeonLi = GetListInt("Please enter the list of pigeons", 1, 100, 5, true);
			List<int> holesLi = GetListInt("Please enter the list of pigeon holes", 1, 100, 10, true);
			int missing;
			bool isFit = GetFitness(pigeonLi, holesLi, out missing);

			DisplayResults(pigeonLi, holesLi, missing, isFit);

			ConDev.ExitStatement();
		}
	}
}
