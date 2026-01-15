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
			Console.WriteLine("return value: {0}\n", testValue);

			int testValue2 = 2;
			Console.WriteLine("\n");
			//Console.WriteLine("original value: {0}", testValue2);
			TestOut(out testValue2);
			Console.WriteLine("return out value: {0}\n", testValue2);

			int testValue3 = 3; //must be initialized
			Console.WriteLine("original value: {0}", testValue3);
			TestRef(ref testValue3);
			Console.WriteLine("return ref value: {0}\n", testValue3);

			Console.WriteLine("Calling testOptional without a parameter");
			TestOptional();
			Console.WriteLine("\n");
			Console.WriteLine("Calling testOptional with a parameter");
			TestOptional(79);
			Console.WriteLine("\n");

			Console.WriteLine("Calling TestMultiple with parameters");
			TestMultiple(1, 2, 3);
			Console.WriteLine("\n");
			Console.WriteLine("Calling TestMultiple without parameters");
			TestMultiple();
			Console.WriteLine("\n");
			Console.WriteLine("Calling TestMultiple with first two parameters");
			TestMultiple(4,5);
			Console.WriteLine("\n");
			Console.WriteLine("Calling TestMultiple with a name value");
			TestMultiple(6,cValue:27);
			Console.WriteLine("\n");
		}

		public static void Test(int aValue)
		{
			aValue = 111;
			Console.WriteLine("value is {0}", aValue);
		}

		// the folowing two methods retain their value after they are called "out" "ref"
		public static void TestOut(out int aValue)
		{
			aValue = 222;
			Console.WriteLine("test out value {0}", aValue);
		}

		public static void TestRef(ref int aValue)
		{
			aValue = 333;
			Console.WriteLine("test ref value {0}", aValue);
		}

		//default parameters
		public static void TestOptional(int aValue = 444) //default value is 444
		{
			Console.WriteLine("test optional value {0}", aValue);
		}

		//Multiple parameters
		public static void TestMultiple(int aValue = 123, int bValue = 234, int cValue = 345) //default value is 444
		{
			Console.WriteLine("test multiple values are {0} {1} {2}\n", aValue, bValue, cValue);
		}
	}
}

