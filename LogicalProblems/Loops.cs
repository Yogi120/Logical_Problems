using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class Loops
    {
        public void Multiplication()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Table of " + i + ": ");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
        }

        public double FractionSum(int num)
        {
            double fraction = 1;
            for (int i = 2; i <= fraction; i++)
            {
                fraction += 1 / (double)(i * i);
            }

            return fraction;
        }

        public string EvenNum(int num)
        {
            string EvenNumbers = "";
            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    EvenNumbers += i + " ";
                }
            }
            return EvenNumbers;
        }

        public int Biggest(int[] arr)
        {
            int biggest = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > biggest)
                {
                    biggest = arr[i];
                }
            }
            return biggest;
        }

        public int NextEachOther7s(int[] arr)
        {
            int adjacent = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 7 && arr[i + 1] == 7)
                {
                    adjacent++;
                }
            }
            return adjacent;
        }

        public bool Increasing(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i - 1] + 1 == arr[1] && arr[i + 1] - 1 == arr[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
