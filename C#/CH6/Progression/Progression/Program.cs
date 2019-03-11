using System;
using System.Collections.Generic;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Arithmetica progression.
	Date Created : 2018-09-20
	Date Updated : 2018-09-20
*/

namespace Progression
{
	class Program
	{
		/// <summary>
		/// Gets an integer from the user given a message.
		/// </summary>
		/// <param name="msg">The message to prompt the user with.</param>
		/// <param name="min">The minimum value to check on.</param>
		/// <returns>An integer.</returns>
		static int GetNumber(string msg, int min = -2147483647)
		{
			int ret = 0;
			string inpValue;

			inpValue = ConDev.Write.ReadLine(msg);
			while (!(int.TryParse(inpValue, out ret) && ret >= min))
			{
				Console.WriteLine($"\nInvalid number entered, it must be valid and greater than or equal to {min}.");
				inpValue = ConDev.Write.ReadLine(msg);
			}

			return ret;
		}

		static void Main(string[] args)
		{
			int startNumber = GetNumber("Sequence Starting Number: ");
			int itemNumber = GetNumber("Sequence Length: ", 1);
			int commonDiff = GetNumber("Common Difference: ");
			List<int> sumNumbers = new List<int> { };
			int sumNumber;
			int tot = 0;

			for (int i = 0; i < itemNumber; i++)
			{
				sumNumber = startNumber + (i * commonDiff);
				sumNumbers.Add(sumNumber);
				tot += sumNumber;
			}

			Console.Write(string.Join(" + ", sumNumbers));
			Console.WriteLine($" = {tot}");

			ConDev.FeedLine();
			ConDev.ExitStatement();
		}
	}
}
