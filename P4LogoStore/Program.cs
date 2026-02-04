// Name: [Jamie Dowden-Duate
// Email: [jdowdenduarte@cnm.edu]
// File: LogoOrderItem.cs
// Date: February 3, 2026
using System;
using System.Windows.Forms;

namespace P4LogoStore
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LogoOrderForm());  // ← Matches your form name
		}
	}
}