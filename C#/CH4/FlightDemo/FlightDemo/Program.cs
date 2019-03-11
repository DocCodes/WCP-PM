using System;

/*
	Author       : Evan Elias Young
	Comment      : Flight class for airport.
	Date Created : 2018-10-31
	Date Updated : 2018-10-31
*/

namespace FlightDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Flight testFlight = new Flight();

			testFlight.FeedInfo();
			Console.Clear();
			testFlight.ShowInfo();

			Console.WriteLine("Press enter to continue. . .");
			Console.ReadLine();
		}
	}
}
