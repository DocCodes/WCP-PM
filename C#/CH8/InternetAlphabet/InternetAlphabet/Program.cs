using System;
using System.Collections.Generic;
using System.Linq;

/*
	Author       : Evan Elias Young
	Comment      : Comment here
	Date Created : 2018-11-27
	Date Updated : 2018-11-27
*/

namespace InternetAlphabet
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> alphabet = new Dictionary<string, string>
			{
				{ "a", "@" },
				{ "b", "8" },
				{ "c", "(" },
				{ "d", "|)" },
				{ "e", "3" },
				{ "f", "#" },
				{ "g", "6" },
				{ "h", "[-]" },
				{ "i", "|" },
				{ "j", "_|" },
				{ "k", "|<" },
				{ "l", "1" },
				{ "m", "[]\\/[]" },
				{ "n", "[]\\[]" },
				{ "o", "0" },
				{ "p", "|D" },
				{ "q", "(,)" },
				{ "r", "|Z" },
				{ "s", "$" },
				{ "t", "']['" },
				{ "u", "|_|" },
				{ "v", "\\/" },
				{ "w", "\\/\\/" },
				{ "x", "}{" },
				{ "y", "`/" },
				{ "z", "2" }
			};

			Console.WriteLine("Enter the sentences to encode.");
			string inp = Console.ReadLine().ToLower();
			if (inp.Length > 5000)
			{
				inp = inp.Substring(0, 5000);
			}
			alphabet.ToList().ForEach(pair => { inp = inp.Replace(pair.Key, pair.Value); });
			Console.WriteLine(inp);

			Console.WriteLine("\nPress the enter key to continue. . .");
			Console.ReadLine();
		}
	}
}
