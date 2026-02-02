// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: Program.cs
// Date: February 2, 2026

using System;

namespace StudentConstructorsDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("==========================================");
			Console.WriteLine("Name: [Your Name]");
			Console.WriteLine("Program: Student Constructors Demo");
			Console.WriteLine("Objective: Demonstrate constructor overloading and chaining");
			Console.WriteLine("==========================================\n");

			// Test 1: Parameterless constructor
			Console.WriteLine("--- Test 1: Parameterless Constructor ---");
			Student student1 = new Student();
			Console.WriteLine("Student Number: {0}", student1.StudentNumber);
			Console.WriteLine("First Name: {0}", student1.FirstName);
			Console.WriteLine("Last Name: {0}", student1.LastName);
			Console.WriteLine("Student Major: {0}", student1.Major);
			Console.WriteLine();

			// Test 2: Single parameter constructor
			Console.WriteLine("--- Test 2: Single Parameter Constructor ---");
			Student student2 = new Student("S001");
			Console.WriteLine("Student Number: {0}", student2.GetStudentNumber());
			Console.WriteLine("First Name: {0}", student2.GetFirstName());
			Console.WriteLine("Last Name: {0}", student2.GetLastName());
			Console.WriteLine("Student Major: {0}", student2.GetMajor());
			Console.WriteLine();

			// Test 3: Three parameter constructor
			Console.WriteLine("--- Test 3: Three Parameter Constructor ---");
			Student student3 = new Student("S002", "Jane", "Doe");
			Console.WriteLine("Student Number: {0}", student3.GetStudentNumber());
			Console.WriteLine("First Name: {0}", student3.GetFirstName());
			Console.WriteLine("Last Name: {0}", student3.GetLastName());
			Console.WriteLine("Student Major: {0}", student3.GetMajor());
			Console.WriteLine();

			// Test 4: Full constructor with all parameters
			Console.WriteLine("--- Test 4: Full Constructor ---");
			Student student4 = new Student("S003", "John", "Smith", 90, 80, 100, "Computer Programming");
			Console.WriteLine("Student Number: {0}", student4.GetStudentNumber());
			Console.WriteLine("First Name: {0}", student4.GetFirstName());
			Console.WriteLine("Last Name: {0}", student4.GetLastName());
			Console.WriteLine("Student Major: {0}", student4.GetMajor());
			Console.WriteLine("Average: {0:F2}", student4.GetAverage());
			Console.WriteLine();

			// Test 5: Using ToString()
			Console.WriteLine("--- Test 5: Using ToString() ---");
			Console.WriteLine(student4.ToString());
			Console.WriteLine();

			Console.WriteLine("\nPress any key to exit...");
			Console.WriteLine("(Watch for destructor messages when program ends)");
			Console.ReadKey();

			// When the program ends, the garbage collector will eventually
			// call the destructors and you'll see the cleanup messages
		}
	}
}

/* 
 * NOTES ON CONSTRUCTOR CHAINING:
 * 
 * All constructors chain to the "main" constructor (the one with all parameters).
 * This follows the DRY principle (Don't Repeat Yourself).
 * 
 * Benefits:
 * 1. Less code duplication
 * 2. Easier to maintain - if initialization logic changes, you only update one place
 * 3. Consistent initialization across all constructors
 * 
 * Example flow when calling: new Student("S001")
 * 1. Student(string sID) constructor is called
 * 2. It chains to Student(string, string, string, int, int, int, string) using ": this(...)"
 * 3. The main constructor does all the actual initialization work
 * 
 * DESTRUCTOR NOTES:
 * 
 * The ~Student() destructor is called by the garbage collector when the object
 * is being removed from memory. You don't control WHEN this happens - the .NET
 * runtime decides.
 * 
 * In modern C#, you rarely need destructors. They're mainly used for cleaning up
 * unmanaged resources (like file handles, database connections, etc.).
 * 
 * For managed resources, use IDisposable pattern instead.
 */