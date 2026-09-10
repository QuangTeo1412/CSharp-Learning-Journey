using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_20
{
    class student
    {
        public string name;
        public int age;
        public double score;
        public student(string name, int age, double score)
        {
            this.name = name;
            this.age = age;
            this.score = score;
        }
        public void Introduce(string message)
        {
            Console.WriteLine(message + " Tôi tên là: " + name + ", Tuổi: " + age );
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            student student1 = new student("Quang", 20, 8.5);
            student1.Introduce("KONICHIQUA");
            Console.ReadLine();
        }
    }
}
