using System;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Converts letters to uppercase
	Date Created : 2018-09-10
	Date Updated : 2018-09-10
*/

namespace ConvertUpper
{
	class Program
	{
		static char[] lower = new char[]
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
		static char[] upper = new char[]
		{
			'A',
			'B',
			'C',
			'D',
			'E',
			'F',
			'G',
			'H',
			'I',
			'J',
			'K',
			'L',
			'M',
			'N',
			'O',
			'P',
			'Q',
			'R',
			'S',
			'T',
			'U',
			'V',
			'W',
			'X',
			'Y',
			'Z'
		};

		static void Main(string[] args)
		{
			string inpBuffer;
			char inpLetter;
			char uprLetter;
			bool success;

			do
			{ // Retry for a valid character
				inpBuffer = ConDev.Write.ReadLine("The Letter: ");
				inpLetter = inpBuffer.Length > 0 ? inpBuffer.ToCharArray()[0] : ' ';
				success = Array.IndexOf(lower, inpLetter) != -1;
			} while (!success);

			uprLetter = upper[Array.IndexOf(lower, inpLetter)];
			Console.WriteLine($"The Uppercase Letter: {uprLetter}");

			ConDev.ExitStatement();
		}
	}
}
