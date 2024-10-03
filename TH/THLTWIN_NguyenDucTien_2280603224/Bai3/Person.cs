using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Person
    {
        private string id;
        private string fullName;

        public Person() { }
        public Person(string iD, string fullName)
        {
            this.id = iD;
            this.fullName = fullName;
        }

        public string ID { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }

        public virtual void input()
        {
            Console.WriteLine("Nhap ma so:");
            this.id = Console.ReadLine();
            Console.WriteLine("Nhap ten:");
            this.fullName += Console.ReadLine();
        }

        public virtual void output() {
            Console.Write($"ID: {id}, Name: {fullName}, ");
        }

    }
}
