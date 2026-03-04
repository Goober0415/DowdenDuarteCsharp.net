// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: Sprocket.cs
// Date: February 3, 2026

using P6SprocketJDD;

namespace P6SprocketJDD
{
	/// <summary>
	/// Steel sprocket - $0.05 per tooth
	/// </summary>
	public class SteelSprocket : Sprocket
	{
		public override string Material => "steel";

		// Parameterless constructor
		public SteelSprocket() : base()
		{
		}

		// Three-parameter constructor
		public SteelSprocket(int itemID, int numItems, int numTeeth)
			: base(itemID, numItems, numTeeth)
		{
		}

		// Calculate price: $0.05 per tooth
		protected override void Calculate()
		{
			Price = NumTeeth * NumItems * 0.05m;
		}

		public override string ToString()
		{
			return base.ToString() + " Material: steel.";
		}
	}

	/// <summary>
	/// Aluminum sprocket - $0.04 per tooth
	/// </summary>
	public class AluminumSprocket : Sprocket
	{
		public override string Material => "aluminum";

		// Parameterless constructor
		public AluminumSprocket() : base()
		{
		}

		// Three-parameter constructor
		public AluminumSprocket(int itemID, int numItems, int numTeeth)
			: base(itemID, numItems, numTeeth)
		{
		}

		// Calculate price: $0.04 per tooth
		protected override void Calculate()
		{
			Price = NumTeeth * NumItems * 0.04m;
		}

		public override string ToString()
		{
			return base.ToString() + " Material: aluminum.";
		}
	}

	/// <summary>
	/// Plastic sprocket - $0.02 per tooth
	/// </summary>
	public class PlasticSprocket : Sprocket
	{
		public override string Material => "plastic";

		// Parameterless constructor
		public PlasticSprocket() : base()
		{
		}

		// Three-parameter constructor
		public PlasticSprocket(int itemID, int numItems, int numTeeth)
			: base(itemID, numItems, numTeeth)
		{
		}

		// Calculate price: $0.02 per tooth
		protected override void Calculate()
		{
			Price = NumTeeth * NumItems * 0.02m;
		}

		public override string ToString()
		{
			return base.ToString() + " Material: plastic.";
		}
	}
}
