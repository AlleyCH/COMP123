using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models {
	public class Customer {
		public string CustomerID { get; private set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime DateOfBirth { get; set; }
		public List<Address> Addresses { get; set; }

		public Customer() {
			this.CustomerID = Guid.NewGuid().ToString();
			this.Addresses = new List<Address>();
		}

		public static Customer CreateCustomer(string name, DateTime dateOfBirth) {
			Customer customer = new Customer() { 
				Name = name,
				DateOfBirth = dateOfBirth
			};

			return customer;
		}

		public void RegisterAddress(Address address) {
			this.Addresses.Add(address);
		}
	}
}
