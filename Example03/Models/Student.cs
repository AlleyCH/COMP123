using System;

namespace Example03.Models {
	public class Student {
		// FIELDS
		private double gpa; // <-- GPA is stored here.

		// PROPERTIES
		public string StudentID { get; private set; } // This has to be unique and cannot be changed outside of this class.
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public double GPA { // Cannot be negative -> Fully-implemented property needed for validation.
			get {
				return this.gpa;
			}
			set {
				// GPA cannot be negative.
				if (value < 0) {
					// Throw error.
				}
				else {
					// Valid value.
					this.gpa = value;
				}
			}
		}

		// CONSTRUCTORS
		public Student() {
			// Initialization logic goes here.
			this.StudentID = Guid.NewGuid().ToString(); // produces a string that is guaranteed to be unique.
		}

		// METHODS
		public void Study() {
			// Method logic goes here.
			Console.WriteLine("I am studying..."); // No no no
		}
	}
}
