using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Circle : IShape
    {
		private double _radius;

		public Circle()
		{

		}

		public Circle(double radius)
		{
			_radius = radius;
		}
		public void Draw()
		{
			double rIn = _radius - 0.4;
			double rOut = _radius + 0.4;
			for (double y = _radius; y >= -_radius; --y)
			{
				for (double x = -_radius; x < rOut; x += 0.5)
				{
					double value = x * x + y * y;
					if (value >= rIn * rIn && value <= rOut * rOut)
						Console.Write("*");
					else
						Console.Write(" ");
				}
				Console.WriteLine();
			}

		}

		public double CalculateArea()
		{
			return Math.PI * _radius * _radius;
		}
	}
}
