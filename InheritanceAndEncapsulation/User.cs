using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndEncapsulation
{
    class User : Person
    {
		public string Email;
		public string Password;

		public User()
		{

		}

		public User(string fullName, int age,
			string address, string email, string password)
			// base: use constructor of class Person
			// Person(string fullName, int age, string address)
			: base(fullName, age, address)
		{
			Email = email;
			Password = password;
		}

		public void PrintInfo()
		{
			// Call function PrintInfo() of class Person
			base.PrintInfo();
			// Because "_id" in class Person is protected
			// Child classes (Student, User) can access _id directly
			Console.WriteLine($"Email: {Email}, Password: {Password}, Id: {_id}");
		}
	}
}
