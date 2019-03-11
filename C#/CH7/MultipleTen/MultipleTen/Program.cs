using System;
using System.Collections.Generic;
using System.Linq;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Multiples of ten?
	Date Created : 2018-10-02
	Date Updated : 2018-10-02
*/

namespace MultipleTen
{
	class Program
	{
		static List<int> Run10(List<int> li)
		{
			bool runMod = false;

			for (int i = 0; i < li.Count; i++)
			{
				if (runMod)
				{
					if (li[i] % 10 == 0 && runMod) { runMod = false; }
				}
				else
				{
					if (li[i] == 10 && !runMod)
					{
						runMod = true;
						continue;
					}
				}

				li[i] *= runMod ? 10 : 1;
			}

			return li;
		}

		static List<int> Run20(List<int> li)
		{
			bool runMod = false;

			for (int i = 0; i < li.Count; i++)
			{
				if (runMod)
				{
					if (li[i] % 10 == 0 && runMod) { runMod = false; }
				}
				else
				{
					if (li[i] == 20 && !runMod)
					{
						runMod = true;
						continue;
					}
				}

				li[i] += runMod ? 2 : 0;
			}

			return li;
		}

		static List<int> Run30(List<int> li)
		{
			bool runMod = false;

			for (int i = 0; i < li.Count; i++)
			{
				if (runMod)
				{
					if (li[i] % 10 == 0 && runMod) { runMod = false; }
				}
				else
				{
					if (li[i] == 30 && !runMod)
					{
						runMod = true;
						continue;
					}
				}

				li[i] -= runMod ? 10 : 0;
			}

			return li;
		}

		static List<int> Run40(List<int> li)
		{
			bool runMod = false;

			for (int i = 0; i < li.Count; i++)
			{
				if (runMod)
				{
					if (li[i] % 10 == 0 && runMod) { runMod = false; }
				}
				else
				{
					if (li[i] == 40 && !runMod)
					{
						runMod = true;
						continue;
					}
				}

				li[i] += runMod ? 6 : 0;
			}

			return li;
		}

		static List<int> Run50(List<int> li)
		{
			bool runMod = false;

			for (int i = 0; i < li.Count; i++)
			{
				if (runMod)
				{
					if (li[i] % 10 == 0 && runMod) { runMod = false; }
				}
				else
				{
					if (li[i] == 50 && !runMod)
					{
						runMod = true;
						continue;
					}
				}

				li[i] *= runMod ? 5 : 1;
			}

			return li;
		}

		static void PrintList(List<int> li)
		{
			for (int i = 0; i < li.Count; i++)
			{
				Console.Write($"{li[i],6}");
				if ((i + 1) % 12 == 0) { ConDev.FeedLine(); }
			}
			ConDev.FeedLine();
		}

		static void Main(string[] args)
		{
			Random rng = new Random(DateTime.Now.Second);
			List<int> rand = Enumerable.Range(0, 100).Select(e => rng.Next(1, 100)).ToList();
			List<int> rand10 = Run10(rand.ToList());
			List<int> rand20 = Run20(rand10.ToList());
			List<int> rand30 = Run30(rand20.ToList());
			List<int> rand40 = Run40(rand30.ToList());
			List<int> rand50 = Run50(rand40.ToList());
			Dictionary<int, int> divCount = new Dictionary<int, int> { };

			Console.WriteLine("Default Array");
			PrintList(rand);
			ConDev.FeedLine();

			Console.WriteLine("10s Array");
			PrintList(rand10);
			ConDev.FeedLine();

			Console.WriteLine("20s Array");
			PrintList(rand20);
			ConDev.FeedLine();

			Console.WriteLine("30s Array");
			PrintList(rand30);
			ConDev.FeedLine();

			Console.WriteLine("40s Array");
			PrintList(rand40);
			ConDev.FeedLine();

			Console.WriteLine("50s Array");
			PrintList(rand50);
			ConDev.FeedLine();

			Console.WriteLine("10 Divisble Counts");
			foreach (int e in rand50)
			{
				if (e % 10 == 0)
				{
					divCount[e] = divCount.ContainsKey(e) ? divCount[e] + 1 : 1;
				}
			}

			foreach (KeyValuePair<int, int> e in divCount.OrderBy(e => e.Key))
			{
				Console.WriteLine($"{e.Key,3} -- {e.Value}");
			}

			ConDev.ExitStatement();
		}
	}
}
