namespace CollectionsDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			// 3.1 Initializing the list with corrected PascalCase methods
			List<string> names = new List<string>();

			names.Add("linus torvalds");
			names.Add("donald knuth");
			names.Add("grace hopper");

			// Initial display using a loop
			Console.WriteLine("--- Initial List ---");
			for (int i = 0; i < names.Count; ++i)
			{
				Console.WriteLine(names[i]);
			}

			// 3.3 Displaying Count and Capacity
			Console.WriteLine("\nCount of list: " + names.Count.ToString());
			Console.WriteLine("Capacity of list: " + names.Capacity.ToString());

			// 3.5 Adding more names
			names.Add("donald knuth");
			names.Add("jean bartik");
			Console.WriteLine("\n--- After adding 2 more names ---");
			Console.WriteLine("Count: " + names.Count);
			Console.WriteLine("Capacity: " + names.Capacity); // Should jump to 8

			// 3.8 Trim the list
			names.TrimExcess();
			Console.WriteLine("\n--- After TrimExcess ---");
			Console.WriteLine("Count: " + names.Count);
			Console.WriteLine("Capacity: " + names.Capacity); // Should match Count

			// 3.11 Remove item at index 3
			if (names.Count > 3)
			{
				names.RemoveAt(3);
			}

			// 3.13 Remove another item by name
			names.Remove("donald knuth");

			// 3.15 Interactive Menu
			string doAnother;
			do
			{
				Console.Clear();
				DisplayNames(names);
				Console.Write("(a)dd, (r)emove, (s)earch: ");
				string operation = Console.ReadLine().ToLower();

				switch (operation)
				{
					case "a":
						Console.Write("Name: ");
						names.Add(Console.ReadLine());
						break;

					case "r":
						Console.Write("Index or Name: ");
						string nameOrIndex = Console.ReadLine();
						int index;
						// Logic to handle both Index and Name removal
						if (int.TryParse(nameOrIndex, out index))
						{
							// Adjusting for 1-based display vs 0-based list
							if (index > 0 && index <= names.Count)
								names.RemoveAt(index - 1);
							else
								Console.WriteLine("Invalid index.");
						}
						else
						{
							names.Remove(nameOrIndex);
						}
						break;

					case "s":
						Console.Write("Name to search: ");
						string searchName = Console.ReadLine();
						// 3.15 Logic for index searching
						int foundIndex = names.IndexOf(searchName);
						Console.WriteLine("Index is " + (foundIndex + 1));
						break;
				}

				Console.Write("\nDo another (y/n)? ");
				doAnother = Console.ReadLine().ToLower();

			} while (doAnother == "y");
		}

		// 3.14 Extracted function to display the list
		private static void DisplayNames(List<string> names)
		{
			Console.WriteLine("--- Current List Elements ---");
			for (int i = 0; i < names.Count; ++i)
			{
				// Displaying as 1-based list for user friendliness
				Console.WriteLine((i + 1) + "; " + names[i]);
			}
			Console.WriteLine();
		}
	}
}