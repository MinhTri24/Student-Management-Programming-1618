using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndList
{
	class Program
	{
		static void Main(string[] args)
		{
			int arrayLength = 10;
			// Syntax create array
			// DataType[] arrayName = new DateType[]
			int[] numbers = new int[arrayLength]; // Create array with datatype int
			double[] realNumbers = new double[arrayLength];

			//int index = 0;
			//numbers[index] = 10; // Assign value 10 to numbers[0]
			//Console.WriteLine($"Value of numbers[0] is: {numbers[0]}");

			// Assign value: arrayName[index] = value
			// Read value from index: Console.WriteLine(arrayName[index]);

			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = i + 20;
				Console.WriteLine($"Value of numbers[{i}] is: {numbers[i]}");
			}

			// Exception because 100 > length of array numbers (10)
			// Array: static
			// numbers[100] = 20;

			// Days of Week 
			// Declare array and assign values
			string[] days = {
				"Monday",			// index = 0
				"Tuesday",		// index = 1
				"Wednesday",	// index = 2
				"Thursday",		// index = 3
				"Friday",			// index = 4
				"Saturday",		// index = 5
				"Sunday"			// index = 6
			};

			Console.Write("Enter day [1...7]: ");
			int dayInput = int.Parse(Console.ReadLine());
			if (dayInput >= 1 && dayInput <= 7)
			{
				Console.WriteLine(days[dayInput - 1]);
			}
			else
			{
				Console.WriteLine("Invalid Input ...");
			}

			//string[] days = new string[7];
			//days[0] = "Monday";
			//days[1] = " Tuesday";

			// Reading Array
			// Define array length
			Console.Write("Enter array length: ");
			arrayLength = int.Parse(Console.ReadLine());

			// Declare array numbers with arrayLength
			numbers = new int[arrayLength];

			// Assign value from keyboard
			for (int index = 0; index < numbers.Length; index++)
			{
				Console.Write("Enter value: ");
				numbers[index] = int.Parse(Console.ReadLine());
			}

			// Print all values of numbers to screen
			for (int index = 0; index < numbers.Length; index++)
			{
				Console.WriteLine($"Value of numbers[{index}] is: {numbers[index]}");
			}

			// Reading Array version 2
			Console.WriteLine("Reading array version 2");
			Console.Write("Enter a list of numbers: ");
			string values = Console.ReadLine();
			string[] arrayValues = values.Split(' ');

			numbers = new int[arrayValues.Length];
			// Convert string to int
			for (int index = 0; index < numbers.Length; index++)
			{
				numbers[index] = int.Parse(arrayValues[index]);
			}

			// Print values to screen
			for (int index = 0; index < numbers.Length; index++)
			{
				Console.WriteLine($"Value of numbers[{index}] is: {numbers[index]}");
			}

			// Reading Array version 3
			Console.WriteLine("Reading array version 3");
			Console.Write("Enter a list of numbers: ");
			values = Console.ReadLine();
			arrayValues = values.Split(' ');

			numbers = arrayValues.Select(int.Parse).ToArray();

			// Reading Array version 4
			Console.WriteLine("Reading array version 4");
			Console.Write("Enter a list of numbers: ");
			numbers = Console.ReadLine().Split(' ')
				.Select(int.Parse).ToArray();

			// Print Numbers in Reverse Order
			numbers = new int[]
			{
				1,2,3,4,5,6,7,8,9
			};

			// Method 1
			// From tail to head
			for (int i = numbers.Length - 1; i >= 0; i--)
			{
				Console.Write(numbers[i] + " ");
			}
			Console.WriteLine();

			// Method 2
			// Reverse array
			// Print head to tail
			numbers = numbers.Reverse().ToArray();
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write(numbers[i] + " ");
			}
			Console.WriteLine();

			// Reverse Array of Strings
			string[] items = new string[]
			{
				"Hello",
				"Bonjour",
				"Xin Chao",
				"Nihao",
				"Konichiwa"
			};

			// Method 1: use Reverse()
			string[] reverseItems = items.Reverse().ToArray();

			// Method 2: use loop
			string tempString = "";
			for (int i = 0; i < items.Length / 2; i++)
			{
				tempString = items[i];
				items[i] = items[items.Length - 1 - i];
				items[items.Length - 1 - i] = tempString;
			}

			// Foreach

			// Print all values of numbers to screen
			Console.WriteLine("Use for loop");
			for (int index = 0; index < numbers.Length; index++)
			{
				Console.WriteLine($"Value of numbers[{index}] is: {numbers[index]}");
			}

			Console.WriteLine("Use foreach");
			foreach (var item in numbers)
			{
				Console.WriteLine("Value of item: " + item);
			}

			Console.ReadLine();
		}
	}
}
