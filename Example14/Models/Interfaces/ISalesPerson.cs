using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example14.Models.Interfaces {
	public interface ISalesPerson<T> { // <-- Generalized interface.
		public void Sell(T item);
	}
}
