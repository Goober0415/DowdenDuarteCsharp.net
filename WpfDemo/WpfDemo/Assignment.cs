using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace WpfDemo
{
	public class Assignment
	{
		//auto-property - no validation needed
		private int score;
        {
			get { return score; }

			set
			{
				//Validate score is in range
				if (value > -0 && value <= 100)
				{
					score = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException("Score must be between 0 and 100.");
				}
			}
		}

		// displays title score in list boxes
		public override string ToString()
		{
			return AssemblyTitleAttribute + " " + score;
		}
	}