// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: Department.cs
// Date: February 3, 2026

namespace HRManager
{
	/// <summary>
	/// Department class - represents a company department
	/// Implements IPhoneBookItem interface
	/// </summary>
	class Department : IPhoneBookItem
	{
		public string Name { get; set; }
		public Employee Manager { get; set; }
		public string Description { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string WebSite { get; set; }

		/// <summary>
		/// Constructor with optional parameters (default values)
		/// </summary>
		public Department(string name, Employee manager = null, string description = "TBD",
						 string phone = "TBD", string email = "TBD", string website = "TBD")
		{
			Name = name;
			Manager = manager;
			Description = description;
			Phone = phone;
			Email = email;
			WebSite = website;
		}

		/// <summary>
		/// Implement IPhoneBookItem interface
		/// Returns formatted department contact information
		/// </summary>
		public string GetContactSummary()
		{
			return "Department: " + Name + "\n" +
				   Description + "\n" +
				   "Phone: " + Phone + "\n" +
				   "Email: " + Email + "\n" +
				   "Web site: " + WebSite;
		}
	}
}
