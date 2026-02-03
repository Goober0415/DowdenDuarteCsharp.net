// Name: [Your Name]
// Email: [Your Email]
// File: Program.cs
// Date: February 3, 2026

using System;

namespace DelegatesDemo
{
	class Program
	{
		//-------------------------------------
		// Delegate Definition
		//-------------------------------------
		delegate void DispStrDelegate(string param);
		static void Main(string[] args)
		{
			Console.WriteLine("==========================================");
			Console.WriteLine("Name: [Your Name]");
			Console.WriteLine("Program: Delegates Demo");
			Console.WriteLine("Objective: Demonstrate C# delegates");
			Console.WriteLine("==========================================\n");

			
			Console.WriteLine("=== PART 1: BASIC DELEGATES ===\n");

			// Get a line of text to convert
			Console.Write("Please enter some text: ");
			string text = Console.ReadLine();

			// Instantiate three delegate objects
			DispStrDelegate saying1 = new DispStrDelegate(Capitalize);
			DispStrDelegate saying2 = new DispStrDelegate(LowerCased);
			DispStrDelegate saying3 = new DispStrDelegate(Console.WriteLine);

			// Call them one after the other
			saying1(text);
			saying2(text);
			saying3(text);
			Console.WriteLine();

			//-------------------------------------
			// Part 2: Multi-cast Delegate
			//-------------------------------------
			Console.WriteLine("=== PART 2: MULTI-CAST DELEGATE ===\n");

			// Get another text line
			Console.Write("Please enter some text: ");
			text = Console.ReadLine();

			// Make a new delegate object and concatenate delegates
			DispStrDelegate sayings = new DispStrDelegate(Capitalize);
			sayings += new DispStrDelegate(LowerCased);
			sayings += new DispStrDelegate(Console.WriteLine);

			// Call the one delegate and run all three methods
			Console.WriteLine("Running multi cast directly: ");
			sayings(text);
			Console.WriteLine();

			//-------------------------------------
			// Part 3: Passing Delegate as Parameter
			//-------------------------------------
			Console.WriteLine("=== PART 3: PASSING DELEGATE AS PARAMETER ===\n");

			// Pass delegate as a method argument
			Console.WriteLine("Running by passing delegate to another method: ");
			RunMyDelegate(sayings, text);
			Console.WriteLine();

			//-------------------------------------
			// Part 4: Lambda Expressions
			//-------------------------------------
			Console.WriteLine("=== PART 4: LAMBDA EXPRESSIONS ===\n");

			// Create and run a lambda expression
			Console.WriteLine("Running by passing in a lambda expression: ");
			RunMyDelegate((string t) => { Console.WriteLine("Lambda: " + t); }, text);
			Console.WriteLine();

			//-------------------------------------
			// Part 5: Lambda Variations
			//-------------------------------------
			Console.WriteLine("=== PART 5: LAMBDA VARIATIONS ===\n");

			// Remove the type and let it be inferred
			Console.WriteLine("Lambda without type: ");
			RunMyDelegate((t) => { Console.WriteLine("Lambda: " + t); }, text);
			Console.WriteLine();

			// Remove the parenthesis
			Console.WriteLine("Lambda without parenthesis: ");
			RunMyDelegate(t => { Console.WriteLine("Lambda2: " + t); }, text);
			Console.WriteLine();

			//-------------------------------------
			// Part 6: Adding Lambda to Multicast
			//-------------------------------------
			Console.WriteLine("=== PART 6: LAMBDA IN MULTICAST ===\n");

			// Add a lambda expression to our delegate
			sayings += t => { Console.WriteLine("Lambda3: " + t); };
			Console.WriteLine("Three Delegates and a lambda: ");
			RunMyDelegate(sayings, text);
			Console.WriteLine();

			// Exit
			Console.WriteLine("\nPress any key to exit...");
			Console.ReadKey();
		}

		//-------------------------------------
		// Methods
		//-------------------------------------

		/// <summary>
		/// Method that capitalizes a string
		/// </summary>
		static void Capitalize(string text)
		{
			Console.WriteLine("Your input capitalized --> " + text.ToUpper());
		}

		/// <summary>
		/// Method that lower cases a string
		/// </summary>
		static void LowerCased(string text)
		{
			Console.WriteLine("Your input lower cased --> " + text.ToLower());
		}

		/// <summary>
		/// Method that takes a delegate as an argument
		/// </summary>
		/// <param name="del">The delegate to execute</param>
		/// <param name="textParam">The text parameter to pass to the delegate</param>
		static void RunMyDelegate(DispStrDelegate del, string textParam)
		{
			del(textParam);
		}
	}
}

/*
 * NOTES ON DELEGATES:
 * 
 * 1. BASIC DELEGATES:
 *    - Delegates are type-safe function pointers
 *    - They reference methods with matching signatures
 *    - Syntax: delegate returnType DelegateName(parameters);
 * 
 * 2. MULTI-CAST DELEGATES:
 *    - Can hold references to multiple methods
 *    - Use += to add methods to the delegate chain
 *    - Calling the delegate calls ALL methods in order
 * 
 * 3. DELEGATES AS PARAMETERS:
 *    - Delegates can be passed to methods just like any other parameter
 *    - This enables callback patterns and event handling
 * 
 * 4. LAMBDA EXPRESSIONS:
 *    - Anonymous functions (methods without names)
 *    - Syntax: (parameters) => { code }
 *    - Can be used anywhere a delegate is expected
 * 
 * 5. LAMBDA VARIATIONS:
 *    - Full: (string t) => { Console.WriteLine(t); }
 *    - Type inferred: (t) => { Console.WriteLine(t); }
 *    - No parenthesis (single param): t => { Console.WriteLine(t); }
 *    - Expression body (single statement): t => Console.WriteLine(t)
 * 
 * 6. REAL-WORLD USES:
 *    - Event handling (button clicks, etc.)
 *    - Callbacks (async operations)
 *    - LINQ queries
 *    - Sorting with custom comparisons
 */
