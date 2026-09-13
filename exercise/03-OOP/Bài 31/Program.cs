using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_31
{
    internal class Program
    {
        class Animal
        {
            private string Name ;
            public string name
            {
                get { return Name; }
                set
                    {
                    if (value.Length > 0)
                    {
                        Name = value;
                    }
                    else
                    {
                        Console.WriteLine("Tên không được để trống");
                    } 
                }
            }

            private int Age;
            public int age
            {
                get { return Age; }
                set
                {
                    if (value >= 0 && value <= 100)
                    {
                        Age = value;
                    }
                    else
                    {
                        Console.WriteLine("Tuổi không được âm và không được lớn hơn 100");
                    }
                }
            }

            public virtual void MakeSound()
            {
                Console.WriteLine("Động vật phát ra âm thanh");
            }
            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Tên: {Name}, Tuổi: {Age}");
            }
            public Animal(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        class Dog : Animal
        {
            public string Breed { get; set; }
            public Dog(string name, int age, string breed) : base(name, age)
            {
                Breed = breed;
            }
            public override void MakeSound()
            {
                Console.WriteLine("Gâu gâu");
            }
            public void Bark()
            {
                Console.WriteLine("Chó đang sủa");
            }
            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Tên: {name}, Tuổi:{age}, Giống: {Breed}");
            }
        }
        class Cat : Animal
        {
            public string Color { get; set; }
            public Cat(string name, int age, string color) : base(name, age)
            {
                Color = color;
            }
            public override void MakeSound()
            {
                Console.WriteLine("Meo meo");
            }
            public void Meow()
            {
                Console.WriteLine("Mèo đang kêu");
            }
            public void Scratch()
            {
                Console.WriteLine("Mèo đang cào");
            }
            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Tên: {name}, Tuổi:{age}, Màu: {Color}");
            }
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;

            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("Lucky", 3, "Golden Retriever"));
            animals.Add(new Cat("Mimi", 2, "White"));

            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;

                Console.WriteLine("======QUẢN LÝ ĐỘNG VẬT======:");
                Console.WriteLine("1.Thêm Chó");
                Console.WriteLine("2.Thêm Mèo");
                Console.WriteLine("3.Hiển Thị Tất Cả Động Vật");
                Console.WriteLine("4.Cho Động Vật Phát Ra Âm Thanh");
                Console.WriteLine("5.Thoát");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Vui lòng nhập một số hợp lệ.");
                    continue;
                }
                if (choice == 1)
                {
                    Console.WriteLine("Nhập tên chó:");
                    string name = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Tên không được để trống. Vui lòng nhập lại:");
                        name = Console.ReadLine();
                    }

                    Console.WriteLine("Nhập tuổi chó:");
                    int age;
                    while (!int.TryParse(Console.ReadLine(), out age) || age < 0 || age > 100)
                    {
                        Console.WriteLine("Tuổi phải là số nguyên. Tuổi không được âm và không được lớn hơn 100. Vui lòng nhập lại:");
                    }

                    Console.WriteLine("Nhập giống chó:");
                    string breed = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(breed))
                    {
                        Console.WriteLine("Giống không được để trống. Vui lòng nhập lại:");
                        breed = Console.ReadLine();
                    }
                    animals.Add(new Dog(name, age, breed));
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Nhập tên mèo:");
                    string name = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Tên không được để trống. Vui lòng nhập lại:");
                        name = Console.ReadLine();
                    }

                    Console.WriteLine("Nhập tuổi mèo:");
                    int age;
                    while (!int.TryParse(Console.ReadLine(), out age) || age < 0 || age > 100)
                    {
                        Console.WriteLine("Tuổi phải là số nguyên. Tuổi không được âm và không được lớn hơn 100. Vui lòng nhập lại:");
                    }

                    Console.WriteLine("Nhập màu mèo:");
                    string color = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(color))
                    {
                        Console.WriteLine("Màu không được để trống. Vui lòng nhập lại:");
                        color = Console.ReadLine();
                    }
                    animals.Add(new Cat(name, age, color));
                }
                else if (choice == 3)
                {
                    foreach (var animal in animals)
                    {
                        animal.DisplayInfo();
                        Console.WriteLine("--------------------");
                    }
                }
                else if (choice == 4)
                {
                    foreach (var animal in animals)
                    {
                        animal.MakeSound();
                        Console.WriteLine("--------------------");
                    }
                }
                else if (choice == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                }
            }
        }
    }
}
