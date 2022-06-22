using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        public string FullName;
        public int Age;
        public string Address;
        
        public Person()
        {

        }

        public Person(string fullName, string age, string address)
        {
            FullName = fullName;
            Age = age;
            Address = address;
        }
    }
}
