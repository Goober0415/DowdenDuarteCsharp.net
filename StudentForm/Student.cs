// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: Student.cs
// Date: February 3, 2026


namespace StudentForm
{
	class Student
	{
		//-------------------------------------
		// Private fields
		//-------------------------------------
		private int[] scores = new int[0];
		private string[] courses = new string[0];

		//-------------------------------------
		// Constructors
		//-------------------------------------

		// Default constructor
		public Student()
			: this("Number pending", "TBD", "TBD", "Undeclared")
		{
		}

		// Single parameter constructor
		public Student(string sID)
			: this(sID, "TBD", "TBD", "Undeclared")
		{
		}

		// Constructor when we have student ID information and major
		public Student(string sID, string firstName, string lastName, string maj)
		{
			Campus = "";
			StudentNumber = sID;
			FirstName = firstName;
			LastName = lastName;
			Major = maj;
		}

		// Constructor when we have student information and score information
		public Student(string sID, string firstName, string lastName, string maj, string[] courses, int[] scores)
			: this(sID, firstName, lastName, maj)
		{
			this.courses = courses;
			this.scores = scores;
			CalcAverage();
		}

		//-------------------------------------
		// Properties (with default values to fix nullable warnings)
		//-------------------------------------

		public string Major { get; set; } = "";
		public string FirstName { get; set; } = "";
		public string LastName { get; set; } = "";
		public string StudentNumber { get; set; } = "";
		public string Campus { get; set; } = "";
		public double Average { get; private set; }

		public int[] Scores
		{
			get
			{
				return scores;
			}
			set
			{
				scores = value;
				CalcAverage();
			}
		}

		public string[] Courses
		{
			get { return courses; }
			set { courses = value; }
		}

		//-------------------------------------
		// Instance methods
		//-------------------------------------

		/// <summary>
		/// Calculates average score from all scores
		/// </summary>
		private void CalcAverage()
		{
			if (scores == null || scores.Length == 0)
			{
				Average = 0;
				return;
			}

			int scoreTotal = 0;
			foreach (int score in scores)
			{
				scoreTotal += score;
			}

			Average = scoreTotal / (double)scores.Length; // Cast to double for decimal precision
		}

		/// <summary>
		/// Returns formatted string with student information
		/// </summary>
		public override string ToString()
		{
			string summary =
				"Student's Major is " + Major +
				"\r\nStudent's first name is " + FirstName +
				"\r\nStudent's last name is " + LastName +
				"\r\nStudent's campus is " + Campus +
				"\r\nStudent's average is " + Average.ToString("F2");

			if (courses != null && courses.Length > 0)
			{
				summary += "\r\nCourses: ";
				for (int i = 0; i < courses.Length; i++)
				{
					summary += "\r\n" + courses[i] + ": " + scores[i];
				}
			}

			return summary;
		}
	}
}