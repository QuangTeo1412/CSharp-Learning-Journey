using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_24
{
    class Printer
    { 
        public void print(string message)
        {
            Console.WriteLine("Tin nhắn: " + message);
        }
        public void print(string message,int number)
        {
            Console.WriteLine("Tin nhắn: " + message + ", Số nguyên: " + number);
        }
        public void print(int number)
        {
            Console.WriteLine("Số nguyên: " + number);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Printer printer = new Printer();
            printer.print("Hello");
            printer.print("Hello", 5);
            printer.print(10);
        }
    }
}
