using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_21
{
    internal class Program
    {
        class student    
        {
            public string name { get; set; }
            public int age { get; set; }
            public double score { get; set; }
            public student(string name, int age, double score)
            {
                this.name = name;
                this.age = age;
                this.score = score;
            }
            public double AddScore(double bonus)
            {
                return score + bonus;
            }

        }
        static void Main(string[] args)
        { 
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            student student = new student("Quang", 20, 8);
            Console.WriteLine("Tên: " + student.name + " Tuổi: " + student.age+ " Điểm: " + student.score);
            double newScore = student.AddScore(4);

            Console.WriteLine("Điểm sau khi được cộng thêm: " + newScore);

            Console.WriteLine($"[Sau khi cộng] Điểm gốc trong đối tượng vẫn là: {student.score}");
            Console.ReadLine();
        }
    }
}
