using System;
using System.Collections;
using System.Linq;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Gets 50 numbers 1-100 randomly.
	Date Created : 2018-10-1
	Date Updated : 2018-10-1
*/

namespace ArrayListRemove
{
	class Program
	{
		private static Random rng = new Random(DateTime.Now.Second);

		static void Main(string[] args)
		{
			int rand;
			ArrayList li = new ArrayList(Enumerable.Range(1, 100).Select(r => r).ToArray());

			while (li.Count > 50)
			{
				rand = rng.Next(1, 100);
				li.Remove(rand);
			}

			Console.WriteLine("Contents of Slim Array");
			foreach (int e in li)
			{
				Console.Write($"{e,8}");
			}
			ConDev.FeedLine();

			ConDev.FeedLine();
			ConDev.ExitStatement();
		}
	}
}
