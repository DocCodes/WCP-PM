using System;
using System.Collections.Generic;
using System.Linq;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Calorie counter
	Date Created : 2018-10-08
	Date Updated : 2018-10-08
*/

namespace TwoDimensional
{
	class Program
	{
		#region Display Data
		const int leftSpace = -15;
		static void DisplayDailyAverage(double[] dailyAverage)
		{
			string[] daysOfWeek = new string[7]
			{
				"Sunday",
				"Monday",
				"Tuesday",
				"Wednesday",
				"Thursday",
				"Friday",
				"Saturday"
			};

			for (int i = 0; i < dailyAverage.Length; i++)
			{
				Console.WriteLine($"{daysOfWeek[i],leftSpace}{dailyAverage[i]:N0}");
			}
		}
		static void DisplayMealAverage(double[] mealAverage)
		{
			string[] mealsOfDay = new string[3]
			{
				"Breakfast",
				"Lunch",
				"Dinner"
			};

			ConDev.FeedLine();
			for (int i = 0; i < mealAverage.Length; i++)
			{
				Console.WriteLine($"{mealsOfDay[i],leftSpace}{mealAverage[i]:N0}");
			}
		}
		static void DisplayAverageCaloriesPerMeal(int[,] calories)
		{
			double sum = 0;

			foreach (int c in calories)
			{
				sum += c;
			}
			sum /= calories.Length;

			ConDev.FeedLine();
			Console.WriteLine($"{"Meal Average",leftSpace}{sum:N0}");
		}
		#endregion

		static double[] CalculateAverageByDay(int[,] calories)
		{
			double[] ret = new double[7];
			double sum;

			for (int i = 0; i < calories.GetLength(0); i++)
			{
				sum = 0;
				for (int j = 0; j < calories.GetLength(1); j++)
				{
					sum += calories[i, j];
				}
				ret[i] = sum / calories.GetLength(1);
			}

			return ret;
		}
		static double[] CalculateAverageByMeal(int[,] calories)
		{
			double[] ret = new double[3];
			double sum;

			for (int j = 0; j < calories.GetLength(1); j++)
			{
				sum = 0;
				for (int i = 0; i < calories.GetLength(0); i++)
				{
					sum += calories[i, j];
				}
				ret[j] = sum / calories.GetLength(0);
			}

			return ret;
		}


		static void Main(string[] args)
		{
			int[,] calories = new int[7, 3]
			{
				{ 900, 750, 1020 },
				{ 300, 1000, 2700 },
				{ 500, 700, 2100 },
				{ 400, 900, 1780 },
				{ 600, 1200, 1100 },
				{ 575, 1150, 1900},
				{ 600, 1020, 1700 }
			};
			double[] dailyAverage = new double[7];
			double[] mealAverage = new double[3];

			dailyAverage = CalculateAverageByDay(calories);
			mealAverage = CalculateAverageByMeal(calories);

			DisplayDailyAverage(dailyAverage);
			DisplayMealAverage(mealAverage);
			DisplayAverageCaloriesPerMeal(calories);

			ConDev.ExitStatement();
		}
	}
}
