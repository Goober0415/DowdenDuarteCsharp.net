using System.Diagnostics;

namespace StudentForm
{
	public partial class FormStudentInfo : Form
	{
		public FormStudentInfo()
		{
			InitializeComponent();
		}

		private void buttonSubmit_Click(object sender, EventArgs e)
		{
			//get major from the form
			string major = "TBD";
			if (radioIT.Checked) major = radioIT.Text;
			else if (radioProgramming.Checked) major = radioProgramming.Text;
			else if (radioWebDesign.Checked) major = radioWebDesign.Text;

			//Instantiate a student
			Student st = new Student(textStudentID.Text, textFirstName.Text, textLastName.Text, major);

			//Set student properties from form - FIXED: null check
			st.Campus = comboCampus.SelectedItem?.ToString() ?? "";

			int count = 0;
			if (checkBoxCIS101.Checked) count++;
			if (checkBoxCIS102.Checked) count++;
			if (checkBoxCIS103.Checked) count++;
			if (checkBoxCIS104.Checked) count++;

			int i = 0;
			string[] courses = new string[count];
			int[] scores = new int[count];

			if (checkBoxCIS101.Checked)
			{
				courses[i] = checkBoxCIS101.Text;
				int.TryParse(textBoxScore1.Text, out scores[i++]);
			}

			if (checkBoxCIS102.Checked)
			{
				courses[i] = checkBoxCIS102.Text;
				int.TryParse(textBoxScore2.Text, out scores[i++]);
			}

			if (checkBoxCIS103.Checked)
			{
				courses[i] = checkBoxCIS103.Text;
				int.TryParse(textBoxScore3.Text, out scores[i++]);
			}

			if (checkBoxCIS104.Checked)
			{
				courses[i] = checkBoxCIS104.Text;
				int.TryParse(textBoxScore4.Text, out scores[i++]);
			}

			//Set new arrays in student object
			st.Scores = scores;
			st.Courses = courses;

			//Display to string in result textbox
			textBoxResult.Text = st.ToString();
		}

		private void Hackster_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// FIXED: Modern way to open browser
			System.Diagnostics.Process.Start(new ProcessStartInfo
			{
				FileName = "https://www.hackster.io/jamiedowden-duarte",
				UseShellExecute = true
			});
			Hackster.LinkVisited = true;
		}

		private void pictureBoxDuckie_Click(object sender, EventArgs e)
		{
			// FIXED: Modern way to open browser
			System.Diagnostics.Process.Start(new ProcessStartInfo
			{
				FileName = "https://www.linkedin.com/in/embeddedcodingjamiedowdenduarte/",
				UseShellExecute = true
			});
		}
	}
}