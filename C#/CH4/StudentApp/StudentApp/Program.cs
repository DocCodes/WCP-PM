using System;
using System.Text.RegularExpressions;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Student processing app
	Date Created : 2018-10-23
	Date Updated : 2018-10-23
*/

namespace StudentApp
{
	class Program
	{
		static string AskForName(string part)
		{
			string inp = "";
			do
			{
				inp = ConDev.Write.ReadLine($"{part} Name: ");
				inp = Regex.Replace(inp, "[^a-zA-Z]", "");
			} while (inp.Length == 0);
			return inp;
		}
		static string AskForID()
		{
			string inp = "";
			do
			{
				inp = ConDev.Write.ReadLine($"Student ID: ");
				inp = Regex.Replace(inp, "[^0-9]", "");
			} while (inp.Length == 0);
			return inp;
		}
		static int AskForScore(int testNo)
		{
			string inp = "";
			int ret = 0;
			while (true)
			{
				inp = ConDev.Write.ReadLine($"Exam {testNo} Score: ");
				if (int.TryParse(inp, out ret) && ret <= 100 && ret >= 0)
				{
					return ret;
				}
			};
		}

		static void Main(string[] args)
		{
			Student firstStudent = new Student();
			Student secondStudent = new Student("5678", "Spade", "Sam");
			Student lastStudent = new Student("4444", "Cups", "Dixie", 98, 78, 100);
			firstStudent.LastName = AskForName("Last");
			firstStudent.FirstName = AskForName("First");
			firstStudent.Major = AskForName("Major");
			firstStudent.ID = AskForID();
			firstStudent.Score1 = AskForScore(1);
			firstStudent.Score2 = AskForScore(2);
			firstStudent.Score3 = AskForScore(3);

			Console.WriteLine(firstStudent);
			Console.WriteLine(secondStudent);
			Console.WriteLine(lastStudent);
			ConDev.ExitStatement();
		}
	}
}
