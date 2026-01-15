// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@student.cnm.com]
// File: IdealGasCalculator.cs
// Date: January 15, 2026

// Name: [Your Name]
// Email: [Your Email]
// File: IdealGasCalculator.cs
// Date: January 15, 2026

using System;
using System.IO;

namespace P1_IdealGasLawCalculator_DowdenDuarte
{
	class Program
	{
		// Parallel arrays for gas names and molecular weights (Obj 1.7.6, 1.7.8)
		static string[] gasNames;
		static double[] molecularWeights;
		static int gasCount = 0;

		// Gas constant in J/(mol·K) (Obj 1.7.1)
		const double R = 8.314;

		static void Main(string[] args)
		{
			// Display header (Obj 1.7.2)
			DisplayHeader();

			// Load gas data from file (Obj 1.7.5)
			LoadGasData("gases.csv");

			// Main program loop (Obj 1.7.10, 1.7.11)
			bool continueCalculating = true;
			while (continueCalculating)
			{
				// Get user inputs
				string gasName = GetGasName();
				double volume = GetVolume();
				double weight = GetWeight();
				double tempCelsius = GetTemperature();

				// Calculate pressure (Obj 1.7.7, 1.7.9)
				double pressure = CalculatePressure(gasName, volume, weight, tempCelsius);

				// Display results (Obj 1.7.3)
				DisplayResults(gasName, volume, weight, tempCelsius, pressure);

				// Ask if user wants to continue
				continueCalculating = AskToContinue();
			}

			Console.WriteLine("\nThank you for using the Ideal Gas Law Calculator!");
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		// Display program header (Obj 1.7.2)
		static void DisplayHeader()
		{
			Console.WriteLine("==========================================");
			Console.WriteLine("Name: [Jamie Dowden-Duarte]");
			Console.WriteLine("Program: Ideal Gas Law Calculator");
			Console.WriteLine("Objective: Calculate gas pressure using PV=nRT");
			Console.WriteLine("==========================================\n");
		}

		// Load gas data from CSV file (Obj 1.7.5)
		static void LoadGasData(string filename)
		{
			try
			{
				string[] lines = File.ReadAllLines(filename);
				gasCount = lines.Length - 1; // Subtract header row

				gasNames = new string[gasCount];
				molecularWeights = new double[gasCount];

				// Skip header, read data
				for (int i = 1; i < lines.Length; i++)
				{
					string[] parts = lines[i].Split('\t'); // Tab-separated from Excel
					if (parts.Length >= 2)
					{
						gasNames[i - 1] = parts[0].Trim();
						molecularWeights[i - 1] = double.Parse(parts[1].Trim());
					}
				}

				Console.WriteLine($"Loaded {gasCount} gases from file.\n");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error loading gas data: {ex.Message}");
				Console.WriteLine("Using default gas data instead.\n");

				// Default data if file not found
				gasNames = new string[] { "Oxygen", "Nitrogen", "Hydrogen", "Carbon Dioxide" };
				molecularWeights = new double[] { 31.9988, 28.0134, 2.016, 44.01 };
				gasCount = 4;
			}
		}

		// Get gas name from user with validation (Obj 1.7.2, 1.7.11)
		static string GetGasName()
		{
			Console.WriteLine($"\n{gasCount} gases available in database.");
			Console.WriteLine("Type 'list' to see all gases, or enter a gas name to search.");

			while (true)
			{
				Console.Write("\nEnter gas name (or 'list'): ");
				string input = Console.ReadLine().Trim();

				// Show full list if requested
				if (input.Equals("list", StringComparison.OrdinalIgnoreCase))
				{
					Console.WriteLine("\nAvailable gases:");
					for (int i = 0; i < gasCount; i++)
					{
						Console.WriteLine($"  {gasNames[i]} (MW: {molecularWeights[i]} g/mol)");
					}
					continue;
				}

				// Check for exact match first
				for (int i = 0; i < gasCount; i++)
				{
					if (gasNames[i].Equals(input, StringComparison.OrdinalIgnoreCase))
					{
						Console.WriteLine($"Selected: {gasNames[i]} (MW: {molecularWeights[i]} g/mol)");
						return gasNames[i];
					}
				}

				// If no exact match, show similar matches
				Console.WriteLine($"\nNo exact match for '{input}'. Did you mean:");
				bool foundSimilar = false;
				for (int i = 0; i < gasCount; i++)
				{
					if (gasNames[i].IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
					{
						Console.WriteLine($"  - {gasNames[i]} (MW: {molecularWeights[i]} g/mol)");
						foundSimilar = true;
					}
				}

				if (!foundSimilar)
				{
					Console.WriteLine("  (no similar matches found)");
				}

				Console.WriteLine("\nPlease try again or type 'list' to see all options.");
			}
		}

		// Get volume from user (Obj 1.7.2, 1.7.11)
		static double GetVolume()
		{
			while (true)
			{
				Console.Write("Enter volume (cubic meters): ");
				string input = Console.ReadLine();

				if (double.TryParse(input, out double volume) && volume > 0)
				{
					return volume;
				}

				Console.WriteLine("Invalid input. Please enter a positive number.");
			}
		}

		// Get weight from user (Obj 1.7.2, 1.7.11)
		static double GetWeight()
		{
			while (true)
			{
				Console.Write("Enter weight (grams): ");
				string input = Console.ReadLine();

				if (double.TryParse(input, out double weight) && weight > 0)
				{
					return weight;
				}

				Console.WriteLine("Invalid input. Please enter a positive number.");
			}
		}

		// Get temperature from user (Obj 1.7.2, 1.7.11)
		static double GetTemperature()
		{
			while (true)
			{
				Console.Write("Enter temperature (degrees Celsius): ");
				string input = Console.ReadLine();

				if (double.TryParse(input, out double temp) && temp >= -273.15)
				{
					return temp;
				}

				Console.WriteLine("Invalid input. Temperature must be >= -273.15°C (absolute zero).");
			}
		}

		// Calculate pressure using Ideal Gas Law (Obj 1.7.4, 1.7.7, 1.7.9, 1.7.12)
		static double CalculatePressure(string gasName, double volume, double weightGrams, double tempCelsius)
		{
			// Find molecular weight for this gas
			double molecularWeight = GetMolecularWeight(gasName);

			// Convert weight to moles: n = weight / molecular weight
			double moles = weightGrams / molecularWeight;

			// Convert Celsius to Kelvin: K = C + 273.15
			double tempKelvin = tempCelsius + 273.15;

			// Calculate pressure using PV = nRT, so P = nRT/V
			double pressure = (moles * R * tempKelvin) / volume;

			return pressure;
		}

		// Helper method to get molecular weight (Obj 1.7.9, 1.7.12)
		static double GetMolecularWeight(string gasName)
		{
			for (int i = 0; i < gasCount; i++)
			{
				if (gasNames[i].Equals(gasName, StringComparison.OrdinalIgnoreCase))
				{
					return molecularWeights[i];
				}
			}
			return 0; // Should never reach here due to validation
		}

		// Display formatted results (Obj 1.7.3)
		static void DisplayResults(string gasName, double volume, double weight, double tempCelsius, double pressure)
		{
			Console.WriteLine("\n========== RESULTS ==========");
			Console.WriteLine($"Gas: {gasName}");
			Console.WriteLine($"Volume: {volume:F2} m³");
			Console.WriteLine($"Weight: {weight:F2} g");
			Console.WriteLine($"Temperature: {tempCelsius:F2}°C ({tempCelsius + 273.15:F2} K)");
			Console.WriteLine($"Pressure: {pressure:F2} Pa ({pressure / 1000:F2} kPa)");
			Console.WriteLine("=============================\n");
		}

		// Ask if user wants another calculation (Obj 1.7.2, 1.7.11)
		static bool AskToContinue()
		{
			Console.Write("Would you like to calculate another pressure? (y/n): ");
			string response = Console.ReadLine().ToLower();
			return response == "y" || response == "yes";
		}
	}
}