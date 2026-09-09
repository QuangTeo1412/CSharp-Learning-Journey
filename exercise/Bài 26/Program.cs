using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_26
{
    internal class Program
    {
        class Calulator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public double Add(double a, double b)
            {
                return a + b;
            }
            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }
            public string Add(string a, string b)
            {
                return a + b;
            }
        }   
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Calulator cal = new Calulator();

            Console.WriteLine(cal.Add(1, 2));
            Console.WriteLine(cal.Add(1.5, 2.5));
            Console.WriteLine(cal.Add(1, 2, 3));
            Console.WriteLine(cal.Add("Hello", "World"));

            Console.WriteLine("\n--- 2. Implicit Conversion ---");
            Console.WriteLine(cal.Add(5, 10)); // Truyền vào một số nguyên và một số thực, sẽ tự động chuyển đổi số nguyên sang số thực và gọi phương thức Add(double, double)
            Console.WriteLine(cal.Add(1.2f, 3.4f)); // Truyền vào hai số thực kiểu float, sẽ tự động chuyển đổi sang kiểu double và gọi phương thức Add(double, double)
            Console.WriteLine(cal.Add('A', 'B')); // Truyền vào hai ký tự, sẽ tự động chuyển đổi sang kiểu int và gọi phương thức Add(int, int)
            // 3. COMMENT GIẢI THÍCH TRƯỜNG HỢP OVERLOAD AMBIGUITY
            // ====================================================

            /*
             * ----------------------------------------------------------------------------------
             * [VÍ DỤ VỀ LỖI OVERLOAD AMBIGUITY (BIÊN DỊCH BỊ LỖI)]
             * 
             * Giả sử trong class Calulator ta định nghĩa thêm 2 hàm overload sau:
             * 
             *    public double Add(int a, double b)    => (Hàm A)
             *    public double Add(double a, int b)    => (Hàm B)
             * 
             * Khi ta thực hiện lời gọi:
             *    cal.Add(5, 10);
             * 
             * TRÌNH BIÊN DỊCH SẼ BÁO LỖI: "The call is ambiguous between the following methods..."
             * 
             * NGUYÊN NHÂN:
             * cả 5 và 10 đều là kiểu 'int'. C# bối rối vì:
             * - Nếu chọn Hàm A: Phải ép kiểu ngầm định tham số thứ 2 (10: int -> double).
             * - Nếu chọn Hàm B: Phải ép kiểu ngầm định tham số thứ 1 (5: int -> double).
             * Mức độ ưu tiên của 2 hướng ép kiểu này là NGANG NHAU, C# không biết chọn hàm nào
             * nên sẽ chặn ngay từ lúc biên dịch (Compile Error).
             * 
             * CÁCH SỬA:
             * Ép kiểu tường minh 1 trong 2 tham số lúc gọi: cal.Add((double)5, 10);
             * ----------------------------------------------------------------------------------
             */

            Console.ReadKey();
        }
    }
}
