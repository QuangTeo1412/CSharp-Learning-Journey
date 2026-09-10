using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_28
{
    internal class Program
    {
        class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public virtual void Eat()
            {
                Console.WriteLine("Đang ăn");
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age},");
            }
        }
        class Dog : Animal
        {
            public string Breed { get; set; }
            public override void Eat()
            {
                Console.WriteLine("Tuất đang ăn");
            }
            public void Bark()
            {
                Console.WriteLine("Gâu gâu");
            }
            public void DisplayDogInfo()
            {
                DisplayInfo();
                Console.WriteLine($"Breed: {Breed}");
            }
        }
        class Cat : Animal
        {
            public string Color { get; set; }

            public override void Eat()
            {
                Console.WriteLine("Lồn Mèo đang ăn");
            }
            public void Meow()
            {
                Console.WriteLine("Meo meo");
            }
            public void DisplayCatInfo()
            {
                DisplayInfo();
                Console.WriteLine($"Color: {Color}");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Dog dog = new Dog
            {
                Name = "Buddy",
                Age = 3,
                Breed = "Golden"
            };

            dog.Eat();
            dog.Bark();
            dog.DisplayDogInfo();

            Cat cat = new Cat
            {
                Name = "Mimi",
                Age = 2,
                Color = "Trắng"
            };

            cat.Eat();
            cat.Meow();
            cat.DisplayCatInfo();
            Console.ReadLine();
        }
    }
}
