using Example05.Utilities;
using System;

namespace Example05 {
	class Program {
		static void Main(string[] args) {
			// STATIC CLASSES
			// Static classes cannot be instantiated.
			Console.WriteLine("Hello World!");

			//Console console = new Console();

			double result = Math.Sqrt(9);

			Database.Create("Something");
		}
	}
}
