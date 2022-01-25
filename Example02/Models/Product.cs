using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02.Models {
	public class Product {
		private double price;

		public string ProductID { get; set; }
		public string Name { get; set; }
		public string Brand { get; set; }
		public double Price { 
			get {
				return this.price;
			}
			set {
				if (value >= 0) {
					this.price = value;
				}
				else {
					// Ignore.
				}
			}
		}
	}
}
