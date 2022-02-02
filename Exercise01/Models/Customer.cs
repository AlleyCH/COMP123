using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models {
	public class Customer {
		public string CustomerID { get; private set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Phone { get; set; }
		public List<Address> Addresses { get; set; }

		public Customer() {
			this.CustomerID = Guid.NewGuid().ToString();
			this.Addresses = new List<Address>();
		}

		public static Customer CreateCustomer(string firstName, string lastName, DateTime dob) {
			Customer customer = new Customer() { 
				FirstName = firstName,
				LastName = lastName,
				DateOfBirth = dob
			};

			return customer;
		}

		public void RegisterAddress(Address address) {
			this.Addresses.Add(address);
		}
	}
}
