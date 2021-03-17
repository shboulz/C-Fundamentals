using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double numOne = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double numTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(numOne + numTwo);

            Console.ReadLine();
        }
    }
}
