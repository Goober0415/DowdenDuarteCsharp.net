namespace P4LogoStore
{
	public partial class LogoOrderForm : Form
	{
		public LogoOrderForm()
		{
			InitializeComponent();

			// Hide color controls initially
			lblNumberOfColors.Visible = false;
			textNumberColors.Visible = false;
		}

		private void checkLogo_CheckedChanged(object sender, EventArgs e)
		{
			// Show/hide color controls based on checkbox state
			lblNumberOfColors.Visible = checkLogo.Checked;
			textNumberColors.Visible = checkLogo.Checked;

			// Clear color value if unchecked
			if (!checkLogo.Checked)
			{
				textNumberColors.Text = "";
			}
		}

		private void buttonSubmit_Click(object sender, EventArgs e)
		{
			try
			{
				// Create LogoOrderItem using two-parameter constructor
				LogoOrderItem order = new LogoOrderItem(textEngrave.Text, checkLogo.Checked);

				// Set remaining properties from form controls
				order.ItemID = int.Parse(textOrderNumber.Text);
				order.NumItems = int.Parse(textNumberOfItems.Text);

				// Get selected item type from radio buttons
				if (radioPen.Checked)
					order.ItemType = "pen";
				else if (radioMug.Checked)
					order.ItemType = "mug";
				else if (radioUSB.Checked)
					order.ItemType = "usb";

				// Set number of colors (only if logo is checked)
				if (checkLogo.Checked && !string.IsNullOrWhiteSpace(textNumberColors.Text))
				{
					order.NumColors = int.Parse(textNumberColors.Text);
				}
				else
				{
					order.NumColors = 0; // No colors if no logo
				}

				// Display order summary in result textbox
				textResult.Text = order.GetOrderSummary();
			}
			catch (FormatException)
			{
				textResult.Text = "Error: Please enter valid numeric values for Order Number, Number of Items, and Number of Colors.";
			}
			catch (Exception ex)
			{
				textResult.Text = $"Error: {ex.Message}";
			}
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			// Clear all text boxes
			textOrderNumber.Text = "";
			textNumberOfItems.Text = "";
			textEngrave.Text = "";
			textNumberColors.Text = "";
			textSummary.Text = "";
			

			// Reset radio buttons (default to mug)
			radioMug.Checked = true;

			// Uncheck logo checkbox
			checkLogo.Checked = false;

			// Hide color controls
			lblNumberOfColors.Visible = false;
			textNumberColors.Visible = false;

			// Set focus to first field
			textOrderNumber.Focus();
		}
	}
}