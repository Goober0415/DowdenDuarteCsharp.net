// Name: Jamie Dowden-Duarte
// Email: jdowdenduarte@cnm.edu
// File: SalaryEmployee.cs
// Date: February 3, 2026

namespace HRManager
{
	class SalaryEmployee : Employee
	{
		public decimal Salary { get; set; }

		public SalaryEmployee() : this("", "", 30000.0M)
		{
		}

		public SalaryEmployee(string firstName, string lastName, decimal salary)
			: base(firstName, lastName)
		{
			Salary = salary;
		}

		public override string PaySummary
		{
			get
			{
				return "This employee is paid " + Salary.ToString("C") + " per year";
			}
		}

		public override decimal Pay(int start, int end)
		{
			const int PAYPERIODSPERYEAR = 24;
			decimal pay = Salary * (end - start) / PAYPERIODSPERYEAR;
			return pay;
		}

		public override string ToString()
		{
			return base.ToString() + " Salary Employee";
		}
	}
}