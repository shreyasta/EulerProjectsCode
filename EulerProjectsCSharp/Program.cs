using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Loops
{
	class SumMultiples
	{
		// Main method
		public static void Main(string[] args)
		{
			List<int> multiplesList = new List<int>();
			for (int i = 1; i < 1000; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
					multiplesList.Add(i);
			}

			// finding the sum  of the multiples. 
			int sumMultiples = 0;
			// printing out the list value of multiples
			for (int j = 0; j < multiplesList.Count; j++)
			{
				Console.WriteLine("The multiples of 3 and 5 are {0}", multiplesList[j]);
				sumMultiples += multiplesList[j];
			}

			Console.WriteLine("The sum of the multiples of 3 and 5 are {0}", sumMultiples);


		}
	}
}