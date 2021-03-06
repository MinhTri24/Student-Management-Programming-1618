using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndEncapsulation
{
    class Person
    {
		// public keyword
		// Allow all classes access the value
		public string FullName;
		public int Age;
		public string Address;

		// private keyboard
		// allow only the current class access
		private int _money;

		// protected word
		// allow the current class and child class access
		protected int _id;

		public Person()
		{

		}

		public Person(string fullName, int age, string address)
		{
			FullName = fullName;
			Age = age;
			Address = address;
			_money = 1000;
			MultipleMoney();
			_id = 10;
		}

		public void PrintInfo()
		{
			Console.WriteLine($"Full Name: {FullName}, Age: {Age}, Address: {Address} ");
		}

		public void GetAge()
		{
			Console.WriteLine("My age is: " + Age);
		}

		public void SetMoney(int money)
		{
			_money = money;
		}

		public int GetMoney()
		{
			return _money;
		}

		private void MultipleMoney()
		{
			_money = _money * 10;
		}
	}
}
