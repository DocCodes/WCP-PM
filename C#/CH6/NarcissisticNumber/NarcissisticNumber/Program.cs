using System;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Determines whether or not a number is narcissistic.
	Date Created : 2018-09-19
	Date Updated : 2018-09-19
*/

namespace NarcissisticNumber
{
	class Program
	{
		/// <summary>
		/// Determines whether a number is narcissistic or not.
		/// </summary>
		/// <param name="num">The number to check is narcissistic.</param>
		/// <param name="tot">The actual value from the narcissistic check.</param>
		/// <returns>Whether or not the number is narcissistic.</returns>
		static bool IsNarcissistic(int num, out int tot)
		{
			char[] cArr = num.ToString().ToCharArray();
			tot = 0;

			foreach (char c in cArr)
			{
				tot += (int)Math.Pow(int.Parse(c.ToString()), 3);
			}

			return tot == num;
		}

		static void Main(string[] args)
		{
			string inpValue;
			bool success = false;
			int actValue;
			int intValue;

			do
			{
				inpValue = ConDev.WriteLine.ReadLine("Please enter a number to check if it is narcissistic.");
				success = int.TryParse(inpValue, out intValue);

				if (success)
				{
					if (intValue < 100 || intValue > 999)
					{
						Console.WriteLine("The number must be between 100 and 999: three digits large.\n");
						success = false;
						continue;
					}

					if (!IsNarcissistic(intValue, out actValue))
					{
						Console.WriteLine($"The number is not narcissistic, {actValue} != {intValue}\n");
						success = false;
						continue;
					}
				}
			} while (!success);

			Console.WriteLine($"\n{intValue} is narcissistic.");

			ConDev.ExitStatement();
		}
	}
}
