using System;

/*
	Author       : Evan Young
	Comment      : Prints out wholesale and markup prices for items
	Date Created : 2018-08-21
	Date Updated : 2018-08-21
*/

namespace MarkupApp
{
	class Program
	{
		static void Main(string[] args)
		{
			double RuggyShoes = 52.00;
			double TenoJacket = 71.00;

			Console.WriteLine("\tMarkup App\n");

			Console.WriteLine("Item: Ruggy Shoes");
			Console.WriteLine($"Wholesale Price: {RuggyShoes:c2}");
			RuggyShoes = 59.80;
			Console.WriteLine($"Retail Price: {RuggyShoes:c2}");
			Console.WriteLine();

			Console.WriteLine("Item: Teno Jacket");
			Console.WriteLine($"Wholesale Price: {TenoJacket:c2}");
			TenoJacket = 81.65;
			Console.WriteLine($"Retail Price: {TenoJacket:c2}");

			Console.WriteLine("Press any key to continue. . .");
			Console.ReadKey();
		}
	}
}
