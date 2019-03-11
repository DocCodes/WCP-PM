using System;
using ConDevLib;

/*
	Author       : Evan Young
	Comment      : Shapes' area calculator
	Date Created : 2018-09-10
	Date Updated : 2018-09-10
*/

namespace AreaCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			string areaInp;
			int areaOption;
			bool success = false;

			do
			{
				Console.WriteLine("FOR WHAT SHAPE DO YOU WISH TO CALCULATE THE AREA?");
				Console.WriteLine("[1] Circle");
				Console.WriteLine("[2] Rectangle");
				Console.WriteLine("[3] Cylinder");
				areaInp = Console.ReadLine();

				success = int.TryParse(areaInp, out areaOption);
				if (!success || areaOption < 1 || areaOption > 3)
				{
					Console.Clear();
				}
			} while (!success);

			Console.Clear();
			switch (areaOption)
			{
				case 1:
					SizeCircle();
					break;
				case 2:
					SizeRectangle();
					break;
				case 3:
					SizeCylinder();
					break;
				default:
					Console.WriteLine("ERROR");
					Console.WriteLine("Invalid option requested.");
					break;
			}

			ConDev.ExitStatement();
		}

		/// <summary>
		/// Branches off the main to get the area of a circle.
		/// </summary>
		static void SizeCircle()
		{
			Console.WriteLine("CIRCLE AREA CALCULATOR");
			string inpRad;
			double rad;
			bool success;

			do
			{
				inpRad = ConDev.Write.ReadLine("Circle Radius: ");
				success = double.TryParse(inpRad, out rad);
			} while (!success);

			Console.WriteLine($"Circle Area: {Math.PI * Math.Pow(rad, 2):N3}");
		}

		/// <summary>
		/// Branches off the main to get the area of a rectangle.
		/// </summary>
		static void SizeRectangle()
		{
			Console.WriteLine("RECTANGLE AREA CALCULATOR");
			string inpLength;
			string inpWidth;
			double length;
			double width;
			bool success;

			do
			{
				inpLength = ConDev.Write.ReadLine("Rectangle Length: ");
				success = double.TryParse(inpLength, out length);
			} while (!success);
			do
			{
				inpWidth = ConDev.Write.ReadLine("Rectangle Width: ");
				success = double.TryParse(inpWidth, out width);
			} while (!success);

			Console.WriteLine($"Rectangle Area: {length * width:N3}");
		}

		/// <summary>
		/// Branches off the main to get the area of a cylinder.
		/// </summary>
		static void SizeCylinder()
		{
			Console.WriteLine("CYLINDER AREA CALCULATOR");
			string inpHeight;
			string inpRad;
			double height;
			double rad;
			bool success;

			do
			{
				inpHeight = ConDev.Write.ReadLine("Cylinder Height: ");
				success = double.TryParse(inpHeight, out height);
			} while (!success);
			do
			{
				inpRad = ConDev.Write.ReadLine("Cylinder Radius: ");
				success = double.TryParse(inpRad, out rad);
			} while (!success);

			Console.WriteLine($"Cylinder Area: {2 * Math.PI * rad * height + (2 * Math.PI * Math.Pow(rad, 2)):N2}");
		}
	}
}
