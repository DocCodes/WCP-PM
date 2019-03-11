using System;

/*
	Author       : Evan Young
	Comment      : Rule of thumb calculator
	Date Created : 2018-08-21
	Date Updated : 2018-08-21
*/

namespace RuleOfThumb
{
	class Program
	{
		static string WriteReadLine(string msg)
		{
			Console.Write(msg);
			return Console.ReadLine();
		}

		static void EndConsole(int ExitCode)
		{
			Console.WriteLine("Press any key to continue. . .");
			Console.ReadKey();
			Environment.Exit(ExitCode);
		}

		static void Main(string[] args)
		{
			string WeightInput = WriteReadLine("Weight (LBS) : ");
			string WaistInput = WriteReadLine("Waist (IN)   : ");
			double Weight;
			double Waist;
			double Neck;
			double Hat;
			double Shoe;

			try
			{ // Check validity of weight
				Convert.ToDouble(WeightInput);
			}
			catch (Exception)
			{
				Console.WriteLine($"Invalid weight entered, \"{WeightInput}\"");
				EndConsole(1);
			}
			Weight = Convert.ToDouble(WeightInput);
			try
			{ // Check validity of waist
				Convert.ToDouble(WaistInput);
			}
			catch (Exception)
			{
				Console.WriteLine($"Invalid waist size entered, \"{WaistInput}\"");
				EndConsole(1);
			}
			Waist = Convert.ToDouble(WaistInput);

			Neck = (float)3 * Weight / Waist;
			Hat = (3 * Weight) / (2.125f * Waist);
			Shoe = (float)50 * Waist / Weight;

			Console.Write($"Neck Size : {Neck:n1}in\t");
			Console.Write($"Hat Size : {Hat:n0}\t");
			Console.WriteLine($"Shoe Size : {Shoe:n1}");

			EndConsole(0);
		}
	}
}
