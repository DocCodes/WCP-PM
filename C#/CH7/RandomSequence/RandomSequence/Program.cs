using System;
using System.Collections.Generic;
using System.Linq;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Sequence analysis
	Date Created : 2018-09-28
	Date Updated : 2018-09-28
*/
namespace RandomSequence
{
	class Program
	{
		static Random rng = new Random(DateTime.UtcNow.Second);

		static void Main(string[] args)
		{
			List<int> randomNumbers = Enumerable.Range(0, 10000).Select(r => rng.Next(0, 10000)).ToList();
			List<int> sequentSeq = new List<int> { };
			List<int> increaseSeq = new List<int> { };
			List<int> increaseBufferSeq = new List<int> { };
			List<int> sequentBufferSeq = new List<int> { };
			int cur = 0;
			int nxt = 0;

			for (int i = 0; i < randomNumbers.Count; i++)
			{
				cur = randomNumbers[i];
				nxt = i == randomNumbers.Count - 1 ? cur : randomNumbers[i + 1];

				if (nxt > cur)
				{
					increaseBufferSeq.Add(cur);
					if (!increaseBufferSeq.Contains(nxt)) { increaseBufferSeq.Add(nxt); }
				}
				else
				{
					if (increaseBufferSeq.Count() >= increaseSeq.Count())
					{
						increaseSeq = increaseBufferSeq.ToList();
					}
					increaseBufferSeq.Clear();
				}

				if (nxt == cur + 1)
				{
					sequentBufferSeq.Add(cur);
					if (!sequentBufferSeq.Contains(nxt)) { sequentBufferSeq.Add(nxt); }
				}
				else
				{
					if (sequentBufferSeq.Count() >= sequentSeq.Count())
					{
						sequentSeq = sequentBufferSeq.ToList();
					}
					sequentBufferSeq.Clear();
				}
			}

			Console.WriteLine("Longest Sequential List");
			Console.WriteLine(string.Join(" ", sequentSeq.ToArray()));
			Console.WriteLine("Longest Incremental List");
			Console.WriteLine(string.Join(" ", increaseSeq.ToArray()));

			ConDev.ExitStatement();
		}
	}
}
