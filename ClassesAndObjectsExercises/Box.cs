using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsExercises
{
    class Box
    {
		public int SerialNumber;
		public Item Item;
		public int ItemQuantity;
		public double Price;

		public Box()
		{

		}

		public Box(int serialNumber, Item item, int itemQuantity)
		{
			SerialNumber = serialNumber;
			Item = item;
			ItemQuantity = itemQuantity;
			Price = itemQuantity * item.Price;
		}

		public void PrintInfo()
		{
			Console.WriteLine(SerialNumber);
			Console.WriteLine($"-- {Item.Name} ${Item.Price}: {ItemQuantity}");
			Console.WriteLine($"-- {Price}");
		}
	}
}
