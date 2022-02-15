using Example09.Models;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Example09 {
	class Program {
		static void Main(string[] args) {
			// SERIALIZATION
			// A technique that can be used to convert virtual objects to files that a computer can easily process (read or write).

			// Creating an object to be serialized.
			Product product = new Product() { 
				Name = "Guitar",
				Description = "A very cool guitar.",
				Price = 14999.00
			};

			// Serializing:

			// In this example we will serialize objects as XML.
			// In order to serialize objects, I need a serializer.
			XmlSerializer serializer = new XmlSerializer(typeof(Product));

			// Streams are required to serialize.
			using (Stream stream = new FileStream($"C:\\temp\\{product.ProductID}.xml", FileMode.Create)) {
				serializer.Serialize(stream, product);
			}

			Console.WriteLine($"Object {product.ProductID} serialized successfully! \n");

			// =======================================================

			// Deserializing:

			// A serializer is also needed to read XML files from the file system.
			// We are also going to need a stream to read the file.

			string[] files = Directory.GetFiles("C:\\temp");

			foreach (string file in files) {
				using (Stream stream = new FileStream(file, FileMode.Open)) {
					Product loadedProduct = (Product)serializer.Deserialize(stream);
					Console.WriteLine("Object deserialized successfully!");

					Console.WriteLine(loadedProduct.ToString());
				}
			}
		}
	}
}
