using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Student
    {
        private string ID;
        private string name;
        private float avg;
        private string faculty;

        public string StudentID { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public float Avg { get => avg; set => avg = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public Student() { }

        public Student(string ID, string name, string faculty, float avg)
        {
            this.ID = ID;
            this.Name = name;
            this.Avg = avg;
            this.Faculty = faculty;
        }
        public void Input()
        {
            Console.WriteLine("Nhap mssv:");
            ID = Console.ReadLine();
            Console.WriteLine("Nhap ten sinh vien:");
            name = Console.ReadLine();
            Console.WriteLine("Nhap diem sinh vien");
            avg = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap khoa:");
            faculty = Console.ReadLine();
        }
        public void show()
        {
            Console.WriteLine($"ID: {ID}, NAME: {name}, AVG: {avg}, FACULTY: {faculty}");
        }
        
    }
}
