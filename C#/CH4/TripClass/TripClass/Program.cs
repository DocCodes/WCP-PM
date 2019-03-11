using System;
using System.Text.RegularExpressions;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Helps calculate trip adata.
	Date Created : 2018-10-24
	Date Updated : 2018-10-24
*/

namespace TripClass
{
	class Program
	{
		static double GetADouble(string prompt)
		{
			string inp = "";
			double ret = 0;

			do
			{
				inp = ConDev.Write.ReadLine(prompt);
			} while (!(double.TryParse(inp, out ret) && ret > 0));

			return ret;
		}

		static string GetDestination()
		{
			string inp = "";
			do
			{
				inp = ConDev.Write.ReadLine("Destination: ");
				inp = Regex.Replace(inp, @"[^A-z\s]", "");
			} while (inp.Length == 0);
			return inp;
		}

		static void Main(string[] args)
		{
			string tripDest = GetDestination();
			double tripDist = GetADouble("Distance (miles): ");
			double tripPrice = GetADouble("Total Price: ");
			double tripGas = GetADouble("Gas Price (Per Gallon): ");
			double tripGal = GetADouble("Gallons Used: ");
			Trip userTrip = new Trip(tripDest, tripDist, tripPrice, tripGas, tripGal);

			Console.Clear();
			Console.WriteLine(userTrip);

			ConDev.FeedLine();
			ConDev.ExitStatement();
		}
	}
}
