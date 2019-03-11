using System;
using ConDevLib;

/*
	Author       : Evan Young
	Comment      : Calculates a person's BMI
	Date Created : 2018-09-07
	Date Updated : 2018-09-07
*/

namespace BMICalc
{
	class Program
	{
		/// <summary>
		/// Calculates a person's BMI given their height and weight.
		/// </summary>
		/// <param name="height">The height in inches.</param>
		/// <param name="weight">The weight in pounds.</param>
		/// <returns>The standard BMI.</returns>
		static double CalcBMI(double height, double weight)
		{
			return weight / Math.Pow(height, 2) * 703;
		}

		/// <summary>
		/// Classifies a BMI based on the USDHSA standard.
		/// </summary>
		/// <param name="BMI">THe BMI.</param>
		/// <returns>The BMI classification.</returns>
		static string GetBMIClass(double BMI)
		{
			string ret = "";
			if (BMI < 18.5)
			{
				ret = "Underweight";
			}
			else if (BMI < 25)
			{
				ret = "Normal";
			}
			else if (BMI < 30)
			{
				ret = "Overweight";
			}
			else if (BMI < 40)
			{
				ret = "Obese";
			}
			else
			{
				ret = "Extremely Obese";
			}
			return ret;
		}

		/// <summary>
		/// Gets a double by retrying forever.
		/// </summary>
		/// <param name="msg">The message to display for input.</param>
		/// <returns>A double.</returns>
		static double GetDouble(string msg)
		{
			string inpVal;
			double dblVal;
			do
			{
				inpVal = ConDev.WriteLine.ReadLine(msg);
			} while (!double.TryParse(inpVal, out dblVal));
			return dblVal;
		}

		static void Main(string[] args)
		{
			double height;
			double weight;
			double BMI;
			string BMIClass;

			height = GetDouble("Enter Your Height (in inches)");
			weight = GetDouble("Enter Your Weight (in pounds)");
			BMI = CalcBMI(height, weight);
			BMIClass = GetBMIClass(BMI);
			Console.WriteLine($"Calculated BMI: {BMI:N1} ({BMIClass})");

			ConDev.ExitStatement();
		}
	}
}
