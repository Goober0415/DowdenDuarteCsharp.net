// Name: [Jamie Dowden-Duarte]
// Email: [jdowden-duarte@cnm.edu]
// File: SSNFormatException.cs
// Date: February 3, 2026

using System;

namespace CustomExceptions
{
	/// <summary>
	/// Custom exception for invalid Social Security Number format
	/// Inherits from Exception class
	/// </summary>
	class SSNFormatException : Exception
	{
		// Parameterless constructor - sets default message
		public SSNFormatException()
			: base("Not a valid Social Security Number.")
		{
		}

		// Constructor with custom message
		public SSNFormatException(string message)
			: base(message)
		{
		}

		// Constructor with custom message and inner exception
		public SSNFormatException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}