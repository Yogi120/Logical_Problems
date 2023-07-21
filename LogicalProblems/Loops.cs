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

        public void Hourglass()
        {
            int num = 5;
            for (int i = 1; i <= num; i++)
            {
                for (int l = 1; l <= i; l++)
                {
                    Console.Write(" ");
                }
                for (int j = num; j >= i; j--)
                {
                    Console.Write("*");
                }
                for (int k = num - 1; k >= i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 2; i <= num; i++)
            {
                for (int j = num; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }

        public void Parallelogram()
        {
            int num = 10;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < num; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void ChristmasTree()
        {
            int num = 5;
            for (int i = 1; i <= num; i++)
            {
                for (int j = num; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= num; i++)
            {
                for (int j = num; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= num; i++)
            {
                for (int j = num; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public double PowerOf(int num, int exp)
        {
            return Math.Pow(num, exp);
        }

        public void Triangle()
        {
            int num = 10;
            for (int i = 1; i <= num; i++)
            {
                for (int j = num; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public int SumofNumbers(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }
            return sum;
        }

        public string SumAverage(int num1, int num2)
        {
            int sum = 0;
            decimal Avg = 0;
            int count = 0;
            for (int i = num1; i <= num2; i++)
            {

                sum += i;
                count++;
                num1 = num1 / 10;
                Avg = (decimal)sum / count;
            }
            return $"Sum = {sum} and Average = {Avg}";
        }
    }
}
