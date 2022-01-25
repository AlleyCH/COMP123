using Example01.Models;
using System;

namespace Example01 {
	class Program {
		static void Main(string[] args) {
			Person john = new Person();
			john.Name = "John";
			john.Height = 185; //cm
			john.DateOfBirth = new DateTime(2000, 01, 30);

			Person joanne = new Person(new DateTime(1990, 2, 28));

			Console.WriteLine(joanne.Age);
		}
	}
}
