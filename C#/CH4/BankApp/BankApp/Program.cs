using System;
using System.Collections.Generic;
using System.Linq;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Bank account app
	Date Created : 2018-10-26
	Date Updated : 2018-10-29
*/

namespace BankApp
{
	class Program
	{
		public const string accountPrintHeader = "   Number   Owner                      Balance         APR";
		public const string consoleHeader = "Welcome To The Bank App";
		public static List<Account> allAccounts = Enumerable.Range(1001, 20).Select(i => new Account(i)).ToList();

		static void PrintAllAccounts()
		{
			Console.WriteLine(accountPrintHeader);
			foreach (Account a in allAccounts)
			{
				if (a.IsOpen)
				{
					Console.WriteLine(a);
				}
			}
		}

		#region Commands
		static bool OpenAccount()
		{
			int actNum;
			int refNum;
			string localHeader = "Open An Account";
			string localMsg = "Please enter an account number to open an account.";
			bool success = false;
			double amt;
			string name;

			do
			{
				success = GetAccountNumber(localHeader, localMsg, out actNum);
				if (success == false) { return false; }

				refNum = actNum - 1001;
				if (allAccounts[refNum].IsOpen)
				{
					localMsg = $"Please enter an account number to open an account.\nAccount {actNum} is already open.";
					success = false;
				}
			} while (!success);

			localMsg = "Please enter an initial deposit to open an account.";
			success = false;
			do
			{
				success = GetDouble(localHeader, localMsg, out amt);
				if (success == false) { return false; }

				if (amt < 100)
				{
					localMsg = "Please enter an initial deposit to open an account.\nThe initial deposit must be larger than $100.00.";
					success = false;
				}
			} while (!success);

			if (GetString(localHeader, "Please enter the account holder's first and last name.", out name))
			{
				allAccounts[refNum].Open(name, amt);
			}
			else
			{
				return false;
			}

			Console.Clear();
			Console.WriteLine(localHeader);
			Console.WriteLine(accountPrintHeader);
			Console.WriteLine(allAccounts[refNum]);
			return true;
		}

		static bool BalanceInquiry()
		{
			int actNum;
			int refNum;
			string localHeader = "Balance Inquiry";
			string localMsg = "Please enter an account number to check the balance.";
			bool success = false;

			do
			{
				success = GetAccountNumber(localHeader, localMsg, out actNum);
				if (success == false) { return false; }

				refNum = actNum - 1001;
				if (!allAccounts[refNum].IsOpen)
				{
					localMsg = $"Please enter an account number to check the balance.\nAccount {actNum} is not open.";
					success = false;
				}
			} while (!success);

			Console.Clear();
			Console.WriteLine(localHeader);
			Console.WriteLine(accountPrintHeader);
			Console.WriteLine(allAccounts[refNum]);
			return true;
		}

