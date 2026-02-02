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
		static void Main(string[] args)
		{
			string[] gasNames = new string[100];
			double[] molecularWeights = new double[100];
			int count = 0;

			DisplayHeader();

			// Load data from CSV
			count = GetMolecularWeights(ref gasNames, ref molecularWeights);

			string choice;
			do
			{
				// Requirement 7.12 & 7.13: Exception Handling
				try
				{
					DisplayGasNames(gasNames, count);

					Console.Write("\nEnter the name of the gas: ");
					string name = Console.ReadLine();

					double weight = GetMolecularWeightFromName(name, gasNames, molecularWeights, count);

					if (weight == -1)
					{
						Console.WriteLine("Error: Gas name not found in database.");
					}
					else
					{
						// Instantiate the class
						IdealGas gas = new IdealGas();
						gas.SetMolecularWeight(weight);

						Console.Write("Enter volume (cubic meters): ");
						gas.SetVolume(Convert.ToDouble(Console.ReadLine()));

						Console.Write("Enter mass (grams): ");
						gas.SetMass(Convert.ToDouble(Console.ReadLine()));

						Console.Write("Enter temperature (Celsius): ");
						gas.SetTemperature(Convert.ToDouble(Console.ReadLine()));

						DisplayPressure(gas.GetPressure());
					}
				}
				catch (FormatException)
				{
					Console.WriteLine("Error: Please enter numeric values for volume, mass, and temperature.");
				}
				catch (OverflowException)
				{
					Console.WriteLine("Error: The number entered is too large.");
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error: " + ex.Message);
				}

				Console.Write("\nDo another? (y/n): ");
				choice = Console.ReadLine().ToLower();

			} while (choice == "y");

			Console.WriteLine("Thank you for using the Ideal Gas Calculator. Goodbye!");
		}

		static void DisplayHeader()
		{
			Console.WriteLine("=================================================");
			Console.WriteLine("Name: [Your Name]");
			Console.WriteLine("Program: Ideal Gas Calculator");
			Console.WriteLine("Objective: Calculate gas pressure using classes.");
			Console.WriteLine("=================================================\n");
		}

		static int GetMolecularWeights(ref string[] names, ref double[] weights)
		{
			int i = 0;
			try
			{
				// Use File.ReadLines for memory efficiency
				foreach (string line in File.ReadLines("gas_data.csv"))
				{
					string[] parts = line.Split(',');
					names[i] = parts[0].Trim();

					// FIX: Use parts[1] (or the correct index) instead of the URL
					weights[i] = Convert.ToDouble(parts[1]);
					i++;
				}
			}
			catch (Exception) { /* Handle file errors */ }
			return i;
		}

		static void DisplayGasNames(string[] names, int count)
		{
			Console.WriteLine("Available Gases:");
			for (int i = 0; i < count; i++)
			{
				Console.Write($"{names[i],-15}");
				if ((i + 1) % 3 == 0) Console.WriteLine();
			}
			Console.WriteLine();
		}

		static double GetMolecularWeightFromName(string name, string[] names, double[] weights, int count)
		{
			for (int i = 0; i < count; i++)
			{
				if (names[i].Equals(name, StringComparison.OrdinalIgnoreCase))
					return weights[i];
			}
			return -1;
		}

		static void DisplayPressure(double pressurePascals)
		{
			double psi = PaToPsi(pressurePascals);
			Console.WriteLine($"\nCalculated Pressure:");
			Console.WriteLine($"- Pascals: {pressurePascals:N2} Pa");
			Console.WriteLine($"- PSI:     {psi:N2} psi");
		}

		static double PaToPsi(double pascals) => pascals * 0.000145038;
	}
}
