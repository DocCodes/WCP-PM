using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Appointment sorter for me mum
	Date Created : 2018-10-11
	Date Updated : 2018-10-15
*/

namespace DrivingCrazy
{
	class Program
	{
		static void DisplayInstructions()
		{
			Console.WriteLine("Please enter the time in the form of 'D H:M T' (q to quit) where...");
			Console.WriteLine("   D is an integer 1-7 inclusive where 1 is Sunday and 7 is Saturday.");
			Console.WriteLine("   H is an integer 1-12, inclusive, representing the hour.");
			Console.WriteLine("   M is a zero-padded two digit integer 00-59, representing the minute.");
			Console.WriteLine("   T is either 'am' or 'pm', representing before or after mid - day.\n");
		}

		static bool ValidateTime(Appointment apt)
		{
			bool success = true;
			string err = "";

			if (apt.Day < 0 || apt.Day > 6)
			{
				err = "Invalid day entered.";
				success = false;
			}
			else if (apt.Hour < 1 || apt.Hour > 12)
			{
				err = "Invalid hour entered.";
				success = false;
			}
			else if (apt.Minute < 0 || apt.Minute > 59)
			{
				err = "Invalid minute entered.";
				success = false;
			}

			if (!success)
			{
				Console.WriteLine($"{err} Press 'Q' to quit.");
			}

			return success;
		}

		static List<Appointment> GetTimes()
		{
			List<Appointment> ret = new List<Appointment>();
			Appointment cur;
			Regex validTime = new Regex(@"^(\d) (\d{1,2}):(\d{2}) ([ap]m)$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
			Regex sentinel = new Regex(@"^\'?q\'?$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
			string inp;

			while (true)
			{
				inp = ConDev.Write.ReadLine("Appointment Time: ");

				if (sentinel.Match(inp).Success) { break; }
				if (validTime.Match(inp).Success)
				{
					cur = new Appointment(inp);

					if (ValidateTime(cur))
					{
						ConDev.FeedLine();
						ret.Add(cur);
					}
				}
				else
				{
					Console.WriteLine("Invalid date format. Press 'Q' to quit.");
				}
				ConDev.FeedLine();
			};

			return ret;
		}

		static void Main(string[] args)
		{
			DisplayInstructions();
			List<Appointment> times = GetTimes();

			Console.Clear();
			Console.WriteLine("The Week Ahead...");
			foreach (Appointment t in times.OrderBy(e => e.Value))
			{
				Console.WriteLine(t.Pretty);
			}

			ConDev.FeedLine();
			ConDev.ExitStatement();
		}
	}

	class Appointment
	{
		public Appointment(string time)
		{
			Time = time;
		}

		private Regex ValidTime = new Regex(@"^(\d) (\d{1,2}):(\d{2}) ([ap]m)$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
		private Match TimeMatch
		{
			get { return ValidTime.Match(Time); }
		}
		private GroupCollection Groups
		{
			get { return TimeMatch.Groups; }
		}

		public int Value
		{
			get { return Minute + (((Day * 24) + Hour24) * 60); }
		}
		public string Pretty
		{
			get { return $"{DayString} @ {Hour}:{Minute} {Meridian}"; }
		}

		public string Time { get; set; }
		public int Day
		{
			get { return int.Parse(Groups[1].Value) - 1; }
		}
		public string DayString
		{
			get
			{
				return new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" }[Day];
			}
		}
		public int Hour
		{
			get { return int.Parse(Groups[2].Value); }
		}
		public int Hour24
		{
			get { return Meridian == "PM" ? Hour + 12 : Hour; }
		}
		public int Minute
		{
			get { return int.Parse(Groups[3].Value); }
		}
		public string Meridian
		{
			get { return Groups[4].ToString().ToUpper(); }
		}
	}
}
