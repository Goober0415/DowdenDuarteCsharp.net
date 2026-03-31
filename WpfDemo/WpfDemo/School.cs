using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace WpfDemo
{
	class School
	{
		private List<string> course;
		private List<string> major;
		private List<string> campus;
		private List<string> student;

		public List<string> Course { get { return course; } set { course = value; } }
		public List<string> Major { get { return major; } set { major = value; } }
		public List<string> Campus { get { return campus; } set { campus = value; } }
		public List<string> Student { get { return student; } set { student = value; } }

		public School()
		{
			Refresh();
		}

		/// <summary>
		/// Re-queries all three reference tables.
		/// </summary>
		public void Refresh()
		{
			campus = GetData("SELECT * FROM Campus");
			course = GetData("SELECT * FROM Course");
			major = GetData("SELECT * FROM Major");
		}

		/// <summary>
		/// Executes a SELECT and returns column 1 from every row.
		/// </summary>
		private List<string> GetData(string sqlStr)
		{
			List<string> items = new List<string>();
			string connStr = ConfigurationManager
				.ConnectionStrings["SchoolDB"].ConnectionString;

			using (SqlConnection conn = new SqlConnection(connStr))
			{
				SqlCommand selectCmd = new SqlCommand(sqlStr, conn);
				conn.Open();
				SqlDataReader dr = selectCmd.ExecuteReader();
				while (dr.Read())
					items.Add(dr.GetString(1));   // column index 1 = Name
			}
			return items;
		}
	}
}
