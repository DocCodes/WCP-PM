using System;
using System.Collections.Generic;
using System.Linq;
using ConDevLib;

namespace ArrayDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arrayThanks = new string[]
			{
				"Thank",
				"you",
				"very",
				"much!"
			};
			string[] arrayPet = new string[]
			{
				"Cat",
				"Dog",
				"Mouse",
				"Horse"
			};
			int[] arrayInt = new int[] { };
			int[] arrayEmp = new int[0];
			string[] arrayFood = {
				"Piza",
				"Poe",
				"Humberg",
				"Bonana"
			};
			int indexFood = Array.IndexOf(arrayFood, "Humberg");
			int nidexFood = Array.IndexOf(arrayFood, "See Cram");
			string[] arrayElements = {
				"Iron",
				"Oxygen",
				"Gold",
				"Silver"
			};
			string joinedElements = string.Join("|", arrayElements);
			string[] reElements = joinedElements.Split('|');
			string[] emptyElements = new string[reElements.Length];


			Console.WriteLine(string.Join(" ", arrayThanks));

			Console.WriteLine(arrayPet[arrayPet.Length - 1]);
			foreach (string pet in arrayPet)
			{
				Console.WriteLine(pet);
			}

			Console.WriteLine(arrayInt.Length == 0);
			Console.WriteLine(arrayEmp.Length == 0);

			Console.WriteLine(indexFood);
			Console.WriteLine(nidexFood);

			Console.WriteLine(joinedElements);
			foreach (string elm in reElements)
			{
				Console.WriteLine(elm);
			}

			ConDev.FeedLine();
			ConDev.ExitStatement();
		}
	}
}
