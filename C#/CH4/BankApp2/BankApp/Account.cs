using System;

namespace BankApp
{
	class Account
	{
		#region Properties
		/// <summary>
		/// The account's unique ID number.
		/// </summary>
		public int Number { get; set; } = 0000;

		/// <summary>
		/// The account's type.
		/// </summary>
		public char Type { get; set; } = 'C';

		/// <summary>
		/// 
		/// </summary>
		public int PIN { get; set; } = 0000;

		/// <summary>
		/// The account's owner's name.
		/// </summary>
		public string Name { get; set; } = "";

		/// <summary>
		/// The account's balance.
		/// </summary>
		public double Balance { get; set; } = 0.00;

		/// <summary>
		/// Whether or not the account is open.
		/// </summary>
		public bool IsOpen { get; private set; } = false;

		/// <summary>
		/// The account's annual percentage rate.
		/// </summary>
		public double APR { get; set; } = 0.00;
		#endregion

		#region Constructors
		/// <summary>
		/// Represents an Account.
		/// </summary>
		/// <param name="number">The account's unique ID number.</param>
		public Account(int number)
		{
			Number = number;
		}

		/// <summary>
		/// Represents an Account.
		/// </summary>
		/// <param name="number">The account's unique ID number.</param>
		/// <param name="type">The account's type.</param>
		/// <param name="name">The account's owner's name.</param>
		/// <param name="apr">The account's annual percentage rate.</param>
		public Account(int number, char type, string name, double apr)
		{
			Number = number;
			Type = type;
			Name = name;
			IsOpen = false;
			Balance = 0;
			APR = apr;
		}

		/// <summary>
		/// Represents an Account.
		/// </summary>
		/// <param name="number">The account's unique ID number.</param>
		/// <param name="type">The account's type.</param>
		/// <param name="name">The account's owner's name.</param>
		/// <param name="isOpen">Whether or not the account is open.</param>
		/// <param name="bal">The account's balance.</param>
		/// <param name="apr">The account's annual percentage rate.</param>
		public Account(int number, char type, string name, bool isOpen, double bal, double apr)
		{
			Number = number;
			Type = type;
			Name = name;
			IsOpen = isOpen;
			Balance = bal;
			APR = apr;
		}
		#endregion

		#region Methods
		/// <summary>
		/// Attempts to deposit money into the account.
		/// </summary>
		/// <param name="amt">The amount to deposit.</param>
		/// <returns>True if the deposit was successful.</returns>
		public bool Deposit(double amt)
		{
			try
			{
				Balance += amt;
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool Open(string name, double amt, int pin)
		{
			if (IsOpen || amt < 100) { return false; }
			try
			{
				IsOpen = true;
				Name = name;
				Balance = amt;
				PIN = pin;
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool Close()
		{
			if (!IsOpen) { return false; }
			try
			{
				IsOpen = false;
				Name = "";
				Balance = 0;
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Attempts to withdraw money from the account.
		/// </summary>
		/// <param name="amt">The amount to withdraw.</param>
		/// <returns>True if the withdrawal was successful.</returns>
		public bool Withdraw(double amt)
		{
			if (amt > Balance) { return false; }
			try
			{
				Balance -= amt;
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		#endregion

		#region Overrides
		public override string ToString()
		{
			return $"   {Number,6}   {Name,-24}   {Balance,-13:C2}   {APR,5:P2}";
		}
		#endregion
	}
}
