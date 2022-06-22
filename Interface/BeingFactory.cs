using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class BeingFactory
    {
		public static IBeing GetBeing(string type)
		{
			if (type.Equals("Human"))
			{
				return new Human();
			}
			else
			{
				return new Animal();
			}
		}
	}
}
