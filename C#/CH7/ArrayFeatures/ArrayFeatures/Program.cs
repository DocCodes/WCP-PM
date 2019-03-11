using System;
using System.Collections.Generic;
using System.Linq;

/*
	Author       : Evan Elias Young
	Comment      : Demoing more array features
	Date Created : 2018-09-27
	Date Updated : 2018-09-27
*/

namespace ArrayFeatures
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Search");
			double[] water = { 2.4, 3.6, 6.8 };
			double x = 0;
			int i = Array.BinarySearch(water, x);
			Console.WriteLine(i);

			Console.WriteLine("\nClone");
			double[] metal = new double[water.Length - 1];
			object o = water.Clone();
			metal = (double[])o;
			metal[0] = 2.2;
			Console.WriteLine(metal[0]);

			Console.WriteLine("\nCopy");
			double[] liquid = new double[3];
			Array.Copy(water, 0, liquid, 0, 3);
			foreach (double e in liquid)
			{
				Console.WriteLine(e);
			}

			Console.WriteLine("\nCopyTo");
			double[] soda = new double[8];
			water.CopyTo(soda, 2);
			foreach (double e in soda)
			{
				Console.WriteLine(e);
			}

			Console.WriteLine("\nGetValue");
			Console.WriteLine(water.GetValue(2));

			Console.WriteLine("\nIndexOf");
			Console.WriteLine(Array.IndexOf(water, 3.5));

			Console.WriteLine("\nLastIndexOf");
			Console.WriteLine(Array.LastIndexOf(water, 2.2));

			Console.WriteLine("\nReverse");
			foreach (double e in water.Reverse())
			{
				Console.WriteLine(e);
			}

			Console.WriteLine("\nSetValue");
			water.SetValue(4.9, 1);
			foreach (double e in water)
			{
				Console.WriteLine(e);
			}

			Console.WriteLine("\nSort");
			Array.Sort(water);
			foreach (double e in water)
			{
				Console.WriteLine(e);
			}

			Console.WriteLine("\nClear");
			Array.Clear(water, 0, 2);
			foreach (double e in water)
			{
				Console.WriteLine(e);
			}

			Console.WriteLine("\nPress enter to continue. . .");
			Console.ReadLine();
		}
	}
}
