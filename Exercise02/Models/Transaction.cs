using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02.Models {
	public class Transaction {
		private double value;

		public string TransactionID { get; set; }
		public double Value { 
			get {
				return this.value;
			}
			set {
				if (value >= 0)
					this.value = value;
				else
					throw new Exception("ERROR: Transaction value cannot be negative!");
			}
		}
		public DateTime ProcessedOn { get; set; }
		public TransactionType Type { get; set; }

		public Transaction() {
			this.TransactionID = Guid.NewGuid().ToString();
			this.ProcessedOn = DateTime.Now;
		}

		public enum TransactionType {
			Debit,
			Credit
		}
	}
}
