// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: Program.cs
// Date: February 2, 2026

using System;
using System.Collections.Generic;

namespace StudentPropertiesDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			// Display header
			Console.WriteLine("==========================================");
			Console.WriteLine("Name: [Your Name]");
			Console.WriteLine("Program: Student Properties Demo");
			Console.WriteLine("Objective: Demonstrate C# properties");
			Console.WriteLine("==========================================\n");

			// Create a list to store multiple students
			List<Student> students = new List<Student>();
			string doAnother;

			// Loop to add students
			do
			{
				Student st = new Student();

				// Use properties to set values (notice how clean this is!)
				st.FirstName = GetInput("First Name");
				st.LastName = GetInput("Last Name");
				st.Major = GetInput("Major");
				st.StudentNumber = GetInput("Student Number");
				st.Score1 = int.Parse(GetInput("Score 1"));
				st.Score2 = int.Parse(GetInput("Score 2"));
				st.Score3 = int.Parse(GetInput("Score 3"));

				// Add student to list
				students.Add(st);

				doAnother = GetInput("\nDo another (y/n)");
				Console.WriteLine();

			} while (doAnother.ToLower() == "y");

			// Display all students
			Console.WriteLine("\n========== STUDENT AVERAGES ==========");
			foreach (Student st in students)
			{
				Console.WriteLine(st.ToString());
			}
			Console.WriteLine("======================================\n");

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		// Helper method to get input
		static private string GetInput(string prompt)
		{
			Console.Write(prompt + ": ");
			return Console.ReadLine();
		}
	}
}
