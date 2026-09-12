using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BÀi_29
{
    internal class Program
    {
        class Animal
        {
            public string Name { get; set; }
            public Animal(string name)
            {
                Name = name;
            }
            public virtual void MakeSound()
            {
                Console.WriteLine("Động vật kêu");
            }
        }
        class Dog : Animal
        {
            public string Breed { get; set; }
            public Dog(string name, string breed) : base(name)
            {
                Breed = breed;
            }
            public override void MakeSound()
            {
                Console.WriteLine("Gâu Gâu");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Animal animal = new Dog("Tuất", "Golden");
            animal.MakeSound();
            Console.WriteLine($"Tên: {animal.Name}");
            Console.ReadLine();
        }
    }
}
