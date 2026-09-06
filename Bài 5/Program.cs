using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bài_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8; // Thiết lập mã hóa đầu ra là UTF-8 để hiển thị tiếng Việt
                Console.WriteLine("Bạn có muốn nhập thông tin nhân viên mới không? (y/n):");
                string response = Console.ReadLine();
                if (response.ToLower() == "y")
                {
                    break; // Thoát khỏi vòng lặp nếu người dùng muốn nhập thông tin
                }
                else if (response.ToLower() == "n")
                {
                    Console.WriteLine("Chương trình kết thúc.");
                    return; // Kết thúc chương trình nếu người dùng không muốn nhập thông tin
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập 'có' hoặc 'không'.");
                }
            }
            bool moreInput = true;
            while (moreInput)
            {
                Console.WriteLine("PHIẾU ĐĂNG KÍ NHÂN VIÊN MỚI");
                Console.WriteLine("Nhập tên của bạn:");
                string name = Console.ReadLine();
                Console.WriteLine("Nhập tuổi của bạn: ");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age)) // Sử dụng TryParse để kiểm tra đầu vào
                {
                    Console.WriteLine("Tuổi không hợp lệ. Vui lòng nhập lại!");
                }
                bool validAge = false;
                while (!validAge)
                {
                    if (age < 18 || age > 60)
                    {
                        Console.WriteLine("Tuổi không hợp lệ. Vui lòng nhập lại tuổi (từ 18 đến 60):");
                        age = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        validAge = true;
                    } 
                }
                Console.WriteLine("Lương hiện tại của bạn:");
                double salary;
                while (!double.TryParse(Console.ReadLine(), out salary)) // Sử dụng TryParse để kiểm tra đầu vào
                {
                    Console.WriteLine("Lương không hợp lệ. Vui lòng nhập lại!");
                }
                bool validSalary = false;
                while (!validSalary)
                {
                    if (salary < 0)
                    {
                        Console.WriteLine("Lương không hợp lệ. Vui lòng nhập lại lương (lương của bạn phải lớn hơn 0):");
                        salary = Convert.ToDouble(Console.ReadLine());
                    }
                    else
                    {
                        validSalary = true;
                    }
                    Console.WriteLine("Bạn đã kí hợp đồng chưa(y/n)");
                    string contract = Console.ReadLine();
                    contract = contract.ToLower(); // Chuyển đổi chuỗi nhập vào thành chữ thường để so sánh
                    if (contract == "y")
                    {
                        Console.WriteLine("Bạn đã kí hợp đồng");
                    }
                    else if (contract == "n")
                    {
                        Console.WriteLine("Bạn chưa kí hợp đồng");
                    }
                    else
                    {
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập 'y' hoặc 'n'.");
                    }
                    if (age >= 18 && contract == "y")
                    {
                        Console.WriteLine("Bạn đã đăng ký hợp đồng này!");
                    }
                    else
                    {
                        Console.WriteLine("Bạn chưa đăng ký hợp đồng này!");
                    }
                    if (salary >= 30000000)
                    {
                        Console.WriteLine("Lương rất cao");
                    }
                    else if (salary >= 12000000)
                    {
                        Console.WriteLine("Lương cao");
                    }
                    else if (salary >= 8000000)
                    {
                        Console.WriteLine("Lương trung bình");
                    }
                    else
                    {
                        Console.WriteLine("Lương thấp");
                    }
                    Console.WriteLine("Thông tin nhân viên:");
                    Console.WriteLine("Tên:" + name);
                    Console.WriteLine("Tuổi:" + age);
                    Console.WriteLine("Lương:" + salary);
                    while (true)
                    {
                        Console.WriteLine("Bạn có muốn nhập thông tin nhân viên khác không? (có/không):");
                        string continueResponse = Console.ReadLine();
                        if (continueResponse.ToLower() == "có")
                        {
                            moreInput = true;
                            break;
                        }
                        else if (continueResponse.ToLower() == "không")
                        {
                            moreInput = false;
                            break;
                        }
                        else  
                        {
                            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập 'có' hoặc 'không'.");
                        }
                    }
                }
            }
        }
    }
}
