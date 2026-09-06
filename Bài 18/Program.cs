using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_18
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Score { get; set; }
        public Student(string name, int age, double score)
        {
            this.Name = name;
            this.Age = age;
            this.Score = score;
        }
        public void displayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Score: " + Score);
        }
        public bool isPassed()
        {
            return Score >= 5;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Student student1 = new Student("Quang", 20, 8.5);
            Student student2 = new Student("An", 21, 4);

            student1.displayInfo();
            if (student1.isPassed())
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            student2.displayInfo();
            if (student2.isPassed())
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }   

        }
    }
}
