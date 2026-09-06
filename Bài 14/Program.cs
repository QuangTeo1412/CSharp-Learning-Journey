using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            myStudent.Name = "Quang";
            myStudent.Age = -5;

            Console.WriteLine($"Name: {myStudent.Name}");
            Console.WriteLine($"Age: {myStudent.Age}");

        }
    }
    class Student
    {
        public string Name { get; set; }

        public double Age
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
        private double age;
    }
}

