using System;

namespace Part_1_C_Sharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
			// PART 1: C# Basics

			Console.WriteLine("Hard-coded string:");
			Console.WriteLine("Hello world");

			Console.WriteLine("String variable:");
			var a = "My first string";
			Console.WriteLine(a);
			var anything = "My second string";
			Console.WriteLine(anything);

			// Assigning user input to a variable:
			Console.WriteLine("Please type in something and press Enter:");
			var b = Console.ReadLine();
			Console.WriteLine(b);


			// CHALLENGE: Muliple choice questions

			Console.WriteLine("What is your name?");
			var name = Console.ReadLine();
			Console.WriteLine("What is your age?");
			var age = Console.ReadLine();
			Console.WriteLine("Spell out the month you were born in");
			var month = Console.ReadLine();

			Console.WriteLine("Your name is: {0}", name);
			Console.WriteLine("Your age is: {0}", age);
			Console.WriteLine("Your birth month is: {0}", month);


			// Adding in conditions (focus on coding, not zodiac accuracy)

			if (month == "March" || month == "march")  // the == sign is making a comparison; the || sign means "or"
			{
				Console.WriteLine("You are an Aries");
			}
			else if (month == "April" || month == "april")
			{
				Console.WriteLine("You are a Taurus");
			}
			else if (month == "May" || month == "may")
			{
				Console.WriteLine("You are a Gemini");
			}
			Console.ReadLine();


			// CHALLENGE: Passcode

			Console.WriteLine("What is the passcode?");
			var passcode = Console.ReadLine();

			if (passcode == "secret")
			{
				Console.WriteLine("Authenticated!");
			}
			else
			{
				Console.WriteLine("NOT Authenticated!");
			}

			/* Alternative to else statement:
			
			else if (passcode != "secret")
			{
				Console.WriteLine("NOT Authenticated!");
			}
			
			 */


			// Adding in a while loop to let the user keep trying to enter the correct passcode

			var passcode2 = "";  // the variable needs to exist first in order to use it in the while loop
								 // this is setting the value of the variable to an empty string

			while (passcode2 != "secret")  // the != sign means "not"
			{
				Console.WriteLine("What is the passcode? ");
				passcode2 = Console.ReadLine();
				if (passcode2 != "secret")
				{
					Console.WriteLine("NOT Authenticated. Try again.");
				}
			}
			Console.WriteLine("Authenticated!");
			Console.ReadLine();


			// while loop and for loop examples:

			var count = 1;  // initializing the variable used to keep count

			while (count <= 10) // while True, it'll keep looping
			{
				Console.WriteLine(count);
				count++;  // increments count by 1 each time it loops until count is equal to 10
			}

			for (int i = 1; i <= 10; i++)  // "i" is the name of a variable; any variable name can be used here
			{
				Console.WriteLine(i);
			}


			// CHALLENGE: Loop counting
			// Goal: Count from 1 to 10 and then back to 1, and repeat 5 times without using if statements


			for (int x = 1; x <= 5; x++)  // repeating 5 times
										  // can't use the same "i" variable inside nested loops so this was changed to x
			{
				for (int i = 1; i <= 10; i++)  // counting up from 1 to 10
				{
					Console.WriteLine(i);
				}
				for (int i = 10; i >= 1; i--)  // counting down from 10 to 1
				{
					Console.WriteLine(i);
				}
			}
			Console.ReadLine();
		}
	}
}
