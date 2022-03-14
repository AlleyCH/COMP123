using System;

namespace Example10.Models {
	public class Employee : Person {
		// Employee-specific properties go here.
		public double HourlyRate { get; set; }
		public EmploymentType Type { get; set; }

		// Employee-specific methods go here.
		public void Work() {
			Console.WriteLine("Work work work..."); // <-- No no no.
		}

		public enum EmploymentType {
			Fulltime,
			Parttime,
			Contractor
		}
	}
}
