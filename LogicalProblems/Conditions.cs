﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class Conditions
    {
        public double Absolute(double num)
        {
            if (num >= 0)
            {
                return num = num;
            }
            else
            {
                return num = num * -1;
            }
        }

        public int Divisible(int num1, int num2)
        {
            if (num1 % 2 == 0 && num2 % 2 == 0 || num1 % 2 == 0 && num2 % 3 == 0)
            {
                return num1 * num2;
            }

            else
            {
                return num1 + num2;
            }
        }

        public bool UppercaseString(string str)
        {
            return (str[0] >= 65 && str[1] >= 65 && str[2] >= 65 && str[0] <= 90 && str[1] <= 90 && str[2] <= 90);
        }

        public bool GreaterThanThirdOne(int num1, int num2, int num3)
        {
            if ((num1 + num2 == num3) || (num1 * num2 == num3))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool Evenodd(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string PosZerNeg(double num)
        {
            if (num > 0)
            {
                return "Positive";
            }
            else if (num == 0)
            {
                return "Zero";
            }
            else
            {
                return "Negative";
            }
        }

        public bool Neighbour(string word)
        {
            return (word[0] == word[1] - 1 || word[0] == word[1] + 1 || word[1] == word[2] - 1 || word[1] == word[2] + 1);

        }

        public bool Sort(int[] arr)
        {
            if (arr[0] < arr[1] && arr[1] < arr[2])
            {
                return true;
            }
            return false;
        }
    }
}
