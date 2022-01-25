using Example02.Models;
using System;

namespace Example02 {
	class Program {
		static void Main(string[] args) {
			Product product = new Product();
			product.Price = -100;

			Console.WriteLine(product.Price);
		}
	}
}
