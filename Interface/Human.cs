using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Human : IBeing
    {
		public int Age;
		public string FullName;

		public Human()
		{

		}

		public Human(int age, string fullName)
		{
			Age = age;
			FullName = fullName;
		}

		public void Born()
		{
			Console.WriteLine("Human is born ...");
		}

		public void Die()
		{
			Console.WriteLine("Human is dying ...");
		}

		public void Drink()
		{
			Console.WriteLine("Human is drinking ...");
		}

		public void Eat()
		{
			Console.WriteLine("Human is eating ...");
		}
		public void Sleep()
		{
			Console.WriteLine("Human is sleeping ...");
		}
	}
}
