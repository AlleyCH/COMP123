using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example13.Models {
	public class RealEstateAgent : SalesPerson<House> { // <-- Specialized class. T = House.
		public override void Sell(House item) {
			Console.WriteLine("House is sold!"); // <-- No no no.
		}
	}
}
