using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02.Models {
	public class Product {
		// FIELDS
		private double price; // <-- Price value is stored here.

		// PROPERTIES
		public string ProductID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { // Fully-implemented property. Needs a field to assist with calculation.
			get {
				return this.price;
			}
			set {
				if (value >= 0) { // If passes validation...
					this.price = value; // Value is stored in private field
				}
				else {
					// Ignore.
				}
			}
		}
	}
}
