using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_4
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.InputEncoding = Encoding.UTF8;   // Dịnh dạng đầu vào là UTF-8 để nhập tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;  // Dịnh dạng đầu ra là UTF-8 để hiển thị tiếng Việt
            bool choice = true; 
            while (true) // Vòng lặp vô hạn để cho phép người dùng đăng nhập lại
            {
                    Console.WriteLine("Nhập tuổi của bạn:");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age)) // Sử dụng TryParse để kiểm tra đầu vào
                {
                    Console.WriteLine("Tuổi không hợp lệ. Vui lòng nhập lại!");
                }
                if (age <= 0 || age > 100)
                {
                    Console.WriteLine("Rất tiếc tuổi không hợp lệ. Vui lòng nhập lại!");
                    return; // Kết thúc chương trình nếu tuổi không hợp lệ
                }
                Console.WriteLine("Đã đăng nhập chưa? (y/n):");
                string input = Console.ReadLine();
                input = input.ToLower(); // Chuyển đổi chuỗi nhập vào thành chữ thường để so sánh
                if (age >= 18 && input == "y")
                {
                    Console.WriteLine("Bạn được phép truy cập vào trang web này!");
                }
                else
                {
                    Console.WriteLine("Bạn chưa được phép truy cập vào trang web này, vui lòng thử lại!");
                }
                Console.WriteLine(" Bạn muốn đăng nhập lại không? (có/không):");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "có")   
                {
                    choice = true;
                    break; // Thoát khỏi vòng lặp để đăng nhập lại
                }
                else if (choice.ToLower() == "không")
                {
                    Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình!");
                    return; // Kết thúc chương trình nếu người dùng không muốn đăng nhập lại    
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại.");
                }
            }     
        }
    }
}
