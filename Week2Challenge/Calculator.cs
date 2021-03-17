using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenge
{
    public class Calculator
    {
        public double NumOne { get; set; }

        public double NumTwo { get; set; }

        public Calculator()
        {

        }

        public Calculator(double numOne, double numTwo)
        {
            NumOne = numOne;
            NumTwo = numTwo;
        }

        public double Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        public double Subtract(double numOne, double numTwo)
        {
            double sum = numOne - numTwo;
            return sum;
        }

        public double Multiply(double numOne, double numTwo)
        {
            double sum = numOne * numTwo;
            return sum;
        }

        public double Divide(double numOne, double numTwo)
        {
            double sum = numOne / numTwo;
            return sum;
        }

        public double Modulate(double numOne, double numTwo)
        {
            double sum = numOne % numTwo;
            return sum;
        }
    }
}
