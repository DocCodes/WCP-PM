namespace CarpetApp
{
	class CarpetCalculator
	{
		#region Properties
		public double Length { get; set; }
		public double Width { get; set; }
		public double SquareYards { get { return Width * Length; } }
		public double Price { get { return SquareYards * PricePerSquareYard; } }
		public double PricePerSquareYard { get; set; }
		#endregion

		#region Constructors
		/// <summary>
		/// Represents a Carpet Calculator.
		/// </summary>
		public CarpetCalculator() { }

		/// <summary>
		/// Represents a Carpet Calculator.
		/// </summary>
		/// <param name="pricePer">The carpet's price per square yard.</param>
		public CarpetCalculator(double pricePer)
		{
			PricePerSquareYard = pricePer;
		}

		/// <summary>
		/// Represents a Carpet Calculator.
		/// </summary>
		/// <param name="length">The room's length.</param>
		/// <param name="width">The room's width.</param>
		public CarpetCalculator(double length, double width)
		{
			Length = length;
			Width = width;
		}

		/// <summary>
		/// Represents a Carpet Calculator.
		/// </summary>
		/// <param name="length">The room's length.</param>
		/// <param name="width">The room's width.</param>
		/// <param name="pricePer">The carpet's price per square yard.</param>
		public CarpetCalculator(double length, double width, double pricePer)
		{
			Length = length;
			Width = width;
			PricePerSquareYard = pricePer;
		}
		#endregion

		#region Overrides
		public override string ToString()
		{
			return $"Length: {Length} yd\nWidth: {Width} yd\nSquare Yards: {SquareYards}";
		}
		#endregion
	}
}
