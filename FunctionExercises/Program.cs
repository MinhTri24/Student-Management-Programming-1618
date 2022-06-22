using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExercises
{
    class Program
    {
        // Sign of Integer Number
        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative");
            }
            else
            {
                Console.WriteLine($"The number {0} is zero");
            }
        }

        // Problem: Grade
        static void PrintGrade(double mark)
        {
            if (mark >= 2.00 && mark <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (mark >= 3.00 && mark <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (mark >= 3.50 && mark <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (mark >= 4.50 && mark <= 5.49)
            {
                Console.WriteLine("Very Good");
            }
            else if (mark >= 5.49 && mark <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        //	Problem: Printing Triangle
        static void PrintTriangle(int size)
        {
            PrintFirstHalfTriangle(size);
            PrintSecondHalfTraingle(size);
        }

        static void PrintTriangle2ndVersion(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            for (int x = size - 1; x >= 1; x--)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write(y + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintFirstHalfTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintLine(i);
            }
        }

        static void PrintSecondHalfTraingle(int size)
        {
            for (int i = size - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // Problem: Calculate rectangle area
        static double CalculateRectangleArea(double height, double width)
        {
            if (height <= 0 && width <= 0)
            {
                Console.WriteLine("Invalid input");
                return 0;
            }
            return height * width;
        }

        // Repeat string
        static string RepeatString(string str, int time)
        {
            if (time <= 0)
            {
                Console.WriteLine("Invalid time ...");
                return "";
            }
            string result = str;
            int i = 1;
            while (i < time)
            {
                result = result + str;
                i++;
            }

            return result;
        }

        //	Problem: Greater of Two Values
        static int GetMax(int value1, int value2)
        {
            if (value1 > value2)
            {
                return value1;
            }
            else return value2;
        }

        static char GetMax(char value1, char value2)
        {
            if (value1 > value2)
            {
                return value1;
            }
            else return value2;
        }

        static string GetMax(string value1, string value2)
        {
            int stringCompare = value1.CompareTo(value2);

            if (stringCompare == 0)
            {
                return value1;
            }
            else if (stringCompare > 0)
            {
                return value1;
            }
            else
            {
                return value2;
            }

        }

        static void Main(string[] args)
        {
            // Sign of integer number
            PrintSign(10);
            PrintSign(-10);
            PrintSign(0);

            // Problem: Grades
            PrintGrade(2.5);
            PrintGrade(3.25);
            PrintGrade(4);
            PrintGrade(5);
            PrintGrade(5.75);

            // Problem: Printing Triangle
            PrintTriangle(4);
            PrintTriangle2ndVersion(5);

            // Problem: Calculate rectangle area
            Console.WriteLine(CalculateRectangleArea(1.00, 2.34));
            Console.WriteLine(CalculateRectangleArea(0, 1.1));
            Console.WriteLine(CalculateRectangleArea(0, -1));

            // Repeat string
            Console.WriteLine(RepeatString("abc", 3));
            Console.WriteLine(RepeatString("String", 4));
            Console.WriteLine(RepeatString("String", 0));
            Console.WriteLine(RepeatString("String", -1));

            //	Problem: Greater of Two Values
            Console.WriteLine(GetMax(10, 20));
            Console.WriteLine(GetMax('a', 'z'));
            Console.WriteLine(GetMax("aaa", "bbb"));
            Console.WriteLine(GetMax("aaa", "aaa"));
            Console.WriteLine(GetMax("bbb", "aaa"));

            Console.ReadLine();
        }
    }
}
