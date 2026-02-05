// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: HourlyEmployee.cs
// Date: February 3, 2026

namespace HRManager
{
	/// <summary>
	/// HourlyEmployee class - inherits from Employee
	/// </summary>
	public class HourlyEmployee : Employee  // Inheritance syntax
	{
		// Additional property specific to hourly employees
		public decimal HourlyRate { get; set; }

		// Constructor - chains to base class constructor
		public HourlyEmployee() : base()
		{
			HourlyRate = 15.0M;
		}

		// Override the virtual property from base class
		public override string PaySummary
		{
			get { return "This employee is paid " + HourlyRate.ToString("C") + " per hour"; }
		}

		// Override ToString() for custom display
		public override string ToString()
		{
			return base.ToString() + " Hourly Employee";
		}
	}
}