using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string name = "";
            int age = 0;
            string namemovie = "";
            int numberofmovie = 0;
            string tickertype = "";
            int totalprice = 0;
            bool isTicketBooked = false;

            while (true)
            {
                Console.WriteLine("====HỆ THỐNG ĐẶT VÉ XEM PHIM====");
                Console.WriteLine("1. Đặt vé");
                Console.WriteLine("2. Kiểm tra vé");
                Console.WriteLine("3. Hủy vé");
                Console.WriteLine("4. Thoát");
                int choice;

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng nhập một số từ 1 đến 4.");
                }

                if (choice == 4)
                {
                    Console.WriteLine("Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi!");
                    break;
                }
                else if (choice == 1)
                {
                    Console.WriteLine("Nhập tên của bạn: "); 
                    string Pattern = @"^[\p{L}\s]+$";
                    name = Console.ReadLine();
                    while (!System.Text.RegularExpressions.Regex.IsMatch(name, Pattern))
                    {
                        Console.WriteLine("Tên không hợp lệ, vui lòng nhập lại (chỉ chứa chữ cái và khoảng trắng): ");
                        name = Console.ReadLine();
                    }

                    Console.WriteLine("Nhập tuổi của bạn: ");
                    while (!int.TryParse(Console.ReadLine(), out age) || age > 100 || age <= 0)
                    {
                        Console.WriteLine("Tuổi không hợp lệ, vui lòng nhập một số tuổi từ 1 đến 100.");
                    }

                    string PatternMovie = @"^[\p{L}\s]+$";
                    Console.WriteLine("Nhập tên phim bạn muốn xem: ");
                    namemovie = Console.ReadLine();
                    while (!System.Text.RegularExpressions.Regex.IsMatch(namemovie, PatternMovie))
                    {
                        Console.WriteLine("Tên phim không hợp lệ, vui lòng nhập lại (chỉ chứa chữ cái và khoảng trắng): ");
                        namemovie = Console.ReadLine();
                    }

                    Console.WriteLine("Nhập số lượng vé bạn muốn đặt: ");
                    while (!int.TryParse(Console.ReadLine(), out numberofmovie) || numberofmovie <= 0)
                    {
                        Console.WriteLine("Số lượng vé không hợp lệ, vui lòng chọn số lớn hơn 0.");
                    }
                    
                    Console.WriteLine("Nhập loại vé (Thường/VIP): ");
                    tickertype = Console.ReadLine();
                    while (tickertype != "Thường" && tickertype != "VIP")
                    {
                        Console.WriteLine("Loại vé không hợp lệ, vui lòng nhập 'Thường' hoặc 'VIP': ");
                        tickertype = Console.ReadLine();
                    }

                    int price = 0;
                    if (tickertype == "Thường")
                    {
                        price = 70000;
                    }
                    else if (tickertype == "VIP")
                    {
                        price = 120000;
                    }
                    totalprice = price * numberofmovie;
                    DisplayTicket(name, age, namemovie, numberofmovie, tickertype, totalprice);// Display ticket information
                    isTicketBooked = true;
                }
                else if (choice == 2)   
                {
                    Console.WriteLine("Kiểm tra vé ");
                    if (!isTicketBooked)
                    {
                        Console.WriteLine("Chưa có vé nào được đặt. Vui lòng đặt vé trước khi kiểm tra.");
                        continue;
                    }
                    CheckTicket(name, age, namemovie, numberofmovie, tickertype);// Check ticket information

                }
                else if (choice == 3)
                {
                    name = "";
                    age = 0;
                    namemovie = "";
                    numberofmovie = 0;
                    tickertype = "";
                    totalprice = 0;
                    Console.WriteLine("Vé của bạn đã được hủy thành công.");
                    isTicketBooked = false;
                }
            }
        }
        static void DisplayTicket(string name, int age, string namemovie, int numberofmovie, string tickertype,int totalprice)
        {
            Console.WriteLine("====THÔNG TIN VÉ XEM PHIM====");
            Console.WriteLine($"Tên: {name}");
            Console.WriteLine($"Tuổi: {age}");
            Console.WriteLine($"Tên phim: {namemovie}");
            Console.WriteLine($"Số lượng vé: {numberofmovie}");
            Console.WriteLine($"Loại vé: {tickertype}");
            Console.WriteLine($"Tổng giá tiền: {totalprice} VNĐ");
        }
        static void CheckTicket(string name, int age, string namemovie, int numberofmovie, string tickertype)
        {
            Console.WriteLine("====THÔNG TIN VÉ XEM PHIM====");
            Console.WriteLine($"Tên: {name}");
            Console.WriteLine($"Tuổi: {age}");
            Console.WriteLine($"Tên phim: {namemovie}");
            Console.WriteLine($"Số lượng vé: {numberofmovie}");
            Console.WriteLine($"Loại vé: {tickertype}");
        }
    }
}
