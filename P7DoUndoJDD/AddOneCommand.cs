// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: AddOneCommand.cs
// Date: February 4, 2026

using System.Collections.Generic;

namespace InventoryCommandApp
{
	/// <summary>
	/// Command to add one item to inventory
	/// Implements Command Pattern via IInventoryCommand interface
	/// </summary>
	class AddOneCommand : IInventoryCommand
	{
		// Item to add
		public InventoryItem Item { get; set; }

		// Target list to add item to
		public List<InventoryItem> TargetList { get; set; }

		/// <summary>
		/// Two-parameter constructor
		/// </summary>
		/// <param name="item">Item to add</param>
		/// <param name="targetList">List to add item to</param>
		public AddOneCommand(InventoryItem item, List<InventoryItem> targetList)
		{
			Item = item;
			TargetList = targetList;
		}

		/// <summary>
		/// Execute command - adds one item to the list
		/// </summary>
		public void Do()
		{
			TargetList.Add(Item);
		}

		/// <summary>
		/// Undo command - removes the item from the list
		/// </summary>
		public void Undo()
		{
			TargetList.Remove(Item);
		}
	}
}