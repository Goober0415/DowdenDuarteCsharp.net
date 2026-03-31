using System;
using System.Collections.Generic;
using System.Text;

namespace DataAdapterDemo
{
	public partial class StudentWindow : Window
	{
		private Student st;

		public Student Student
		{
			get { return st; }
			set { st = value; }
		}

		// Parameterless constructor chains to the one below
		public StudentWindow() : this(new Student()) { }

		public StudentWindow(Student st)
		{
			InitializeComponent();
			this.st = st;

			// Populate dropdowns from the database
			School school = new School();
			cbxCourse.ItemsSource = school.Course;
			cbxMajor.ItemsSource = school.Major;
		}

		// --- Add score button ---
		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{
			Assignment assign = new Assignment();
			assign.Title = cbxCourse.SelectedValue.ToString();
			assign.Score = int.Parse(txbScore.Text);  // Score setter validates range
			lbScores.Items.Add(assign);
		}

		// --- Submit button ---
		private void btnSubmit_Click(object sender, RoutedEventArgs e)
		{
			// Write form values into the Student object
			st.FirstName = txbFirstName.Text;
			st.LastName = txbLastName.Text;
			st.StudentNumber = txbStudentNum.Text;
			st.Major = cbxMajor.SelectedValue.ToString();

			// Collect assignments from list box
			List<Assignment> scores = new List<Assignment>();
			foreach (Assignment score in lbScores.Items)
				scores.Add(score);

			st.Scores = scores;     // Also triggers CalcAverage()

			// Show result in the TextBlock
			txbResults.Text = st.ToString();

			DialogResult = true;    // Signals caller that data is ready
			Close();
		}
	}
}

