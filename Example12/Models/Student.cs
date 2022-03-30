using Example12.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example12.Models {
	public class Student : Person, IStudyingPerson {
		public StudentType Type { get; set; }

		public void Study() {
			System.Console.WriteLine("Study study study..."); // <-- No no no.
		}

		public override void Greet(string name) {
			string greeting = this.CreateGreeting(name);

			System.Console.WriteLine(greeting); // <-- No no no.
		}

		public enum StudentType {
			Domestic,
			International
		}
	}
}
