using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example09.Models {
	public class Product {
		public string ProductID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }

		public Product() {
			this.ProductID = Guid.NewGuid().ToString();
		}

		public override string ToString() {
			return $"ProductID: {this.ProductID} \n" +
				   $"Name: {this.Name} \n" +
				   $"Description: {this.Description} \n" +
				   $"Price: {this.Price:C} \n";
		}
	}
}
