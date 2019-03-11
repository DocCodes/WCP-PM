using System;
using System.Collections.Generic;
using System.Linq;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Card shuffling program
	Date Created : 2018-09-26
	Date Updated : 2018-09-26
*/

namespace ShuffleCards
{
	class Program
	{
		private static Random rng = new Random();
		
		static List<string> GetCardList()
		{
			List<string> ret = new List<string> { };
			string cardValue;

			foreach (char suit in new char[] { 'H', 'S', 'D', 'C' })
			{
				for (int i = 1; i < 14; i++)
				{
					switch (i)
					{
						case 1:
							cardValue = "A";
							break;
						case 11:
							cardValue = "J";
							break;
						case 12:
							cardValue = "Q";
							break;
						case 13:
							cardValue = "K";
							break;
						default:
							cardValue = i.ToString();
							break;
					}
					ret.Add($"{cardValue,2} {suit}");
				}
			}
			return ret;
		}

		static void Main(string[] args)
		{
			List<string> cardList = GetCardList();
			List<string> shufList = cardList.OrderBy(x => rng.Next()).ToList();

			for (int i = 0; i < cardList.Count(); i++)
			{
				Console.WriteLine($"{cardList[i]}\t{shufList[i]}");
			}

			ConDev.FeedLine();
			ConDev.ExitStatement();
		}
	}
}
