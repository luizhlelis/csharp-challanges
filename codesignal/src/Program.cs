using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace SourceCode
{
    public class Century
    {
        public int Solution(int year)
        {
            int century;
            if (year % 100 < 0)
                century = 1;
            else if (year % 100 == 0)
                century = year / 100;
            else
                century = year / 100 + 1;

            return century;
        }
    }

    public class Palindrome
    {
        public bool Solution(string inputString)
        {
            var backwardWord = new StringBuilder();
            if (inputString.Length == 1)
                return true;
            for (int i = inputString.Length - 1; i > -1; i--)
                backwardWord.Append(inputString[i]);

            return inputString.Equals(backwardWord.ToString());
        }
    }

    public class AdjancentElementsProduct
    {
        public int Solution(int[] inputArray)
        {
            var largestProduct = int.MinValue;
            var current = 0;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                current = inputArray[i] * inputArray[i + 1];
                if (largestProduct < current)
                    largestProduct = current;
            }

            return largestProduct;
        }
    }

    public class ShapeArea
    {
        public int Solution(int n)
        {
            return (int) (Math.Pow(n, 2) + Math.Pow(n - 1, 2));
        }
    }

    public class MakeArrayConsecutive
    {
        public int Solution(int[] statues)
        {
            var count = 0;
            var diffBetweenConsecutive = 0;
            Array.Sort(statues);

            if (statues.Length == 1)
                return 0;

            for (int i = 0; i < statues.Length - 1; i++)
            {
                diffBetweenConsecutive = statues[i + 1] - statues[i];
                if (diffBetweenConsecutive > 1)
                    count = diffBetweenConsecutive - 1 + count;
            }
            return count;
        }
    }

    public class AlmostIncreasingSequence
    {
        public bool Solution(int[] sequence)
        {
            var alreadyRemoved = false;
            var newList = new List<int> {};

            for (var i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                {
                    if (alreadyRemoved == true)
                        return false;

                    alreadyRemoved = true;

                    if (i == 0)
                    {
                        newList.AddRange(sequence.Skip(i + 1));
                        break;
                    }
                    else if (i + 1 == sequence.Length - 1)
                        return true;

                    if (sequence[i-1] < sequence[i+1])
                        newList.AddRange(sequence.Skip(i + 1));
                    else if (i + 2 < sequence.Length && sequence[i] < sequence[i+2])
                        newList.AddRange(sequence.Skip(i + 2));
                    else
                        return false;

                    break;
                }
            }

            if (!alreadyRemoved)
                return true;

            for (var i = 0; i < newList.Count - 1; i++)
            {
                if (newList[i] >= newList[i + 1])
                    return false;
            }

            return true;
        }
    }

    public class MatrixElementsSum
    {
        public int Solution(int[][] matrix)
        {
            List<int> columnNotSum = new List<int>();
            int totalSum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (!columnNotSum.Contains(j))
                        totalSum += matrix[i][j];

                    if (matrix[i][j] == 0)
                        columnNotSum.Add(j);
                }
            }

            return totalSum;
        }
    }
}
