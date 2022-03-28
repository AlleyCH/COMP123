using Example12.Models.Interfaces;
using System;

namespace Example12.Models {
	public class Student : Person, IStudyingPerson, IWorkingPerson {
		public StudentType Type { get; set; }

		public override void Greet(string name) {
			string greeting = this.CreateGreeting(name);

			System.Console.WriteLine(greeting); // <-- No no no.
		}

		public void Study() {
			Console.WriteLine("Studying..."); // <-- No no no.
		}

		public void Work() {
			Console.WriteLine("Work work work..."); // No no no.
		}

		public enum StudentType {
			Domestic,
			International
		}
	}
}
