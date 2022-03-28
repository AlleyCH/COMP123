using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example13.Models {
	// Abstract classes cannot be instantiated.
	public abstract class SalesPerson<T> { // <-- Generalized class. T is a generic type.
		public string SalesPersonID { get; set; }
		public string Name { get; set; }
		public DateTime DateOfBirth { get; set; }

		public SalesPerson() {
			this.SalesPersonID = Guid.NewGuid().ToString();
		}

		// Abstract methods are not implemented in the class 
		// they are defined.
		// It's the sub-type's responsibility to implement this method.
		public abstract void Sell(T item);
	}
}
