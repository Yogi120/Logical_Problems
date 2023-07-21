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
    }
}
