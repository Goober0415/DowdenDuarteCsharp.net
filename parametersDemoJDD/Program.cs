// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: Program.cs
// Date: February 3, 2026

using System;

namespace parameterDemoJDD
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("==========================================");
			Console.WriteLine("Parameter Passing Methods in C#");
			Console.WriteLine("==========================================\n");

			// 1. PASS BY VALUE
			Console.WriteLine("--- 1. PASS BY VALUE ---");
			int myNumber = 5;
			Console.WriteLine($"Before Increment: myNumber = {myNumber}");
			Increment(myNumber);
			Console.WriteLine($"After Increment: myNumber = {myNumber}");
			Console.WriteLine("(Original variable unchanged - passed by value)\n");

			// 2. PASS BY REFERENCE
			Console.WriteLine("--- 2. PASS BY REFERENCE (ref) ---");
			int myRefNumber = 5;
			Console.WriteLine($"Before IncrementRef: myRefNumber = {myRefNumber}");
			IncrementRef(ref myRefNumber);
			Console.WriteLine($"After IncrementRef: myRefNumber = {myRefNumber}");
			Console.WriteLine("(Original variable modified - passed by reference)\n");

			// 3. OUT PARAMETERS
			Console.WriteLine("--- 3. OUT PARAMETERS ---");
			int a, b;  // Not initialized
			GetValues(out a, out b);
			Console.WriteLine($"a = {a}, b = {b}");
			Console.WriteLine("(Variables don't need initialization before passing as out)\n");

			// Out parameters example 2
			string input = "123";
			int result;
			bool success = TryParseInt(input, out result);
			Console.WriteLine($"Parsing '{input}': Success = {success}, Result = {result}\n");

			// 4. NAMED ARGUMENTS
			Console.WriteLine("--- 4. NAMED ARGUMENTS ---");
			DisplayInfo(name: "Alice", age: 25);
			DisplayInfo(age: 30, name: "Bob");  // Order doesn't matter
			Console.WriteLine("(Arguments can be passed in any order when named)\n");

			// 5. OPTIONAL ARGUMENTS
			Console.WriteLine("--- 5. OPTIONAL ARGUMENTS ---");
			Greet();  // Uses default value
			Greet("Alice");
			Greet("Bob", "Good morning");
			Console.WriteLine();

			// 6. METHOD OVERLOADING
			Console.WriteLine("--- 6. METHOD OVERLOADING ---");
			Print(10);
			Print("Hello");
			Print(3.14);
			Print("Result", 42);
			Console.WriteLine();

			// COMBINATION EXAMPLE
			Console.WriteLine("--- COMBINATION EXAMPLE ---");
			int x = 10, y = 20;
			int sum, product;
			Calculate(x, y, out sum, out product, operation: "both");
			Console.WriteLine($"{x} + {y} = {sum}");
			Console.WriteLine($"{x} × {y} = {product}\n");

			Console.WriteLine("==========================================");
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		//================================================
		// 1. PASS BY VALUE
		//================================================

		/// <summary>
		/// Pass by value - receives a COPY of the argument
		/// Changes don't affect the original variable
		/// </summary>
		static void Increment(int number)
		{
			number++;
			Console.WriteLine($"  Inside Increment: number = {number}");
		}

		//================================================
		// 2. PASS BY REFERENCE
		//================================================

		/// <summary>
		/// Pass by reference - receives a REFERENCE to the original variable
		/// Changes DO affect the original variable
		/// </summary>
		static void IncrementRef(ref int number)
		{
			number++;
			Console.WriteLine($"  Inside IncrementRef: number = {number}");
		}

		//================================================
		// 3. OUT PARAMETERS
		//================================================

		/// <summary>
		/// Out parameters - used to return multiple values
		/// Variables don't need to be initialized before passing
		/// Method MUST assign values to all out parameters
		/// </summary>
		static void GetValues(out int x, out int y)
		{
			x = 10;
			y = 20;
		}

		/// <summary>
		/// Common use case: TryParse pattern
		/// Returns bool for success, actual value via out parameter
		/// </summary>
		static bool TryParseInt(string input, out int result)
		{
			return int.TryParse(input, out result);
		}

		//================================================
		// 4. NAMED ARGUMENTS
		//================================================

		/// <summary>
		/// Named arguments allow passing parameters by name
		/// Order doesn't matter when using named arguments
		/// </summary>
		static void DisplayInfo(string name, int age)
		{
			Console.WriteLine($"  Name: {name}, Age: {age}");
		}

		//================================================
		// 5. OPTIONAL ARGUMENTS
		//================================================

		/// <summary>
		/// Optional arguments have default values
		/// Can be omitted when calling the method
		/// </summary>
		static void Greet(string name = "Guest", string greeting = "Hello")
		{
			Console.WriteLine($"  {greeting}, {name}!");
		}

		//================================================
		// 6. METHOD OVERLOADING
		//================================================

		/// <summary>
		/// Print an integer
		/// </summary>
		static void Print(int number)
		{
			Console.WriteLine($"  Number: {number}");
		}

		/// <summary>
		/// Print a string
		/// </summary>
		static void Print(string message)
		{
			Console.WriteLine($"  Message: {message}");
		}

		/// <summary>
		/// Print a double
		/// </summary>
		static void Print(double value)
		{
			Console.WriteLine($"  Double: {value}");
		}

		/// <summary>
		/// Print a label and value
		/// </summary>
		static void Print(string label, int value)
		{
			Console.WriteLine($"  {label}: {value}");
		}

		//================================================
		// COMBINATION EXAMPLE
		//================================================

		/// <summary>
		/// Demonstrates combining multiple techniques:
		/// - Pass by value (x, y)
		/// - Out parameters (sum, product)
		/// - Optional argument (operation)
		/// </summary>
		static void Calculate(int x, int y, out int sum, out int product, string operation = "both")
		{
			sum = 0;
			product = 0;

			if (operation == "add" || operation == "both")
			{
				sum = x + y;
			}

			if (operation == "multiply" || operation == "both")
			{
				product = x * y;
			}
		}
	}
}

