using System;
using System.Collections.Generic;
// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: IInventoryCommand.cs
// Date: February 4, 2026

namespace InventoryCommandApp
{
	/// <summary>
	/// Command Pattern Interface
	/// All command objects must implement Do() and Undo() methods
	/// </summary>
	interface IInventoryCommand
	{
		/// <summary>
		/// Execute the command
		/// </summary>
		void Do();

		/// <summary>
		/// Reverse the command
		/// </summary>
		void Undo();
	}
}