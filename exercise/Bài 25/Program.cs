using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_25
{
    internal class Program
    {
        class Calculate
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }
            public static double Add(double a, double b)
            {
                return a + b;
            }
            public static int Add(int a, int b, int c)
            {
                return a + b + c;
            }
            public static string Add(string a, string b)
            {
                return a + b;
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("INT: " + Calculate.Add(5, 3));
            Console.WriteLine("DOUBLE: " + Calculate.Add(5.5, 2.5));
            Console.WriteLine("THREE INT: " + Calculate.Multiply(1, 2, 3));
            Console.WriteLine("STRING: " + Calculate.Multiply("Hello", "World"));
            Console.ReadLine();
        }
    }
}
