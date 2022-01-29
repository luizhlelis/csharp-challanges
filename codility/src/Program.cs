using System;
using System.Collections.Generic;
using System.Linq;

namespace SourceCode
{
	public class BinaryGap
	{
		public int Solution(int N)
		{
			bool started = false;
			int length = 0, max = 0;
			for (uint i = 1; i <= N; i <<= 1)
			{
				if ((i & N) != 0)
				{
					if (started)
					{
						if (length > max)
							max = length;
						length = 0;
					}
					started = true;
				}
				else if (started)
					++length;
			}
			return max;
		}
	}

	public class CyclicRotation
	{
		public int[] Solution(int[] A, int K)
		{
			var resultArray = new int[A.Length];

			if (A.Length > 0)
			{
				int firstIterationK = K % A.Length;

				for (int i = 0; i < A.Length; i++)
				{
					if (i + firstIterationK < A.Length)
						resultArray[i + firstIterationK] = A[i];
					else
						resultArray[firstIterationK - (A.Length - i)] = A[i];
				}
			}

			return resultArray;
		}
	}

	public class OddOccurrencesInArray
	{
		public int Solution(int[] A)
		{
			var hash = new HashSet<int>();

			for (int i = 0; i < A.Length; i++)
            {
				if (hash.Contains(A[i]))
					hash.Remove(A[i]);
				else
					hash.Add(A[i]);
			}

			return hash.First();
		}
	}

	public class FrogJmp
    {
		public int Solution(int X, int Y, int D)
        {
			var minValue = (double)(Y - X) / D;

			return (int)Math.Ceiling(minValue);
		}
	}

	public class PermMissingElem
    {
		public int Solution(int[] A)
        {
            if (A.Length < 1)
				return 1;

			Array.Sort(A);

			if (A[0] != 1)
				return 1;

			for (int i = 0; i < A.Length - 1; i++)
				if (A[i + 1] - A[i] > 1)
					return A[i] + 1;

			return A[A.Length-1]+1;
		}
	}
}
