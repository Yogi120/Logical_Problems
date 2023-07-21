using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class Strings
    {
        public bool Palindrome(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str[str.Length - 1])
                {
                    return true;
                }
            }
            return false;
        }

        public int LengthofString(string str)
        {
            int count = 0;
            foreach (char strs in str)
            {
                count++;
            }
            return count;
        }

        public string Reverse(string str)
        {
            string Reverse = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Reverse += str[i];
            }
            return Reverse;
        }

        public int SumDigitString(string str)
        {
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    sum += (int)Char.GetNumericValue(str[i]);
                }
            }
            return sum;
        }

        public bool Equalbrackets(string str)
        {
            int count = 0;

            for(int i=0; i<str.Length; i++)
            {
                if (str[i] == '(')
                {
                    count++;
                }
                else if (str[i] == ')')
                {
                    count--;
                }
            }
            if (count == 0)
            {
                return true;
            }
            return false;
        }

        public string Addseperator(string str, string separator)
        {
            string result = "";

            for(int i=0; i<str.Length; i++)
            {
                result += str[i];

                if (i < str.Length - 1)
                {
                    result += separator;
                }
            }
            return result;
        }
    }
}
