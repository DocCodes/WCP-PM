using System;

/*
	Author       : Evan Young
	Comment      : Read input and perform math
	Date Created : 2018-08-16
	Date Updated : 2018-08-16
*/

namespace ReadInput
{
	class Program
	{
		static string WriteReadLine(string value)
		{
			Console.Write(value);
			return Console.ReadLine();
		}
		static void Main(string[] args)
		{
			long NumOne = 55; // Define the numbers as a default value, then replace them later
			long NumTwo = 22;
			string ReadOne = WriteReadLine("Enter a number: "); // Define the number values as input strings
			string ReadTwo = WriteReadLine("Enter a number: ");

			try
			{ // Try to make the entered first number a number
				NumOne = Convert.ToInt64(ReadOne);
			}
			catch (Exception)
			{ // Alert of the error and use the default value
				Console.WriteLine("Your first number is invalid, defaulting to 55.");
			}
			try
			{ // Try to make the entered second number a number
				NumTwo = Convert.ToInt64(ReadTwo);
			}
			catch (Exception)
			{ // Alert of the error and use the default value
				Console.WriteLine("Your second number is invalid, defaulting to 22.");
			}

			Console.WriteLine($"{NumOne} + {NumTwo} = {NumOne + NumTwo}");
			Console.WriteLine($"{NumOne} - {NumTwo} = {NumOne - NumTwo}");
			Console.WriteLine($"{NumOne} x {NumTwo} = {NumOne * NumTwo}");

			Console.WriteLine("Press any key to continue. . .");
			Console.ReadKey();
		}
	}
}
