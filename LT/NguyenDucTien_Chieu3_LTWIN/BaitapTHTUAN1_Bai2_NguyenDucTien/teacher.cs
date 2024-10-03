using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapTHTUAN1_Bai2_NguyenDucTien
{
    public class teacher : person
    {
        private string address;


        public teacher() { }
        public teacher(string address)
        {
            this.address = address;
        }


        public string Address { get => address; set => address = value; }

        public void input()
        {
            base.input();
            Console.WriteLine("Nhap dia chi:");
            address = Console.ReadLine();
        }
        public void output()
        {
            base.output();
            Console.WriteLine($"Dia chi: {address}");
        }
    }
}
