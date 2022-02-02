using Example03.Models;
using System;

namespace Example03 {
	class Program {
		static void Main(string[] args) {
			Student student = new Student();
			student.FirstName = "Clark";
			student.LastName = "Kent";
			student.DateOfBirth = new DateTime(1985, 7, 15);

			Console.WriteLine(student.StudentID);
			student.Study();
		}
	}
}
