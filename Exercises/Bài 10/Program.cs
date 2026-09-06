using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bài_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                double[] point = new double[5];
                double pointtotal = 0;
                double currentPoint;
                int pass = 0;
                int fail = 0;

                Console.WriteLine("SỐ ĐIỂM CỦA BẠN!");
                Console.WriteLine("Nhập điểm của bạn");
                for (int i = 1; i <= 5; i++) 
                {
                    Console.WriteLine($"Nhập điểm thứ {i}: ");
                    while (!double.TryParse(Console.ReadLine(), out currentPoint)|| currentPoint < 0|| currentPoint > 10)
                    {
                        Console.WriteLine("Điểm không hợp lệ vui lòng nhập lại! (từ 1 đến 10)");
                        Console.WriteLine($"Nhập điểm thứ {i}: ");
                    }

                    pointtotal += currentPoint;
                    point[i - 1] = currentPoint;
                }
                double max = point[0];
                double min = point[0];
                double averagepoint = pointtotal / 5;

                for (int i = 0; i < point.Length; i++)
                {
                    if (point[i] > max)
                    {
                        max = point[i];
                    }
                    if (point[i] < min)
                    {
                        min = point[i];
                    }

                    if (point[i] >= 5)
                    {
                        pass++;
                    }
                    else
                    {
                        fail++;
                    }
                }
                Console.WriteLine($"Điểm cao nhất: {max}");
                Console.WriteLine($"Điểm thấp nhất: {min}");
                Console.WriteLine($"Điểm trung bình: {averagepoint}");
                Console.WriteLine($"Số điểm >= 5: {pass}");
                Console.WriteLine($"Số điểm < 5: {fail}");
                
                while (true)
                {
                    Console.WriteLine("Bạn muốn nhập tiếp chứ(y/n)");
                    string continuechoice = Console.ReadLine().Trim().ToLower();
                    if (continuechoice == "y")
                    {
                        break;
                    }
                    else if (continuechoice == "n")
                    {
                        Console.WriteLine("Cảm ơn bạn đã sử dụng dịch vụ");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại");
                    }
                }    
            }  
        }
    }
}