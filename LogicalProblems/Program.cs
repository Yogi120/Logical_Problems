﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Basic");
            Console.WriteLine("2. Conditional Statements");
            Console.WriteLine("3. Loops");
            Console.WriteLine("4. Strings");

            Console.Write("Choose Option: ");
            int opt = Convert.ToInt32(Console.ReadLine());

            switch(opt)
            {
                case 1:

                    Basics basic = new Basics();

                    Console.WriteLine("1. Add two numbers");
                    Console.WriteLine("2. Celsius to Fahrenheit ");
                    Console.WriteLine("3. Elementary operations");
                    Console.WriteLine("4. Is result the same ");
                    Console.WriteLine("5. Modulo operations");
                    Console.WriteLine("6. The cube of");
                    Console.WriteLine("7. Swap two numbers ");

                    Console.Write("Choode Option: ");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            
                            Console.WriteLine(basic.Product(5, 6, 8));
                            break;

                        case 2:
                            Console.WriteLine(basic.CelsiusToFahrenheit(30));
                            break;

                        case 3:
                            Console.WriteLine(basic.Elementary(3, 8));
                            break;

                        case 4:
                            Console.WriteLine(basic.Result(2 * 2, 4 / 2));
                            break;

                    }
                    break;
            }


        }
    }
}
