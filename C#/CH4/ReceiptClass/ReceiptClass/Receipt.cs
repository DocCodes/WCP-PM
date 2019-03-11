using System;
using System.Linq;
using System.Collections.Generic;

namespace ReceiptClass
{
	class Receipt
	{
		#region Properties
		/// <summary>
		/// The receipt's unique ID number.
		/// </summary>
		public long Number { get; set; }

		/// <summary>
		/// The receipt's creation date.
		/// </summary>
		public DateTime Date { get; set; }

		/// <summary>
		/// The receipt's customer.
		/// </summary>
		public Customer Customer { get; set; }

		/// <summary>
		/// The receipt's purchased items.
		/// </summary>
		public List<Item> Purchases { get; set; }

		/// <summary>
		/// The receipt's tax rate.
		/// </summary>
		public double Tax { get { return 0.10; } }

		/// <summary>
		/// The The receipt's subtotal (w/o tax).
		/// </summary>
		public double Subtotal { get { return Enumerable.Range(0, Purchases.Count).Select(i => Purchases[i].Price).Aggregate((acc, e) => acc + e); } }

		/// <summary>
		/// The receipt's total (w/ tax).
		/// </summary>
		public double Total { get { return Subtotal * (1 + Tax); } }
		#endregion

		#region Constructors
		/// <summary>
		/// Represents a Recipt.
		/// </summary>
		/// <param name="number">The receipt's unique ID number.</param>
		/// <param name="customer">The receipt's customer.</param>
		public Receipt(long number, Customer customer)
		{
			Number = number;
			Date = DateTime.Now;
			Customer = customer;
			Purchases = new List<Item>();
		}

		/// <summary>
		/// Represents a Recipt.
		/// </summary>
		/// <param name="number">The receipt's unique ID number.</param>
		/// <param name="date">The receipt's creation date.</param>
		/// <param name="customer">The receipt's customer.</param>
		public Receipt(long number, DateTime date, Customer customer)
		{
			Number = number;
			Date = date;
			Customer = customer;
			Purchases = new List<Item>();
		}
		#endregion

		#region Methods
		#endregion

		#region Overrides
		public override string ToString()
		{
			return string.Join("\n", new string[]
			{
				"     ╦┌─┐┬┌─┌─┐;┌─┐  ╔═╗┬ ┬┌┬┐┌─┐  ╔═╗┌─┐┬─┐┌┬┐┌─┐",
				"     ║├─┤├┴┐├┤  └─┐  ╠═╣│ │ │ │ │  ╠═╝├─┤├┬┘ │ └─┐",
				"    ╚╝┴ ┴┴ ┴└─┘ └─┘  ╩ ╩└─┘ ┴ └─┘  ╩  ┴ ┴┴└─ ┴ └─┘",
				new string('=', 54),
				$"\t\t    {Date.ToShortDateString()}",
				$"\t\t     {Date.ToShortTimeString()}",
				"",
				Customer.ToString(),
				"\n",
				string.Join("\n", Purchases.Select((e) => e.ToString())),
				"\n\n",
				new string('=', 54),
				$"\t\t\t       Subtotal {Subtotal,12:C2}",
				$"\t\t\t       Total    {Total,12:C2}"
			});
		}
		#endregion
	}
}
