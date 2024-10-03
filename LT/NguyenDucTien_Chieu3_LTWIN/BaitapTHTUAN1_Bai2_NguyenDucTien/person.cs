using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapTHTUAN1_Bai2_NguyenDucTien
{
    public class person
    {
        private int id;
        private string name;

        public person() { }
        public person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public void input()
        {
            Console.WriteLine("Nhap ID:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ho ten:");
            name = Console.ReadLine();
        }
        public void output() {
            Console.WriteLine($"ID: {id}, ho ten: {name}");
        }
    }
}
