using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_15
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
                if (value >= 0)
                {
                    age = value;
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
            }
        }
    } 

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Student student = new Student();    
            student.Name = "Quang";
            student.Age = -20;
            student.Score = 15;

            Console.WriteLine("Tên: " + student.Name);
            Console.WriteLine("Tuổi: " + student.Age);
            Console.WriteLine("Điểm: " + student.Score);
        }
    }
}