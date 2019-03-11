namespace ReceiptClass
{
	class Item
	{
		#region Properties
		/// <summary>
		/// The item's unique product number.
		/// </summary>
		public long Number { get; set; }

		/// <summary>
		/// The item's title.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// The item's description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The item's quantity.
		/// </summary>
		public int Quantity { get; set; }

		/// <summary>
		/// The item's unit price.
		/// </summary>
		public double UnitPrice { get; set; }

		/// <summary>
		/// The item's price.
		/// </summary>
		public double Price { get { return Quantity * UnitPrice; } }
		#endregion

		#region Constructors
		/// <summary>
		/// Represents an Item.
		/// </summary>
		/// <param name="number">The item's unique product number.</param>
		/// <param name="title">The item's title.</param>
		/// <param name="description">The item's description.</param>
		/// <param name="price">The item's unit price.</param>
		public Item(long number, string title, string description, double price)
		{
			Number = number;
			Title = title;
			Description = description;
			UnitPrice = price;
		}
		#endregion

		#region Overrides
		public override string ToString()
		{
			return $" {Quantity,3}   {Title,-10}   {Number,-8}   {UnitPrice,7:C2}   {Price,11:C2}\n       {Description}\n";
		}
		#endregion
	}
}
