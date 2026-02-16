// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: Program.cs
// Date: February 3, 2026

using System;

namespace CustomExceptions
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("==========================================");
			Console.WriteLine("Custom Exceptions Demo");
			Console.WriteLine("==========================================\n");

			string doAnother;

			do
			{
				try
				{
					Console.Write("Please enter a social security number (XXX-XX-XXXX): ");
					string userInput = Console.ReadLine();

					SocialSecurityNumber ssn = new SocialSecurityNumber();
					ssn.SSN = userInput;

					Console.WriteLine("Valid SSN: " + ssn.SSN);
				}
				catch (SSNFormatException exc)
				{
					// Catch our custom exception
					Console.WriteLine("Error! " + exc.Message);
					Console.WriteLine("Exception type: " + exc.GetType());
				}
				catch (Exception exc)
				{
					// Catch any other exceptions
					Console.WriteLine("Error! " + exc.Message);
					Console.WriteLine("Exception type: " + exc.GetType());
				}
				finally
				{
					// This section always executes!
					Console.WriteLine("(Finally block always executes)");
				}

				Console.WriteLine();
				Console.Write("Do another (y/n): ");
				doAnother = Console.ReadLine();
				Console.WriteLine();

			} while (doAnother.ToLower() == "y");

			Console.WriteLine("\n--- Division Demo (Multiple Exception Types) ---\n");
			DivisionDemo();

			Console.WriteLine("\nPress any key to exit...");
			Console.ReadKey();
		}

		/// <summary>
		/// Demonstrates catching multiple exception types
		/// </summary>
		static void DivisionDemo()
		{
			string doAnother;

			do
			{
				try
				{
					Console.Write("Please enter num1: ");
					string num1str = Console.ReadLine();
					int num1 = int.Parse(num1str);

					Console.Write("Please enter num2: ");
					string num2str = Console.ReadLine();
					int num2 = int.Parse(num2str);

					Console.WriteLine("Num1/Num2: {0}", num1 / num2);
				}
				catch (FormatException exc)
				{
					Console.WriteLine("Not a number!");
				}
				catch (OverflowException exc)
				{
					Console.WriteLine("Number is too large or small!");
				}
				catch (DivideByZeroException exc)
				{
					Console.WriteLine("Cannot divide by zero!");
				}
				catch (Exception exc)
				{
					Console.WriteLine("Error! " + exc.Message + "\nException type: " + exc.GetType());
				}
				finally
				{
					Console.WriteLine("This section always executes!");
				}

				Console.WriteLine();
				Console.Write("Do another (y/n): ");
				doAnother = Console.ReadLine();
				Console.WriteLine();

			} while (doAnother.ToLower() == "y");
		}
	}
}

/*
 * KEY CONCEPTS DEMONSTRATED:
 * 
 * 1. TRY-CATCH-FINALLY:
 *    - try: Code that might throw exceptions
 *    - catch: Handle specific exception types
 *    - finally: Always executes (even after exception)
 * 
 * 2. MULTIPLE CATCH BLOCKS:
 *    - Catch specific exceptions first (FormatException, OverflowException)
 *    - Generic Exception catch block last (catches anything not already caught)
 *    - Order matters! Specific to general
 * 
 * 3. THROWING EXCEPTIONS:
 *    - Use 'throw new ExceptionType()' to raise an exception
 *    - Can throw from anywhere (properties, methods, constructors)
 * 
 * 4. CUSTOM EXCEPTIONS:
 *    - Create by inheriting from Exception class
 *    - class SSNFormatException : Exception
 *    - Provide custom constructors with default messages
 *    - Use base() to call parent Exception constructors
 * 
 * 5. EXCEPTION PROPERTIES:
 *    - exc.Message: Error message
 *    - exc.GetType(): Exception type
 *    - exc.StackTrace: Call stack when error occurred
 * 
 * TEST CASES FOR DIVISION DEMO:
 * 
 * Num1    Num2    Expected Exception
 * ----    ----    ------------------
 * 5       2       No exception (result: 2)
 * One     5       FormatException
 * <blank> 3       FormatException
 * 5       0       DivideByZeroException
 * 2147483647  5   No exception
 * 2147483648  5   OverflowException
 * 
 * TEST CASES FOR SSN:
 * 
 * Input           Valid?
 * -----           ------
 * 123-45-6789     Valid ✓
 * 12-45-6789      Invalid (SSNFormatException)
 * 123456789       Invalid (SSNFormatException)
 * abc-de-fghi     Invalid (SSNFormatException)
 * 123-45-67890    Invalid (SSNFormatException)
 */
