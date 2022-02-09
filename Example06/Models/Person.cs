using System;

namespace Example06.Models {
	public class Person {
		public string Name { get; set; } 
		public double Height { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int Age { 
			get {
				int age = DateTime.Now.Year - this.DateOfBirth.Year;

				if (DateTime.Now.DayOfYear < this.DateOfBirth.DayOfYear) {
					age--;
				}

				return age;
			}
		}

		// Methods
		public override string ToString() {
			return $"Name: {this.Name} \n" +
				   $"Date Of Birth: {this.DateOfBirth:d} \n" +
				   $"Age: {this.Age}";
		}
	}
}
