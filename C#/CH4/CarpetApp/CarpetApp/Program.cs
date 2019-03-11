using System;
using ConDevLib;

namespace CarpetApp
{
	class Program
	{
		static double GetMeasure(string measure)
		{
			string inp = "";
			double ret = 0;
			while (true)
			{
				inp = ConDev.Write.ReadLine($"Room {measure}: ");
				if (double.TryParse(inp, out ret) && ret > 0)
				{
					return ret;
				}
			}
		}

		static void Main(string[] args)
		{
			CarpetCalculator berberCalc = new CarpetCalculator(25.99);
			CarpetCalculator shagCalc = new CarpetCalculator(17.59);
			double roomLength = GetMeasure("Length (yd)");
			double roomWidth = GetMeasure("Width  (yd)");

			berberCalc.Length = roomLength;
			berberCalc.Width = roomWidth;
			shagCalc.Length = roomLength;
			shagCalc.Width = roomWidth;

			ConDev.FeedLine(2);
			Console.WriteLine($"Length:       {berberCalc.Length}yd");
			Console.WriteLine($"Width:        {berberCalc.Width}yd");
			Console.WriteLine($"Area:         {berberCalc.SquareYards}yd^2");
			Console.WriteLine($"Berber Price: {berberCalc.Price:C2}");
			Console.WriteLine($"Shag Price:   {shagCalc.Price:C2}");

			ConDev.FeedLine(2);
			ConDev.ExitStatement();
		}
	}
}
