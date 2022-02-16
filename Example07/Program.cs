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
			list.Add("World!");

			// ARRAY LISTS
			// Array lists are dynamic in size.
			// Array lists are dynamic in type (array list elements can be of different types).
			// An array list's size changes throughout the array list's lifecycle.
			ArrayList arrayList = new ArrayList();
			arrayList.Add("Hello");
			arrayList.Add(1);

			// STACKS
			// Stacks are dynamic in size.
			// Stacks are dynamic in type (stack elements can be of different types).
			// A stack's size changes throughout the stack's lifecycle.
			// FILO: First in, last out.
			Stack stack = new Stack();
			stack.Push("I can add a string"); // First
			stack.Push(1); // Second
			stack.Push(true); // Third

			var last = stack.Pop();

			// QUEUES
			// Queues are dynamic in size.
			// Queues can be dynamic in type (queue elements can be of different types);
			// A queue's size changes throughout the queue's lifecycle.
			// FIFO: First in, first out.
			Queue queue = new Queue(); // Dynamic in type
			Queue<string> queue2 = new Queue<string>(); // Static in type

			queue.Enqueue("I can add a string");
			queue.Enqueue(1);
			queue.Enqueue(false);

			// LINKED LISTS
			// Linked lists are dynamic in size.
			// Linked lists are static in type (linked list elements must be of the same type).
			// A linked list's size changes throughout the linked list's lifecycle.
			LinkedList<string> linkedList = new LinkedList<string>();
			linkedList.AddFirst("First");
			linkedList.AddLast("Last");

			var firstOnTheList = linkedList.First;
			var next = firstOnTheList.Next;

			// DICTIONARIES
			// Dictionaries are dynamic in size.
			// Dictionaries are static in type (dictionary elements must be of the same type).
			// A dictionary's size changes throughout the disctionary's lifecycle.
			// Dictionaries have a key, whichis associated with a value.
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("123", "John");
			dictionary.Add("321", "Mary");

			var person = dictionary["123"];

			// HASHTABLES
			// Hashtables are dynamic in size.
			// Hashtables are dynamic in type (hashtable elements can be of different types).
			// A hashtable's size changes throughout the hashtable's lifecycle.
			// Hashtables have a key, which is associated with a value.
			Hashtable hashtable = new Hashtable();
			hashtable.Add("123", "John");
			hashtable.Add(1, true);

			var item = hashtable[1];
		}
	}
}
