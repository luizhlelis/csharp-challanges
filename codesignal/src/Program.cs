using System;
using System.Text;

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
}
