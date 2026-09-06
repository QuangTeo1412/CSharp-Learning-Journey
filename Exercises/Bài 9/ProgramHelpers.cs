using System;
using System.Text;

namespace Bài_9
{
    internal static class ProgramHelpers
    {
        // Renamed from Main to Run to avoid duplicate entry point (CS0017).
        internal static void Run(string[] agrs)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string name = string.Empty;
            int quantity = 0;
            double price = 0.0;
            int totalValue = 0;
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
                Console.WriteLine("4. Xóa sản phẩm");
                Console.WriteLine("5. Thoát");
                int choice;

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại từ 1 đến 5.");
                }

                if (choice == 5)
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
                        productName[productCount] = Console.ReadLine();

                        if (string.IsNullOrEmpty(productName[productCount]))
                        {
                            Console.WriteLine("Tên sản phẩm không hợp lệ. Vui lòng nhập lại.");
                        }
                    }
                    name = productName[productCount];
                    Console.WriteLine("Nhập giá sản phẩm: ");
                    while (!double.TryParse(Console.ReadLine(), out priceProduct[productCount]) || priceProduct[productCount] < 0)
                    {
                        Console.WriteLine("Số lượng sản phẩm không hợp lệ. Vui lòng nhập lại.");
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
                            Console.WriteLine($"name:{productName[i]}, price{priceProduct[i]}, quantity{quantityProduct[i]}");
                            Console.WriteLine($"Tổng giá trị: {priceProduct[i] * quantityProduct[i]}");
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
                            Console.WriteLine("Tên sản phẩm: " + productName[i]);
                            Console.WriteLine("Giá sản phẩm: " + priceProduct[i]);
                            Console.WriteLine("Số lượng sản phẩm: " + quantityProduct[i]);
                        }
                    }
                    if (!fuond)
                    {
                        Console.WriteLine("Không tìm thấy sản phẩm.");
                    }
                }
            }
        }
    }
}