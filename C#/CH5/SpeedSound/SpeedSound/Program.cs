using System;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Calculates the speed of sound
	Date Created : 2018-09-10
	Date Updated : 2018-09-10
*/

namespace SpeedSound
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] mediumTypes = new string[] { "Air", "Water", "Steel" };
			decimal[] mediumSpeeds = new decimal[] { 1100, 4900, 16400 };
			int medium;
			string inpMedium;
			decimal distance;
			string inpDistance;
			bool success;

			do
			{
				Console.Clear();
				Console.WriteLine("Please Select A Medium");
				Console.WriteLine("[1] Air");
				Console.WriteLine("[2] Water");
				Console.WriteLine("[3] Steel");

				inpMedium = ConDev.Write.ReadLine("Medium: ");
				success = int.TryParse(inpMedium, out medium);
			} while (!success || medium < 1 || medium > 3);
			medium--;

			do
			{
				Console.Clear();
				Console.WriteLine($"Medium: {mediumTypes[medium]}");
				inpDistance = ConDev.Write.ReadLine("Distance (Feet): ");
				success = decimal.TryParse(inpDistance, out distance);
			} while (!success);

			Console.Clear();
			Console.WriteLine($"Medium: {mediumTypes[medium]}");
			Console.WriteLine($"Distance: {distance:N4} Feet");
			Console.WriteLine($"Time: {distance / mediumSpeeds[medium]:N4} Seconds");

			ConDev.ExitStatement();
		}
	}
}
