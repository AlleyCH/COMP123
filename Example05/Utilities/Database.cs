using System;

namespace Example05.Utilities {
	public static class Database {
		// A class that encapsulates database functionality.
		// I.e. CRUD operations
		// Can only contain static methods.

		// FIELDS
		private static readonly string connectionString = "Connection";

		// PROPERTIES
		public static int Constant { 
			get {
				return 5;
			}
		}

		// CONSTRUCTOR
		static Database() { 
			// Static constructor.
			// Static Initialization logic.
			// Read connection string from config file.
		}

		// METHODS
		public static void Create(object entry) {
			// Fancy database logic goes here.
			Console.WriteLine("Entry inserted successfully!");
		}

		public static object Get(string id) {
			// Fancy database logic goes here.
			return null;
		}

		public static void Update(object entry) {
			// Fancy database logic goes here.
			Console.WriteLine("Entry updated!");
		}

		public static void Delete(string id) {
			// Fancy database logic goes here.
			Console.WriteLine("Entry deleted!");
		}
	}
}
