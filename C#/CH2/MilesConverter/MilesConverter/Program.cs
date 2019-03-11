using System;

/*
	Author       : Evan Young
	Comment      : Converts miles to feet to inches
	Date Created : 2018-08-21
	Date Updated : 2018-08-21
*/

namespace MilesConverter
{
	class Program
	{
		const short FEET_MILE = 5280;
		const byte INCH_FEET = 12;

		static void Main(string[] args)
		{
			const double Miles = 4.5;

			Console.WriteLine($"Miles             : {Miles:n2}");
			Console.WriteLine($"Equivalent Feet   : {Miles * FEET_MILE:n0}");
			Console.WriteLine($"Equivalent Inches : {Miles * FEET_MILE * INCH_FEET:n0}");
			Console.WriteLine("Press any key to continue. . .");
			Console.ReadKey();
		}
	}
}
