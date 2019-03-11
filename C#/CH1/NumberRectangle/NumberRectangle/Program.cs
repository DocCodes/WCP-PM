using System;

/*
	Author       : Evan Young
	Comment      : Comment here
	Date Created : 2018-08-16
	Date Updated : 2018-08-16
*/

namespace NumberRectangle
{
	class Program
	{
		static void Main(string[] args)
		{
			long Num = 8;
			int NumLen = 1;
			Console.Write("Enter a number: ");
			string Inp = Console.ReadLine();

			try
			{ // Convert the input to the number
				Num = Convert.ToInt64(Inp);
			}
			catch (Exception)
			{ // Alert the user of the error and use the default (8).
				Console.WriteLine("Invalid number entered, defaulting to 8.");
			}
			NumLen = Convert.ToString(Num).Length * 2; // Allows support for numbers of any length

			Console.WriteLine($"{Num}{Num}{Num}{Num}");
			Console.WriteLine($"{Num}{new String(' ', NumLen)}{Num}");
			Console.WriteLine($"{Num}{Num}{Num}{Num}");

			Console.WriteLine("Press any key to continue. . .");
			Console.ReadKey();
		}
	}
}
