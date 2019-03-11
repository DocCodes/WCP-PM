using System;
using ConDevLib;

/*
	Author       : Evan Young
	Comment      : Methods example
	Date Created : 2018-08-27
	Date Updated : 2018-08-27
*/

namespace MethodExercise
{
	class Program
	{
		/// <summary>
		/// Gets a list of strings containing information about Valley Park School District
		/// </summary>
		/// <returns>A list of 4 strings about VPSD.</returns>
		static string[] GetSchoolInfo()
		{
			string[] linesAboutSchool =
			{
				"Name: Valley Park School District",
				"Students: 832",
				"Teachers: 38",
				"Grades: K-12",
				"Colors: Blue & Orange"
			};
			return linesAboutSchool;
		}
		/// <summary>
		/// Gives a string containing asterisks.
		/// </summary>
		/// <param name="linesAboutSchool"></param>
		/// <returns>A string containing 21 asterisks.</returns>
		static string GetAsterisks(string[] linesAboutSchool)
		{
			int count = -1;
			foreach (string line in linesAboutSchool)
			{
				count = line.Length > count ? line.Length : count;
			}
			return new string('*', count + 4);
		}

		static void Main(string[] args)
		{
			string[] linesAboutSchool = GetSchoolInfo();
			string asterisks = GetAsterisks(linesAboutSchool);

			Console.WriteLine(asterisks);
			foreach (string line in linesAboutSchool)
			{
				Console.WriteLine($"  {line}  ");
			}
			Console.WriteLine(asterisks);
			ConDev.WriteLine.ReadLine("Press the enter key to continue. . .");
		}
	}
}
