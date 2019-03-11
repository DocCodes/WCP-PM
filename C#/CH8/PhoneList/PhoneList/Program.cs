using System;
using System.Collections.Generic;
using System.Linq;

/*
	Author       : Evan Elias Young
	Comment      : Comment here
	Date Created : 2018-11-26
	Date Updated : 2018-11-26
*/

namespace PhoneList
{
	class Program
	{
		static List<string> PhoneBook = new List<string>
		{
			"Becky Warren, 678-1223",
			"Joe Looney, 586-0097",
			"Geri Palmer, 223-8787",
			"Lynn Persnell, 887-1212",
			"Holly Gaddis, 223-8878",
			"Sam Wiggins, 468-0998",
			"Bob Kain, 586-8712",
			"Tim Haynes, 586-7676",
			"Warren Gaddis, 223-9037",
			"Jean James, 678-4939",
			"Ron Palmer, 486-2783",
			"Kenney McCarthy, 232-7914"
		};

		static void Main(string[] args)
		{
			Console.WriteLine("Enter the search criteria.");
			string inp = Console.ReadLine();
			List<string> matched = PhoneBook.Where(e => e.Contains(inp)).ToList();

			if (matched.Count == 0)
			{
				Console.WriteLine("\nThere are no matches for that specified criteria.");
			}
			else
			{
				Console.WriteLine();
				foreach (string num in matched)
				{
					Console.WriteLine(num);
				}
			}


			Console.WriteLine("\n\nPress enter to continue. . .");
			Console.ReadLine();
		}
	}
}
