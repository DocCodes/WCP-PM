using System;
using System.Collections.Generic;
using ConDevLib;

/*
	Author       : Evan Young
	Comment      : Averages test scores without the lowest score.
	Date Created : 2018-08-28
	Date Updated : 2018-08-28
*/

namespace LowestScoreDrop
{
	class Program
	{
		/// <summary>
		/// Gets five test score between 0.00 and 1.00.
		/// </summary>
		/// <returns></returns>
		static List<double> GetTestScores()
		{
			List<double> scores = new List<double> { };
			string inputString;
			double outDouble;
			Console.WriteLine("Enter the test scores 1-100");
			for (int i = 0; i < 5; i++)
			{
				inputString = ConDev.Write.ReadLine($"Test {i + 1} Score: ");
				if (!double.TryParse(inputString, out outDouble))
				{
					Console.WriteLine("Invalid test score entered.");
					ConDev.ExitStatement(13);
				}
				scores.Add(outDouble / 100);
			}
			return scores;
		}

		/// <summary>
		/// Gets the lowest score out of a list of scores.
		/// </summary>
		/// <param name="scores">The list of scores between 0.00 ad 1.00.</param>
		/// <returns>The lowest score in the list.</returns>
		static double GetLowestScore(List<double> scores)
		{
			double minScore = 1;

			foreach (double score in scores)
			{
				minScore = Math.Min(minScore, score);
			}
			return minScore;
		}

		/// <summary>
		/// Gets the average score out of a list of scores, without the lowest score.
		/// </summary>
		/// <param name="scores">The list of scores to average.</param>
		/// <param name="lowest">The lowest score to ignore.</param>
		/// <returns>The average score of the list.</returns>
		static double GetAverage(List<double> scores, double lowest)
		{
			double totalScore = 0;
			double avgScore;
			foreach (double score in scores)
			{
				totalScore += score;
			}
			totalScore -= lowest;
			avgScore = totalScore / 4;

			return avgScore;
		}

		static void Main(string[] args)
		{
			List<double> testScores = GetTestScores();
			double minScore = GetLowestScore(testScores);
			double avgScore = GetAverage(testScores, minScore);
			Console.WriteLine($"The Average Score is {avgScore:P0}");

			ConDev.ExitStatement();
		}
	}
}
