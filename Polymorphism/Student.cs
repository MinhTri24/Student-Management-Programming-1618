using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Class name: PascalCase
    // E.g: StudentManagement, FoodFactory
    // Noun
    class Student
    {
		// Properties
		// Property: PascalCase
		// Noun
		public string FullName;
		public int Age;

		// private property name: _camelCase 
		private string _fullName;
		private int _age;

		// Constructors
		public Student()
		{

		}

		// Parameter of function: camelCase
		public Student(string fullName, int age)
		{
			FullName = fullName;
			Age = age;
		}

		// Methods
		// Method name: Verb + Noun, PascalCase
		public int GetAge()
		{
			return Age;
		}

		public void SetFullName(string fullName)
		{
			FullName = fullName;
		}
	}
}
