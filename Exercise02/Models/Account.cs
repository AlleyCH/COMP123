using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02.Models {
	public class Account {
		public string AccountID { get; set; }
		public string AccountNumber { get; set; }
		public Customer Customer { get; set; }
		public AccountType Type { get; set; }
		public List<Transaction> Transactions { get; set; }
		public double Balance {
			get {
				double total = 0;

				foreach (Transaction transaction in this.Transactions) {
					if (transaction.Type == Transaction.TransactionType.Credit)
						total += transaction.Value;
					else
						total -= transaction.Value;
				}

				return total;
			}
		}

		public Account() {
			this.AccountID = Guid.NewGuid().ToString();
			this.Transactions = new List<Transaction>();
		}

		public enum AccountType {
			Checking,
			Savings,
			Investment
		}
	}
}
