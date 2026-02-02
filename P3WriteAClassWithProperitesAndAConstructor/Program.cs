// Name: [Jamie Dowden-Duarte]
// Email: [jd]
// File: Program.cs
// Date: February 2, 2026

using System;

namespace GravitationalForceDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			// Display program header
			Console.WriteLine("==========================================");
			Console.WriteLine("Name: [Your Name]");
			Console.WriteLine("Program: Gravitational Force Calculator");
			Console.WriteLine("Objective: Calculate gravitational force between objects");
			Console.WriteLine("==========================================\n");

			string doAnother;

			// Main do-another loop
			do
			{
				try
				{
					// Instantiate GravitationalForce object
					GravitationalForce gravity = new GravitationalForce();

					// Get object 1 information
					Console.Write("Enter name of first object: ");
					gravity.Object1Name = Console.ReadLine();

					Console.Write("Enter mass of first object (kg): ");
					gravity.Mass1 = double.Parse(Console.ReadLine());

					// Get object 2 information
					Console.Write("Enter name of second object: ");
					gravity.Object2Name = Console.ReadLine();

					Console.Write("Enter mass of second object (kg): ");
					gravity.Mass2 = double.Parse(Console.ReadLine());

					// Get distance between objects
					Console.Write("Enter distance between objects (m): ");
					gravity.Radius = double.Parse(Console.ReadLine());

					// Display result using ToString()
					Console.WriteLine("\n" + gravity.ToString());
					Console.WriteLine();
				}
				catch (FormatException)
				{
					Console.WriteLine("\nError: Please enter valid numeric values.\n");
				}
				catch (Exception ex)
				{
					Console.WriteLine($"\nError: {ex.Message}\n");
				}

				// Ask if user wants to do another calculation
				Console.Write("Do another calculation? (y/n): ");
				doAnother = Console.ReadLine();
				Console.WriteLine();

			} while (doAnother.ToLower() == "y");

			// Goodbye message
			Console.WriteLine("Thank you for using the Gravitational Force Calculator!");
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}

/*
 * EXAMPLE CALCULATIONS TO TEST:
 * 
 * Earth and Moon:
 * - Earth mass: 5.972e24 kg
 * - Moon mass: 7.348e22 kg
 * - Distance: 3.844e8 m (384,400 km)
 * - Expected force: ~1.98e20 N
 * 
 * Earth and Sun:
 * - Earth mass: 5.972e24 kg
 * - Sun mass: 1.989e30 kg
 * - Distance: 1.496e11 m (149.6 million km)
 * - Expected force: ~3.54e22 N
 * 
 * Two 1kg objects 1 meter apart:
 * - Mass 1: 1 kg
 * - Mass 2: 1 kg
 * - Distance: 1 m
 * - Expected force: 6.67408e-11 N (very tiny!)
 */
