namespace StudentClassDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			string doAnother;

			do
			{
				Student st = new Student();

				string firstName = GetInput("First Name: ");
				st.SetFirstName(firstName);

				string lastName = GetInput("Last Name: ");
				st.SetLastName(lastName);

				string major = GetInput("Major: ");
				st.SetMajor(major);

				string studentNum = GetInput("Student Number: ");
				st.SetStudentNumber(studentNum);

				int score1 = int.Parse(GetInput("Score 1: "));
				st.SetScore1(score1);

				int score2 = int.Parse(GetInput("Score 2: "));
				st.SetScore2(score2);

				int score3 = int.Parse(GetInput("Score 3: "));
				st.SetScore3(score3);

				Console.WriteLine("\n" + st.GetSummary());

				doAnother = GetInput("\nDo another (y/n): ");

			} while (doAnother == "y");

			Console.WriteLine("\nThank you!");
		}

		private static string GetInput(string prompt)
		{
			Console.Write(prompt);
			return Console.ReadLine();
		}
	}
}