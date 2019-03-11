namespace TripClass
{
	class Trip
	{
		#region Properties
		public string Destination { get; set; }
		public double Distance { get; set; }
		public double Price { get; set; }

		public double GasPrice { get; set; }
		public double GallonsUsed { get; set; }
		public double CostPerMile { get { return Price / Distance; } }
		public double MilesPerGallon { get { return Distance / GallonsUsed; } }
		#endregion

		#region Constructors
		public Trip(string dest, double dist, double price, double gas, double gallons)
		{
			Destination = dest;
			Distance = dist;
			Price = price;
			GasPrice = gas;
			GallonsUsed = gallons;
		}
		#endregion

		#region Overrides
		public override string ToString()
		{
			return string.Join("\n", new string[]
			{
				$"Trip Destination: {Destination}",
				$"Trip Distance: {Distance:N2}",
				$"Trip Price: {Price:C2}",
				$"Gas Price: {GasPrice:C2}",
				$"Gallons Used: {GallonsUsed:N2}",
				$"Cost Per Mile: {CostPerMile:C2}",
				$"Miles Per Gallon: {MilesPerGallon:N2}"
			});
		}
		#endregion
	}
}