		static bool MakeDeposit()
		{
			int actNum;
			int refNum;
			string localHeader = "Make Deposit";
			string localMsg = "Please enter an account number to make a deposit.";
			bool success = false;
			double amt;

			do
			{
				success = GetAccountNumber(localHeader, localMsg, out actNum);
				if (success == false) { return false; }

				refNum = actNum - 1001;
				if (!allAccounts[refNum].IsOpen)
				{
					localMsg = $"Please enter an account number to make a deposit.\nAccount {actNum} is not open.";
					success = false;
				}
			} while (!success);

			localMsg = "Please enter an amount to deposit into the account.";
			success = false;
			do
			{
				success = GetDouble(localHeader, localMsg, out amt);
				if (success == false) { return false; }

				if (amt < 0)
				{
					localMsg = "Please enter an amount to deposit into the account.\nThe deposit must be larger than $0.00.";
					success = false;
				}
			} while (!success);

			Console.Clear();
			Console.WriteLine(localHeader);
			if (allAccounts[refNum].Deposit(amt))
			{
				Console.WriteLine("An error has occurred while making your deposit.");
			}
			Console.WriteLine(accountPrintHeader);
			Console.WriteLine(allAccounts[refNum]);
			return true;
		}
		static bool MakeWithdrawal()
		{
			int actNum;
			int refNum;
			string localHeader = "Make Withdrawal";
			string localMsg = "Please enter an account number to make a withdrawal.";
			bool success = false;
			double amt;

			do
			{
				success = GetAccountNumber(localHeader, localMsg, out actNum);
				if (success == false) { return false; }

				refNum = actNum - 1001;
				if (!allAccounts[refNum].IsOpen)
				{
					localMsg = $"Please enter an account number to make a withdrawal.\nAccount {actNum} is not open.";
					success = false;
				}
			} while (!success);

			localMsg = "Please enter an amount to withdraw from the account.";
			success = false;
			do
			{
				success = GetDouble(localHeader, localMsg, out amt);
				if (success == false) { return false; }

				if (amt < 0)
				{
					localMsg = "Please enter an amount to withdraw from the account.\nThe withdrawal must be larger than $0.00.";
					success = false;
				}
			} while (!success);

			Console.Clear();
			Console.WriteLine(localHeader);
			if (!allAccounts[refNum].Withdraw(amt))
			{
				Console.WriteLine("An error has occurred while withdrawing funds.");
			}
			Console.WriteLine(accountPrintHeader);
			Console.WriteLine(allAccounts[refNum]);
			return true;
		}
		static bool CloseAccount()
		{
			int actNum;
			int refNum;
			string localHeader = "Close Account";
			string localMsg = "Please enter an account number to close the account.";
			bool success = false;
			double amt;

			do
			{
				success = GetAccountNumber(localHeader, localMsg, out actNum);
				if (success == false) { return false; }

				refNum = actNum - 1001;
				if (!allAccounts[refNum].IsOpen)
				{
					localMsg = $"Please enter an account number to close the account.\nAccount {actNum} is not open.";
					success = false;
				}
			} while (!success);

			Console.Clear();
			Console.WriteLine(localHeader);
			if (allAccounts[refNum].Close())
			{
				Console.WriteLine("Account closed.");
			} else
			{
				Console.WriteLine("An error has occurred while closing your account.");
				Console.WriteLine(accountPrintHeader);
				Console.WriteLine(allAccounts[refNum]);
			}
			return true;
		}
		static bool CalculateInterest()
		{
			int actNum;
			int refNum;
			string localHeader = "Calculate Interest";
			string localMsg = "Please enter an account number to calculate the interest.";
			bool success = false;
			double apr;

			do
			{
				success = GetAccountNumber(localHeader, localMsg, out actNum);
				if (success == false) { return false; }

				refNum = actNum - 1001;
				if (!allAccounts[refNum].IsOpen)
				{
					localMsg = $"Please enter an account number to calculate the interest.\nAccount {actNum} is not open.";
					success = false;
				}
			} while (!success);

			localMsg = "Please enter an interest rate in percent (XX.YY%).";
			success = false;
			do
			{
				success = GetDouble(localHeader, localMsg, out apr);
				if (success == false) { return false; }

				if (apr < 0)
				{
					localMsg = "Please enter an interest rate in percent (XX.YY%).\nThe percent must be greater than or equal to 0%.";
					success = false;
				}
			} while (!success);
			apr /= 100;

			Console.Clear();
			Console.WriteLine(localHeader);
			Console.WriteLine(accountPrintHeader);
			Console.WriteLine(allAccounts[refNum]);
			allAccounts[refNum].APR = apr;
			allAccounts[refNum].Balance += allAccounts[refNum].Balance * allAccounts[refNum].APR;
			Console.WriteLine(allAccounts[refNum]);

			foreach (Account a in allAccounts)
			{
				a.APR = apr;
			}
			return true;
		}
		#endregion

		#region Command Parser
		static char GetConsoleCommand(string header, char[] commands, string[] descriptions)
		{
			string inp;
			while (true)
			{
				Console.Clear();
				Console.WriteLine(header);
				for (int i = 0; i < commands.Length; i++)
				{
					Console.WriteLine($"{commands[i]} -- {descriptions[i]}");
				}
				Console.WriteLine("\nWhat Do You Wish Do To? ");
				inp = Console.ReadLine().ToUpper();
				if (inp.Length != 0 && commands.Contains(inp[0])) { return inp[0]; }
			}
		}

		static void ParseCommand(char command)
		{
			Console.Clear();
			switch (command)
			{
				case 'A':
					if (!OpenAccount()) { return; }
					break;
				case 'B':
					if (!BalanceInquiry()) { return; }
					break;
				case 'D':
					if (!MakeDeposit()) { return; }
					break;
				case 'W':
					if (!MakeWithdrawal()) { return; }
					break;
				case 'C':
					if (!CloseAccount()) { return; }
					break;
				case 'I':
					if (!CalculateInterest()) { return; }
					break;
				case 'P':
					PrintAllAccounts();
					break;
				case 'E':
					Environment.Exit(0);
					break;
			}

			Console.WriteLine("\n\nPress enter to return to the main menu. . .");
			Console.ReadLine();
		}
		#endregion

		#region Getters
		static string GetterPrinter(string header, string message)
		{
			Console.Clear();
			Console.WriteLine(header);
			Console.WriteLine(message);
			Console.WriteLine("Alternatively, enter 'C' to cancel.");
			return Console.ReadLine();
		}
		static bool GetAccountNumber(string header, string message, out int actNum)
		{
			string inp;
			string[] accounts = allAccounts.Select(e => e.Number.ToString()).ToArray();
			actNum = 0;
			do
			{
				inp = GetterPrinter(header, message);
				if (inp.ToUpper() == "C") { return false; }
			} while (!accounts.Contains(inp));
			actNum = int.Parse(inp);
			return true;
		}

		static bool GetDouble(string header, string message, out double doubleVal)
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

		static bool GetString(string header, string message, out string stringVal)
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
		#endregion


		static void Main(string[] args)
		{
			char act;

			while (true)
			{
				act = GetConsoleCommand(
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
				ParseCommand(act);
			}
		}
	}
}
