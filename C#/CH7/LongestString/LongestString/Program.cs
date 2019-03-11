using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Gets the longest and shortest string in entered strings.
	Date Created : 2018-10-10
	Date Updated : 2018-10-10
*/

namespace LongestString
{
	class Program
	{
		static List<string> GetStrings()
		{
			List<string> ret = new List<string> { };
			string inp;
			Regex sentinel = new Regex(@"^\'?q\'?$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

			Console.WriteLine("Please enter strings and the longest and shortest will be displayed.");
			Console.WriteLine("When you are done entering values, type 'Q'");
			do
			{
				inp = ConDev.Write.ReadLine("String: ");
				if (sentinel.Match(inp).Success) { break; }

				ret.Add(inp);
			} while (true);

			return ret;
		}

		static string GetLongest(List<string> li)
		{
			string ret = li[0];

			foreach (string e in li)
			{
				if (e.Length > ret.Length)
				{
					ret = e;
				}
			}

			return ret;
		}

		static string GetShortest(List<string> li)
		{
			string ret = li[0];

			foreach (string e in li)
			{
				if (e.Length < ret.Length)
				{
					ret = e;
				}
			}

			return ret;
		}

		static string GetShortestNotEmpty(List<string> li)
		{
			string ret = "a";

			foreach (string e in li)
			{
				if (e.Length < ret.Length && e != "")
				{
					ret = e;
				}
			}

			return ret;
		}

		static void Main(string[] args)
		{
			List<string> li = GetStrings();
			string longest = GetLongest(li);
			string shortest = GetShortest(li);
			string shortreal = GetShortestNotEmpty(li);

			Console.Clear();
			Console.WriteLine($"Total Strings:          {li.Count}");
			Console.WriteLine($"Longest String:        '{longest}'");
			Console.WriteLine($"Shortest String:       '{shortest}'");
			Console.WriteLine($"Shortest Real String:  '{shortreal}'");

			ConDev.ExitStatement();
		}
	}
}
