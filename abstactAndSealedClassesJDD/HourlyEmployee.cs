// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: HourlyEmployee.cs
// Date: February 3, 2026

using abstractAndSealedClassesJDD;

namespace abstractAndSealedClassesJDD
{
	/// <summary>
	/// HourlyEmployee class - SEALED (cannot be inherited from)
	/// Inherits from abstract Employee class
	/// </summary>
	public sealed class HourlyEmployee : Employee
	{
		// Additional property specific to hourly employees
		public decimal HourlyRate { get; set; }

		// Parameterless constructor - chains to three-parameter constructor
		public HourlyEmployee() : this("", "", 15.0M)
		{
		}

		// Three-parameter constructor - chains to base class constructor
		public HourlyEmployee(string firstName, string lastName, decimal hourlyRate)
			: base(firstName, lastName)
		{
			HourlyRate = hourlyRate;
		}

		// Override abstract PaySummary property
		public override string PaySummary
		{
			get
			{
				return "This employee is paid " + HourlyRate.ToString("C") + " per hour.";
			}
		}

		// Override abstract Pay method
		// Calculates pay based on hours worked × hourly rate
		public override decimal Pay(int start, int end)
		{
			double hours = 0;

			for (int day = start; day < end; ++day)
			{
				hours += Hours[day];
			}

			return (decimal)hours * HourlyRate;
		}

		// Override ToString
		public override string ToString()
		{
			return base.ToString() + " Hourly Employee";
		}
	}
}