using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_23
{
    class Calculator 
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int sum1 = calculator.Add(5, 3);
            int sum2 = calculator.Add(5, 3, 2);
            double sum3 = calculator.Add(5.5, 3.2);

            Console.WriteLine("Sum1: " + sum1);
            Console.WriteLine("Sum2: " + sum2);
            Console.WriteLine("Sum3: " + sum3);
        }
    }
}
