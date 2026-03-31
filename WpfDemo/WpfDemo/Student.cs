using System;
using System.Collections.Generic;
using System.Text;

namespace WpfDemo
{
	/// <summary>
	/// Stores information related to one student.
	/// </summary>
	public class Student
	{
		#region Properties
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string StudentNumber { get; set; }
		public string Major { get; set; }
		public double Average { get; private set; }

		private List<Assignment> scores;

		public List<Assignment> Scores
		{
			get { return scores; }
			set { scores = value; CalcAverage(); }  // Recalculate on set
		}
		#endregion

		#region Constructors

		/// <summary>
		/// Defaults StudentNumber to "Number Pending",
		/// names to "TBD", Major to "Undeclared".
		/// </summary>
		public Student()
			: this("Number Pending", "TBD", "TBD", "Undeclared") { }

		/// <summary>
		/// Defaults names to "TBD", Major to "Undeclared".
		/// </summary>
		public Student(string sID)
			: this(sID, "TBD", "TBD", "Undeclared") { }

		/// <summary>
		/// Sets all fields except scores.
		/// </summary>
		public Student(string sID, string firstName,
					   string lastName, string maj)
		{
			StudentNumber = sID;
			FirstName = firstName;
			LastName = lastName;
			Major = maj;
			scores = new List<Assignment>();
		}

		/// <summary>
		/// Sets all fields including a list of scores.
		/// </summary>
		public Student(string sID, string firstName, string lastName,
					   string maj, List<Assignment> scores)
			: this(sID, firstName, lastName, maj)
		{
			this.scores = scores;
			CalcAverage();
		}
		#endregion

		#region Instance Methods

		/// <summary>
		/// Calculates the average of all assignment scores.
		/// </summary>
		public void CalcAverage()
		{
			double sum = 0;
			foreach (Assignment assignment in scores)
				sum += assignment.Score;
			Average = sum / scores.Count;
		}

		/// <summary>
		/// Returns "FirstName LastName  Major: X  Average: X.XX"
		/// </summary>
		public override string ToString()
		{
			return FirstName + " " + LastName
				+ " Major: " + Major
				+ " Average: " + Average.ToString("f2");
		}
		#endregion
	}
}