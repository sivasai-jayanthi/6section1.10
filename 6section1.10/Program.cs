using System;
using System.Text;

namespace _6section1._10
{
	class Program
	{
		static void Main(string[] args)
		{
			doApp();
			Console.ReadLine();
		}

		public static void doApp()
		{
			string duke = "sai has duke 390";
			Console.WriteLine("Original string=" + duke);
			Console.WriteLine("Clone of a string =" + duke.Clone());
			Console.WriteLine("Compare two strings =" + duke.CompareTo("sai has a duke 200"));
			Console.WriteLine("Characters in a string =" + duke.Contains("r"));
			Console.WriteLine("String ending with =" + duke.EndsWith("390"));
			Console.WriteLine("All lowercase =" + duke.ToLower());
			Console.WriteLine("All uppercase =" + duke.ToUpper());
			Console.WriteLine("Insert string within a string =" + duke.Insert(4, " and siva "));
			Console.WriteLine("Splitting string into words:");
			string[] parts = duke.Split();
			foreach (string p in parts)
			{
				Console.WriteLine(p);
			}

			StringBuilder sb = new StringBuilder("");
			for (int i = 0; i < 10; i++)
			{
				sb.Append(i.ToString() + " ");
			}
			Console.WriteLine(sb.ToString());

		}
	}
}

