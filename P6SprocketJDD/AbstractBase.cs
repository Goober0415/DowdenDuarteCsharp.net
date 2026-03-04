// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: Sprocket.cs
// Date: February 3, 2026

namespace P6SprocketJDD
{
	/// <summary>
	/// Abstract base class for all sprocket types
	/// </summary>
	public abstract class Sprocket
	{
		// Private backing fields
		private int numItems;
		private int numTeeth;

		/// <summary>
		/// Item ID (read-only)
		/// </summary>
		public int ItemID { get; private set; }

		/// <summary>
		/// Number of sprocket items ordered
		/// </summary>
		public int NumItems
		{
			get { return numItems; }
			set
			{
				numItems = value;
				Calculate();
			}
		}

		/// <summary>
		/// Number of teeth on each sprocket
		/// </summary>
		public int NumTeeth
		{
			get { return numTeeth; }
			set
			{
				numTeeth = value;
				Calculate();
			}
		}

		/// <summary>
		/// Total price (read-only, calculated)
		/// </summary>
		public decimal Price { get; protected set; }

		/// <summary>
		/// Abstract material name (implemented by derived classes)
		/// </summary>
		public abstract string Material { get; }

		/// <summary>
		/// Parameterless constructor
		/// </summary>
		public Sprocket()
		{
			ItemID = 0;
			numItems = 0;
			numTeeth = 0;
			Price = 0;
		}

		/// <summary>
		/// Three-parameter constructor
		/// </summary>
		public Sprocket(int itemID, int numItems, int numTeeth)
		{
			ItemID = itemID;
			this.numItems = numItems;
			this.numTeeth = numTeeth;
			Calculate();
		}

		/// <summary>
		/// Abstract calculate method - implemented by derived classes
		/// Business logic: Price = numTeeth × numItems × pricePerTooth
		/// </summary>
		protected abstract void Calculate();

		/// <summary>
		/// Returns formatted string representation
		/// </summary>
		public override string ToString()
		{
			return $"Order num: {ItemID} Number: {NumItems} Teeth: {NumTeeth} Price: {Price:C}";
		}
	}
}
