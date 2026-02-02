// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: Student.cs
// Date: February 2, 2026

namespace StudentPropertiesDemo
{
	class Student
	{
		// Auto-Implemented Properties (no calculation needed)
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string StudentNumber { get; set; }
		public string Major { get; set; }

		// Read-only property with private setter (calculated value)
		public double Average { get; private set; }

		// Private fields for scores (need to trigger calculation)
		private int score1;
		private int score2;
		private int score3;

		// Fully-defined properties for scores (call CalcAverage when set)
		public int Score1
		{
			get { return score1; }
			set { score1 = value; CalcAverage(); }
		}

		public int Score2
		{
			get { return score2; }
			set { score2 = value; CalcAverage(); }
		}

		public int Score3
		{
			get { return score3; }
			set { score3 = value; CalcAverage(); }
		}

		// Constructor - initializes properties
		public Student()
		{
			FirstName = "";
			LastName = "";
			StudentNumber = "";
			Major = "";
			Score1 = 0;
			Score2 = 0;
			Score3 = 0;
			Average = 0;
		}

		// Calculate average (called automatically when scores change)
		public void CalcAverage()
		{
			Average = (score1 + score2 + score3) / 3.0;
		}

		// Override ToString for formatted output
		public override string ToString()
		{
			return FirstName + " " + LastName
				+ " Major: " + Major
				+ " Average: " + Average.ToString("F2");
		}
	}
}