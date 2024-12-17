using System;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("\n\t\t\t ----------------------------------");
			Console.WriteLine("\n\t\t\t\t BOX OFFICE");
			Console.WriteLine("\n\t\t\t ----------------------------------");
			Console.WriteLine("\n\t\t\t\t Welcome Customer!");
			Console.WriteLine("\n\n\t\t\t\t <1> Movie Timings");

			Console.WriteLine("\n\t\t\t\t <2> Contact Us");
			Console.WriteLine("\n\t\t\t\t <3> DTCard Registration");
			Console.WriteLine("\n\t\t\t\t <4> Exit \n\n");
			Console.WriteLine("\\t\\t\\t\\tEnter Your Choice :\"<<\"\\t");

			int choooosee = Convert.ToInt32(Console.ReadLine()); ;

			while (choooosee < 1 || choooosee > 4)
			{
				Console.WriteLine("Invalid selection - Please input 1 to 4 only.\n");
				Console.Clear();
			}
		}
	}
}