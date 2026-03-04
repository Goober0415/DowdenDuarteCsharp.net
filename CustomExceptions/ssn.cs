// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: SocialSecurityNumber.cs
// Date: February 3, 2026

using System;
using System.Text.RegularExpressions;

namespace CustomExceptions
{
	/// <summary>
	/// Represents a Social Security Number with validation
	/// </summary>
	class SocialSecurityNumber
	{
		private string ssn;

		/// <summary>
		/// SSN property with validation
		/// Format must be: XXX-XX-XXXX (where X is a digit)
		/// </summary>
		public string SSN
		{
			get { return ssn; }
			set
			{
				// Regex pattern for SSN format: XXX-XX-XXXX
				string pattern = @"^\d{3}-\d{2}-\d{4}$";

				if (Regex.IsMatch(value, pattern))
				{
					ssn = value;
				}
				else
				{
					// Throw custom exception for invalid format
					throw new SSNFormatException();
				}
			}
		}

		// Default constructor
		public SocialSecurityNumber()
		{
			ssn = "";
		}

		// Override ToString for display
		public override string ToString()
		{
			return ssn;
		}
	}
}