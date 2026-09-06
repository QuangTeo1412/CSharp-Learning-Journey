using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_16
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
                    Console.WriteLine(" Lỗi: Giá không được âm! Giữ nguyên giá trị cũ.");
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
                    Console.WriteLine("Lỗi: Số lượng không được âm! Giữ nguyên giá trị cũ.");
                }
            }
        }

        public Product(string name1, double price1, int quantity1)
        {
            Name = name1;
            Price = price1;
            Price = (price1 >= 0) ? price1 : 10000;
            Quantity = quantity1;
            Quantity = (quantity1 >= 0) ? quantity1 : 5;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Quantity: {Quantity}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Product product1 = new Product("Coca", -10000, 5);
            product1.DisplayInfo();

            Product product2 = new Product("Bánh", -15000, 3);
            product2.DisplayInfo();

            Console.ReadLine();
        }
    }
}