/*
 * Name: [Jamie Dowden-Duarte]
 * Email: [jdowdenduarte@cnm.edu]
 * File Name: IdealGas.cs
 * Date: 2026-02-02
 */

namespace P2IdealGasLawDowdenDuarte
{
    class IdealGas
    {
        // Private fields
        private double mass;              // grams
        private double volume;            // cubic meters
        private double temp;              // Celsius
        private double molecularWeight;   // g/mol
        private double pressure;          // Pascals

        // Gas constant
        private const double R = 8.314;   // J/(mol·K)

        // Constructor - initializes all fields to zero
        public IdealGas()
        {
            mass = 0;
            volume = 0;
            temp = 0;
            molecularWeight = 0;
            pressure = 0;
        }

        // Getter and Setter for Mass
        public double GetMass()
        {
            return mass;
        }

        public void SetMass(double mass)
        {
            this.mass = mass;
            Calc();  // Recalculate pressure when mass changes
        }

        // Getter and Setter for Volume
        public double GetVolume()
        {
            return volume;
        }

        public void SetVolume(double volume)
        {
            this.volume = volume;
            Calc();  // Recalculate pressure when volume changes
        }

        // Getter and Setter for Temperature
        public double GetTemperature()
        {
            return temp;
        }

        public void SetTemperature(double temp)
        {
            this.temp = temp;
            Calc();  // Recalculate pressure when temperature changes
        }

        // Getter and Setter for Molecular Weight
        public double GetMolecularWeight()
        {
            return molecularWeight;
        }

        public void SetMolecularWeight(double molecularWeight)
        {
            this.molecularWeight = molecularWeight;
            Calc();  // Recalculate pressure when molecular weight changes
        }

        // Getter ONLY for Pressure (read-only, calculated automatically)
        public double GetPressure()
        {
            return pressure;
        }

        // Private calculate method - calculates pressure using PV = nRT
        private void Calc()
        {
            // Avoid division by zero
            if (volume == 0 || molecularWeight == 0)
            {
                pressure = 0;
                return;
            }

            // Convert temperature from Celsius to Kelvin
            double tempKelvin = temp + 273.15;

            // Calculate moles: n = mass / molecular weight
            double moles = mass / molecularWeight;

            // Calculate pressure: P = nRT / V
            pressure = (moles * R * tempKelvin) / volume;
        }
    }
}