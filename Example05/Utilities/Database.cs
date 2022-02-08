using System;

namespace Example05.Utilities {
	public static class Database {
		// A class that encapsulates database functionality.
		// I.e. CRUD operations
		// Static classes can only have static methods.

		// FIELDS
		private static readonly string connectionString = "Some connection string";

		// PROPERTIES
		public static string Constant { 
			get {
				return "VALUE";
			}
		}

		// CONSTRUCTORS
		static Database() { 
			// Static constructor.
			// Static initialization logic.
		}

		// METHODS
		public static void Create(object entry) {
			// Fancy database logic goes here.
			Console.WriteLine("Entry inserted into database!");
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
