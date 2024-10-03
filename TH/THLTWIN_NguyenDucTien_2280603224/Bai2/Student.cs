using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai2
{
    internal class Student
    {
        //1. Field
        private string studentID;
        private string fullName;
        private float averageScore;
        private string faculty;

        public Student() { }
        public Student(string studentID, string fullName,  string faculty, float averageScore)
        {
            this.studentID = studentID;
            this.fullName = fullName;
            this.averageScore = averageScore;
            this.faculty = faculty;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }


        public void input()
        {
            Console.WriteLine("Nhap mssv:");
            studentID = Console.ReadLine();
            Console.WriteLine("Nhap ho ten sinh vien");
            fullName = Console.ReadLine();
            Console.WriteLine("Nhap khoa:");
            faculty = Console.ReadLine();
            Console.WriteLine("Nhap diem TB:");
            averageScore = float.Parse(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine($"ID: {this.studentID}, Name: {this.fullName}, Faculty: {this.faculty}, Avg: {this.averageScore}");
        }
    }
}
