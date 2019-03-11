using System;
using ConDevLib;

/*
	Author       : Evan Young
	Comment      : Coding test
	Date Created : 2018-09-05
	Date Updated : 2018-09-05
*/

namespace CodingTest
{
	class Program
	{
		const double MILEAGE = 10.03;
		const double EXEMPT = 25000;
		const double YEAR_INC = 1.027;

		/// <summary>
		/// Displays the directions at the beginning of the program and pauses for an input key.
		/// </summary>
		static void DisplayDirections()
		{
			Console.WriteLine("This application determines taxes due for this calendar year.");
			Console.WriteLine("You will be asked to enter the property address and your");
			Console.WriteLine("assessed value for the previous calendar year.");
			ConDev.FeedLine();

			Console.WriteLine("Taxes are based on the following:");
			Console.WriteLine($"Mileage Rate: {MILEAGE:C} (per $1,000 of taxable value).");
			Console.WriteLine($"Exemption: {EXEMPT:C} (subtracted from taxable values for homeowners).");

			ConDev.FeedLine(2);
			ConDev.WriteLine.ReadLine("Press the enter key when you are ready to begin...");
			Console.Clear();
		}

		/// <summary>
		/// Displays the formatted output of the program.
		/// </summary>
		/// <param name="address">The property address.</param>
		/// <param name="prevVal">The value from the previous calendar year.</param>
		/// <param name="curVal">The current value.</param>
		/// <param name="taxVal">The taxable value (after deductions).</param>
		/// <param name="taxDue">The amount of taxes due today.</param>
		static void DisplayOutput(string address, double prevVal, double curVal, double taxVal, double taxDue)
		{
			const int leftWidth = -25;
			const int rightWidth = 15;

			Console.Clear();
			Console.WriteLine($"{" ",-9}Property Assessment App{" ",10}");
			ConDev.FeedLine();

			Console.WriteLine($"{"Property Address:",leftWidth}{address,rightWidth}");
			ConDev.FeedLine();
			Console.WriteLine($"{"Previous Assessed Value:",leftWidth}{prevVal,rightWidth:C}");
			ConDev.FeedLine();
			Console.WriteLine($"{"Current Assessed Value:",leftWidth}{curVal,rightWidth:C}");
			Console.WriteLine($"{"Exemption:",leftWidth}{EXEMPT,rightWidth:C}");
			Console.WriteLine($"{"Current Taxable Value:",leftWidth}{taxVal,rightWidth:C}");
			ConDev.FeedLine();
			Console.WriteLine($"{"Mileage Rate:",leftWidth}{MILEAGE,rightWidth:C}");
			ConDev.FeedLine();
			Console.WriteLine($"{"Taxes Due:",leftWidth}{taxDue,rightWidth:C}");
			ConDev.FeedLine();
		}

		/// <summary>
		/// Gets the property's street address.
		/// </summary>
		/// <returns></returns>
		static string GetAddress()
		{
			return ConDev.WriteLine.ReadLine("Current Property Address");
		}

		/// <summary>
		/// Asks for the property's value until a valid double is entered.
		/// </summary>
		/// <returns>The property's value for the previous calendar year.</returns>
		static double GetPreviousValue()
		{
			string valInput = "INVALID DOUBLE";
			double value;
			bool didParse = false;
			do
			{ // Get input until it is a valid double
				valInput = ConDev.WriteLine.ReadLine("Assessed Value For Last Year");
				didParse = double.TryParse(valInput, out value);
			} while (!didParse);
			return value;
		}

		/// <summary>
		/// Gets the property's current value with increases.
		/// </summary>
		/// <param name="prevVal">The property's value for the previous calendar year.</param>
		/// <returns>The property's current value.</returns>
		static double GetCurrentValue(double prevVal)
		{
			return prevVal * YEAR_INC;
		}

		/// <summary>
		/// Gets the property's current taxable value after deductions.
		/// </summary>
		/// <param name="curVal">The property's current value.</param>
		/// <returns>The property's current taxable value.</returns>
		static double GetTaxableValue(double curVal)
		{
			return curVal - EXEMPT;
		}

		/// <summary>
		/// Gets the property's amount of taxes due today.
		/// </summary>
		/// <param name="taxVal">The property's current taxable value.</param>
		/// <returns></returns>
		static double GetTaxDue(double taxVal)
		{
			return (taxVal / 1000) * MILEAGE;
		}

		static void Main(string[] args)
		{
			string address;
			double prevVal;
			double curVal;
			double taxVal;
			double taxDue;
			DisplayDirections();

			address = ConDev.WriteLine.ReadLine("Current Property Address");
			prevVal = GetPreviousValue();
			curVal = GetCurrentValue(prevVal);
			taxVal = GetTaxableValue(curVal);
			taxDue = GetTaxDue(taxVal);

			DisplayOutput(address, prevVal, curVal, taxVal, taxDue);
			ConDev.ExitStatement();
		}
	}
}
