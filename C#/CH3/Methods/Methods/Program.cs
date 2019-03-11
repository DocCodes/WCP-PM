using System;
using ConDevLib;

/*
	Author       : Evan Young
	Comment      : Methods demo
	Date Created : 2018-08-27
	Date Updated : 2018-08-27
*/

namespace Methods
{
	class Program
	{
		/// <summary>
		/// Displays instructions for the program.
		/// </summary>
		static void DisplayInstructions()
		{
			Console.WriteLine("This program will determine how much carpet to purchase");
			Console.WriteLine("You will be asked to enter the size of the room");
			Console.WriteLine("and the price of the carpet, in price per square yard.");
		}
		/// <summary>
		/// Gets for the size of the specified side in feet.
		/// </summary>
		/// <param name="side">The side to ask for.</param>
		/// <returns>The size in feet.</returns>
		static double GetDimensions(string side)
		{
			string inputValue;
			double feet, inches;

			inputValue = ConDev.WriteLine.ReadLine($"Enter the {side} in feet.");
			feet = double.Parse(inputValue);

			inputValue = ConDev.WriteLine.ReadLine($"Enter the {side} in inches.");
			inches = double.Parse(inputValue);

			return feet + (inches / 12);
		}
		/// <summary>
		/// Gets the price of the carpet per square yard.
		/// </summary>
		/// <returns>The price of the carpet per square yard.</returns>
		static double GetPrice()
		{
			string inputValue;
			double price;
			inputValue = ConDev.WriteLine.ReadLine("Enter the price per square yard.");
			price = double.Parse(inputValue);
			return price;
		}
		/// <summary>
		/// Determines the amount of square yards in a given area.
		/// </summary>
		/// <param name="width">The width of the area in feet.</param>
		/// <param name="length">The length of the area in feet.</param>
		/// <returns>The amount of square yards in the area.</returns>
		static double DetermineSquareYards(double width, double length)
		{
			const int SQ_FT_PER_SQ_YARD = 9;
			double amtOfSquareYards;

			amtOfSquareYards = length * width / SQ_FT_PER_SQ_YARD;
			return amtOfSquareYards;
		}
		/// <summary>
		/// Displays the results of the calculations.
		/// </summary>
		/// <param name="yards">The number of square yards.</param>
		/// <param name="price">The price per squard yard.</param>
		static void DisplayResults(double yards, double price)
		{
			Console.WriteLine($"\nSquare yards needed: {yards:N2}");
			Console.WriteLine($"Price Per Sq. Yard: {price:C}");
         Console.WriteLine($"Total Price: {yards * price:C2}");
		}

		static void Main(string[] args)
		{
			double roomLength;
			double roomWidth;
			double amtOfSquareYards;
			double pricePerSquardYard;

			DisplayInstructions();

			roomLength = GetDimensions("Length");
			roomWidth = GetDimensions("Width");
			amtOfSquareYards = DetermineSquareYards(roomLength, roomWidth);

			pricePerSquardYard = GetPrice();
			DisplayResults(amtOfSquareYards, pricePerSquardYard);

			ConDev.WriteLine.ReadLine("Press the enter key to continue. . .");
		}
	}
}
