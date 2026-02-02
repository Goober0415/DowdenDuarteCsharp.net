// Name: [Jamie Dowden-Duarte]
// Email: [jdowdenduarte@cnm.edu]
// File: Student.cs
// Date: February 2, 2026

namespace StudentConstructorsDemo
{
	class Student
	{
		// Private fields
		private string studentNumber;
		private string studentFirstName;
		private string studentLastName;
		private int score1;
		private int score2;
		private int score3;
		private string major;
		private double average;

		//-------------------------------------
		// Constructors (using constructor chaining)
		//-------------------------------------

		// Default constructor - chains to the full constructor
		public Student()
			: this("Number Pending", "TBD", "TBD", -1, -1, -1, "Undeclared")
		{
		}

		// Single parameter constructor - chains to the full constructor
		public Student(string sID)
			: this(sID, "TBD", "TBD", -1, -1, -1, "Undeclared")
		{
		}

		// First overloaded constructor - chains to the full constructor
		public Student(string sID, string firstName, string lastName)
			: this(sID, firstName, lastName, -1, -1, -1, "Undeclared")
		{
		}

		// Second overloaded constructor - the "main" constructor that does all the work
		public Student(string sID, string firstName, string lastName, int s1, int s2, int s3, string maj)
		{
			studentNumber = sID;
			studentFirstName = firstName;
			studentLastName = lastName;
			score1 = s1;
			score2 = s2;
			score3 = s3;
			major = maj;
			CalcAverage();
		}

		//-------------------------------------
		// Destructor
		//-------------------------------------
		~Student()
		{
			Console.WriteLine("Student {0} data no longer in memory!", studentNumber);
		}

		//-------------------------------------
		// Properties
		//-------------------------------------

		public string StudentNumber
		{
			get { return studentNumber; }
			set { studentNumber = value; }
		}

		public string FirstName
		{
			get { return studentFirstName; }
			set { studentFirstName = value; }
		}

		public string LastName
		{
			get { return studentLastName; }
			set { studentLastName = value; }
		}

		public string Major
		{
			get { return major; }
			set { major = value; }
		}

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

		public double Average
		{
			get { return average; }
		}

		//-------------------------------------
		// Get methods (for demonstration)
		//-------------------------------------

		public string GetStudentNumber()
		{
			return studentNumber;
		}

		public string GetFirstName()
		{
			return studentFirstName;
		}

		public string GetLastName()
		{
			return studentLastName;
		}

		public string GetMajor()
		{
			return major;
		}

		public double GetAverage()
		{
			return average;
		}

		//-------------------------------------
		// Calculate method
		//-------------------------------------

		private void CalcAverage()
		{
			if (score1 >= 0 && score2 >= 0 && score3 >= 0)
			{
				average = (score1 + score2 + score3) / 3.0;
			}
			else
			{
				average = 0;
			}
		}

		//-------------------------------------
		// ToString override
		//-------------------------------------

		public override string ToString()
		{
			return studentFirstName + " " + studentLastName
				+ " ID: " + studentNumber
				+ " Major: " + major
				+ " Average: " + average.ToString("F2");
		}
	}
}