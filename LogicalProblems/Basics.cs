using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public  class Basics
    {
        public int Product(int a, int b, int c)
        {
            return (a + b) * c;
        }

        public string CelsiusToFahrenheit(int tem)
        {
            double Fahrenheit = (tem * 1.8) + 32;

            return $"Temp = {Fahrenheit} F";
        }

        public string Elementary(double Num1, double Num2)
        {
            double add = Num1 + Num2;
            double sub = Num1 - Num2;
            double mul = Num1 * Num2;
            double divide;

            if (Num2 != 0)
            {
                divide = Num1 / Num2;
            }
            else
            {
                divide = 0;
            }

            return $"(a+b) = {add}, (a-b) = {sub}, (a*b) = {mul}, (a/b) = {divide}";
        }

        public bool Result(double num1, double num2)
        {
            return num1 == num2;
        }

        public int Modulo(int num1, int num2, int num3)
        {
            return num1 % num2 % num3;
        }

        public double Cube(int num)
        {
            return Math.Pow(num, 3);
        }
    }
}
