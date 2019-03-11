using System;

namespace IfDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			int a, b, c, d, e, f, result;
			char grade;
			a = 5;
			b = 2;
			c = 5;
			d = 6;
			e = 10;
			f = 20;
			grade = 'B';
			result = a / b;

			if (result == 2)
			{
				Console.WriteLine("Result 2");
			}
			else if (result == 3)
			{
				Console.WriteLine("Result 3");
			}

			result = c - d;
			if (result > 0)
			{
				Console.WriteLine("Result is greater than zero.");
			}
			else
			{
				Console.WriteLine("Result is less than or equal to zero.");
			}

			if (grade == 'A')
			{
				Console.WriteLine("Excellent");
			}
			else if (grade == 'B')
			{
				Console.WriteLine("Well");
			}
			else if (grade == 'C' || grade == 'D')
			{
				Console.WriteLine("Passed");
			}
			else
			{
				Console.WriteLine("Fail");
			}

			switch (grade)
			{
				case 'A':
					Console.WriteLine("Excellent");
					break;
				case 'B':
					Console.WriteLine("Well");
					break;
				case 'C':
				case 'D':
					Console.WriteLine("Passed");
					break;
				default:
					Console.WriteLine("Fail");
					break;
			}

			Console.WriteLine(e > f ? "e is greater than f" : "e is less than f");

			Console.WriteLine("Done");
			Console.ReadLine();
		}
	}
}
