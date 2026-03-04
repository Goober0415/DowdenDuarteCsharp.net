// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: InventoryItem.cs
// Date: February 4, 2026

namespace InventoryCommandApp
{
	/// <summary>
	/// Represents an item in the inventory
	/// </summary>
	public class InventoryItem
	{
		public string Name { get; set; }

		/// <summary>
		/// Single parameter constructor
		/// </summary>
		/// <param name="name">Name of the inventory item</param>
		public InventoryItem(string name)
		{
			Name = name;
		}

		/// <summary>
		/// Returns the name of the item
		/// </summary>
		public override string ToString()
		{
			return Name;
		}
	}
}
