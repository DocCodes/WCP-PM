using System;

/*
	Author       : Evan Young
	Comment      : Displays a test message to the user
	Date Created : 2018-08-14
	Date Updated : 2018-08-16
*/

namespace ConsoleTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Today is Tuesday, the second day of class.");
			Console.WriteLine("This is the second line\nThis is the third line.\rRewrite line three...");
			Console.WriteLine("Today is Tuesday, the second day of class.");
			Console.WriteLine("Today is Tuesday, the second day of class.");
			Console.Write("Today is Tuesday, the second day of class.");
			Console.WriteLine("\rRewrite line six.");

			Console.Write("Enter a number: ");
			Int32 NumOne = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"You typed: {NumOne}");
			Console.WriteLine($"{NumOne} + {NumOne} = {NumOne * 2}");

			Console.WriteLine("Press any key to continue . . .");
			Console.ReadKey();
		}
	}
}
