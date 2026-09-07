using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string name = "";   
            double price = 0;
            int quantity = 0;
            bool hasProduct = false; // Biến kiểm tra xem sản phẩm đã được nhập hay chưa

            while (true)
            {
                Console.WriteLine("====HỆ THỐNG QUẢN LÝ KHO HÀNG====");
                Console.WriteLine("1. Nhập sản phẩm");
                Console.WriteLine("2. Kiểm tra sản phẩm");
                Console.WriteLine("3. Thoát chương trình");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3) // Kiểm tra lựa chọn có hợp lệ hay không
                {
                    Console.WriteLine("Lựa chọn không hợp lệ vui lòng chọn lại từ (1-3):");
                }

                if (choice == 3) // Nếu chọn 3 thì thoát chương trình
                {
                    Console.WriteLine("Chương trình đã kết thúc");
                    Console.WriteLine("Cảm ơn bạn đã sử dụng dịch vụ này!");
                    break;
                }

                else if (choice == 1) // Nếu chọn 1 thì nhập sản phẩm
                {
                    Console.WriteLine("Nhập tên sản phẩm:");
                    name = Console.ReadLine();
                    string Pattern = @"^[\p{L}\s]+$";
                    while (!System.Text.RegularExpressions.Regex.IsMatch(name, Pattern)) // Kiểm tra tên sản phẩm có chứa ký tự đặc biệt hay không
                    {
                        Console.WriteLine("Tên sản phẩm không hợp lệ. Vui lòng nhập lại.");
                        name = Console.ReadLine();
                    }

                    Console.WriteLine("Nhập giá sản phẩm:");
                    while (!double.TryParse(Console.ReadLine(), out price) || price <= 0) // Kiểm tra giá sản phẩm có hợp lệ hay không
                    {
                        Console.WriteLine("Giá sản phẩm không hợp lệ. Vui lòng nhập lại.");
                    }

                    Console.WriteLine("Nhập số lượng sản phẩm:");
                    while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0) // Kiểm tra số lượng sản phẩm có hợp lệ hay không
                    {
                        Console.WriteLine("Số lượng sản phẩm không hợp lệ. Vui lòng nhập lại.");
                    }
                    DisplayProduct(name, price, quantity);
                    hasProduct = true; // Đánh dấu sản phẩm đã được nhập
                    if (hasProduct)
                    {

                        if (quantity == 0)
                        {
                            Console.WriteLine("Sản phẩm đã hết hàng");
                        }
                        else if (quantity <= 10)
                        {
                            Console.WriteLine("Sản phẩm sắp hết hàng");
                        }
                        else if (quantity <= 50)
                        {
                            Console.WriteLine("Sản phẩm còn hàng");
                        }
                        else if (quantity > 50)
                        {
                            Console.WriteLine("Sản phẩm tồn kho nhiều");
                        }
                    }
                }

                else if (choice == 2) // Nếu chọn 2 thì kiểm tra sản phẩm
                {
                    Console.WriteLine("Kiểm tra sản phẩm");
                    if (!hasProduct) // Nếu sản phẩm chưa được nhập thì thông báo lỗi
                    {
                        Console.WriteLine("Chưa có sản phẩm nào được nhập. Vui lòng nhập sản phẩm trước khi kiểm tra.");
                        continue;
                    }
                    CheckProduct(name, price, quantity);
                }
                
            }
        }
        static void DisplayProduct(string name, double price, int quantity)
        {
            Console.WriteLine("Tên sản phẩm: " + name);
            Console.WriteLine("Giá sản phẩm: " + price);
            Console.WriteLine("Số lượng sản phẩm: " + quantity);
            Console.WriteLine("Đã nhập sản phẩm thành công");
        }
        static void CheckProduct(string name, double price, int quantity)
        {
            Console.WriteLine("Tên sản phẩm: " + name);
            Console.WriteLine("Giá sản phẩm: " + price);
            Console.WriteLine("Số lượng sản phẩm: " + quantity);
            Console.WriteLine("Tổng giá trị sản phẩm: " + (double)price * quantity);
        }
    }
}