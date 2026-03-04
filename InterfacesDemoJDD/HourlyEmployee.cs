// Name: Jamie Dowden-Duarte
// Email: jdowdenduarte@cnm.edu
// File: HourlyEmployee.cs
// Date: February 3, 2026

namespace HRManager
{
	public sealed class HourlyEmployee : Employee
	{
		public decimal HourlyRate { get; set; }

		public HourlyEmployee() : this("", "", 15.0M)
		{
		}

		public HourlyEmployee(string firstName, string lastName, decimal hourlyRate)
			: base(firstName, lastName)
		{
			HourlyRate = hourlyRate;
		}

		public override string PaySummary
		{
			get
			{
				return "This employee is paid " + HourlyRate.ToString("C") + " per hour.";
			}
		}

		public override decimal Pay(int start, int end)
		{
			double hours = 0;
			for (int day = start; day < end; ++day)
			{
				hours += Hours[day];
			}
			return (decimal)hours * HourlyRate;
		}

		public override string ToString()
		{
			return base.ToString() + " Hourly Employee";
		}
	}
}