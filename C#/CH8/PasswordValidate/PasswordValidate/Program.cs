using System;
using System.Linq;
using System.Text.RegularExpressions;

/*
	Author       : Evan Elias Young
	Comment      : Comment here
	Date Created : 2018-11-26
	Date Updated : 2018-11-26
*/

namespace PasswordValidate
{
	class Program
	{
		static string[] errorCodes = new string[] {
			"The password is valid.",
			"The password should be at least 8 characters long.",
			"The password should contain at least one uppercase and at least one lowercase letter.",
			"The password should have at least one special character.",
			"The password should have 1 combination of 2 numbers and a letter.",
			"The password should start with a letter."
		};

		static void DisplayInstructions()
		{
			Console.WriteLine("Enter your password to validate it.");
			Console.WriteLine("Enter three astericks *** to exit.");
			Console.WriteLine("");
		}

		static int ValidatePassword(string pass)
		{
			if (pass.Length < 8) { return 1; }
			if (!(pass.Any(char.IsUpper) && pass.Any(char.IsLower))) { return 2; }
			if (pass.IndexOfAny(" !\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~".ToCharArray()) == -1) { return 3; }
			if (!Regex.IsMatch(pass, @"\d{2}[A-z]|[A-z]\d{2}")) { return 4; }
			if (!Regex.IsMatch(pass, @"^[A-z]")) { return 5; }
			return 0;
		}

		static void Main(string[] args)
		{
			DisplayInstructions();
			string inp;
			int errCode;
			while (true)
			{
				inp = Console.ReadLine();
				if (inp == "***") { break; }
				errCode = ValidatePassword(inp);
				Console.WriteLine(errorCodes[errCode]);
			}
		}
	}
}
