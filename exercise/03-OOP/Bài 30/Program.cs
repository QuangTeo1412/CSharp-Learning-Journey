using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_30
{
    internal class Program
    {
        class Animal
        {
            public string Name { get; set; }
            public virtual void MakeSound()
            {
                Console.WriteLine("Động vật kêu");
            }
            public Animal(string name)
            {
                Name = name;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"Name: {Name}");
            }
        }
        class Dog : Animal
        {
            public Dog(string name) : base(name)
            {
            }
            public override void MakeSound()
            {
                Console.WriteLine("Gâu gâu");
            }
        }
        class Cat : Animal
        {
            public Cat(string name) : base(name)
            {
            }
            public override void MakeSound()
            {
                Console.WriteLine("Meo meo");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Animal animal1 = new Dog("Tuất");
            Animal animal2 = new Cat("Mão");
            animal1.ShowInfo();
            animal1.MakeSound();
            animal2.ShowInfo();
            animal2.MakeSound();
            Console.ReadLine();
        }
    }
}
