using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Thiết lập mã hóa đầu ra là UTF-8 để hiển thị tiếng Việt
            while (true)
            {
                Console.WriteLine("Nhập Điểm Của Bạn:");
                double score;
                while (!double.TryParse(Console.ReadLine(), out score)) // Sử dụng TryParse để kiểm tra đầu vào
                {
                    Console.WriteLine("Điểm không hợp lệ. Vui lòng nhập lại");
                }
                if (score < 0 || score > 10)
                {
                    Console.WriteLine("Điểm không hợp lệ. Vui lòng nhập lại (từ 0 đến 10):");
                    continue; // Quay lại đầu vòng lặp nếu điểm không hợp lệ
                }
                string grade;
                if (score >= 9)
                {
                    grade = "A";
                }
                else if (score >= 8)
                {
                    grade = "B";
                }
                else if (score >= 6.5)
                {
                    grade = "C";
                }
                else if (score >= 5)
                {
                    grade = "D";
                }
                else
                { 
                    grade = "F";
                }
                    Console.WriteLine("Bạn Xếp Loại Hạng: " + grade);
                if (score >= 9 && score <=10)
                {
                    Console.WriteLine("Học lực: Xuất sắc - A");
                }
                else if (score >= 8 && score <9)
                {
                    Console.WriteLine("Học lực: Giỏi - B");
                }
                else if (score >= 6.5 && score <8)
                {
                    Console.WriteLine("Học lực: Khá - C");
                }
                else if (score >= 5 && score <6.5)
                {
                    Console.WriteLine("Học lực: Trung bình - D");
                }
                else
                {
                    Console.WriteLine("Học lực: Yếu - F");
                }
                if (score >= 5)
                {
                    Console.WriteLine("Kết Quả: Đậu");
                }
                else
                {
                    Console.WriteLine("Kết Quả: Rớt");
                }
                if (score == 10)
                {
                    Console.WriteLine("Điểm tuyệt đối! Chúc mừng bạn!");
                }
                else if (score == 0)
                {
                    Console.WriteLine("Bạn cần cố gắng hơn!");
                }
                Console.WriteLine("Bạn có muốn nhập tiếp không? (Y/N)");
                string choice = Console.ReadLine();
                choice = choice.ToLower(); // Chuyển đổi chuỗi nhập vào thành chữ thường để so sánh
                if (choice == "y")
                {
                    continue; // Tiếp tục vòng lặp nếu người dùng nhập 'y'
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
