using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8; // Dịch sang tiếng Việt
            Console.OutputEncoding = Encoding.UTF8; // Dịch sang tiếng Việt
            while (true)
            {
                Console.WriteLine("====**HỆ THỐNG QUẢN LÝ NHÂN VIÊN**====");
                Console.WriteLine("1. Thêm nhân viên");
                Console.WriteLine("2 Thoát chương trình");
                Console.WriteLine("Nhập lựa chọn của bạn: ");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
                }
                if (choice == 2)
                {
                    Console.WriteLine("Chương trình đã kết thúc.");
                    Console.WriteLine("Cảm ơn bạn đã sử dụng dịch vụ này!");
                    break;
                }
                if (choice == 1)
                {
                    Console.WriteLine("Nhập tên nhân viên: ");
                    string name = Console.ReadLine();
                    string Pattern = @"^[\p{L}\s]+$";
                    if (!System.Text.RegularExpressions.Regex.IsMatch(name, Pattern))
                    {
                        Console.WriteLine("Tên không hợp lệ. Vui lòng nhập lại.");
                        continue;
                    }
                    int age;
                    Console.WriteLine("Nhập tuổi nhân viên: ");
                    while (!int.TryParse(Console.ReadLine(), out age)|| age < 18 || age > 60)// Tuổi hợp lệ từ 18 đến 60
                    {
                        Console.WriteLine("Tuổi không hợp lệ. Vui lòng nhập lại (từ 18 đến 60 tuổi):");
                    }
                    double salary;
                    Console.WriteLine("Nhập lương nhân viên: ");
                    while (!double.TryParse(Console.ReadLine(), out salary)|| salary < 0) // Lương phải lớn hơn 0
                    {
                        Console.WriteLine("Lương không hợp lệ. Vui lòng nhập lại lương phải lớn hơn 0: ");
                    }
                    Console.WriteLine("Bạn đã ký hợp đồng chưa:(y/n) ");
                    string contract = Console.ReadLine();
                    while (contract != "y" && contract != "n")
                    {
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại (y/n): ");
                        contract = Console.ReadLine();
                    }
                    Console.WriteLine("====THÔNG TIN NHÂN VIÊN====");
                    Console.WriteLine("Tên nhân viên: " + name);
                    Console.WriteLine("Tuổi nhân viên: " + age);
                    Console.WriteLine("Lương nhân viên: " + salary);
                    Console.WriteLine("Hợp đồng : " + (contract == "y" ? "Đã ký" : "Chưa ký"));
                    if (salary >= 30000000)
                    {
                        Console.WriteLine("Nhân viên có mức lương rất cao.");
                    }
                    else if (salary >= 12000000 && salary < 30000000)
                    {
                        Console.WriteLine("Nhân viên có mức lương cao.");
                    }
                    else if (salary >= 8000000 && salary < 12000000)
                    {
                        Console.WriteLine("Nhân viên có mức lương trung binh.");
                    }
                    else
                    {
                        Console.WriteLine("Nhân viên có mức lương thấp.");
                    }
                    if (age >= 18 && contract == "y")
                    {
                        Console.WriteLine("Nhân viên đủ điều kiện đăng ký.");
                    }
                    else
                    {
                        Console.WriteLine("Nhân viên chưa đủ điều kiện đăng ký.");
                    }
                    while (true)
                    {
                        Console.WriteLine("Bạn có muốn tiếp tục thêm nhân viên không? (y/n): ");
                        string continueChoice = Console.ReadLine();
                        if (continueChoice == "y")
                        {
                            break
                                ; 
                        }
                        else if (continueChoice == "n")
                        {
                            Console.WriteLine("Chương trình kết thúc.");
                            Console.WriteLine("Cảm ơn bạn đã sử dụng!");
                            return; 
                        }
                        else
                        {
                            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
                        }
                    }
                }
            } 
        }
    }
}
