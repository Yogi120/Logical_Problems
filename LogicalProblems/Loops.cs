﻿using System;
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
    }
}
