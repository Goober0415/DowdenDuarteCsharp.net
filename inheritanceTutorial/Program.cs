// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: Program.cs
// Date: February 3, 2026

using System;

namespace HRManager
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("==========================================");
			Console.WriteLine("Inheritance and Polymorphism Demo");
			Console.WriteLine("==========================================\n");

			// Create base class Employee object
			Employee emp = new Employee();
			emp.EmpNum = 1;
			emp.FirstName = "Steve";
			emp.LastName = "Jobs";

			// Create derived class HourlyEmployee object
			HourlyEmployee hourEmp = new HourlyEmployee();
			hourEmp.EmpNum = 2;
			hourEmp.FirstName = "Bill";
			hourEmp.LastName = "Gates";
			hourEmp.HourlyRate = 15.00M;

			// Test the PaySummary property
			Console.WriteLine("--- Testing PaySummary Property ---");
			Console.WriteLine("emp.PaySummary: " + emp.PaySummary);
			Console.WriteLine("hourEmp.PaySummary: " + hourEmp.PaySummary);
			Console.WriteLine();

			// POLYMORPHISM DEMONSTRATION
			// Assign HourlyEmployee object to Employee variable
			Employee emp2 = hourEmp;

			Console.WriteLine("--- Polymorphism Demo ---");
			Console.WriteLine("Assigned hourEmp to Employee variable emp2");
			Console.WriteLine();

			// Display type information
			Console.WriteLine("hourEmp.GetType(): " + hourEmp.GetType());
			Console.WriteLine("emp2.GetType(): " + emp2.GetType());
			Console.WriteLine();

			// Display ToString() results
			Console.WriteLine("hourEmp.ToString(): " + hourEmp.ToString());
			Console.WriteLine("emp2.ToString(): " + emp2.ToString());
			Console.WriteLine();

			// Display PaySummary results - demonstrates polymorphism
			Console.WriteLine("hourEmp.PaySummary: " + hourEmp.PaySummary);
			Console.WriteLine("emp2.PaySummary: " + emp2.PaySummary);
			Console.WriteLine();

			Console.WriteLine("==========================================");
			Console.WriteLine("Notice: emp2 is declared as Employee type,");
			Console.WriteLine("but still calls HourlyEmployee's overridden");
			Console.WriteLine("methods because of polymorphism!");
			Console.WriteLine("==========================================");

			Console.WriteLine("\nPress any key to exit...");
			Console.ReadKey();
		}
	}
}

/*
 * KEY CONCEPTS DEMONSTRATED:
 * 
 * 1. INHERITANCE:
 *    - HourlyEmployee : Employee
 *    - Derived class inherits all properties/methods from base class
 *    - Use : base() to call base class constructor
 * 
 * 2. VIRTUAL/OVERRIDE:
 *    - Base class uses 'virtual' keyword on property/method
 *    - Derived class uses 'override' keyword to replace implementation
 *    - Overridden methods are called even when object is in base class variable
 * 
 * 3. POLYMORPHISM:
 *    - Employee emp2 = hourEmp;
 *    - emp2 is Employee type but holds HourlyEmployee object
 *    - Calls HourlyEmployee's overridden methods (not Employee's)
 *    - This is the power of polymorphism!
 * 
 * 4. METHOD HIDING vs OVERRIDING:
 *    - OVERRIDE (used here): Polymorphic - correct method called regardless of variable type
 *    - HIDING (using 'new' keyword): Non-polymorphic - method depends on variable type
 *    - Always prefer override unless you have a specific reason to hide
 * 
 * 5. VIRTUAL PROPERTIES:
 *    - Properties can be virtual/override just like methods
 *    - Same polymorphic behavior
 *    - Cleaner syntax than Get/Set methods
 * 
 * EXPECTED OUTPUT:
 * 
 * emp.PaySummary: No pay for base class employee.
 * hourEmp.PaySummary: This employee is paid $15.00 per hour
 * 
 * hourEmp.GetType(): HRManager.HourlyEmployee
 * emp2.GetType(): HRManager.HourlyEmployee
 * 
 * hourEmp.ToString(): HRManager.HourlyEmployee Hourly Employee
 * emp2.ToString(): HRManager.HourlyEmployee Hourly Employee
 * 
 * hourEmp.PaySummary: This employee is paid $15.00 per hour
 * emp2.PaySummary: This employee is paid $15.00 per hour
 * 
 * Notice that emp2 (declared as Employee) calls HourlyEmployee methods!
 */
