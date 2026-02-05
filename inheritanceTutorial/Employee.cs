// Name: [Jamie Dowden-Duarte]
// Email: [jdowden-duarte@cnm.edu]
// File: Employee.cs
// Date: February 3, 2026

namespace HRManager
{
	/// <summary>
	/// Base Employee class
	/// </summary>
	public class Employee
	{
		// Auto-implemented properties
		public int EmpNum { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		// Virtual property - can be overridden by derived classes
		public virtual string PaySummary
		{
			get { return "No pay for base class employee."; }
		}

		// Default constructor
		public Employee()
		{
			EmpNum = 0;
			FirstName = "";
			LastName = "";
		}
	}
}