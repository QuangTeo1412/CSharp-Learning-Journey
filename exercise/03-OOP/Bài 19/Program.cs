using System;
using System.Text;

namespace BÀi_19
{
    class Product
    {
        public string Name { get; set; }

        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Giá tiền không thể âm!");
                }
            }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
                else
                {
                    Console.WriteLine("Số lượng không thể âm!");
                }
            }
        }

        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public double GetTotalPrice()
        {
            return Price * Quantity;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Tên sản phẩm: {Name}");
            Console.WriteLine($"Giá tiền: {Price}");
            Console.WriteLine($"Số lượng: {Quantity}");
            Console.WriteLine($"Tổng tiền: {GetTotalPrice()}");
        }

        public bool IsAvailable() 
        {
            return Quantity > 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Product product1 = new Product("Coca", 10000, 5);
            Product product2 = new Product("Bánh", 15000, 0);

            product1.Price = -5000;
            product1.Quantity = -10;

            product1.DisplayInfo();
            Console.WriteLine($"Sản phẩm: {product1.Name} {(product1.IsAvailable() ? "còn hàng" : "hết hàng")}\n");

            product2.DisplayInfo();
            Console.WriteLine($"Sản phẩm: {product2.Name} {(product2.IsAvailable() ? "còn hàng" : "hết hàng")}");

            Console.ReadLine();
        }
    }
}