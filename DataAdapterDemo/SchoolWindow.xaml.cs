using System;
using System.Collections.Generic;
using System.Text;

namespace DataAdapterDemo
{
	public partial class SchoolWindow : Window
	{
		School school;

		public SchoolWindow()
		{
			InitializeComponent();
			school = new School();
			lbCampuses.ItemsSource = school.Campus;
			lbCourses.ItemsSource = school.Course;
			lbMajor.ItemsSource = school.Major;
		}

		// --- Add Student button on Students tab ---
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Student newStudent = new Student();
			StudentWindow studentWindow = new StudentWindow(newStudent);
			studentWindow.ShowDialog();         // blocks until closed

			if (studentWindow.DialogResult == true)
				lbStudents.Items.Add(newStudent);
		}

		// --- Add Campus button on Campuses tab ---
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			string insStr = "INSERT INTO Campus(Name) VALUES (@Name);";
			string connStr = ConfigurationManager
				.ConnectionStrings["SchoolDB"].ConnectionString;

			using (SqlConnection conn = new SqlConnection(connStr))
			{
				SqlCommand insCmd = new SqlCommand(insStr, conn);
				insCmd.Parameters.AddWithValue("Name", txbCampus.Text);
				conn.Open();
				insCmd.ExecuteNonQuery();
			}


			// Refresh the list box
			school.Refresh();
			lbCampuses.ItemsSource = school.Campus;
			lbCampuses.Items.Refresh();
		}
	}
}
