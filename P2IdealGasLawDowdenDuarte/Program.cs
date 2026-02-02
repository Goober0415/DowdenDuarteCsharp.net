/*
 * Name: [Jamie Dowden-Duarte]
 * Email: [jdowdenduarte@cnm.edu]
 * File Name: Program.cs
 * Date: 2026-02-02
 */


using System;
using System.IO;

namespace P2IdealGasLawDowdenDuarte
{
	class Program
	{
		// Arrays to store gas data
		static string[] gasNames;
		static double[] molecularWeights;
		static int gasCount = 0;

		static void Main(string[] args)
		{
			// Display header
			DisplayHeader();

			// Load gas data from file
			GetMolecularWeights("gases.txt");

			// Display available gases
			DisplayGasNames();

			// Main loop for multiple calculations
			string doAnother;
			do
			{
				try
				{
					// Get gas name from user
					Console.Write("\nEnter gas name: ");
					string gasName = Console.ReadLine();

					// Get molecular weight for selected gas
					double molWeight = GetMolecularWeightFromName(gasName);

					// Check if gas was found
					if (molWeight == -1)
					{
						Console.WriteLine($"Error: Gas '{gasName}' not found in database.");
						Console.WriteLine("Please check spelling and try again.\n");
						doAnother = GetInput("Do another calculation? (y/n): ");
						continue;  // Skip to next iteration
					}

					// Create new IdealGas object
					IdealGas gas = new IdealGas();

					// Set molecular weight
					gas.SetMolecularWeight(molWeight);

					// Get volume from user
					Console.Write("Enter volume (cubic meters): ");
					double volume = double.Parse(Console.ReadLine());
					gas.SetVolume(volume);

					// Get mass from user
					Console.Write("Enter mass (grams): ");
					double mass = double.Parse(Console.ReadLine());
					gas.SetMass(mass);

					// Get temperature from user
					Console.Write("Enter temperature (Celsius): ");
					double temperature = double.Parse(Console.ReadLine());
					gas.SetTemperature(temperature);

					// Get calculated pressure and display results
					double pressurePa = gas.GetPressure();
					DisplayPressure(pressurePa, temperature, gasName);

				}
				catch (FormatException)
				{
					Console.WriteLine("\nError: Invalid input format. Please enter numeric values.");
				}
				catch (OverflowException)
				{
					Console.WriteLine("\nError: Number is too large or too small.");
				}
				catch (Exception exc)
				{
					Console.WriteLine("\nError: " + exc.Message);
				}

				// Ask if user wants to do another calculation
				doAnother = GetInput("\nDo another calculation? (y/n): ");

			} while (doAnother.ToLower() == "y");

			// Goodbye message
			Console.WriteLine("\nThank you for using the Ideal Gas Calculator!");
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		// Display program header
		static void DisplayHeader()
		{
			Console.WriteLine("==========================================");
			Console.WriteLine("Name: [Your Name]");
			Console.WriteLine("Program: Ideal Gas Law Calculator (Class Version)");
			Console.WriteLine("Objective: Calculate gas pressure using OOP and PV=nRT");
			Console.WriteLine("==========================================\n");
		}

		// Load molecular weights from file
		static void GetMolecularWeights(string filename)
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
					string[] parts = lines[i].Split('\t'); // Tab-separated
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

		// Display gas names in three columns
		static void DisplayGasNames()
		{
			Console.WriteLine("Available Gases:");
			Console.WriteLine("================");

			int columns = 3;
			int rows = (int)Math.Ceiling((double)gasCount / columns);

			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < columns; col++)
				{
					int index = col * rows + row;
					if (index < gasCount)
					{
						Console.Write($"{gasNames[index],-25}");
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}

		// Get molecular weight for a given gas name
		static double GetMolecularWeightFromName(string gasName)
		{
			for (int i = 0; i < gasCount; i++)
			{
				if (gasNames[i].Equals(gasName, StringComparison.OrdinalIgnoreCase))
				{
					return molecularWeights[i];
				}
			}
			return -1; // Return -1 if not found
		}

		// Display pressure results
		static void DisplayPressure(double pressurePa, double tempC, string gasName)
		{
			double pressurePsi = PaToPSI(pressurePa);

			Console.WriteLine("\n========== RESULTS ==========");
			Console.WriteLine($"Gas: {gasName}");
			Console.WriteLine($"Temperature: {tempC:F2}°C ({tempC + 273.15:F2} K)");
			Console.WriteLine($"Pressure: {pressurePa:F2} Pa");
			Console.WriteLine($"Pressure: {pressurePa / 1000:F2} kPa");
			Console.WriteLine($"Pressure: {pressurePsi:F2} PSI");
			Console.WriteLine("============================");
		}

		// Convert Pascals to PSI
		static double PaToPSI(double pascals)
		{
			return pascals * 0.000145038; // Conversion factor
		}

		// Helper method to get input
		static string GetInput(string prompt)
		{
			Console.Write(prompt);
			return Console.ReadLine();
		}
	}
}