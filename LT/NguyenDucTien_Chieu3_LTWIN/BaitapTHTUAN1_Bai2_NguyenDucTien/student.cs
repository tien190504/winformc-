using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapTHTUAN1_Bai2_NguyenDucTien
{
    public class student : person
    {
        private float AverageScores;
        private string faculty;

        public student() { }
        public student(float averageScores, string faculty)
        {
            AverageScores1 = averageScores;
            this.Faculty = faculty;
        }

        public float AverageScores1 { get => AverageScores; set => AverageScores = value; }
        public string Faculty { get => faculty; set => faculty = value; }

        public void input()
        {
            base.input();
            Console.WriteLine("Nhap diem trung binh:");
            AverageScores = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap khoa:");
            faculty = Console.ReadLine();
        }

        public void output()
        {
            base.output();
            Console.WriteLine($"DTB: {AverageScores}, khoa: {faculty}");
        }
    }
}
