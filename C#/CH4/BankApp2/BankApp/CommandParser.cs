using System;
using System.Linq;

namespace BankApp
{
	static class CommandParser
	{
		public const string accountPrintHeader = "   Number   Owner                      Balance         APR";
		public static char Get(string header, char[] commands, string[] descriptions)
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

		public static void Parse(char command)
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
					if (!PrintAllAccounts()) { return; }
					break;
				case 'E':
					if (!ExitBank()) { return; }
					break;
			}

			Console.WriteLine("\n\nPress enter to return to the main menu. . .");
			Console.ReadLine();
		}

		static bool OpenAccount()
		{
			int actNum;
			int refNum;
			string localHeader = "Open An Account";
			string localMsg = "Please enter an account number to open an account.";
			bool success = false;
			double amt;
			string name;
			int pin;

			do
			{
				success = Getters.GetAccountNumber(localHeader, localMsg, out actNum);
				if (success == false) { return false; }

				refNum = actNum - 1001;
				if (Program.allAccounts[refNum].IsOpen)
				{
					localMsg = $"Please enter an account number to open an account.\nAccount {actNum} is already open.";
					success = false;
				}
			} while (!success);

			localMsg = "Please enter a PIN to protect your account.";
			success = false;
			do
			{
				success = Getters.GetPinNumber(localHeader, localMsg, out pin);
				if (success == false) { return false; }

				if (pin.ToString().Length != 4)
				{
					localMsg = "Please enter a PIN to protect your account.\nThe PIN must be 4 digits long.";
					success = false;
				}
			} while (!success);

			localMsg = "Please enter an initial deposit to open an account.";
			success = false;
			do
			{
				success = Getters.GetDouble(localHeader, localMsg, out amt);
				if (success == false) { return false; }

				if (amt < 100)
				{
					localMsg = "Please enter an initial deposit to open an account.\nThe initial deposit must be larger than $100.00.";
					success = false;
				}
			} while (!success);

			if (Getters.GetString(localHeader, "Please enter the account holder's first and last name.", out name))
			{
				Program.allAccounts[refNum].Open(name, amt, pin);
			}
			else
			{
				return false;
			}

			Console.Clear();
			Console.WriteLine(localHeader);
			Console.WriteLine(accountPrintHeader);
			Console.WriteLine(Program.allAccounts[refNum]);
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
				success = Getters.GetAccountNumber(localHeader, localMsg, out actNum);
				if (success == false) { return false; }

				refNum = actNum - 1001;
				if (!Program.allAccounts[refNum].IsOpen)
				{
					localMsg = $"Please enter an account number to check the balance.\nAccount {actNum} is not open.";
					success = false;
				}
			} while (!success);

			Console.Clear();
			Console.WriteLine(localHeader);
			Console.WriteLine(accountPrintHeader);
			Console.WriteLine(Program.allAccounts[refNum]);
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
				success = Getters.GetAccountNumber(localHeader, localMsg, out actNum);
				if (success == false) { return false; }

				refNum = actNum - 1001;
				if (!Program.allAccounts[refNum].IsOpen)
				{
					localMsg = $"Please enter an account number to make a deposit.\nAccount {actNum} is not open.";
					success = false;
				}
			} while (!success);

			localMsg = "Please enter an amount to deposit into the account.";
			success = false;
			do
			{
				success = Getters.GetDouble(localHeader, localMsg, out amt);
				if (success == false) { return false; }

				if (amt < 0)
				{
					localMsg = "Please enter an amount to deposit into the account.\nThe deposit must be larger than $0.00.";
					success = false;
				}
			} while (!success);

			Console.Clear();
			Console.WriteLine(localHeader);
			if (Program.allAccounts[refNum].Deposit(amt))
			{
				Console.WriteLine("An error has occurred while making your deposit.");
			}
			Console.WriteLine(accountPrintHeader);
			Console.WriteLine(Program.allAccounts[refNum]);
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
				success = Getters.GetAccountNumber(localHeader, localMsg, out actNum);
				if (success == false) { return false; }

				refNum = actNum - 1001;
				if (!Program.allAccounts[refNum].IsOpen)
				{
					localMsg = $"Please enter an account number to make a withdrawal.\nAccount {actNum} is not open.";
					success = false;
				}
			} while (!success);

			localMsg = "Please enter an amount to withdraw from the account.";
			success = false;
			do
			{
				success = Getters.GetDouble(localHeader, localMsg, out amt);
				if (success == false) { return false; }

				if (amt < 0)
				{
					localMsg = "Please enter an amount to withdraw from the account.\nThe withdrawal must be larger than $0.00.";
					success = false;
				}
			} while (!success);

			Console.Clear();
			Console.WriteLine(localHeader);
			if (!Program.allAccounts[refNum].Withdraw(amt))
			{
				Console.WriteLine("An error has occurred while withdrawing funds.");
			}
			Console.WriteLine(accountPrintHeader);
			Console.WriteLine(Program.allAccounts[refNum]);
			return true;
		}
		static bool CloseAccount()
		{
			int actNum;
			int refNum;
			string localHeader = "Close Account";
			string localMsg = "Please enter an account number to close the account.";
			bool success = false;

			do
			{
				success = Getters.GetAccountNumber(localHeader, localMsg, out actNum);
				if (success == false) { return false; }

				refNum = actNum - 1001;
				if (!Program.allAccounts[refNum].IsOpen)
				{
					localMsg = $"Please enter an account number to close the account.\nAccount {actNum} is not open.";
					success = false;
				}
			} while (!success);

			Console.Clear();
			Console.WriteLine(localHeader);
			if (Program.allAccounts[refNum].Close())
			{
				Console.WriteLine("Account closed.");
			}
			else
			{
				Console.WriteLine("An error has occurred while closing your account.");
				Console.WriteLine(accountPrintHeader);
				Console.WriteLine(Program.allAccounts[refNum]);
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
			int pin;

			do
			{
				success = Getters.GetPinNumber(localHeader, localMsg, out pin);
				if (success == false) { return false; }

				if (pin != Program.managerialPIN)
				{
					localMsg = $"Please enter your managerial PIN.\n{pin} is an invalid PIN.";
					success = false;
				}
			} while (!success);
			do
			{
				success = Getters.GetAccountNumber(localHeader, localMsg, out actNum);
				if (success == false) { return false; }

				refNum = actNum - 1001;
				if (!Program.allAccounts[refNum].IsOpen)
				{
					localMsg = $"Please enter an account number to calculate the interest.\nAccount {actNum} is not open.";
					success = false;
				}
			} while (!success);

			localMsg = "Please enter an interest rate in percent (XX.YY%).";
			success = false;
			do
			{
				success = Getters.GetDouble(localHeader, localMsg, out apr);
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
			Console.WriteLine(Program.allAccounts[refNum]);
			Program.allAccounts[refNum].APR = apr;
			Program.allAccounts[refNum].Balance += Program.allAccounts[refNum].Balance * Program.allAccounts[refNum].APR;
			Console.WriteLine(Program.allAccounts[refNum]);

			foreach (Account a in Program.allAccounts)
			{
				a.APR = apr;
			}
			return true;
		}
		static bool PrintAllAccounts()
		{
			string localHeader = "Print All Accounts";
			string localMsg = "Please enter your managerial PIN.";
			bool success = false;
			int pin;

			do
			{
				success = Getters.GetPinNumber(localHeader, localMsg, out pin);
				if (success == false) { return false; }

				if (pin != Program.managerialPIN)
				{
					localMsg = $"Please enter your managerial PIN.\n{pin} is an invalid PIN.";
					success = false;
				}
			} while (!success);

			Console.Clear();
			Console.WriteLine(accountPrintHeader);
			foreach (Account a in Program.allAccounts)
			{
				if (a.IsOpen)
				{
					Console.WriteLine(a);
				}
			}
			return true;
		}
		static bool ExitBank()
		{
			string localHeader = "Exit Bank";
			string localMsg = "Please enter your managerial PIN.";
			bool success = false;
			int pin;

			do
			{
				success = Getters.GetPinNumber(localHeader, localMsg, out pin);
				if (success == false) { return false; }

				if (pin != Program.managerialPIN)
				{
					localMsg = $"Please enter your managerial PIN.\n{pin} is an invalid PIN.";
					success = false;
				}
			} while (!success);
			Environment.Exit(0);
			return true;
		}
	}
}
