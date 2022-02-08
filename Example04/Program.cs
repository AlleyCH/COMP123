using System;

namespace Example04 {
	class Program {
		static void Main(string[] args) {
			// EXCEPTIONS
			// Exceptions are errors.

			Console.WriteLine("Please input your age: ");
			int age;
			
			try {
				// Code that may raise an error goes here.
				age = int.Parse(Console.ReadLine());

				// Age cannot be negative!
				if (age < 0) {
					throw new Exception("Age cannot be negative!"); // <-- Manually throwing an error.
				}
			}
			catch (Exception e) {
				// What needs to happen in case something goes wrong.
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"Error! Please try again.");
				Console.WriteLine(e.Message);
				Console.ForegroundColor = ConsoleColor.White;

				return;
			}
			finally {
				// Optional block.
				// Code that goes here gets executed regardless of whether an exception was raised.
			}

			Console.WriteLine($"Your age is {age}.");
		}
	}
}
