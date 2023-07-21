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
    }
}
