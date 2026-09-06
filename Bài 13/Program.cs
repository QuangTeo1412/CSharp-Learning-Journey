using System;
using System.Text;

namespace Bài_13
{
    internal class Program
    {
        class product
        {
            public string name {  get; set; }
            public double price {  get; set; }
            public int quantity {  get; set; }
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8; 

            product product1 = new product();
            product1.name = "Pepsi";
            product1.price = 12000;
            product1.quantity = 10;

            product product2 = new product();
            product2.name = "Bánh";
            product2.price = 15000;
            product2.quantity = 3;

            Console.WriteLine($"Tên: {product1.name}");
            Console.WriteLine($"Giá: {product1.price}");
            Console.WriteLine($"Số lượng: {product1.quantity}");

            Console.WriteLine($"Tên: {product2.name}");
            Console.WriteLine($"Giá: {product2.price}");
            Console.WriteLine($"Số lượng: {product2.quantity}");
        }
    }
}
