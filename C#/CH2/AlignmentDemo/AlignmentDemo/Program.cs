using System;

/*
	Author       : Evan Young
	Comment      : Alignment demo
	Date Created : 2018-08-23
	Date Updated : 2018-08-23
*/

namespace AlignmentDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"\t{"Student Name:",-20}{"Debbie Downer",-25}");
			Console.WriteLine($"\t{"Total Credits:",-20}{"43",-45}");
			Console.WriteLine($"\t{"College Cost:",-20}{"20034.04",-12:C}");
			Console.WriteLine($"\t{"Dorm Cost:",-20}{"8039.65",-12:C}");

			Console.WriteLine("Press any key to continue. . .");
			Console.ReadKey();
		}
	}
}
