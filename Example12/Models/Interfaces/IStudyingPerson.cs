using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example12.Models.Interfaces {
	public interface IStudyingPerson {
		// Interfaces are "contracts".
		// Interfaces define functionality that implementing classes MUST implement.
		// Usually, method implementations are not included in interfaces - just definitions.
		// However, in newer C# versions, method implementation in interfaces is allowed.
		
		// The differences between classes and interfaces are:
		// - Classes: Implement functionality.
		// - Interfaces: Define functionality.
		// - Sub-types can extend one, and only one, super-class.
		//	 However, they can implement multiple interfaces.
		// - Interfaces cannot be instantiated.

		// The advantage of using interfaces is that it allows
		// abstractions models to be more flexible.
		// Functionality can be trated as "plug-in" items.

		public void Study(); // <-- This is a method DECLARATION. It does not include a body.
	}
}
