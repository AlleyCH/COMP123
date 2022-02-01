using System;

namespace Example03.Models {
	public class Student {
		public string StudentID { get; private set; } // This has to be unique, and cannot be changed outside of this class.
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		// ...

		public Student() {
			this.StudentID = Guid.NewGuid().ToString(); // Produces a string that is guaranteed to be unique.
		}

		public void Study() {
			Console.WriteLine("I'm studying...");
		}
	}
}
