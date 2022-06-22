using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsExercises
{
    class Song
    {
		public string TypeList;
		public string Name;
		public string Time;

		public Song()
		{

		}

		public Song(string typeList, string name, string time)
		{
			TypeList = typeList;
			Name = name;
			Time = time;
		}

		public void PrintInfo()
		{
			Console.WriteLine($"TypeList: {TypeList}, Name: {Name}, Time: {Time}");
		}
	}
}
