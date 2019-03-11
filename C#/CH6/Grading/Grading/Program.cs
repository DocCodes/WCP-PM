using System;
using System.Collections.Generic;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Averages grades together
	Date Created : 2018-09-18
	Date Updated : 2018-09-18
*/

namespace Grading
{
	class Program
	{
		/// <summary>
		/// Averages a list of grades together to get an average.
		/// </summary>
		/// <param name="grades">The list of grades to average.</param>
		/// <returns>The average grade in the list.</returns>
		static Grade GetAverageGrade(List<Grade> grades)
		{
			decimal totalGrade = 0;
			decimal averageGrade = 0;

			foreach (Grade gr in grades)
			{
				totalGrade += gr.Level;
			}
			averageGrade = totalGrade / grades.Count;

			return new Grade((int)Math.Round(averageGrade));
		}

		/// <summary>
		/// Displays a list of grades.
		/// </summary>
		/// <param name="grades">The list of grades to display.</param>
		static void DisplayGrades(List<Grade> grades)
		{
			Grade averageGrade = GetAverageGrade(grades);

			Console.Clear();
			Console.WriteLine("--GRADE REPORT--");
			foreach (Grade gr in grades)
			{
				Console.WriteLine($"{gr.Letter}\t{gr.Level}%");
			}
			Console.WriteLine("----------------");
			Console.WriteLine($"{averageGrade.Letter}\t{averageGrade.Level}%");
			ConDev.FeedLine(2);
		}

		/// <summary>
		/// Gets a list of grades to the rest of the program.
		/// </summary>
		/// <returns>A list of grades.</returns>
		static List<Grade> GetGrades()
		{
			List<Grade> grades = new List<Grade> { };
			int gradeLevel;
			string inpValue;

			Console.WriteLine("Please enter the grades you want to average, use whole numbers 0-100. Type 'Q' to quit.");
			do
			{
				inpValue = ConDev.Write.ReadLine("Grade: ");
				if (int.TryParse(inpValue, out gradeLevel) && gradeLevel <= 100 && gradeLevel >= 0)
				{
					grades.Add(new Grade(gradeLevel));
				}
			} while (inpValue != "Q");

			return grades;
		}
		static void Main(string[] args)
		{
			List<Grade> grades = GetGrades();
			DisplayGrades(grades);
			ConDev.ExitStatement();
		}
	}

	class Grade
	{
		public Grade (int level)
		{
			Level = level;
		}

		public int Level { get; set; }
		public char Letter
		{
			get
			{
				if (Level >= 90)
				{
					return 'A';
				}
				else if (Level >= 80)
				{
					return 'B';
				}
				else if (Level >= 70)
				{
					return 'C';
				}
				else if (Level >+ 60)
				{
					return 'D';
				} else
				{
					return 'F';
				}
			}
		}
	}
}
