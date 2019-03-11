using System;
using ConDevLib;

/*
	Author       : Evan Young
	Comment      : Calculates the average number of days out in a company.
	Date Created : 2018-08-28
	Date Updated : 2018-08-28
*/

namespace DaysOut
{
	class Program
	{
		/// <summary>
		/// Gets the number of employees in an organization. A return value indicates whether the conversion succeeded.
		/// </summary>
		/// <param name="employees">When this method returns, contains the number of employees, if the conversion succeeded, or zero if the conversion failed.</param>
		/// <returns>True if it was retrieved successfully; otherwise, false.</returns>
		static bool GetEmployees(out int employees)
		{
			string inputString = ConDev.WriteLine.ReadLine("Please enter the amount of employees you have.");
			return int.TryParse(inputString, out employees);
		}

		/// <summary>
		/// Gets the total number of days out for the total number of employees.
		/// </summary>
		/// <param name="employees">The total number of employees.</param>
		/// <returns>The total number of days out.</returns>
		static int GetTotalDaysOut(int employees)
		{
			int daysOut = 0;
			int intRunner;
			string stringRunner;
			for (int i = 0; i < employees; i++)
			{
				stringRunner = ConDev.Write.ReadLine($"Employee {i + 1}'s Days Out: ");
				if (!int.TryParse(stringRunner, out intRunner))
				{
					Console.WriteLine("An invalid number of days out was entered.");
					ConDev.ExitStatement(13);
				}
				daysOut += intRunner;
			}
			return daysOut;
		}

		/// <summary>
		/// Gets the average number of days out per employee in an organization.
		/// </summary>
		/// <param name="employees">The total number of employees.</param>
		/// <param name="daysOut">The total number of days out.</param>
		/// <returns>The average number of days out per employee.</returns>
		static float AverageDaysOut(int employees, int daysOut)
		{
			return (float)daysOut / employees;
		}

		static void DisplayData(int employees, int daysOut, float averageOut)
		{
			ConDev.FeedLine();
			Console.WriteLine($"In the organization of {employees} employee(s), there was a total of {daysOut} day(s) out.");
			Console.WriteLine($"This means that there was an average of {averageOut:n1} day(s) out per employee.");
		}

		static void Main(string[] args)
		{
			int employeeCount;
			int totalOutDays;
			float averageOut;

			if (!GetEmployees(out employeeCount))
			{
				Console.WriteLine("An invalid number of employees was entered.");
				ConDev.ExitStatement(13);
			}
			totalOutDays = GetTotalDaysOut(employeeCount);
			averageOut = AverageDaysOut(employeeCount, totalOutDays);
			DisplayData(employeeCount, totalOutDays, averageOut);

			ConDev.ExitStatement();
		}
	}
}

