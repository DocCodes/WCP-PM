using System;

namespace FlightDemo
{
	class Flight
	{
		#region Properties
		private int FlightNumber { get; set; }
		private string Destination { get; set; }
		private float Distance { get; set; }
		private float Fuel { get; set; }
		#endregion

		#region Methods
		private float CalcFuel()
		{
			if (Distance > 2000)
			{
				return 2200;
			}
			else if (Distance > 1000)
			{
				return 1100;
			}
			return 500;
		}

		public void FeedInfo()
		{
			string inp;
			int flightNumber;
			string destination;
			float distance;

			inp = "";
			do
			{
				Console.Clear();
				Console.WriteLine("Please enter the flight number.\nThis is a 4 digit number indicating the flight you will be on.");
				inp = Console.ReadLine();
			} while (!(int.TryParse(inp, out flightNumber) && flightNumber >= 1000 && flightNumber <= 9999));
			inp = "";
			do
			{
				Console.Clear();
				Console.WriteLine("Please enter the flight destination.\nThis is the city, state where you will be arriving.");
				inp = Console.ReadLine();
				destination = inp;
			} while (inp.Length == 0);
			inp = "";
			do
			{
				Console.Clear();
				Console.WriteLine("Please enter the flight distance.\nThis is the distance in miles from the departure and arrival.");
				inp = Console.ReadLine();
			} while (!(float.TryParse(inp, out distance) && distance >= 0));

			FlightNumber = flightNumber;
			Destination = destination;
			Distance = distance;
			Fuel = CalcFuel();
		}

		public void ShowInfo()
		{
			Console.WriteLine($"Flight: #{FlightNumber}");
			Console.WriteLine($"Destination: {Destination}");
			Console.WriteLine($"Distance: {Distance} Miles");
			Console.WriteLine($"Fuel: {Fuel} Gallons");
		}
		#endregion
	}
}
