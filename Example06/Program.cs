using Example06.Models;
using System;

namespace Example06 {
	class Program {
		static void Main(string[] args) {
			Person person = new Person();
			person.Name = "John";
			person.DateOfBirth = new DateTime(1985, 07, 15);

			Console.WriteLine(person.ToString());
		}
	}
}
