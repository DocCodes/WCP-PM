using System;
using System.Linq;

namespace BankApp
{
	public static class Getters
	{
		public static string GetterPrinter(string header, string message)
		{
			Console.Clear();
			Console.WriteLine(header);
			Console.WriteLine(message);
			Console.WriteLine("Alternatively, enter 'C' to cancel.");
			return Console.ReadLine();
		}
		public static bool GetAccountNumber(string header, string message, out int actNum)
		{
			string inp;
			string[] accounts = Program.allAccounts.Select(e => e.Number.ToString()).ToArray();
			actNum = 0;
			do
			{
				inp = GetterPrinter(header, message);
				if (inp.ToUpper() == "C") { return false; }
			} while (!accounts.Contains(inp));
			actNum = int.Parse(inp);
			return true;
		}
		public static bool GetPinNumber(string header, string message, out int pinNum)
		{
			string inp;
			int pin;
			pinNum = 0;
			do
			{
				inp = GetterPrinter(header, message);
				if (inp.ToUpper() == "C") { return false; }
			} while (!(int.TryParse(inp, out pin) && inp.Length == 4));
			pinNum = pin;
			return true;
		}
		public static bool GetDouble(string header, string message, out double doubleVal)
		{
			string inp;
			double amt;
			doubleVal = 0;
			do
			{
				inp = GetterPrinter(header, message);
				if (inp.ToUpper() == "C") { return false; }
			} while (!double.TryParse(inp, out amt));
			doubleVal = amt;
			return true;
		}
		public static bool GetString(string header, string message, out string stringVal)
		{
			string inp;
			stringVal = "";
			do
			{
				inp = GetterPrinter(header, message);
				inp.Trim();
				if (inp.ToUpper() == "C") { return false; }
			} while (inp.Length == 0);
			stringVal = inp;
			return true;
		}
	}
}
