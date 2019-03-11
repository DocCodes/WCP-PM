using System;
using System.Collections.Generic;
using System.Linq;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Comment here
	Date Created : 2018-10-0
	Date Updated : 2018-10-0
*/

namespace Balance
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rng = new Random(DateTime.Now.Second);
			int len = rng.Next(4, 10);
			int mid = len / 2;
			List<int> rand = Enumerable.Range(0, len).Select(e => rng.Next(1, 3)).ToList();
			List<int> left = new List<int> { };
			List<int> right = new List<int> { };
			int sumLeft;
			int sumRight;

			Console.WriteLine($"Original Array ({len})");
			foreach (int e in rand)
			{
				Console.Write($"{e,8}");
			}
			ConDev.FeedLine();

			if (len % 2 == 1)
			{
				Console.WriteLine("The array cannot be balanced; it's odd.");
			}
			else
			{
				left = rand.GetRange(0, mid);
				right = rand.GetRange(mid, mid);
				sumLeft = left.Aggregate(0, (acc, e) => acc + e);
				sumRight = right.Aggregate(0, (acc, e) => acc + e);

				if (sumLeft == sumRight)
				{
					Console.WriteLine($"The array can be balanced ({sumLeft}), index {mid - 1} and {mid} are the middle.");
				}
				else
				{
					Console.WriteLine($"The array cannot be balanced; {sumLeft} != {sumRight}.");
				}
			}

			ConDev.FeedLine();
			ConDev.ExitStatement();
		}
	}
}
