using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models {
	public class Person {
		// Properties
		public string Name { get; set; }
		public double Height { get; set; }
		public DateTime DateOfBirth { get; set; }

		// Methods

		// Constructors

		// Default constructor: Provided by C# by default when a
		// constructor is not explicitly defined.

		// If a constructor is provided, then
		// C# will not provide a default constructor.

		// We can use constructors to enforce business rules.
		// For example, if business rules determine that
		// Person objects MUST have a value initialized in DateOfBirth,
		// Then, I can define a parameterized constructor that takes in
		// a DateTime object, and eliminate the parameterless constructor.

		// Ex.
		// public Person(DateTime dob) { }

		public Person() {
			// This is NOT a default constructor.
			// This is a PARAMETERLESS constructor.			
		}

		// Constructors are overloadable.
		public Person(DateTime dob) {
			// Constructors can house initialization logic.
			this.DateOfBirth = dob;
		}
	}
}
