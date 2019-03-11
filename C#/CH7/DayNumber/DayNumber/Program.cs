using System;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Month and day to day of year
	Date Created : 2018-10-0
	Date Updated : 2018-10-0
*/

namespace DayNumber
{
	class Program
	{
		public static string[] months = new string[12]
		{
			"January",
			"February",
			"March",
			"April",
			"May",
			"June",
			"July",
			"August",
			"September",
			"October",
			"November",
			"December"
		};
		public static int[] monthDays = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

		static int GetMonth()
		{
			string inp = "";
			int ret = 0;

			do
			{
				Console.Clear();
				Console.WriteLine("Please choose a month below");
				for (int i = 0; i < months.Length; i++)
				{
					Console.WriteLine($"[{i + 1}] {months[i]}");
				}
				inp = Console.ReadLine();
			} while (!(int.TryParse(inp, out ret) && ret >= 1 && ret <= 12));

			return ret - 1;
		}

		static int GetDay(int month)
		{
			string inp = "";
			int ret = 0;
			int max = monthDays[month];

			do
			{
				Console.Clear();
				Console.WriteLine("Please enter the number of days you are into the month");
				Console.WriteLine($"(In {months[month]} there are 1-{max} days)");
				inp = Console.ReadLine();
			} while (!(int.TryParse(inp, out ret) && ret >= 1 && ret <= max));

			return ret;
		}

		static int CalcDays(int month, int day)
		{
			int days = 0;

			for (int i = 0; i < month; i++)
			{
				days += monthDays[i];
			}
			days += day;

			return days;
		}

		static void Main(string[] args)
		{
			int month = GetMonth();
			int day = GetDay(month);
			int daysInYear = CalcDays(month, day);

			Console.Clear();
			Console.WriteLine($"{months[month]} {day} is Day {daysInYear} of the year.");

			ConDev.ExitStatement();
		}
	}
}
