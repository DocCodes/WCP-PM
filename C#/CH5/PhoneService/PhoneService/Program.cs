using System;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Automates the Liberty telephone service billing process.
	Date Created : 2018-09-14
	Date Updated : 2018-09-14
*/

namespace PhoneService
{
	class Program
	{
		static Time blockAStart = new Time();
		static Time blockAEnd = new Time(6, 59);
		static Time blockBStart = new Time(7, 0);
		static Time blockBEnd = new Time(19, 0);
		static Time blockCStart = new Time(19, 1);
		static Time blockCEnd = new Time(23, 59);
		static decimal blockARate = 0.24M;
		static decimal blockBRate = 0.86M;
		static decimal blockCRate = 0.41M;

		/// <summary>
		/// Gets a time object with a do loop.
		/// </summary>
		/// <param name="msg">The message to prompt the user for the time.</param>
		/// <returns>The time object the user entered.</returns>
		static Time GetTime(string msg)
		{
			Time ret = new Time();
			string errString = "";
			bool success = false;
			string inpValue;
			decimal timeValue;

			do
			{
				Console.Clear();
				if (errString != "")
				{
					Console.WriteLine(errString);
				}
				inpValue = ConDev.WriteLine.ReadLine(msg);
				success = decimal.TryParse(inpValue, out timeValue);

				if (success)
				{ // If the decimal is valid try to convert the decimal to a time
					success = ret.FromDouble(timeValue, out errString);
				}
			} while (!success);

			return ret;
		}

		/// <summary>
		/// Gets the difference in time between two times.
		/// </summary>
		/// <param name="start">The start time.</param>
		/// <param name="end">The end time.</param>
		/// <returns>The difference in time.</returns>
		static Time GetTimeDifference(Time start, Time end)
		{
			decimal diff = end.DoubleTime - start.DoubleTime;

			return new Time(diff);
		}

		/// <summary>
		/// Gets the amount of time a call was in a specific block.
		/// </summary>
		/// <param name="start">The call's start time.</param>
		/// <param name="end">The call's end time.</param>
		/// <param name="blockStart">The block's start time.</param>
		/// <param name="blockEnd">The block's end time.</param>
		/// <returns>The time object with the minutes and hours as the time spent in the specified block.</returns>
		static Time GetBlockTime(Time start, Time end, Time blockStart, Time blockEnd)
		{
			if (start.IsAfter(blockEnd) || end.IsBefore(blockStart))
			{
				return new Time();
			}

			Time retStart = start.IsAfter(blockStart) ? start : blockStart; // Limit the start to the first minute in the block
			Time retEnd = end.IsAfter(blockEnd) ? blockEnd : end; // Limit the end to the last minute in the block

			return GetTimeDifference(retStart, retEnd);
		}

		static void Main(string[] args)
		{
			const int col = -18;
			string callerName = ConDev.WriteLine.ReadLine("Please enter the caller's Name.");
			Time startTime = GetTime("Please enter the start time of the call (HH.MM format)");
			Time endTime = GetTime("Please enter the end time of the call (HH.MM format)");
			Time diffTime = GetTimeDifference(startTime, endTime);
			Time blockATime = GetBlockTime(startTime, endTime, blockAStart, blockAEnd);
			Time blockBTime = GetBlockTime(startTime, endTime, blockBStart, blockBEnd);
			Time blockCTime = GetBlockTime(startTime, endTime, blockCStart, blockCEnd);
			decimal cost = blockATime.DoubleTime * 60 * blockARate;
			cost += blockBTime.DoubleTime * 60 * blockBRate;
			cost += blockCTime.DoubleTime * 60 * blockCRate;

			Console.Clear();
			// Print the columns
			Console.Write($"{"Caller's Name",col}");
			Console.Write($"{"Call Started",col}");
			Console.Write($"{"Call Minutes",col}");
			Console.Write($"{"Call Cost",col}");
			ConDev.FeedLine();

			// Print the data
			Console.Write($"{callerName,col}");
			Console.Write($"{startTime.PrintFriendly,col}");
			Console.Write($"{diffTime.Hours * 60 + diffTime.Minutes,col}");
			Console.Write($"{cost,col:C2}");
			ConDev.FeedLine(2);

			ConDev.ExitStatement();
		}
	}


	class Time
	{
		/// <summary>
		/// Represents a time object.
		/// </summary>
		public Time()
		{
			Hours = 0;
			Minutes = 0;
		}

		/// <summary>
		/// Represents a time object with hours and minutes.
		/// </summary>
		/// <param name="hours">The hours of the time, 24 hours.</param>
		/// <param name="minutes">The minutes of the time.</param>
		public Time(int hours, int minutes)
		{
			Hours = hours;
			Minutes = minutes;
		}

		/// <summary>
		/// Represents a time object with double representation with minutes as fractional hours.
		/// </summary>
		/// <param name="timeValue">The double representation of the time with minutes as fractional hours</param>
		public Time(decimal timeValue)
		{
			Hours = (int)Math.Floor(timeValue);
			Minutes = (int)Math.Round(timeValue % 1 * 60);
		}

		/// <summary>
		/// Converts a double formatted like the input to a time.
		/// </summary>
		/// <param name="timeValue">The double to attempt to format.</param>
		/// <param name="errString">The error code, if there is an error.</param>
		/// <returns>False and errString if there is an error, otherwise true.</returns>
		public bool FromDouble(decimal timeValue, out string errString)
		{
			string stringValue = $"{timeValue:N2}";
			string[] splitTime = stringValue.Split('.');
			decimal hours;
			decimal minutes;
			errString = "";

			if (!decimal.TryParse(splitTime[0], out hours) || hours < 0 || hours > 23)
			{ // Invalid hours return false
				errString = "Invalid hours entered, must be between 0 - 23.";
				return false;
			}
			if (!decimal.TryParse(splitTime[1], out minutes) || minutes > 60 || minutes < 0)
			{ // Invalid minutes return false
				errString = "Invalid minutes entered, must be between 0 - 60.";
				return false;
			}

			Hours = (int)Math.Round(hours);
			Minutes = (int)Math.Round(minutes);

			return true;
		}

		/// <summary>
		/// Compares two times, if the current time is after the next time.
		/// </summary>
		/// <param name="compare">The time to compare against.</param>
		/// <returns>If the object time is after than the argument time.</returns>
		public bool IsAfter(Time compare)
		{
			return DoubleTime > compare.DoubleTime;
		}

		/// <summary>
		/// Compares two times, if the current time is before the next time.
		/// </summary>
		/// <param name="compare">The time to compare against.</param>
		/// <returns>If the object time is before than the argument time.</returns>
		public bool IsBefore(Time compare)
		{
			return DoubleTime < compare.DoubleTime;
		}

		/// <summary>
		/// The time's double representation with minutes as fractional hours.
		/// </summary>
		public decimal DoubleTime
		{
			get
			{
				return Hours + (decimal)Minutes / 60;
			}
		}

		/// <summary>
		/// The hours of the time.
		/// </summary>
		public int Hours { get; set; }

		/// <summary>
		/// The minutes of the time.
		/// </summary>
		public int Minutes { get; set; }

		/// <summary>
		/// The print-friendly, 12 hour time.
		/// </summary>
		public string PrintFriendly
		{
			get
			{
				int twelveHours = Hours % 12 == 0 ? 12 : Hours % 12;
				string paddedMinutes = Minutes.ToString("00");
				string amPM = Hours >= 12 ? "PM" : "AM";

				return $"{twelveHours}:{paddedMinutes} {amPM}";
			}
		}
	}
}
