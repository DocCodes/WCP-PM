using System;

/*
Author      : Evan Elias Young
Description : Prints a quote on seperate lines
Created     : 2018-08-15
Updated     : 2018-08-15
*/

namespace QuoteExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] QuoteSections = new string[] { // The quote stored as an array of lines
				"He's a real nowhere man,",
				"Sitting in his nowhere land,",
				"Making all his nowhere plans for nobody."
			};

			Console.WriteLine("Output #1"); // Output 1 is all on the same line
			Console.WriteLine(String.Join(" ", QuoteSections));

			Console.WriteLine("\nOutput #2"); // Output 2 is all on different lines
			Console.WriteLine(String.Join("\n", QuoteSections));

			Console.WriteLine("\nOutput #3"); // Output 3 is all words on different lines
			for (int i = 0; i < QuoteSections.Length; i++)
			{
				string[] Words = QuoteSections[i].Split(' ');
				for (int j = 0; j < Words.Length; j++)
				{
					Console.WriteLine(Words[j]);
				}
			}

			Console.WriteLine("Press any key to continue . . .");
			Console.ReadKey();
		}
	}
}
