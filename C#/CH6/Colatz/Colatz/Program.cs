using System;
using ConDevLib;
namespace Colatz
{
	class Program
	{
		/// <summary>
		/// Returns the next number in the Colatz sequence.
		/// </summary>
		/// <param name="cur">The current number in the Colatz sequence.</param>
		/// <returns>The next number in the Colatz sequence.</returns>
		static int Colatz(int cur)
		{
			if (cur % 2 == 0)
			{
				return cur / 2;
			}
			return 3 * cur + 1;
		}

		/// <summary>
		/// Gets the starting number in the Colatz sequence.
		/// </summary>
		/// <returns>The starting number.</returns>
		static int GetStartNumber()
		{
			string inpValue;
			int ret;
			Console.WriteLine("The program will display the progression in a lines of 8.");
			Console.WriteLine("At the end of each line press 'X' to exit or any other key to continue.");
			do
			{
				inpValue = ConDev.Write.ReadLine("Sequence Starting Number (not 0): ");
			} while (!(int.TryParse(inpValue, out ret) && ret != 0));
			return ret;
		}

		/// <summary>
		/// Prints a line in the Colatz sequence
		/// </summary>
		/// <param name="curNumber">The current number in the sequence.</param>
		/// <param name="lastNumber">The previous number in the sequence.</param>
		static void PrintLine(ref int curNumber, ref int lastNumber)
		{
			for (int i = 0; i < 8; i++)
			{
				if (lastNumber == 1) { break; }

				lastNumber = curNumber;
				curNumber = Colatz(curNumber);
				Console.Write($"{lastNumber,-8} ");
			}
		}

		static void Main(string[] args)
		{
			int curNumber;
			int lastNumber;
			char action;

			curNumber = GetStartNumber();
			lastNumber = curNumber;

			Console.Clear();
			do
			{
				PrintLine(ref curNumber, ref lastNumber);
				if (lastNumber == 1) { break; }

				action = Console.ReadKey().KeyChar;
				ConDev.FeedLine();
			} while (action != 'X');

			ConDev.FeedLine();
			ConDev.ExitStatement();
		}
	}
}
