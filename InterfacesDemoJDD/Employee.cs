// Name: Jamie Dowden-Duarte
// Email: jdowdenduarte@cnm.edu
// File: Employee.cs
// Date: February 3, 2026

using System.Collections.Generic;

namespace HRManager
{
	public abstract class Employee : IPhoneBookItem
	{
		private static int LastEmpNum = 0;
		private List<double> hours = new List<double>();

		public int EmpNum { get; private set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }

		public List<double> Hours
		{
			get { return hours; }
			set { hours = value; }
		}

		public abstract string PaySummary { get; }

		public Employee()
		{
			EmpNum = LastEmpNum++;
			FirstName = "";
			LastName = "";
			Phone = "";
			Email = "";
		}

		public Employee(string firstName, string lastName) : this()
		{
			FirstName = firstName;
			LastName = lastName;
		}

		public abstract decimal Pay(int start, int end);

		public string GetContactSummary()
		{
			return FirstName + " " + LastName + "\n" +
				   "Phone: " + Phone + "\n" +
				   "Email: " + Email;
		}

		public override string ToString()
		{
			return EmpNum + " " + FirstName + " " + LastName;
		}
	}
}