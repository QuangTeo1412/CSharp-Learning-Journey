using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_27
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public void Introduce()
            {
                Console.WriteLine($"Xin Chào, Tôi tên là {Name} Và Tôi {Age} tuổi.");
            }
        }
        class Student : Person
        {
            public string StudentId { get; set; }
            public string School { get; set; }
            public void Study()
            {
                Console.WriteLine($"Tôi đang học tại {School}");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Student student = new Student();
            student.Name = "Quang";
            student.Age = 20;
            student.StudentId = "SV001";
            student.School = "Đại học Bách Khoa";
            student.Introduce();
            Console.WriteLine($"Mã sinh viên của tôi là {student.StudentId}");
            student.Study();
            Console.ReadLine();
        }
    }
}
