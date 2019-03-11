using System;
using ConDevLib;

/*
	Author       : Evan Young
	Comment      : Measures the pH of an aqarium
	Date Created : 2018-09-07
	Date Updated : 2018-09-07
*/

namespace FishTank
{
	class Program
	{
		static string GetTankStatus(int phValue)
		{
			string ret = "neutral";

			if (phValue > 7)
			{
				ret = "alkaline";
			}
			else if (phValue < 7)
			{
				ret = "acidic";
			}

			return ret;
		}

		static void Main(string[] args)
		{
			string phInput;
			int phValue = 7;
			int retry = 5;
			string tankStatus;

			while (retry > 0)
			{ // Try for a good value max 5 times
				phInput = ConDev.WriteLine.ReadLine("Enter the Aqarium's Current pH Level (0-14)");
				if (!int.TryParse(phInput, out phValue) || phValue < 0 || phValue > 14)
				{
					Console.Clear();
					Console.WriteLine("An invalid pH value was entered.");
					retry--;
				}
				else
				{
					break;
				}
			}

			if (retry == 0)
			{ // Maximum retries and no good value
				Console.WriteLine("The maximum number of retries was reached.");
			}
			else
			{ // Good value
				tankStatus = GetTankStatus(phValue);
				Console.WriteLine($"The tank is {tankStatus}, because of its pH level of {phValue}.");
			}

			ConDev.ExitStatement();
		}
	}
}
