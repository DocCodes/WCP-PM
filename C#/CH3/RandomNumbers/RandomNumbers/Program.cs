using System;
using System.Collections.Generic;
using ConDevLib;

namespace RandomNumbers
{
	class Program
	{
		static Random rng = new Random();
		static List<ulong> ShuffleList(List<ulong> list)
		{
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				ulong value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
			return list;
		}

		static void Main(string[] args)
		{
			ulong maxNum;
			string inpMaxNum = ConDev.Write.ReadLine("Maximum Number: ");
			List<ulong> outNumbers = new List<ulong> { };

			if (!ulong.TryParse(inpMaxNum, out maxNum))
			{
				Console.WriteLine("Invalid maximum number entered.");
				ConDev.ExitStatement(13);
			}
			for (ulong i = 0; i < maxNum; i++)
			{
				outNumbers.Add(i);
			}
			outNumbers = ShuffleList(outNumbers);
			foreach (ulong num in outNumbers)
			{
				Console.WriteLine(num);
			}

			ConDev.ExitStatement();
		}
	}
}
