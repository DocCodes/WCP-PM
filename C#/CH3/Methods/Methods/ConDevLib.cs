using System;

/*
	Creator : Evan Elias Young
	Program : Console Development Library
	Comment : A library for working with console applications
	Created : 2018-08-25
	Updated : 2018-08-27
	Version : 2.0-a
*/

namespace ConDevLib
{
	public static class ConDev
	{
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
