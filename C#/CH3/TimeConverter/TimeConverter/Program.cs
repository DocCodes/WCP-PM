using System;
using ConDevLib;

/*
	Author       : Evan Young
	Comment      : Converts seconds to larger units of time
	Date Created : 2018-08-27
	Date Updated : 2018-08-27
*/

namespace TimeConverter
{
	class Program
	{
		const int SEC_PER_MIN = 60;
		const int MIN_PER_HR = 60;
		const int SEC_PER_HR = SEC_PER_MIN * MIN_PER_HR;

		/// <summary>
		/// Gets and converts a string into an integer. A return value indicates whether the conversion succeeded.
		/// </summary>
		/// <param name="result">Contains a 32-bit signed integer if the conversion was successful, otherwise contains zero.</param>
		/// <returns>A boolean on whether or not the conversion was successful.</returns>
		static bool GetSeconds(out int result)
		{
			string inputValue = ConDev.WriteLine.ReadLine("Enter the number of seconds.");
			return int.TryParse(inputValue, out result);
		}
		/// <summary>
		/// Converts the seconds into a list of hours, minutes, and seconds.
		/// </summary>
		/// <param name="seconds">The number of seconds to convert.</param>
		/// <returns>The list of hours, minutes, and seconds.</returns>
		static int[] GetTimes(int seconds)
		{
			int[] output = new int[]
			{
				seconds / SEC_PER_HR,
				(seconds % SEC_PER_HR) / SEC_PER_MIN,
				seconds % SEC_PER_MIN
			};
			return output;
		}
		/// <summary>
		/// Displays the given time data
		/// </summary>
		/// <param name="times">The list of hours, minutes, and seconds.</param>
		static void DisplayTimes(int[] times)
		{
			const int colWidth = 9;
			const int columns = 3;

			Console.WriteLine(new string('_', columns * (colWidth + 1) + 1)); // Table layout
			Console.WriteLine($"|{"Hours",-colWidth}|{"Minutes",-colWidth}|{"Seconds",-colWidth}|");
			Console.WriteLine($"|{times[0],colWidth}|{times[1],colWidth}|{times[2],colWidth}|");
			Console.WriteLine(new string('_', columns * (colWidth + 1) + 1)); // Table layout
		}

		static void Main(string[] args)
		{
			int seconds;
			int[] times;
			bool readSeconds = GetSeconds(out seconds);

			if (!readSeconds)
			{ // If invalid seconds stop program
				Console.WriteLine("Incorrect seconds entered");
				ConDev.WriteLine.ReadLine("Press the enter key to continue. . .");
				Environment.Exit(13);
			}

			times = GetTimes(seconds);
			DisplayTimes(times);

			ConDev.WriteLine.ReadLine("Press the enter key to continue. . .");
			Environment.Exit(0);
		}
	}
}
