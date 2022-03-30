using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example12.Models {
	public class Person {
		public string PersonID { get; private set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }

		public Person() {
			this.PersonID = Guid.NewGuid().ToString();
		}

		public override string ToString() {
			return $"Person ID: {this.PersonID} \n" +
				   $"Name: {this.FirstName} {this.LastName} \n" +
				   $"Date of Birth: {this.DateOfBirth:d} ";
		}

		public void Speak() {
			Console.WriteLine("Bla bla bla..."); // <- No no no.
		}

		public virtual void Greet(string name) { // <-- The "virtual" keyword makes this method overridable.
			string greeting = this.CreateGreeting(name);

			Console.WriteLine(greeting); // <-- No no no.
		}

		protected string CreateGreeting(string name) {
			return $"Hello, {name}";
		}
	}
}
