using System;

namespace Part_1_Array
{
    class Program
    {
        static void Main(string[] args)
        {
			// Hard-coded array of student grades

			var studentGrades = new int[] { 80, 99, 78, 90, 77, 65, 88, 93, 99, 100 };

			/* NOTES: 
			- var: var data type is letting the compiler implicitly decide on the data type
			  (could've explicitly stated the data type as int instead of using var)
			- studentGrades: this is the name of the array we're creating
			- new int[]: needed to create a new instance of an array
			- {}: initializing the array with these 10 values
			- 80 is in index position 0, 99 is position 1, 78 is position 2, etc.
			*/

			foreach (var grade in studentGrades)  // "grade" is a variable name; any variable name can be used
			{
				Console.WriteLine(grade);
			}
			Console.ReadLine();  // to see each grade one at a time instead of all at once, put the ReadLine inside of the foreach loop
		}
    }
}
