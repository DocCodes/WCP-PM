using System;
using System.Collections.Generic;

/*
	Author       : Evan Young
	Comment      : Generates permutations of three numbers
	Date Created : 2018-08-22
	Date Updated : 2018-08-23
*/

namespace Permutations
{
	public static class PermutationEngine
	{
		public static List<string> Generate(List<char> set)
		{ // Runs the override which is supplimented with data from the char[] set
			return Generate(set, 0, set.Count - 1, new List<string> { });
		}
		private static List<string> Generate(List<char> set, int i, int n, List<string> output)
		{ // Generates all permutations using the backtrack method
			int j;
			if (i == n)
			{
				output.Add(string.Concat(set));
			}
			else
			{
				for (j = i; j <= n; j++)
				{
					char tmp;
					// Swap chars for current level
					tmp = set[i];
					set[i] = set[j];
					set[j] = tmp;
					Generate(set, i + 1, n, output); // Generate permutations for the current level
					// Swap for backtracking
					tmp = set[i];
					set[i] = set[j];
					set[j] = tmp;
				}
			}
			return output;
		}
	}

	class Program
	{
		static string ReadWriteLine(string msg)
		{
			Console.Write(msg);
			return Console.ReadLine();
		}

		static void PrintExit(int ExitCode)
		{
			Console.WriteLine("\nPress any key to continue. . .");
			Console.ReadKey();
			Environment.Exit(ExitCode);
		}

		static void ErrorCheckNumber(string num)
		{
			try
			{
				long TestVal = Convert.ToByte(num);
				if (TestVal > 9 || TestVal < 0)
				{
					Console.WriteLine($"Invalid number \"{num}\"");
					PrintExit(1);
					Environment.Exit(1);
				}
			}
			catch (Exception)
			{
				Console.WriteLine($"Invalid number \"{num}\"");
				PrintExit(1);
				Environment.Exit(1);
			}
		}

		static void Main(string[] args)
		{
			// Get each number and check if it's valid, if not exit the program
			string NumOneInput = ReadWriteLine("Number 1: ");
			ErrorCheckNumber(NumOneInput);
			string NumTwoInput = ReadWriteLine("Number 2: ");
			ErrorCheckNumber(NumTwoInput);
			string NumThreeInput = ReadWriteLine("Number 3: ");
			ErrorCheckNumber(NumThreeInput);
			List<char> permuteChars = new List<char>
			{
				Convert.ToChar(NumOneInput),
				Convert.ToChar(NumTwoInput),
				Convert.ToChar(NumThreeInput)
			};
			List<string> permuteStrings = PermutationEngine.Generate(permuteChars);
			int newNumberSum = 0;

			foreach (string perm in permuteStrings)
			{
				newNumberSum += Convert.ToInt32(perm);
				Console.WriteLine(Convert.ToInt32(perm));
			}
			Console.WriteLine($"Sum: {newNumberSum}");

			PrintExit(0);
		}
	}
}
