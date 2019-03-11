using System;

/*
	Author       : Evan Young
	Comment      : Displays a hangman to the user
	Date Created : 2018-08-16
	Date Updated : 2018-08-16
*/

namespace HangmanExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] Hangman = new string[]
			{
				"  (^;^)",
				"    |",
				"./  |  \\.",
				"    |",
				" _ / \\_"
			};

			for (int i = 0; i < Hangman.Length; i++)
			{
				Console.WriteLine(Hangman[i]);
			}

			Console.WriteLine("Press any key to continue. . .");
			Console.ReadKey();
		}
	}
}
