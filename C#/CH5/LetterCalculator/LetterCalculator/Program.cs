using System;
using ConDevLib;

namespace LetterCalculator
{
	class Program
	{
		static char[] alphaChars = new char[]
		{
			'a',
			'b',
			'c',
			'd',
			'e',
			'f',
			'g',
			'h',
			'i',
			'j',
			'k',
			'l',
			'm',
			'n',
			'o',
			'p',
			'q',
			'r',
			's',
			't',
			'u',
			'v',
			'w',
			'x',
			'y',
			'z'
		};

		static void Main(string[] args)
		{
			char c;

			do
			{
				Console.Clear();
				Console.WriteLine("Character Analysis");
				Console.WriteLine("Please enter a lowercase letter a-z.");
				c = ConDev.WriteLine.ReadKey("Character: ").KeyChar;
			} while (Array.IndexOf(alphaChars, c) == -1);

			switch (c)
			{
				case 'a':
				case 'e':
				case 'i':
				case 'o':
				case 'u':
				case 'y':
					Console.WriteLine(", that is a vowel.");
					break;
				default:
					Console.WriteLine(", that is a consonant.");
					break;
			}

			ConDev.ExitStatement();
		}
	}
}
