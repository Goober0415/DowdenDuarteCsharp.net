// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: IPhoneBookItem.cs
// Date: February 3, 2026

namespace HRManager
{
	/// <summary>
	/// Interface for items that can be added to a phone book
	/// Any class implementing this interface must provide GetContactSummary() method
	/// </summary>
	interface IPhoneBookItem
	{
		/// <summary>
		/// Returns formatted contact information as a string
		/// </summary>
		string GetContactSummary();
	}
}