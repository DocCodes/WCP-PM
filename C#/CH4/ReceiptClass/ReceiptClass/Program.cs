using System;
using ConDevLib;

/*
	Author       : Evan Elias Young
	Comment      : Receipt generator fo an auto parts store.
	Date Created : 2018-10-24
	Date Updated : 2018-10-24
*/

namespace ReceiptClass
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.SetWindowSize(54, 50);
			Console.SetBufferSize(54, 50);
			Item shovel = new Item(81364423, "Shovel", "It is a hand-held folding shovel.", 11.99);
			Item flower = new Item(24114837, "Flower", "It is a generic non-potted flower.", 7.49);
			Customer evan = new Customer(710724, "Young", "Evan", "314-277-7058");
			Receipt evanReceipt = new Receipt(273, evan);

			shovel.Quantity = 3;
			flower.Quantity = 10;

			evanReceipt.Purchases.Add(shovel);
			evanReceipt.Purchases.Add(flower);

			Console.WriteLine(evanReceipt);

			ConDev.FeedLine(2);
			ConDev.ExitStatement();
		}
	}
}
