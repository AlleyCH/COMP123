using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02.Models {
	public class Address {
		public string AddressID { get; set; }
		public string AddressLine1 { get; set; }
		public string AddressLine2 { get; set; }
		public string City { get; set; }
		public string Province { get; set; }
		public string PostalCode { get; set; }

		public Address() {
			this.AddressID = Guid.NewGuid().ToString();
		}
	}
}
