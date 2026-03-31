using System;
using System.Collections.Generic;
using System.Text;

namespace DataAdapterDemo
{
	public partial class MainWindow : Window
		{
			public MainWindow()
			{
				InitializeComponent();
			}

			private void btnButton_Click(object sender, RoutedEventArgs e)
			{
				// Start with what the user typed
				lblResult.Content = txbUserInput.Text;

				// Append each checked CheckBox
				if (cbCheck1.IsChecked == true) lblResult.Content += "Checked1!";
				if (cbCheck2.IsChecked == true) lblResult.Content += "Checked2!";
				if (cbCheck3.IsChecked == true) lblResult.Content += "Checked3!";

				// Radio group 1 — only one can be true
				if (rbOption1.IsChecked == true) lblResult.Content += "Option1!";

			    else if (rbOption2.IsChecked == true) lblResult.Content += "Option2!";
			    else if (rbOption3.IsChecked == true) lblResult.Content += "Option3!";

			// Radio group 2
			    if (rbOption4.IsChecked == true) lblResult.Content += "Option4!";
			    else if (rbOption5.IsChecked == true) lblResult.Content += "Option5!";
			    else if (rbOption6.IsChecked == true) lblResult.Content += "Option6!";
		}
	}
}
