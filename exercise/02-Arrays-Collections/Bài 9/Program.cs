using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_9
{
    internal class Program
    {
        static void Main(string[] agrs)
        {
            Console.InputEncoding = Encoding.UTF8;  
            Console.OutputEncoding = Encoding.UTF8;

            string name = "";
            int productCount = 0;
            string[] productName = new string[5];
            double[] priceProduct = new double[5];
            int[] quantityProduct = new int[5];

            while (true)
            {
                Console.WriteLine("====QUẢN LÝ SẢN PHẨM====");
                Console.WriteLine("1. Thêm sản phẩm");
                Console.WriteLine("2. Hiển thị danh sách");
                Console.WriteLine("3. Tìm kiếm sản phẩm");
                Console.WriteLine("4. Thoát");
                int choice;

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại từ 1 đến 5.");
                }

                if (choice == 4)
                {
                    Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình! ");
                    break;
                }
                else if (choice == 1) // Thêm sản phẩm
                {
                    if (productCount >= 5) // Kiểm tra nếu danh sách sản phẩm đã đầy
                    {
                        Console.WriteLine("Danh sách sản phẩm đã đầy. Không thể thêm sản phẩm mới.");
                        continue;
                    }
                    Console.WriteLine("Nhập tên sản phẩm: ");
                    while (string.IsNullOrEmpty(productName[productCount])) 
                    {
                        productName[productCount] = Console.ReadLine().Trim();

                        if (string.IsNullOrEmpty(productName[productCount]))
                        {
                            Console.WriteLine("Tên sản phẩm không hợp lệ. Vui lòng nhập lại.");
                        }
                    }
                    name = productName[productCount];
                    Console.WriteLine("Nhập giá sản phẩm: ");
                    while (!double.TryParse(Console.ReadLine(), out priceProduct[productCount]) || priceProduct[productCount] < 0)
                    {
                        Console.WriteLine("Giá sản phẩm không hợp lệ. Vui lòng nhập lại.");
                    }

                    Console.WriteLine("Nhập số lượng sản phẩm: ");
                    while (!int.TryParse(Console.ReadLine(), out quantityProduct[productCount]) || quantityProduct[productCount] < 0)
                    {
                        Console.WriteLine("Số lượng sản phẩm không hợp lệ. Vui lòng nhập lại.");
                    }
                    NhapSanPham(name, priceProduct[productCount], quantityProduct[productCount]);
                    productCount++;
                }
                else if (choice == 2) // Hiển thị danh sách
                {
                    Console.WriteLine("Hiển thị danh sách");
                    if (productCount == 0)
                    {
                        Console.WriteLine("Danh sách sản phẩm trống.");
                    }
                    else
                    {
                        Console.WriteLine("Danh sách sản phẩm:");
                        for (int i = 0; i < productCount; i++)
                        {
                            double totalValue = priceProduct[i] * quantityProduct[i];
                            HienThiDanhSach(productName[i], priceProduct[i], quantityProduct[i], totalValue);
                        }
                    }
                }
                else if (choice == 3) // Tìm kiếm sản phẩm
                {
                    Console.WriteLine("Nhập tên sản phẩm cần tìm: ");
                    string searchName = Console.ReadLine();
                    bool fuond = false;

                    for (int i = 0; i < productCount; i++)
                    {
                        if (searchName.Equals(productName[i], StringComparison.OrdinalIgnoreCase))
                        {
                            TimSanPham(searchName, productName[i], priceProduct[i], quantityProduct[i]);
                            fuond = true;
                            break;
                        }
                    }
                    if (!fuond)
                    {
                        Console.WriteLine("Không tìm thấy sản phẩm.");
                    }
                }
            }
        }
        static void NhapSanPham(string name, double price, int quantity)
        {
            Console.WriteLine($"Sản phẩm '{name}' đã được thêm với giá {price} và số lượng {quantity}.");
        }
        static void HienThiDanhSach(string name, double price, int quantity, double totalValue)
        {
            Console.WriteLine($"Tên sản phẩm: {name}, Giá: {price}, Số lượng: {quantity}, Tổng giá trị: {totalValue}");
        }
        static void TimSanPham(string searchName, string name, double price, int quantity)
        {
            Console.WriteLine($"Tìm kiếm sản phẩm '{searchName}':");
            Console.WriteLine($"Tên sản phẩm: {name}, Giá: {price}, Số lượng: {quantity}");
        }
    }
}