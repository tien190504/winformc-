using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Teacher : Person
    {

        private string address;
        
        public Teacher() : base() { }
        public Teacher(string id, string fullName, string address) : base(id, fullName)
        {
            this.address = address;
        }

        public string Address { get => address; set => address = value; }
        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap dia chi:");
            this.address = Console.ReadLine();
        }
        public override void output() { 
            base.output();
            Console.WriteLine($"Address: {address}");
        }
    }
}
