using System;

namespace Example01.Models {
	public class Person {
		// Properties
		public string Name { get; set; } // Auto-implemented property
		public double Height { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int Age { // Auto-calculated property
			get {
				int age = DateTime.Now.Year - this.DateOfBirth.Year;

				if (DateTime.Now.DayOfYear < this.DateOfBirth.DayOfYear) {
					age--;
				}

				return age;
			}
		}

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
