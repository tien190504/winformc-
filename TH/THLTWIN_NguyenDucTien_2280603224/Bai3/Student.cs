using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Student : Person
    {
        private string faculty;
        private float averageScore;

        public Student() { }
        public Student(string id, string fullName, string faculty, float averageScore) : base(id, fullName)
        {
            this.faculty = faculty;
            this.averageScore = averageScore;
        }

        public string Faculty { get => faculty; set => faculty = value; }
        public float AverageScore { get => averageScore; set => averageScore = value; }

        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap khoa: ");
            faculty = Console.ReadLine();
            Console.WriteLine("Nhap diem: ");
            averageScore = float.Parse(Console.ReadLine());
        }
        public override void output() { 
            base.output();
            Console.WriteLine($"Khoa: {faculty}, Diem: {averageScore}");
        }
    }
}
