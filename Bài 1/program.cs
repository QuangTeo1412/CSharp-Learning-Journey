using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learning_Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Đọc chữ tiếng Việt

            Console.WriteLine("Nhập Họ Và Tên:");
            string name = Console.ReadLine();

            Console.WriteLine("Nhập Tuổi:");
            int age = Convert.ToInt32(Console.ReadLine());

            int nextYearAge = age + 1;

            Console.WriteLine("Xin Chào Oni-chan " + name);
            Console.WriteLine("Tuổi của bạn trong năm sau là: " + nextYearAge);

            Console.ReadLine();
        }
    }
}