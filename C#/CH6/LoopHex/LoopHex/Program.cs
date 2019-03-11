using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Sums hex numbers a reports back the decimal value.
	Date Created : 2018-09-19
	Date Updated : 2018-09-19
*/

namespace LoopHex
{
	class Program
	{
		/// <summary>
		/// Gets a list of valid hex values.
		/// </summary>
		/// <returns>A list of hex values.</returns>
		static List<string> GetHexValues()
		{
			List<string> ret = new List<string> { };
			string inpVal;

			while (true)
			{
				inpVal = ConDev.WriteLine.ReadLine("Please enter a hexadecimal [0-F] number. Enter 'Y/y' to confirm your entries.");

				if (inpVal.ToUpper() == "Y")
				{
					break;
				}

				if (Regex.Match(inpVal, @"^[0-9A-f]+$").Success)
				{
					ret.Add(inpVal);
				}
				else
				{
					Console.WriteLine("Invalid hex value, entry ignored.");
				}
				ConDev.FeedLine();
			}

			return ret;
		}

		/// <summary>
		/// Converts a list of hex values to a list of int values.
		/// </summary>
		/// <param name="hexValues">The hex values to convert.</param>
		/// <returns>A list of int values.</returns>
		static List<int> GetIntValues(List<string> hexValues)
		{
			List<int> ret = new List<int> { };

			foreach (string hex in hexValues)
			{
				ret.Add(HexToDec(hex));
			}

			return ret;
		}

		/// <summary>
		/// Reverses a string.
		/// </summary>
		/// <param name="str">The string to reverse.</param>
		/// <returns>The reversed string.</returns>
		static string ReverseString(string str)
		{
			char[] arr = str.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}

		/// <summary>
		/// Converts a hex number to a decimal number.
		/// </summary>
		/// <param name="hex">The hex number to convert.</param>
		/// <returns>The decimal value.</returns>
		static int HexToDec(string hex)
		{
			char[] values = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
			int tot = 0;
			int max = 16;
			int mult;
			string rev = ReverseString(hex);

			for (int i = rev.Length - 1; i > -1; i--)
			{
				mult = (int)Math.Pow(max, i);
				tot += Array.IndexOf(values, hex[i]) * mult;
			}
			return tot;
		}

		/// <summary>
		/// Converts a decimal number to a hex number.
		/// </summary>
		/// <param name="dec">The decimal number.</param>
		/// <returns>The hex number.</returns>
		static string DecToHex(int dec)
		{
			char[] values = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
			int max = 16;
			string ret = "";

			if (dec == 0)
			{
				return "0";
			}
			while (dec > 0)
			{
				ret += values[dec % max];
				dec /= max;
			}

			return ReverseString(ret);
		}

		static void Main(string[] args)
		{
			List<string> hexValues = GetHexValues();
			List<int> intValues = GetIntValues(hexValues);
			int total = 0;

			Console.Clear();
			for (int i = 0; i < hexValues.Count; i++)
			{
				Console.WriteLine($"0x{hexValues[i],-10} {intValues[i],-10}");
				total += intValues[i];
			}
			Console.WriteLine(new string('-', 21));
			Console.WriteLine($"0x{DecToHex(total),-10} {total,-10}");

			ConDev.FeedLine();
			ConDev.ExitStatement();
		}
	}
}
