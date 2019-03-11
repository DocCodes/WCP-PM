using System;

/*
	Author       : Evan Young
	Comment      : Types and demos
	Date Created : 2018-08-21
	Date Updated : 2018-08-21
*/

namespace TypeScripting
{
	class Program
	{
		static void Main(string[] args)
		{
			int NumOne = 6;
			float NumTwo = 5.2F;
			decimal endowmentAmount = 34562.54M;
			bool moreData = true;
			string courseName = "WCP-PM";
			const decimal TAX = 0.06543M;
			decimal percentage = 0.456M;
			decimal change = 62.1567M;

			/* Byte 8 Bits */
			sbyte[] SByteStat = new sbyte[]
			{
				-127,
				127
			};
			byte[] UByteStat = new byte[]
			{
				0,
				255
			};
			/* Short 16 Bits */
			short[] SShortStat = new short[]
			{
				-32767,
				32767
			};
			ushort[] UShortStat = new ushort[]
			{
				0,
				65535
			};
			/* Int 32 Bits */
			int[] SIntStat = new int[]
			{
				-2147483647,
				2147483647
			};
			uint[] UIntStat = new uint[]
			{
				0,
				4294967295
			};
			long[] SLongStat = new long[]
			{
				-9223372036854775807,
				9223372036854775807
			};
			ulong[] ULongStat = new ulong[]
			{
				0,
				18446744073709551615
			};

			Console.WriteLine($"Number One : {NumOne}");
			Console.WriteLine($"Number Two : {NumTwo}");
			Console.WriteLine($"Percentage : {percentage:p0}");
			Console.WriteLine($"Change     : {change:c2}");

			Console.WriteLine("Press any key to continue. . .");
			Console.ReadKey();
		}
	}
}
