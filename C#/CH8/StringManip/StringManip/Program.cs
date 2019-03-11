using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManip
{
	class Program
	{
		static void Main(string[] args)
		{
			string first, last;
			first = "Alberto";
			last = "Etstiner";
			char[] letters = { 'H', 'e', 'l', 'l', 'o' };
			string[] strArray = { "Today", "is", "Monday." };
			DateTime waiting = new DateTime(2018, 11, 26, 13, 58, 1);

			// Concat
			string fullName = $"{first} {last}";
			Console.WriteLine($"Full Name: {fullName}");

			// Concat w/ String Constructor
			string greet = new string(letters);
			Console.WriteLine(greet);

			// Concat w/ Join
			string message = string.Join("*", strArray);
			Console.WriteLine(message);

			// Formatter
			string chat = $"Sent at {waiting:t} on {waiting:D}";
			Console.WriteLine(chat);

			// Comparator
			string testOne = "Today is Monday";
			string testTwo = "Today is monday";

			if (string.Compare(testOne, testTwo) == 0)
			{
				Console.WriteLine("They Are Equal");
			}
			else
			{
				Console.WriteLine("They Are Not Equal");
			}

			// Containment
			string str = "Today is Monday";
			string tst = "day";
			if (str.Contains(tst))
			{
				Console.WriteLine($"Contains '{tst}'");
			}
			else
			{
				Console.WriteLine($"Does Not Contain '{tst}'");
			}

			// Substringing
			string strA = "The wise never marry and when they marry, they become otherwise.";
			string substr = strA.Substring(4, 4);
			Console.WriteLine(substr);

			// Joining
			string[] strTest = new string[] { "You don't know", "what you have", "until it's gone", "for example,", "tooilet paper" };
			Console.WriteLine(string.Join("\n", strTest));

			// String to Char
			string spli = "Expert";
			char[] chArr = spli.ToCharArray();
			string array = new string(chArr);
			Console.WriteLine(array);

			// Empty and Null
			string empty;
			Console.Write("Enter your name: ");
			empty = Console.ReadLine();
			if (empty == string.Empty) { empty = null; }
			if (empty != null)
			{
				Console.WriteLine($"There are {empty.Length} characters in your name.");
			} else
			{
				Console.WriteLine("The name field has been left empty");
			}

			// Start With
			string name = "Albert is the Einstei.";
			Console.WriteLine(name.StartsWith("albert"));

			// Ends With
			Console.WriteLine(name.EndsWith("Einstei."));

			// Insert
			name = "Expert";
			string sub = name.Insert(2, "--");
			Console.WriteLine(sub);

			// Remove
			name = "Ex--pert";
			sub = name.Remove(2, 2);
			Console.WriteLine(sub);

			// Trim
			name = "      I am in Class today.       ";
			Console.WriteLine(name.Trim());

			// Split
			name = "      I am in Class today.       ";
			foreach (string e in name.Split())
			{
				Console.WriteLine(e);
			}

			// REplace
			greet = "Hi Albert Eisnti";
			greet = greet.Replace("Hi", "Hello");
			Console.WriteLine(greet);

			Console.ReadLine();
		}
	}
}
