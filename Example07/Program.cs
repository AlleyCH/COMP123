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

			// Retrieving an item from the list:
			var listItem = list[0]; // 0 is the index of the item to be retrieved.

			// ARRAY LISTS
			// Array lists are dynamic in size.
			// Array lists are dynamic in type (array list elements can be of different types).
			// An array list's size changes throughout the array list's lifecycle.
			ArrayList arrayList = new ArrayList();
			arrayList.Add("Hello");
			arrayList.Add(1);

			// Retrieving an item from the array list:
			var arrayListItem = arrayList[0]; // 0 is the index of the item to be retrieved.

			// STACKS
			// Stacks are dynamic in size.
			// Stacks can be dynamic in type (stack elements can be of different types).
			// A stack's size changes throughout the stack's lifecycle.
			// FILO: First in, last out.
			Stack stack = new Stack(); // Dynamic in type.
			Stack<int> stack2 = new Stack<int>(); // Static in type.
			stack.Push("I can add a string"); // First
			stack.Push(1); // Second
			stack.Push(true); // Third

			// Retrieving the last item from the stack:
			var last = stack.Pop();

			// QUEUES
			// Queues are dynamic in size.
			// Queues can be dynamic in type (queue elements can be of different types).
			// A queue's size changes throughout the queue's lifecycle.
			// FIFO: First in, first out.
			Queue queue = new Queue(); // Dynamic in type.
			Queue<string> queue2 = new Queue<string>(); // Static in type.

			queue.Enqueue("I can add a string");
			queue.Enqueue(1);
			queue.Enqueue(false);

			// Retrieving the first item on the queue:
			var first = queue.Dequeue();

			// LINKED LISTS
			// Linked lists are dynamic in size.
			// Linked lists are static in type (linked list elements must be of the same type).
			// A linked list's size changes throughout the linked list's lifecycle.
			// A linked-list is a sequence of data structures which are connected together via links.
			// Linked List is a sequence of links which contains items.Each link contains a connection to another link.
			LinkedList<string> linkedList = new LinkedList<string>();
			linkedList.AddFirst("First");
			linkedList.AddLast("Last");

			// Retrieving the first item on the linked list:
			var firstOnTheList = linkedList.First;
			var next = firstOnTheList.Next; // Each item has a reference to the next position.

			// DICTIONARIES
			// Dictionaries are dynamic in size.
			// Dictionaries are static in type (dictionary elements must be of the same type).
			// A dictionary's size changes throughout the disctionary's lifecycle.
			// Dictionaries have keys, each of which is associated with a value.
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("123", "John");
			dictionary.Add("321", "Mary");

			// Retrieving an item from the dictionary:
			var person = dictionary["123"]; // "123" is the key of the item to be retrieved.

			// HASHTABLES
			// Hashtables are dynamic in size.
			// Hashtables are dynamic in type (hashtable elements can be of different types).
			// A hashtable's size changes throughout the hashtable's lifecycle.
			// Hashtables have keys, each of which is associated with a value.
			Hashtable hashtable = new Hashtable();
			hashtable.Add("123", "John");
			hashtable.Add(1, true);

			// Retrieving an item from the hashtable:
			var item = hashtable["123"]; // "123" is the key of the item to be retrieved.
		}
	}
}
