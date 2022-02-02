using Exercise01.Models;
using System;

namespace Exercise01 {
	class Program {
		/*

		1. Create a Customer class. Feel free to define the appropriate properties as you see fit.
		2. Create an Address class. Feel free to define the appropriate properties as you see fit.
		3. In your Customer class, implement a new static method, CreateCustomer. 
		   This method takes in string parameters for first name and last name, as well as a DateTime parameter for date of birth.
		   When this method is called, a new Customer object should be created and returned, with its
		   properties properly initialized.
		4. In your Customer class, implement a new non-static method, RegisterAddress.
		   This method takes in an Address type parameter, address, and passes it to the appropriate Customer property.
		   Nothing is to be returned when this method is invoked.
		5. How does your code change if now customers can have multiple addresses?

		*/
		static void Main(string[] args) {
			Customer customer = Customer.CreateCustomer("Diana", "Prince", new DateTime(1985, 7, 15));

			Address address = new Address() { 
				AddressLine1 = "123 Test Avenue",
				AddressLine2 = "Suite 5",
				City = "Toronto",
				Province = "ON",
				PostalCode = "A1B 2C3",
				Country = "Canada",
				AddressType = AddressType.Residential
			};

			customer.RegisterAddress(address);

			Console.WriteLine(customer.CustomerID);
			Console.WriteLine($"{customer.FirstName} {customer.LastName}");
			Console.WriteLine(customer.Addresses[0].AddressLine1);
		}
	}
}
