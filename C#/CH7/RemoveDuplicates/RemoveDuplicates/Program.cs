using System;
using System.Collections.Generic;
using System.Linq;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Remove duplicates
	Date Created : 2018-09-28
	Date Updated : 2018-09-28
*/

namespace RemoveDuplicates
{
	class Program
	{
		static Random rng = new Random();

		static void Main(string[] args)
		{
			int genMin = 1;
			int genMax = 20;
			int rand = 0;
			List<int> randNumbers = Enumerable.Range(0, 25).Select(r => rng.Next(genMin, genMax)).ToList();
			List<int> uniqNumbers = new List<int> { };
			List<int> dupeCounts = Enumerable.Range(genMin, genMax).Select(r => 0).ToList();

			Console.WriteLine("Random Elements");
			for (int i = 0, j = 1; i < randNumbers.Count; i++, j = (j + 1) % 8)
			{
				rand = randNumbers[i];
				dupeCounts[rand]++;
				if (!uniqNumbers.Contains(rand)) { uniqNumbers.Add(rand); }

				Console.Write($"{rand,2}\t");
				if (j == 0 || i == randNumbers.Count - 1) { ConDev.FeedLine(); }
			}
			ConDev.FeedLine();

			Console.WriteLine("Unique Elements");
			for (int i = 0, j = 1; i < uniqNumbers.Count; i++, j = (j + 1) % 8)
			{
				rand = uniqNumbers[i];

				Console.Write($"{rand,2}\t");
				if (j == 0 || i == randNumbers.Count - 1) { ConDev.FeedLine(); }
			}
			ConDev.FeedLine(2);

			Console.WriteLine("Removed Elements");
			for (int i = genMin, j = 1; i <= genMax; i++)
			{
				if (dupeCounts[i - 1] >= 2) { Console.Write($"{i,2}\t"); }
				if (dupeCounts[i - 1] >= 2) { j = (j + 1) % 8; }
				if (j == 0) { ConDev.FeedLine(); }
			}

			ConDev.FeedLine();
			ConDev.ExitStatement();
		}
	}
}
