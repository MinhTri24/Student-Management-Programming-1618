using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Animal
    {
		// "virtual" key word: allow Child class overrides function
		public virtual void Eat()
		{
			Console.WriteLine("Animal is eating ...");
		}
		public virtual string Eat(string food)
		{
			string result = $"Animal eats {food}";
			return result;
		}
		public virtual string Eat(string food, string drink)
		{
			string result = $"Animal eats {food} and drink {drink}";
			return result;
		}
	}
}
