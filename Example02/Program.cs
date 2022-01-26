using Example02.Models;
using System;

namespace Example02 {
	class Program {
		static void Main(string[] args) {
			Product product = new Product();
			product.Price = -50; // <-- -50 does not go through, as it does not pass validation.
			product.Price = 50; // <-- 50 goes through, as it does pass validation.

			Console.WriteLine(product.Price);
		}
	}
}
