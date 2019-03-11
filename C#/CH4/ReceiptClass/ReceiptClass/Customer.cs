namespace ReceiptClass
{
	class Customer
	{
		#region Properties
		/// <summary>
		/// The customer's unique number.
		/// </summary>
		public long Number { get; set; }

		/// <summary>
		/// The customer's first name.
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// The customer's last name.
		/// </summary>
		public string FirstName { get; set; }

		/// <summary>
		/// The customer's phone number.
		/// </summary>
		public string PhoneNumber { get; set; }
		#endregion

		#region Constructors
		/// <summary>
		/// Represents a Customer.
		/// </summary>
		/// <param name="number">The customer's unique number.</param>
		/// <param name="lastName">The customer's last name.</param>
		/// <param name="firstName">The customer's first name.</param>
		/// <param name="phoneNumber">The customer's phone number.</param>
		public Customer(long number, string lastName, string firstName, string phoneNumber)
		{
			Number = number;
			LastName = lastName;
			FirstName = firstName;
			PhoneNumber = phoneNumber;
		}
		#endregion

		#region Overrides
		public override string ToString()
		{
			return $"{Number} - {LastName}, {FirstName} ({PhoneNumber})";
		}
		#endregion
	}
}
