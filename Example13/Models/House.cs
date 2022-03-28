using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example13.Models {
	public class House {
		public string PropertyID { get; set; }
		public string AddressLine1 { get; set; }
		public string AddressLine2 { get; set; }
		public string AddressLine3 { get; set; }
		public string City { get; set; }
		public string PostalCode { get; set; }
		public string Province { get; set; }
		public string Country { get; set; }
		public double SquareFootage { get; set; }

		public House() {
			this.PropertyID = Guid.NewGuid().ToString();
		}
	}
}
