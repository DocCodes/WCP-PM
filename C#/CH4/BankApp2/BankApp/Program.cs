using System;
using System.Collections.Generic;
using System.Linq;

/*
	Author       : Evan Elias Young
	Comment      : Bank account app
	Date Created : 2018-10-26
	Date Updated : 2018-10-30
*/

namespace BankApp
{
	class Program
	{
		public const string consoleHeader = "Welcome To The Bank App";
		public static List<Account> allAccounts = Enumerable.Range(1001, 20).Select(i => new Account(i)).ToList();
		public const int managerialPIN = 1234;

		static void Main(string[] args)
		{
			char act;

			while (true)
			{
				int pin;
				act = CommandParser.Get(
					"Welome To The Bank App\nWhat would you like to do today?",
					new char[]
					{
						'O', 'E'
					},
					new string[]
					{
						"Open the bank",
						"Exit the app"
					}
				);
				if (act == 'E')
				{
					Environment.Exit(0);
				}

				string localHeader = "Open The Bank";
				string localMsg = "Please enter your managerial PIN.";
				bool success = false;
				do
				{
					success = Getters.GetPinNumber(localHeader, localMsg, out pin);
					if (success == false) { break; }

					if (pin != Program.managerialPIN)
					{
						localMsg = $"Please enter your managerial PIN.\n{pin} is an invalid PIN.";
						success = false;
					}
				} while (!success);
				if (success) { break; }
			}

			while (true)
			{
				act = CommandParser.Get(
					"Welome To The Bank App\nWhat would you like to do today?",
					new char[]
					{
						'A', 'B', 'D', 'W', 'C', 'I', 'P', 'E'
					},
					new string[]
					{
						"Open an account", "Balance inquiry on an account", "Deposit funds into an account", "Withdraw funds from an account", "Close an account", "Calculate interest on an account", "Print info on the accounts", "Exit the app"
					}
				);
				CommandParser.Parse(act);
			}
		}
	}
}
