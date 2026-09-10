using System;
using System.Text;

namespace BÀi_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                double[] diem;
                int soluonghocsinh = 0;
                double diemhientai;
                double tongdiem = 0;
                int pass = 0;
                int fail = 0;

                Console.WriteLine("====THỐNG KÊ ĐIỂM LỚP====");
                Console.WriteLine("1. Nhập điểm học sinh");
                Console.WriteLine("2. Thoát chương trinh");
                int choice;

                while(!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại (từ 1-2)");
                }
                if (choice == 2)
                {
                    Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình");
                    return;
                }
                if (choice == 1)
                {
                    Console.WriteLine("Nhập số lượng học sinh bạn muốn nhập");
                    while (!int.TryParse(Console.ReadLine(), out soluonghocsinh)|| soluonghocsinh <=0)
                    {
                        Console.WriteLine("Số lượng không hợp lệ vui lòng nhập lại!");
                    }
                    diem = new double[soluonghocsinh];

                    for (int i = 1; i <= soluonghocsinh; i++)
                    {
                        Console.WriteLine($"Nhập điểm thứ {i}: ");
                        while (!double.TryParse(Console.ReadLine(), out diemhientai) || diemhientai < 0 || diemhientai > 10)
                        {
                            Console.WriteLine("Điểm không hợp lệ vui lòng nhập lại! (từ 1 đến 10)");
                            Console.WriteLine($"Nhập điểm thứ {i}: ");
                        }

                        tongdiem += diemhientai;
                        diem[i - 1] = diemhientai;
                    }
                    double diemlonnhat = diem[0];
                    double diemnhonhat = diem[0];
                    double diemtrungbinh = tongdiem / soluonghocsinh;
                    for (int i = 0; i < diem.Length; i++)
                    {
                        if (diem[i] > diemlonnhat )
                        {
                            diemlonnhat = diem[i];
                        }
                        if (diem[i] < diemnhonhat )
                        {
                            diemnhonhat = diem[i];
                        }
                        if (diem[i] >= 5)
                        {
                            pass++;
                        }
                        else
                        {
                            fail++;
                        }
                    }
                    Console.WriteLine("====KẾT QUẢ ĐIỂM CỦA LỚP====");
                    Console.WriteLine($"Điểm cao nhất: {diemlonnhat}");
                    Console.WriteLine($"Điểm thấp nhất: {diemnhonhat}");
                    Console.WriteLine($"Điểm trung bình: {diemtrungbinh}");
                    Console.WriteLine($"Số học sinh đạt: >= 5: {pass}");
                    Console.WriteLine($"Số học sinh không đạt: < 5: {fail}");
                }
                while (true)
                {
                    Console.WriteLine("Bạn muốn nhập tiếp chứ(y/n)");
                    string ContinueChoice = Console.ReadLine().Trim().ToLower();
                    if (ContinueChoice == "y")
                    {
                        break;
                    }
                    else if (ContinueChoice == "n")
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
