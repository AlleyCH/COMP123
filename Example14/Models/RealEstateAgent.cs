using Example14.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example14.Models {
	public class RealEstateAgent : ISalesPerson<House> { // <-- Specialized class. T = House.
		public void Sell(House item) {
			Console.WriteLine("House is sold!"); // <-- No no no.
		}
	}
}