/*
 * SUMMARY OF PARAMETER PASSING METHODS:
 * 
 * 1. PASS BY VALUE (default):
 *    - Method gets a COPY of the argument
 *    - Original variable is NOT modified
 *    - Use: Most common, safest approach
 * 
 * 2. PASS BY REFERENCE (ref):
 *    - Method gets a REFERENCE to original variable
 *    - Original variable IS modified
 *    - Variable MUST be initialized before passing
 *    - Use: When you need to modify the original variable
 * 
 * 3. OUT PARAMETERS (out):
 *    - Similar to ref, but for OUTPUT values
 *    - Variable does NOT need initialization before passing
 *    - Method MUST assign value before returning
 *    - Use: When method needs to return multiple values
 * 
 * 4. NAMED ARGUMENTS:
 *    - Pass arguments by parameter name
 *    - Order doesn't matter
 *    - Use: Improve readability, skip optional parameters
 * 
 * 5. OPTIONAL ARGUMENTS:
 *    - Parameters have default values
 *    - Can be omitted when calling method
 *    - Use: Provide flexibility without overloading
 * 
 * 6. METHOD OVERLOADING:
 *    - Multiple methods with same name
 *    - Different parameter types or counts
 *    - Compiler selects correct version based on arguments
 *    - Use: Provide multiple ways to call same operation
 * 
 * KEY DIFFERENCES: ref vs out
 * 
 * ref:
 * - Variable MUST be initialized before passing
 * - Method can read AND write
 * - Used when method modifies existing value
 * 
 * out:
 * - Variable does NOT need initialization
 * - Method can only write (must assign before return)
 * - Used when method returns multiple values
 * 
 * EXPECTED OUTPUT:
 * 
 * Before Increment: myNumber = 5
 * Inside Increment: number = 6
 * After Increment: myNumber = 5
 * 
 * Before IncrementRef: myRefNumber = 5
 * Inside IncrementRef: number = 6
 * After IncrementRef: myRefNumber = 6
 * 
 * a = 10, b = 20
 * 
 * Name: Alice, Age: 25
 * Name: Bob, Age: 30
 * 
 * Hello, Guest!
 * Hello, Alice!
 * Good morning, Bob!
 * 
 * Number: 10
 * Message: Hello
 * Double: 3.14
 * Result: 42
 */