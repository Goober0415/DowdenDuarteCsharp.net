// Name: [Your Name]
// Email: [Your Email]
// File: GravitationalForce.cs
// Date: February 2, 2026

using System;

namespace GravitationalForceDemo
{
	/// <summary>
	/// Represents the gravitational force between two objects in space.
	/// Uses Newton's Law of Universal Gravitation: F = G * (M1 * M2) / R^2
	/// </summary>
	class GravitationalForce
	{
		// Gravitational constant (m^3 kg^-1 s^-2)
		private const double G = 6.67408e-11;

		// Auto-implemented properties for object names (don't affect calculation)
		public string Object1Name { get; set; }
		public string Object2Name { get; set; }

		// Private backing fields for properties that affect force calculation
		private double mass1;
		private double mass2;
		private double radius;

		// Read-only property for calculated force
		public double Force { get; private set; }

		//-------------------------------------
		// Constructors
		//-------------------------------------

		/// <summary>
		/// Default constructor - initializes all properties to default values
		/// </summary>
		public GravitationalForce()
		{
			Object1Name = "Object 1";
			Object2Name = "Object 2";
			mass1 = 0;
			mass2 = 0;
			radius = 1; // Avoid division by zero
			Force = 0;
		}

		/// <summary>
		/// Parameterized constructor - initializes all properties with provided values
		/// </summary>
		/// <param name="name1">Name of first object</param>
		/// <param name="name2">Name of second object</param>
		/// <param name="m1">Mass of first object (kg)</param>
		/// <param name="m2">Mass of second object (kg)</param>
		/// <param name="r">Distance between objects (m)</param>
		public GravitationalForce(string name1, string name2, double m1, double m2, double r)
		{
			Object1Name = name1;
			Object2Name = name2;
			mass1 = m1;
			mass2 = m2;
			radius = r;
			Calculate(); // Calculate force with initial values
		}

		//-------------------------------------
		// Fully-qualified properties (call Calculate when set)
		//-------------------------------------

		/// <summary>
		/// Mass of first object in kilograms
		/// </summary>
		public double Mass1
		{
			get { return mass1; }
			set
			{
				mass1 = value;
				Calculate(); // Recalculate when mass changes
			}
		}

		/// <summary>
		/// Mass of second object in kilograms
		/// </summary>
		public double Mass2
		{
			get { return mass2; }
			set
			{
				mass2 = value;
				Calculate(); // Recalculate when mass changes
			}
		}

		/// <summary>
		/// Distance between objects in meters
		/// </summary>
		public double Radius
		{
			get { return radius; }
			set
			{
				radius = value;
				Calculate(); // Recalculate when radius changes
			}
		}

		//-------------------------------------
		// Calculate Method
		//-------------------------------------

		/// <summary>
		/// Calculates gravitational force using F = G * (M1 * M2) / R^2
		/// </summary>
		private void Calculate()
		{
			// Avoid division by zero
			if (radius == 0)
			{
				Force = 0;
				return;
			}

			// F = G * (M1 * M2) / R^2
			Force = G * (mass1 * mass2) / (radius * radius);
		}

		//-------------------------------------
		// ToString Override
		//-------------------------------------

		/// <summary>
		/// Returns a formatted string describing the gravitational force
		/// </summary>
		/// <returns>Formatted string with object names and force</returns>
		public override string ToString()
		{
			return $"The force between {Object1Name} and {Object2Name} is {Force:E2} Newtons";
		}
	}
}