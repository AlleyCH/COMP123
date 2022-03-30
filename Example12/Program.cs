using Example12.Models;
using Example12.Models.Interfaces;
using System;

namespace Example12 {
	class Program {
		static void Main(string[] args) {
			// Through polymorphism, it is possible to declare
			// objects as instances of their super-types.
			// Interfaces are super-types.
			// Therefore:
			// Student objects are instances of IStudyingPerson.

			IStudyingPerson student = new Student();

			// Interfaces cannot be instantiated. The line below errors.
			//IStudyingPerson person = new IStudyingPerson();
		}
	}
}
