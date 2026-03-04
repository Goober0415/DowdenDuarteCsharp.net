// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: PhoneBook.cs
// Date: February 3, 2026

using System.Collections.Generic;

namespace HRManager
{
	/// <summary>
	/// PhoneBook class - stores any items that implement IPhoneBookItem
	/// Demonstrates Dependency Inversion Principle
	/// </summary>
	class PhoneBook
	{
		// List of phone book entries - can be ANY type that implements IPhoneBookItem
		public List<IPhoneBookItem> PhoneBookEntries { get; set; }

		/// <summary>
		/// Constructor - initializes empty phone book
		/// </summary>
		public PhoneBook()
		{
			PhoneBookEntries = new List<IPhoneBookItem>();
		}

		/// <summary>
		/// Returns the entire phone book as a formatted string
		/// Calls GetContactSummary() on each entry (polymorphism via interface)
		/// </summary>
		public string GetPhoneBook()
		{
			string phonebook = "";

			foreach (var item in PhoneBookEntries)
			{
				// Each item implements IPhoneBookItem, so we know it has GetContactSummary()
				phonebook += item.GetContactSummary() + "\n\n";
			}

			return phonebook;
		}
	}
}
