namespace Example10.Models {
	public class Student : Person { // <-- Defining Person as a super-class
		// Public members defined in the super-class are inherited.
		// The sub-class "inherits" all public members.
		// The sub-class "inherits" all protected members.
		// The sub-class DOES NOT "inherit" private members.

		// Student-specific properties go here.
		public StudentType Type { get; set; }

		// Student-specific methods go here.
		public void Study() {
			System.Console.WriteLine("Study study study..."); // <-- No no no.
		}

		public override void Greet(string name) {
			// Through inheritance, Student already has an implicit Greet definition.
			// However, I can override the inherited definition by using the "override" keyword.
			// Sub-classes can have completely different implementations for inherited methods.
			// As this is just an example, we will keep the implementation the same.

			string greeting = this.CreateGreeting(name);

			System.Console.WriteLine(greeting); // <-- No no no.
		}

		public enum StudentType {
			Domestic,
			International
		}
	}
}
