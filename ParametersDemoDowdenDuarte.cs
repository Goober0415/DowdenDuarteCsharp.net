using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametersDemoDowdenDuarte
{
	class Program
	{
		static void Main(string[] args)
		{
			int testValue = 1;
			Console.WriteLine("original value: {0}", testValue);
			Test(testValue);
			Console.WriteLine("return value: {0}", testValue);

			int testValue2 = 2;
			Console.WriteLine("original value: {0}", testValue2);
			TestOut(out testValue2);
			Console.WriteLine("return value: {0}", testValue2);
		}
		public static void Test(int aValue)
		{
			aValue = 111;
			Console.WriteLine("value is {0}", aValue);
		}

		public static void TestOut(out int aValue)
		{
			aValue = 222;
			Console.WriteLine("test out value {0}", aValue);
		}
	}
}

