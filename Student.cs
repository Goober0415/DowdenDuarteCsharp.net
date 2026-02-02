namespace StudentClassDemo
{
	class Student
	{
		// Private fields
		private string firstName;
		private string lastName;
		private string major;
		private string studentNumber;
		private int score1;
		private int score2;
		private int score3;
		private float average;

		// Constructor - initializes fields when object is created
		public Student()
		{
			firstName = "";
			lastName = "";
			major = "";
			studentNumber = "";
			score1 = 0;
			score2 = 0;
			score3 = 0;
			average = 0;
		}

		// Getters and Setters
		public string GetFirstName()
		{
			return firstName;
		}

		public void SetFirstName(string firstName)
		{
			this.firstName = firstName;
		}

		public string GetLastName()
		{
			return lastName;
		}

		public void SetLastName(string lastName)
		{
			this.lastName = lastName;
		}

		public string GetMajor()
		{
			return major;
		}

		public void SetMajor(string major)
		{
			this.major = major;
		}

		public string GetStudentNum()
		{
			return studentNumber;
		}

		public void SetStudentNumber(string studentNumber)
		{
			this.studentNumber = studentNumber;
		}

		public int GetScore1()
		{
			return score1;
		}

		public void SetScore1(int score1)
		{
			this.score1 = score1;
			Calc();
		}

		public int GetScore2()
		{
			return score2;
		}

		public void SetScore2(int score2)
		{
			this.score2 = score2;
			Calc();
		}

		public int GetScore3()
		{
			return score3;
		}

		public void SetScore3(int score3)
		{
			this.score3 = score3;
			Calc();
		}

		public float GetAverage()
		{
			return average;
		}

		public string GetSummary()
		{
			return firstName + " " + lastName + " " + studentNumber + " Average: " + average;
		}

		private void Calc()
		{
			average = (score1 + score2 + score3) / 3.0f;
		}
	}
}