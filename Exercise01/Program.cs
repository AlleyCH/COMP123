using Exercise01.Models;
using System;

namespace Exercise01 {
	class Program {
		/*

		In this exercise, we are implementing a simple problem domain for an e-commerce app.

		1. Create a Customer class. Feel free to define the appropriate properties as you see fit.
		2. Create an Address class. Feel free to define the appropriate properties as you see fit.
		3. In your Customer class, implement a new static method, CreateCustomer. 
		   This method takes in a string parameter, name, as well as a DateTime parameter, dateOfBirth.
		   When this method is called, a new Customer object should be created and returned, with its
		   properties properly initialized.
		4. In your Customer class, implement a new non-static method, RegisterAddress.
		   This method takes in an Address type parameter, address, and passes it to the appropriate Customer property.
		   Nothing is to be returned when this method is invoked.
		5. How does your code change if now customers can have multiple addresses?

		*/

		static void Main(string[] args) {
			Customer customer = Customer.CreateCustomer("Diana Prince", new DateTime(1985, 7, 15));

			Address address = new Address() {
				AddressLine1 = "123 Test Street",
				AddressLine2 = "Apartment 5",
				City = "Toronto",
				Province = "ON",
				PostalCode = "A1B 2C3",
				Country = "Canada",
				AddressType = AddressType.Residential
			};

			customer.RegisterAddress(address);

			Console.WriteLine(customer.Name);
			Console.WriteLine(customer.Addresses[0].AddressLine1);
		}
	}
}
