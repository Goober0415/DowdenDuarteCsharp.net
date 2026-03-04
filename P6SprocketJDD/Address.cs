// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: Address.cs
// Date: February 3, 2026

namespace P6SprocketJDD
{
	/// <summary>
	/// Represents a shipping address
	/// </summary>
	public class Address
	{
		public string Street { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }

		/// <summary>
		/// Parameterless constructor
		/// </summary>
		public Address()
		{
			Street = "";
			City = "";
			State = "";
			ZipCode = "";
		}

		/// <summary>
		/// Four-parameter constructor
		/// </summary>
		public Address(string street, string city, string state, string zipCode)
		{
			Street = street;
			City = city;
			State = state;
			ZipCode = zipCode;
		}

		/// <summary>
		/// Returns formatted address string
		/// </summary>
		public override string ToString()
		{
			return $"{Street}\n{City} {State} {ZipCode}";
		}
	}
}