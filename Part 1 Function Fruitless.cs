using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Function_Fruitless
{
    class Program
    {
        static void Main(string[] args)
        {
			// Fruitless function example
			// Goal: Don't allow the user to press Enter without typing in any information

			Console.WriteLine("What is your name?");
			var name = Console.ReadLine();
			if (name == "")  // An empty string means the user just pressed Enter without typing in any information
			{
				TryAgain();  // This is calling the function that was created below the Main method
				name = Console.ReadLine();
			}

			Console.WriteLine("What is your age?");
			var age = Console.ReadLine();
			if (age == "")
			{
				TryAgain();
				age = Console.ReadLine();
			}

			Console.WriteLine("Spell out the month you were born in:");
			var month = Console.ReadLine();
			if (month == "")
			{
				TryAgain();
				month = Console.ReadLine();
			}

			Console.WriteLine("Your name is: {0}", name);
			Console.WriteLine("Your age is: {0}", age);
			Console.WriteLine("Your birth month is: {0}", month);
			Console.ReadLine();
		}

		static void TryAgain()  // this is a new function called TryAgain; "void" means it's a fruitless function
		{
			Console.WriteLine("You didn't type anything, try again:");
		}
	}
}
