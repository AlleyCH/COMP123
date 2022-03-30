using Example12.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example12.Models {
	public class WorkingStudent : Student, IWorkingPerson {
		public void Work() {
			Console.WriteLine("Work work work..."); // <-- No no no.
		}
	}
}
