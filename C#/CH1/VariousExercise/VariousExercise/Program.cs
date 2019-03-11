using System;

/*
	Author       : Evan Young
	Comment      : Displays a various equations to the user
	Date Created : 2018-08-16
	Date Updated : 2018-08-16
*/

namespace VariousExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Step 1");
			Console.WriteLine($"{139 / 6}");

			Console.WriteLine("\nStep 2");
			Console.WriteLine($"-1 + 4 x 6 = {-1 + 4 * 6}");
			Console.WriteLine($"(35 + 5) mod 7 = {(35 + 5) % 7}");
			Console.WriteLine($"14 + -4 x 6 / 11 = {14 + -4 * 6 / 11}");
			Console.WriteLine($"2 + 15 / 6 x 1 - 7 mod 2 = {2 + 15 / 6 * 1 - 7 % 2}");

			Console.WriteLine("\nStep 3");
			short NumOne = 5;
			short NumTwo = 6;
			short NumThree = (short)(NumOne * NumTwo);
			Console.WriteLine($"{NumOne} x {NumTwo} = {NumThree}");

			Console.WriteLine("\nStep 4");
			string s1 = "string1";
			string s2 = "string2";
			string s3 = "string3";
			Console.WriteLine($"{s1}    {s2}    {s3}    ");

			Console.WriteLine("Press any key to continue. . .");
			Console.ReadKey();
		}
	}
}
