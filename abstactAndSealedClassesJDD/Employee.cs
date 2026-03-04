// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: Employee.cs
// Date: February 3, 2026

using System.Collections.Generic;

namespace abstractAndSealedClassesJDD
{
	/// <summary>
	/// Abstract base Employee class
	/// Cannot be instantiated - must be inherited
	/// </summary>
	public abstract class Employee
	{
		// Static field to auto-increment employee numbers
		private static int LastEmpNum = 0;

		// Private backing field for hours list
		private List<double> hours = new List<double>();

		// Properties
		public int EmpNum { get; private set; }  // Read-only
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public List<double> Hours
		{
			get { return hours; }
			set { hours = value; }
		}

		// Abstract property - must be implemented by derived classes
		public abstract string PaySummary { get; }

		// Parameterless constructor - auto-assigns employee number
		public Employee()
		{
			EmpNum = LastEmpNum++;
			FirstName = "";
			LastName = "";
		}

		// Two-parameter constructor - chains to parameterless constructor
		public Employee(string firstName, string lastName) : this()
		{
			FirstName = firstName;
			LastName = lastName;
		}

		// Abstract method - must be implemented by derived classes
		public abstract decimal Pay(int start, int end);

		// Override ToString from Object class
		public override string ToString()
		{
			return EmpNum + " " + FirstName + " " + LastName;
		}
	}
}