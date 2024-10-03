using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapTHTUAN1_Bai2_NguyenDucTien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student st = new student();
            st.input();
            st.output();
            Console.ReadKey();

            teacher teacher = new teacher();
            teacher.input();
            teacher.output();
            Console.ReadKey();
        }
    }
}
