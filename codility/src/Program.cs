using System;
using System.Collections.Generic;
using System.Linq;

namespace SourceCode
{
	public static class Utils
    {
		// O(n)
		public static int[] GetPrefixSum (this int[] A)
        {
			var prefixSum = new int[A.Length];
			prefixSum[0] = A[0];

			for (int i = 1; i < A.Length; i++)
				prefixSum[i] = A[i] + A[i - 1];

			return prefixSum;
		}

		// O(n)
		public static int[] GetSufixSum(this int[] A)
		{
			var sufixSum = new int[A.Length];
			sufixSum[A.Length - 1] = A[A.Length - 1];

			for (int i = A.Length - 2; i > -1; i--)
				sufixSum[i] = A[i] + A[i + 1];

			return sufixSum;
		}
	}

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

	public class FrogRiverOne
    {
		public int Solution(int X, int[] A)
        {
			var positions = new HashSet<int>();

			for (int i = 0; i < A.Length; i++)
            {
				positions.Add(A[i]);
				if (positions.Count() == X) // that's because elements in array are less than or equal to X
					return i;
			}

			return -1;
        }
	}

	// O(n)
	public class PassingCars
    {
		public int Solution(int[] A)
        {
			var goingToEast = new HashSet<int>();
			int pairs = 0;

			var prefixSum = new int[A.Length];

			prefixSum[0] = A[0];
            if (A[0] == 0)
				goingToEast.Add(0);

			for (int i = 1; i < A.Length; i++)
            {
                if (A[i] == 0)
					goingToEast.Add(i);

				prefixSum[i] = A[i] + prefixSum[i - 1];
			}

            foreach (var carToEastPosition in goingToEast)
            {
				if (pairs > 1e9)
					return -1;

				pairs += prefixSum[prefixSum.Length - 1] - prefixSum[carToEastPosition];
			}

			return pairs;
		}
	}

	public class NumberOfDiscIntersections
	{
		public int Solution(int[] A)
		{
			// key=left-border, value = circle-indexes
			var ranges = new Dictionary<int, HashSet<int>>();

			// key= one-circle, value = other-circle
			int intersections = 0;

			for (int i = 0; i < A.Length; i++)
            {
				for (int j = i - A[i]; j < i + A[i]; j++)
				{
					if (ranges.ContainsKey(j))
                    {
						ranges[j].Add(i);
						continue;
					}
					ranges.Add(j, new HashSet<int>() { i });
				}
			}

			foreach (var item in ranges)
				intersections += item.Value.Count/2;

			return intersections;
		}
	}
}
