using Example10.Models;
using System;
using System.Collections.Generic;

namespace Example10 {
	class Program {
		static void Main(string[] args) {
			Person person = new Person();
			person.FirstName = "John";
			//person.Speak();

			Student student = new Student();
			student.FirstName = "Mary";
			//student.Speak();

			Employee employee = new Employee();
			employee.FirstName = "Steve";
			//employee.Speak();

			person.Greet(student.FirstName);
			student.Greet(person.FirstName);

			student.Study();
			employee.Work();

			// The example below does not work.
			// The reason is:
			// All employees are persons, but not all persons are employees.
			//person.Work();

			// POLYMORPHISM
			// Polymorphism is the concept of acknowledging sub-types and their super-types.
			// Through polymorphism, objects of a sub-type may be treated as an instance of their super-type.
			// Example: All employees are persons, but not all persons are employees.
			// Example: All trucks are vehicles, but not all vehicles are trucks.

			// I can declare objects polymorphically.
			Person john = new Student();

			// I can declare collections polymorphically.
			// Student and Employee are just a sub-type of Person.
			// Hence, they can be added to a Person list.
			List<Person> people = new List<Person>();
			people.Add(person);
			people.Add(student);
			people.Add(employee);

			// However...
			List<Student> students = new List<Student>();
			students.Add(student);

			// The below will throw an error.
			// The error is raised because a student will always be a person, but a person won't always be a student.
			//students.Add(person);
			//students.Add(employee);
		}
	}
}
