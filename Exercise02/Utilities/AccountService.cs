using Exercise02.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise02.Utilities {
	public static class AccountService {
		private static string root = "C:\\test\\";

		static AccountService() {
			if (!Directory.Exists(root))
				Directory.CreateDirectory(root);
		}

		// CRUD Operations.

		public static void Create(Account account) {
			XmlSerializer serializer = new XmlSerializer(typeof(Account));

			using (Stream stream = new FileStream($"{root}{account.AccountID}.xml", FileMode.Create)) {
				serializer.Serialize(stream, account);
			}
		}

		public static Account Get(string accountID) {
			string filename = $"{root}{accountID}.xml";
			XmlSerializer serializer = new XmlSerializer(typeof(Account));

			if (File.Exists(filename)) {
				using (Stream stream = new FileStream(filename, FileMode.Open)) {
					Account account = (Account)serializer.Deserialize(stream);

					return account;
				}
			}
			else {
				throw new Exception($"ERROR: Tried to load an account that does not exist ({accountID}).");
			}
		}

		public static List<Account> GetAll() {
			XmlSerializer serializer = new XmlSerializer(typeof(Account));
			string[] files = Directory.GetFiles(root);
			List<Account> accounts = new List<Account>();

			foreach (string file in files) {
				using (Stream stream = new FileStream(file, FileMode.Open)) {
					Account account = (Account)serializer.Deserialize(stream);

					accounts.Add(account);
				}
			}

			return accounts;
		}

		public static void Update(Account account) {
			Delete(account.AccountID);
			Create(account);
		}

		public static void Delete(string accountID) {
			string filename = $"{root}{accountID}.xml";

			if (File.Exists(filename))
				File.Delete(filename);
			else
				throw new Exception($"ERROR: Tried to delete an account that does not exist ({accountID}).");
		}
	}
}
