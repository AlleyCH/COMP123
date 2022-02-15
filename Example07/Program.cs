using System;
using System.Collections;
using System.Collections.Generic;

namespace Example07 {
	class Program {
		static void Main(string[] args) {
			// ARRAYS
			// Arrays are static in size.
			// Arrays are static in type (all array elements must be of the same type).
			// Array size must be known upon declaration time.
			string[] array = { "Hello", "World!" };

			// LISTS
			// Lists are dynamic in size.
			// Lists are static in type (all list elements must be of the same type).
			// A list's size changes throughout the list's lifecycle.
			List<string> list = new List<string>();
			list.Add("Hello");
			list.Add("World");

			// ARRAY LISTS
			// Array Lists are dynamic in size.
			// Array Lists are dynamic in type (array list elements can be of different types).
			// An array list's size changes throughout the array list's lifecycle.
			ArrayList arrayList = new ArrayList();
			arrayList.Add("I can add a string");
			arrayList.Add(1);

			// STACKS
			// Stacks are dynamic in size.
			// Stacks are dynamic in type (all stack elements can be of different types).
			// A stack's size changes throughout the stacks's lifecycle.
			// FILO: First in, last out.
			Stack stack = new Stack();
			stack.Push("I can add a string"); // First item on the stack
			stack.Push(1); // Second item on the stack
			stack.Push(true); // Third item on the stack

			var last = stack.Pop(); // Last added item (third) "pops" out of the stack and is returned.

			// QUEUE
			// Queues are dynamic in size.
			// Queues can be dynamic in type (all queue elements can be of different types).
			// A queue's size changes throughout the queue's lifecycle.
			// FIFO: First in, first out.
			Queue queue = new Queue(); // Dynamic in type
			Queue<string> queue2 = new Queue<string>(); // Static in type

			queue.Enqueue("I can add a string"); // First item in the queue
			queue.Enqueue(1); // Second item in the queue
			queue.Enqueue(false); // Third item in the queue

			var first = queue.Dequeue(); // First item in the queue is removed and returned.

			// DICTIONARY
			// Dictionaries are dynamic in size.
			// Dictionaries are static in type (all dictionary elements must be of the same type).
			// A dictionary's size changes throughout the dictionary's lifecycle.
			// Dictionaries have a key, which is associated with a value.
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("1", "John"); // John's ID is 1.
			dictionary.Add("2", "Mary"); // Mary's ID is 2.
			dictionary.Add("3", "Peter"); // Peter's ID is 3.

			string person = dictionary["1"]; // ID

			// HASHTABLE
			// Hashtables are dynamic in size.
			// Hashtables are dynamic in type (all hashtable elements can be of different types).
			// A hashtable's size changes throughout the hashtables's lifecycle.
			// Hashtables have a key, which is associated with a value.
			Hashtable hashtable = new Hashtable();
			hashtable.Add("1", "John");
			hashtable.Add(2, true);

			var item = hashtable[2];
		}
	}
}
