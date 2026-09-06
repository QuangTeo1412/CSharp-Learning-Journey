using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //  Hiển thị tiếng Việt
            while (true)
            {
                    Console.WriteLine("Nhập Điểm Của Bạn: ");
                double point;
                while (!double.TryParse(Console.ReadLine(), out point)) // Sử dụng TryParse để kiểm tra đầu vào
                {
                    Console.WriteLine("Bạn nhập sai, vui lòng nhập lại.");
                }
                if (point < 0 || point > 10)
                    {
                        Console.WriteLine("Điểm không hợp lệ vui lòng nhập lại.");
                    }
                    else if (point >= 5)
                    {
                        Console.WriteLine("Bạn đã đậu");
                    }
                    else
                    {
                        Console.WriteLine("Bạn đã rớt.");
                    }
                    Console.WriteLine("Bạn có muốn nhập lại không? (y/n)");
                string choice = Console.ReadLine();
                choice = choice.ToLower(); // Chuyển đổi lựa chọn thành chữ thường để so sánh
                if (choice == "y")
                    {
                    continue;   
                }
                else if (choice == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng nhập lại.");
                }

            }
        }
    }
}
