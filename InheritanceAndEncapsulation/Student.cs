using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndEncapsulation
{
    class Student : Person
    {
		public string Major;
		public string ClassName;

		public Student()
		{

		}

		public Student(string fullName, int age, string address,
			string major, string className)
			: base(fullName, age, address)
		{
			Major = major;
			ClassName = className;
		}

		public void PrintInfo()
		{
			base.PrintInfo();
			Console.WriteLine($"Major: {Major}, Class Name: {ClassName}");
			// Because "_id" in class Person is protected
			// Child classes (Student, User) can access _id directly
			Console.WriteLine($"Id: {_id}");
		}
	}
}
