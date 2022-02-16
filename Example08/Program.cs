using System;
using System.IO;

namespace Example08 {
	class Program {
		static void Main(string[] args) {
			// FILE IO
			// Writing and reading files to and from your computer's file system.

			// Writing a string to a text file:
			string content = "C# is awesome!";

			if (Directory.Exists("C:\\temp")) {
				File.WriteAllText("C:\\temp\\file.txt", content);
			}
			else {
				throw new Exception("ERROR: Tried to create a file in a directory that does not exist.");
			}

			Console.WriteLine("File written successfully! \n");

			// ===================================================

			// Loading contents from a text file:
			string data = File.ReadAllText("C:\\temp\\file.txt");

			Console.WriteLine("File contents successfully loaded!");
			Console.WriteLine("Content is: ");
			Console.WriteLine(data);
		}
	}
}
