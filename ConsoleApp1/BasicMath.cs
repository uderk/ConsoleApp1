﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BasicMath
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Substract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Divide(double num1, double num2)
        {
            double res = 0.0;
            try
            {
                res = num1 / num2;
                return res;
            }
            catch(DivideByZeroException exp)
            {
                Console.WriteLine(exp.Message);
            }
            return res;
        }
        public double Multiply(double num1, double num2)
        {
            return num2 * num1;
        }
    }
}
