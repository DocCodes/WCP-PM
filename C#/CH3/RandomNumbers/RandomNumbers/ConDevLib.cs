using System;

/*
	Creator : Evan Elias Young
	Program : Console Development Library
	Comment : A (small) library for working with console applications.
	Created : 2018-08-25
	Updated : 2018-08-27
	Version : 2.2-a
*/

namespace ConDevLib
{
	public static class ConDev
	{
		/// <summary>
		/// Outputs the current line terminator to the standard output stream.
		/// </summary>
		public static void FeedLine()
		{
			Console.WriteLine();
		}
		/// <summary>
		/// Outputs any number of current line terminators to the standard output stream.
		/// </summary>
		/// <param name="lines">The number of new lines.</param>
		public static void FeedLine(int lines)
		{
			string value = new System.Text.StringBuilder().Insert(0, Environment.NewLine, lines).ToString();
			Console.Write(value);
		}
		/// <summary>
		/// Outputs a string to the standard output prompting for the enter key before exiting.
		/// </summary>
		public static void ExitStatement()
		{
			WriteLine.ReadLine("Press enter to continue...");
			Environment.Exit(0);
		}
		/// <summary>
		/// Outputs a string to the standard output stream for the enter key, then exits with an exit code.
		/// </summary>
		/// <param name="exitCode">EXit code to be given to the operating system.</param>
		public static void ExitStatement(int exitCode)
		{
			WriteLine.ReadLine("Press enter to continue...");
			Environment.Exit(exitCode);
		}
		/// <summary>
		/// Writes the specified string value to the standard output stream.
		/// </summary>
		public static class Write
		{
			/// <summary>
			/// Reads the next line of characters from the standard input stream.
			/// </summary>
			/// <param name="value">The value to write.</param>
			/// <returns>The next line of characters from the standard input stream.</returns>
			public static string ReadLine(string value)
			{
				Console.Write(value);
				return Console.ReadLine();
			}
			/// <summary>
			/// Reads the next character from the standard input stream.
			/// </summary>
			/// <param name="value">The value to write.</param>
			/// <returns>The next character from the standard input stream.</returns>
			public static ConsoleKeyInfo ReadKey(string value)
			{
				Console.Write(value);
				return Console.ReadKey();
			}
		}
		/// <summary>
		/// Writes the specified string value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		public static class WriteLine
		{
			/// <summary>
			/// Reads the next line of characters from the standard input stream.
			/// </summary>
			/// <param name="value">The value to write.</param>
			/// <returns>The next line of characters from the standard input stream.</returns>
			public static string ReadLine(string value)
			{
				Console.WriteLine(value);
				return Console.ReadLine();
			}
			/// <summary>
			/// Reads the next character from the standard input stream.
			/// </summary>
			/// <param name="value">The value to write.</param>
			/// <returns>The next character from the standard input stream.</returns>
			public static ConsoleKeyInfo ReadKey(string value)
			{
				Console.WriteLine(value);
				return Console.ReadKey();
			}
		}
	}
}