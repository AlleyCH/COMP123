using System;

namespace Example04 {
	class Program {
		static void Main(string[] args) {
			// EXCEPTIONS
			// Exceptions are errors.

			while (true) {
				Console.WriteLine("Please input your age: ");
				int age;

				try {
					// Where code goes.
					// Always executed.
					age = int.Parse(Console.ReadLine());

					if (age < 0) {
						throw new Exception("Age cannot be negative!"); // <-- Manually throwing an error.
					}

					Console.WriteLine($"Your age is {age}.");

					break;
				}
				catch (Exception e) {
					// What to do if an error is thrown in the try block.
					// Only executed if the try block fails.

					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($"Error! Please try again. {e.Message}\n");
					Console.ForegroundColor = ConsoleColor.White;
				}
				finally {
					// Optional
					// Code to be executed regardless of whether an exception was raised.
				}
			}
		}
	}
}
