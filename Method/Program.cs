using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void IncreaseNumber(int a)
        {
            Console.WriteLine("Begin function IncreaseNumber");
            a = a + 1;
            Console.WriteLine(a);
            Console.WriteLine("End function IncreaseNumber");
        }
        static void PrintOneToTen()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                if(i == 7)
                {
                    return;
                }
            }
        }
        static void PrintHello()
        {
            Console.WriteLine("Hello World ...");
            Console.WriteLine("Welcome to C#");
            Console.WriteLine("CSharp is beautiful ..."); ;
        }
        static void PrintHello(string fullname)
        {
            Console.WriteLine("Hello " + fullname);
            Console.WriteLine("Welcome to CSharp...");
        }
        static string PrintHello(string fullName, int age)
        {
            return $"Hello {fullName}, you are {age} years old ...";
        }
        static void PrintHello(int age, string fullName)
        {
            Console.WriteLine($"Hello {fullName}, you are {age} years old ...");
        }
        static void PrintMenu()
        {
            Console.WriteLine("==Welcome to my app==");
            Console.WriteLine("1. Create new order");
            Console.WriteLine("2. Create payment");
            Console.WriteLine("3. Quit the App");
        }
        static int SumTwoNumber(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static int SumThreeNumber(int a, int b, int c)
        {
            int result = a + b + c;
            result = SumTwoNumber(a, SumTwoNumber(b, c));
            return result;
        }
        static void Main(string[] args)
        {
            int numberA = 10;
            int numberB = 20;
            int sum = SumTwoNumber(numberA, numberB);
            int numberC = 30;
            int sums = SumThreeNumber(numberA, numberB, numberC);
            

            Console.WriteLine(sum);
            Console.WriteLine(sums);
            PrintHello();
            PrintHello("Tri Min");
            PrintMenu();
            PrintOneToTen();
            string hello = PrintHello("Tri Min", 300);
            Console.WriteLine(hello);
            PrintHello(200, "Minh Tri");
            numberA = 100;
            Console.WriteLine("value of numberA: " + numberA);
            IncreaseNumber(numberA);
            Console.WriteLine("Value of numberA: " + numberA);

            Console.ReadLine();
        }
    }
}
