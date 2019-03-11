using System;

/*
	Author       : Evan Young
	Comment      : Displays my initials (EEY) to the user
	Date Created : 2018-08-16
	Date Updated : 2018-08-16
*/

namespace InitialsExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			char AltChar = ':';
			char NoChar = ' ';
			UInt16 CharWidth = 22;
			UInt16 CharHeight = 16;
			string[] CharE = new string[]
			{
				"1111111111111111111111",
				"1222222222222222222221",
				"1222222222222222222221",
				"1122222211111111122221",
				"0012222210000000111111",
				"0012222210000000000000",
				"0012222221111111111000",
				"0012222222222222221000",
				"0012222222222222221000",
				"0012222221111111111000",
				"0012222210000000000000",
				"0012222210000000111111",
				"1122222211111111222221",
				"1222222222222222222221",
				"1222222222222222222221",
				"1111111111111111111111"
			};
			string[] CharY = new string[]
			{
				"111111100000001111111",
				"122222100000001222221",
				"122222100000001222221",
				"122222210000012222221",
				"111222221000122222111",
				"000122222101222221000",
				"000012222212222210000",
				"000001222222222100000",
				"000000122222221000000",
				"000000012222210000000",
				"000000012222210000000",
				"000000012222210000000",
				"000000012222210000000",
				"000011112222211110000",
				"000012222222222210000",
				"000011111111111110000",
			};
			string[][] PrintChars = new string[][]
			{
				CharE,
				CharE,
				CharY
			};

			for (int i = 0; i < CharHeight; i++) // For each line in the char
			{
				for (int j = 0; j < PrintChars.Length; j++) // For each char in the print list
				{
					Console.Write(PrintChars[j][i].Replace('0', NoChar).Replace('1', 'E').Replace('2', AltChar));
					Console.Write("  ");
				}
				Console.WriteLine("");
			}

			Console.WriteLine("Press any key to continue. . .");
			Console.ReadKey();
		}
	}
}
