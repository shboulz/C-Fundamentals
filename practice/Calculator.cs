using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class Calculator
    {
        public double Addition(double numThree, double numFour)
        {
            double sum = numThree + numFour;
            return sum;
        }
        
        public double Subtraction(double numThree, double numFour)
        {
            double sum = numThree - numFour;
            return sum;
        }

        public double Multiplication(double numThree, double numFour)
        {
            double sum = numThree * numFour;
            return sum;
        }

        public double Division(double numThree, double numFour)
        {
            double sum = numThree / numFour;
            return sum;
        }
        
        public int Addition(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public int Subtraction(int numOne, int numTwo)
        {
            int sum = numOne - numTwo;
            return sum;
        }

        public int Multiplication(int numOne, int numTwo)
        {
            int sum = numOne * numTwo;
            return sum;
        }

        public int Division(int numOne, int numTwo)
        {
            int sum = numOne / numTwo;
            return sum;
        }

        [TestClass]
        public class CalculatorTestClass
        {
            // BEST PRACTICE
            private int numOne = 27;
            private int numTwo = 3;
            private double numThree = 2.4;
            private double numFour = 5.5;
            Calculator calculate = new Calculator();
            [TestMethod]
            public void TestingAdditionMethodShouldReturnTrue()
            {
                double sum = calculate.Addition(numThree, numFour);
                int sumTwo = calculate.Addition(numOne, numTwo);
                Assert.AreEqual(sum, (numThree + numFour));
                Assert.AreEqual(sumTwo, (numOne + numTwo));

                Console.WriteLine(sum);
                Console.WriteLine(sumTwo);
            }
            [TestMethod]
            public void TestingSubtractionMethodShouldReturnTrue()
            {
                double sum = calculate.Subtraction(numThree, numFour);
                int sumTwo = calculate.Subtraction(numOne, numTwo);
                Assert.AreEqual(sum, (numThree - numFour));
                Assert.AreEqual(sumTwo, (numOne - numTwo));

                Console.WriteLine(sum);
                Console.WriteLine(sumTwo);
            }
            [TestMethod]
            public void TestingMultiplicationMethodShouldReturnTrue()
            {
                double sum = calculate.Multiplication(numThree, numFour);
                int sumTwo = calculate.Multiplication(numOne, numTwo);
                Assert.AreEqual(sum, (numThree * numFour));
                Assert.AreEqual(sumTwo, (numOne * numTwo));
                
                Console.WriteLine(sum);
                Console.WriteLine(sumTwo);
            }
            [TestMethod]
            public void TestingDivisionMethodShouldReturnTrue()
            {
                double sum = calculate.Division(numThree, numFour);
                int sumTwo = calculate.Division(numOne, numTwo);
                Assert.AreEqual(sum, (numThree / numFour));
                Assert.AreEqual(sumTwo, (numOne / numTwo));

                Console.WriteLine(sum);
                Console.WriteLine(sumTwo);
            }

        }

    }
}