using System;

namespace Part_1_Function_Fruitful
{
    class Program
    {
        static void Main(string[] args)
        {
			// Fruitful function example
			// Goal: Don't allow the user to press Enter without typing in any information

			Console.WriteLine("What is your name?");
			var name = Console.ReadLine();
			if (name == "")  // An empty string means the user just pressed Enter without typing in any information
			{
				name = TryAgain();  // This is calling the function that was created below the Main method
			}

			Console.WriteLine("What is your age?");
			var age = Console.ReadLine();
			if (age == "")
			{
				age = TryAgain();
			}

			Console.WriteLine("Spell out the month you were born in:");
			var month = Console.ReadLine();
			if (month == "")
			{
				month = TryAgain();
			}

			Console.WriteLine("Your name is: {0}", name);
			Console.WriteLine("Your age is: {0}", age);
			Console.WriteLine("Your birth month is: {0}", month);
			Console.ReadLine();
		}

		static string TryAgain()
		// This is a new function called TryAgain that returns a string
		// Since it's returning something, it's a fruitful function
		{
			Console.WriteLine("You didn't type anything, try again:");
			return Console.ReadLine();
			// return has to be the last line in a fruitful function
		}
	}
}
