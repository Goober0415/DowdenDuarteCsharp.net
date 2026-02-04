// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: LogoOrderItem.cs
// Date: February 3, 2026

using System;

namespace P4LogoStore  
{
	class LogoOrderItem
	{
		//-------------------------------------
		// Private backing fields
		//-------------------------------------
		private bool hasLogo;
		private string itemType;
		private int numColors;
		private int numItems;
		private string text;

		//-------------------------------------
		// Auto-implemented properties
		//-------------------------------------
		public int ItemID { get; set; }

		//-------------------------------------
		// Read-only auto-property
		//-------------------------------------
		public decimal TotalPrice { get; private set; }

		//-------------------------------------
		// Properties with backing fields
		//-------------------------------------
		public bool HasLogo
		{
			get { return hasLogo; }
			set { hasLogo = value; Calc(); }
		}

		public string ItemType
		{
			get { return itemType; }
			set { itemType = value; Calc(); }
		}

		public int NumColors
		{
			get { return numColors; }
			set { numColors = value; Calc(); }
		}

		public int NumItems
		{
			get { return numItems; }
			set { numItems = value; Calc(); }
		}

		public string Text
		{
			get { return text; }
			set { text = value; Calc(); }
		}

		//-------------------------------------
		// Constructors
		//-------------------------------------

		// Full constructor
		public LogoOrderItem(int itemID, string itemType, int numColors, int numItems, string text, bool hasLogo)
		{
			ItemID = itemID;
			this.itemType = itemType;
			this.numColors = numColors;
			this.numItems = numItems;
			this.text = text;
			this.hasLogo = hasLogo;
			Calc();
		}

		// Two parameter constructor
		public LogoOrderItem(string text, bool hasLogo)
			: this(-1, "mug", 0, 0, text, hasLogo)
		{
		}

		// Parameterless constructor
		public LogoOrderItem()
			: this(-1, "mug", 0, 0, "", false)
		{
		}

		//-------------------------------------
		// Private Calculate Method
		//-------------------------------------
		private void Calc()
		{
			decimal basePrice = 0;
			decimal textPrice = 0;
			decimal logoPrice = 0;
			decimal colorPrice = 0;

			// Base price by item type
			switch (itemType.ToLower())
			{
				case "pen":
					basePrice = 1.00m;
					break;
				case "mug":
					basePrice = 3.50m;
					break;
				case "usb":
					basePrice = 4.00m;
					break;
			}

			// Text price
			if (!string.IsNullOrWhiteSpace(text))
			{
				textPrice = 0.05m;
			}

			// Logo and color pricing
			if (hasLogo)
			{
				logoPrice = 0.10m;
				colorPrice = numColors * 0.03m;
			}

			// Total = (base + text + logo + colors) × quantity
			TotalPrice = (basePrice + textPrice + logoPrice + colorPrice) * numItems;
		}

		//-------------------------------------
		// GetOrderSummary Method
		//-------------------------------------
		public string GetOrderSummary()
		{
			string summary = $"Order num {ItemID}: {NumItems} {ItemType}s";

			if (hasLogo)
			{
				summary += $" with {NumColors} color logo";
			}

			if (!string.IsNullOrWhiteSpace(text))
			{
				summary += $" with the following text: {text}";
			}

			summary += $" Price: {TotalPrice:C}";

			return summary;
		}
	}
}
