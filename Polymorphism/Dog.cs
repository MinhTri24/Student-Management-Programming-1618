﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Dog : Animal
    {
		public int Age;
		public Dog()
		{

		}
		public Dog(int age)
		{
			Age = age;
		}

		public override void Eat()
		{
			Console.WriteLine("This is a Dog. Dog is eating ...");
		}

		public override string Eat(string food)
		{
			return $"This is a Dog. Dog is eating {food} ...";
		}

		public override string Eat(string food, string drink)
		{
			return $"This is a Dog. Dog is eating {food} and drinking {drink}";
		}
	}
}
