using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Author  : Evan Elias Young
Comment : Logs C and # as a collection of C and #
Created : 2018-08-14
Updated : 2018-08-14
*/

namespace ConsoleCharacters
{
	class Program
	{
		static void Main(string[] args)
		{
			int CharSize = 7; // The number of items that make up a character square
			int[,] CharC = new int[,] { // Each character is a multidimensional array where each item is a line
				{1, 1, 1, 1, 1, 1, 1},
				{1, 1, 1, 1, 1, 1, 1},
				{1, 1, 0, 0, 0, 0, 0},
				{1, 1, 0, 0, 0, 0, 0},
				{1, 1, 0, 0, 0, 0, 0},
				{1, 1, 1, 1, 1, 1, 1},
				{1, 1, 1, 1, 1, 1, 1}
			};
			int[,] CharS = new int[,] {
				{0, 1, 1, 0, 1, 1, 0},
				{1, 1, 1, 1, 1, 1, 1},
				{1, 1, 1, 1, 1, 1, 1},
				{0, 1, 1, 0, 1, 1, 0},
				{1, 1, 1, 1, 1, 1, 1},
				{1, 1, 1, 1, 1, 1, 1},
				{0, 1, 1, 0, 1, 1, 0}
			};

			for (int i = 0; i < CharSize; i++) // i represents a line of characters
			{
				for (int j = 0; j < CharSize; j++) // Write the line in the C
				{
					if (CharC[i,j] == 1)
					{
						Console.Write("C");
					} else
					{
						Console.Write(" ");
					}
				}
				Console.Write("  "); // Create padding for characters
				for (int j = 0; j < CharSize; j++) // Write the line in the #
				{
					if (CharS[i, j] == 1)
					{
						Console.Write("#");
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}

			Console.WriteLine("\nPress any key to continue...");
			Console.ReadKey();
		}
	}
}
