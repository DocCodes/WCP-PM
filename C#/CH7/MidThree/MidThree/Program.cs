using System;
using System.Collections.Generic;
using System.Linq;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Random array with middle three print
	Date Created : 2018-10-02
	Date Updated : 2018-10-02
*/

namespace MidThree
{
	class Program
	{
		public static int randSeed = DateTime.Now.Second;

		static int GetRandOdd(int min = 0, int max = 10)
		{
			int rand;
			Random rng = new Random(randSeed);

			do
			{
				rand = rng.Next(min, max);
			} while (rand % 2 == 0);
			return rand;
		}

		static void Main(string[] args)
		{
			Random rng = new Random(randSeed);
			int randElms = GetRandOdd(3, 25);
			int midElm = (int)Math.Floor((double)randElms / 2);
			List<int> randList = Enumerable.Range(0, randElms).Select(r => rng.Next(1, 1000)).ToList();

			Console.WriteLine($"Full Array ({randElms})");
			randList.Sort();
			foreach (int rand in randList)
			{
				Console.Write($"{rand,8}");
			}
			ConDev.FeedLine(2);

			Console.WriteLine($"Middle Three ({midElm - 1}-{midElm + 1})");
			Console.WriteLine($"{randList[midElm - 1],8}{randList[midElm],8}{randList[midElm + 1],8}");

			ConDev.FeedLine();
			ConDev.ExitStatement();
		}
	}
}
