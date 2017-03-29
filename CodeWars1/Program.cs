using System;

namespace CodeWars1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] a = { 1, 2, 3, 4, 25 };
			int[] b = { 16, 4, 1, 9, 625 };
			int[] c = { 4, 1, 7, 5 };

			Console.WriteLine($"comp(a , b) = {comp(a, b)}");
			Console.WriteLine($"comp(a , c) = {comp(a, c)}");
		}

		public static bool comp(int[] a, int[] b)
		{
			if (a == null || b == null)
				return false;


			for (int i = 0; i < a.Length; i++)
			{
				bool doesBContainSquareOfA = false;

				for (int j = 0; j < b.Length; j++)
				{
					if (a[i] * a[i] == b[j])
					{
						doesBContainSquareOfA = true;
						break;
					}
				}

				if (doesBContainSquareOfA == false)
				{
					return false;
				}
			}

			return true;
		}




	}
}
