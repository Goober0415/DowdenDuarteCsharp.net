
// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: Program.cs
// Date: February 3, 2026

using System;
using System.Collections.Generic;

namespace HRManager
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("==========================================");
			Console.WriteLine("HR Manager - Interfaces Demo");
			Console.WriteLine("==========================================\n");

			// Create HourlyEmployee
			HourlyEmployee hourEmp = new HourlyEmployee("Bill", "Gates", 15.0M);
			hourEmp.Phone = "(206) 555-1234";
			hourEmp.Email = "bill@microsoft.com";
			hourEmp.Hours.Add(80.0);
			hourEmp.Hours.Add(90.0);
			hourEmp.Hours.Add(70.0);

			// Create SalaryEmployee
			SalaryEmployee salaryEmp = new SalaryEmployee("Alan", "Turing", 40000.0M);
			salaryEmp.Phone = "(555) 123-4567";
			salaryEmp.Email = "alan@computing.com";
			salaryEmp.Hours.Add(80.0);
			salaryEmp.Hours.Add(80.0);
			salaryEmp.Hours.Add(80.0);

			// Create Department
			Department dep = new Department("Sales Department");

			// Create PhoneBook and add entries
			// Note: PhoneBook accepts ANY object that implements IPhoneBookItem
			PhoneBook pb = new PhoneBook();
			pb.PhoneBookEntries.Add(hourEmp);      // Employee implements IPhoneBookItem
			pb.PhoneBookEntries.Add(salaryEmp);    // Employee implements IPhoneBookItem
			pb.PhoneBookEntries.Add(dep);          // Department implements IPhoneBookItem

			Console.WriteLine("--- PHONE BOOK ---");
			Console.WriteLine(pb.GetPhoneBook());

			Console.WriteLine("==========================================");
			Console.WriteLine("\n--- Employee Information ---\n");
			DisplayEmployeeInfo(hourEmp, 0, 3);
			DisplayEmployeeInfo(salaryEmp, 0, 3);

			// POLYMORPHISM DEMONSTRATION
			Console.WriteLine("--- Polymorphism: List of Employees ---");
			List<Employee> myEmployees = new List<Employee>();
			myEmployees.Add(salaryEmp);
			myEmployees.Add(hourEmp);

			decimal payroll = 0;
			foreach (Employee e in myEmployees)
			{
				payroll += e.Pay(0, 3);
			}
			Console.WriteLine("Payroll total for 0-2: " + payroll.ToString("C"));
			Console.WriteLine();

			// IS AND AS OPERATOR DEMONSTRATION
			Console.WriteLine("--- IS and AS Operators ---");
			foreach (Employee employee in myEmployees)
			{
				Console.WriteLine("Employee: " + employee);

				if (employee is HourlyEmployee)
				{
					HourlyEmployee hourlyEmp = employee as HourlyEmployee;
					Console.WriteLine("  Hourly rate: " + hourlyEmp.HourlyRate.ToString("C"));
				}

				if (employee is SalaryEmployee)
				{
					SalaryEmployee salEmp = (SalaryEmployee)employee;
					Console.WriteLine("  Salary: " + salEmp.Salary.ToString("C"));
				}
				Console.WriteLine();
			}

			Console.WriteLine("==========================================");
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		/// <summary>
		/// Displays employee information - demonstrates polymorphism
		/// Accepts Employee base class, works with any derived class
		/// </summary>
		private static void DisplayEmployeeInfo(Employee emp, int payStart, int payEnd)
		{
			Console.WriteLine(emp.ToString());
			Console.WriteLine(emp.PaySummary);
			Console.WriteLine("Pay for periods " + payStart + "-" + payEnd + ": "
				+ emp.Pay(payStart, payEnd).ToString("C"));
			Console.WriteLine();
		}
	}
}

/*
 * KEY CONCEPTS DEMONSTRATED:
 * 
 * 1. INTERFACES:
 *    - Define a contract that classes must implement
 *    - Use 'interface' keyword
 *    - Contains method signatures (no implementation)
 *    - IPhoneBookItem requires GetContactSummary() method
 * 
 * 2. IMPLEMENTING INTERFACES:
 *    - Use : InterfaceName syntax
 *    - Must implement ALL interface members
 *    - Employee : IPhoneBookItem
 *    - Department : IPhoneBookItem
 * 
 * 3. DEPENDENCY INVERSION PRINCIPLE:
 *    - PhoneBook depends on IPhoneBookItem interface
 *    - NOT dependent on specific Employee or Department classes
 *    - Can work with ANY class that implements IPhoneBookItem
 *    - Makes code more flexible and maintainable
 * 
 * 4. POLYMORPHISM VIA INTERFACES:
 *    - List<IPhoneBookItem> can hold any implementing type
 *    - Employee and Department are different classes
 *    - Both can be stored in same list because of interface
 *    - GetContactSummary() calls correct implementation
 * 
 * 5. INTERFACE vs ABSTRACT CLASS:
 *    Interface:
 *    - No implementation (just contract)
 *    - A class can implement multiple interfaces
 *    - Use when defining capability across unrelated classes
 *    
 *    Abstract Class:
 *    - Can have implementation
 *    - A class can inherit from only ONE abstract class
 *    - Use when defining shared behavior for related classes
 * 
 * EXPECTED OUTPUT:
 * 
 * --- PHONE BOOK ---
 * Bill Gates
 * Phone: (206) 555-1234
 * Email: bill@microsoft.com
 * 
 * Alan Turing
 * Phone: (555) 123-4567
 * Email: alan@computing.com
 * 
 * Department: Sales Department
 * TBD
 * Phone: TBD
 * Email: TBD
 * Web site: TBD
 * 
 * Notice: Different types (Employee, Department) stored in same list
 *         Each displays contact info in its own way
 *         PhoneBook doesn't need to know about specific types!
 */