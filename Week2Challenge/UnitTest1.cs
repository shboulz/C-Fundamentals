using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Week2Challenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalc()
        {
            Calculator calculate = new Calculator();
            calculate.NumOne = 10;
            calculate.NumTwo = 5;

        }

        [TestMethod]
        public void TestAdd()
        {
            Calculator calculate = new Calculator();
            double add = calculate.Add(10, 5);
            Console.WriteLine(add);
        }

        [TestMethod]
        public void TestSub()
        {
            Calculator calculate = new Calculator();
            double sub = calculate.Subtract(10, 5);
            Console.WriteLine(sub);
        }

        [TestMethod]
        public void TestMult()
        {
            Calculator calculate = new Calculator();
            double mult = calculate.Multiply(10, 5);
            Console.WriteLine(mult);
        }

        [TestMethod]
        public void TestDiv()
        {
            Calculator calculate = new Calculator();
            double div = calculate.Divide(10, 5);
            Console.WriteLine(div);
        }

        [TestMethod]
        public void TestMod()
        {
            Calculator calculate = new Calculator();
            double mod = calculate.Modulate(10, 5);
            Console.WriteLine(mod);
        }
    }
}
