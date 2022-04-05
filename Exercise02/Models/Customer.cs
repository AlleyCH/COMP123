using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02.Models {
	public class Customer {
		public string CustomerID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public Address Address { get; set; }

		public Customer() {
			this.CustomerID = Guid.NewGuid().ToString();
		}
	}
}
