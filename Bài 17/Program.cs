using System;
using System.Text;

namespace Bài_17
{
    class Student
    {
        public string Name { get; set; }

        private int age = 20;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Lỗi! Tuổi phải từ 0 đến 100.");
                }
            }
        }

        private double score = 8.5;
        public double Score
        {
            get { return score; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    score = value;
                }
                else
                {
                    Console.WriteLine("Lỗi! Điểm phải từ 0 đến 10.");
                }
            }
        }

        public Student(string name, int age, double score)
        {
            this.Name = name;
            this.Age = age;
            this.Score = score;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Score: {Score}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Student student1 = new Student("Quang", -20, 8.5);
            Student student2 = new Student("An", 21, 7);

            student1.DisplayInfo();
            student2.DisplayInfo();

            Console.ReadLine();
        }
    }
}