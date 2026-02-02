/*
 * Name: [Jamie Dowden-Duarte]
 * Email: [jdowdenduarte@cnm.edu]
 * File Name: IdealGas.cs
 * Date: 2026-02-02
 */

using System;

namespace P2IdealGasLawDowdenDuarte
{
	public class IdealGas
	{
		// Private fields (Data Members) - Requirement 2.4
		private double mass;
		private double volume;
		private double temperature;
		private double molecularWeight;
		private double pressure;

		// Constant for the Ideal Gas Constant (J / (mol·K))
		private const double R = 8.314;

		// Requirement 2.5 & 2.6: Class Methods (Getters and Setters)

		// Mass Property Methods
		public void SetMass(double mass)
		{
			this.mass = mass;
			Calc(); // Automatically recalculate when data changes
		}
		public double GetMass() => mass;

		// Volume Property Methods
		public void SetVolume(double volume)
		{
			this.volume = volume;
			Calc();
		}
		public double GetVolume() => volume;

		// Temperature Property Methods (Stored in Celsius, Calc converts to Kelvin)
		public void SetTemperature(double temperature)
		{
			this.temperature = temperature;
			Calc();
		}
		public double GetTemperature() => temperature;

		// Molecular Weight Property Methods
		public void SetMolecularWeight(double mw)
		{
			this.molecularWeight = mw;
			Calc();
		}
		public double GetMolecularWeight() => molecularWeight;

		// Pressure Property Method (Get only)
		public double GetPressure() => pressure;

		// Requirement 2.6: Private, parameterless calculate method
		private void Calc()
		{
			// Conversion: Celsius to Kelvin
			double tempKelvin = temperature + 273.15;

			// P = (mRT) / (MW * V)
			// Ensure we don't divide by zero
			if (molecularWeight > 0 && volume > 0)
			{
				pressure = (mass * R * tempKelvin) / (molecularWeight * volume);
			}
			else
			{
				pressure = 0;
			}
		}
	}
}