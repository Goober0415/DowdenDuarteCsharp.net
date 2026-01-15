# Ideal Gas Law Calculator

A C# console application that calculates the pressure exerted by a gas in a container using the Ideal Gas Law equation (PV = nRT).

## Author Information
- **Name:** [Your Name]
- **Email:** [Your Email]
- **Course:** C# Programming
- **Date:** January 15, 2026

## Program Description

This program demonstrates fundamental C# programming concepts while solving real-world chemistry calculations. It calculates gas pressure based on user-provided inputs including gas type, volume, weight, and temperature.

### Features
- Load gas data from external file (84+ gases supported)
- Interactive gas selection with smart search and filtering
- Input validation for all user entries
- Formatted output with results in both Pascals and kiloPascals
- Loop functionality for multiple calculations
- Error handling for file operations

## Learning Objectives Demonstrated

This project demonstrates the following C# programming concepts:

1. **Variables and Data Types** - Proper use of int, double, string, bool, and const
2. **Console I/O** - Reading user input and displaying formatted output
3. **Format Strings** - Professional output formatting with decimal precision
4. **Arithmetic Expressions** - Complex mathematical calculations
5. **File Reading** - Loading data from external files (CSV/TXT)
6. **Arrays** - Storing and accessing collections of data
7. **Parallel Arrays** - Maintaining related data across multiple arrays
8. **Methods** - Modular code organization with clear responsibilities
9. **Loops** - for loops for iteration, while loops for validation
10. **Conditionals** - if/else statements for flow control
11. **Exception Handling** - try/catch blocks for robust error handling

## The Ideal Gas Law

The program uses the Ideal Gas Law equation:

```
PV = nRT

Where:
P = Pressure (Pascals)
V = Volume (cubic meters)
n = Number of moles (weight in grams / molecular weight)
R = Gas constant (8.314 J/(mol·K))
T = Temperature (Kelvin)

Solving for P: P = nRT/V
```

## Requirements

- .NET 6.0 or higher
- Visual Studio 2022 (or Visual Studio Code with C# extension)
- Gas data file (gases.txt or gases.csv)

## Installation & Setup

1. **Clone the repository:**
   ```bash
   git clone [your-repo-url]
   cd IdealGasLaw
   ```

2. **Open in Visual Studio:**
   - Open `IdealGasLaw.sln`
   - Or open the project folder in Visual Studio Code

3. **Add gas data file:**
   - Place `gases.txt` or `gases.csv` in the project root
   - The file should be tab or comma-separated with format:
     ```
     Gas or Vapor    Molecular Weight
     Oxygen          31.9988
     Nitrogen        28.0134
     ...
     ```

4. **Build and run:**
   - Press `F5` in Visual Studio
   - Or run `dotnet run` from command line

## Usage

1. **Start the program** - The header displays with program information

2. **Select a gas:**
   - Type `list` to see all 84 available gases
   - Or type a gas name directly (e.g., "Oxygen", "Methane")
   - Partial matches will show suggestions

3. **Enter measurements:**
   - Volume in cubic meters (e.g., 0.5)
   - Weight in grams (e.g., 100)
   - Temperature in Celsius (e.g., 25)

4. **View results:**
   - Pressure calculated in Pascals and kiloPascals
   - All inputs echoed back for verification

5. **Continue or exit:**
   - Choose 'y' for another calculation
   - Choose 'n' to exit

## Example Session

```
==========================================
Name: John Doe
Program: Ideal Gas Law Calculator
Objective: Calculate gas pressure using PV=nRT
==========================================

84 gases available in database.
Type 'list' to see all gases, or enter a gas name to search.

Enter gas name (or 'list'): Oxygen
Selected: Oxygen (MW: 31.9988 g/mol)

Enter volume (cubic meters): 0.5
Enter weight (grams): 100
Enter temperature (degrees Celsius): 25

========== RESULTS ==========
Gas: Oxygen
Volume: 0.50 m³
Weight: 100.00 g
Temperature: 25.00°C (298.15 K)
Pressure: 15485.67 Pa (15.49 kPa)
=============================

Would you like to calculate another pressure? (y/n):
```

## Project Structure

```
IdealGasLaw/
├── Program.cs          # Main program file with all methods
├── gases.txt           # Gas molecular weight data
├── README.md           # This file
└── IdealGasLaw.sln     # Visual Studio solution file
```

## Gas Data File Format

The program supports two formats:

**Tab-delimited (.txt):**
```
Gas or Vapor	Molecular Weight
Oxygen	31.9988
Nitrogen	28.0134
```

**Comma-separated (.csv):**
```
Gas or Vapor,Molecular Weight
Oxygen,31.9988
Nitrogen,28.0134
```

## Error Handling

- **Missing file:** Program uses default gas data (Oxygen, Nitrogen, Hydrogen, Carbon Dioxide)
- **Invalid input:** All inputs are validated with helpful error messages
- **Out of range:** Temperature must be ≥ -273.15°C (absolute zero)

## Troubleshooting

### "No Dockerfile could be found" error
- Click the dropdown next to the green play button
- Select your project name instead of "Docker"
- Press F5 to run

### "Error loading gas data" message
- Ensure gases.txt or gases.csv is in the correct location
- Check file format matches expected structure
- Program will work with default gases if file is missing

### Gas not found
- Type `list` to see all available gases
- Check spelling (case-insensitive)
- Try partial name for suggestions

## Future Enhancements

- [ ] Add support for different units (atm, psi, bar)
- [ ] Save calculation history to file
- [ ] GUI version using Windows Forms or WPF
- [ ] Add more gas properties (density, specific heat, etc.)
- [ ] Support for gas mixtures

## License

This project is created for educational purposes as part of a C# programming course.

## Acknowledgments

- Gas molecular weight data from standard chemistry references
- Ideal Gas Law from fundamental thermodynamics principles
- Course instructor: Brian Rashap, IoT Product Design and Rapid Prototyping

---

**Note:** This is a console application for educational demonstration. For production use in scientific applications, consider using specialized chemistry libraries with more precise gas constants and real gas behavior models.
