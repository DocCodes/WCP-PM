using System;
using System.Collections;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Demoing array lists
	Date Created : 2018-10-10
	Date Updated : 2018-10-10
*/

namespace ArrayLists
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayList li = new ArrayList();

			li.Add(1);
			li.Add(true);
			li.Add("string");
			li.Add(34.55);

			Console.WriteLine(li.Count);
			Console.WriteLine(li.Contains(34.56));
			Console.WriteLine(li[1]);
			li.RemoveAt(1);
			Console.WriteLine(li[1]);
			li.Insert(1, "New Item");
			foreach (var e in li)
			{
				Console.WriteLine(e);
			}
			Console.WriteLine("**********");

			ArrayList b = new ArrayList();
			b.Add(99);
			b.Add("2nd array");
			b.InsertRange(2, li);
			foreach (var e in b)
			{
				Console.WriteLine(e);
			}
			Console.WriteLine("**********");

			b.Reverse();
			foreach (var e in b)
			{
				Console.WriteLine(e);
			}
			Console.WriteLine("**********");

			ConDev.ExitStatement();
		}
	}
}
