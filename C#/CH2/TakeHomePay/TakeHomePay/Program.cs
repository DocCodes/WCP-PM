using System;
using System.Collections.Generic;

/*
	Author       : Evan Young
	Comment      : Calculates take home pay for commission salespeople
	Date Created : 2018-08-21
	Date Updated : 2018-08-21
*/

namespace TakeHomePay
{
	class Program
	{
		const double FED_TAX = 0.18;
		const double FICA_TAX = 0.06;

		static void Main(string[] args)
		{
			string EmployeeName = "Nesbith Lang";
			double Commission = 0.07;
			double Retirement = 0.1;
			int MonthlySales = 161432;
			double GrossPay = MonthlySales * Commission;
			double NetPay = GrossPay; // Iteratively subtract later
			double TotalDeductions = 0; // Iteratively add later
			var Deductions = new Dictionary<string, double>
			{
				{ "USA Federal Taxes", GrossPay * FED_TAX },
				{ "Social Security Tax", GrossPay * FICA_TAX },
				{ "Retirement Fund", GrossPay * Retirement }
			};

			Console.WriteLine($"\tEmployee:\t{EmployeeName}");
			Console.WriteLine($"Total Sales\t\t{MonthlySales,20:c2}");
			Console.WriteLine($"Gross Pay ({Commission:p0})\t\t{GrossPay,20:c2}");
			foreach (KeyValuePair<string, double> deduc in Deductions)
			{
				Console.WriteLine($"{deduc.Key}:\t{deduc.Value,20:c2}");
				TotalDeductions += deduc.Value;
				GrossPay -= deduc.Value;
			}
			Console.WriteLine($"\t\t\t{"-----------",20}");
			Console.WriteLine($"Total Deductions:\t{TotalDeductions,20:c2}\n");
         Console.WriteLine($"Take Home Pay:\t\t{GrossPay,20:c2}");


			Console.WriteLine("Press any key to continue. . .");
			Console.ReadKey();
		}
	}
}
