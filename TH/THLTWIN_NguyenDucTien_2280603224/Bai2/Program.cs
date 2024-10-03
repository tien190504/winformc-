using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("234567", "Tran Thi B", "Kinh Te", 8.5f),
                new Student("345678", "Le Van C", "Hoa Hoc", 7.8f),
                new Student("789012", "Hoang Van G", "CNTT", 3.9f),
                new Student("123456", "Nguyen Van A", "CNTT", 9.2f),
                new Student("456789", "Pham Thi D", "Toan", 6.9f),
                new Student("567890", "Vu Van E", "Ly", 5.5f),
                new Student("678901", "Ngo Thi F", "Sinh", 4.5f)
            };

            bool exit = false;
            while(!exit)
            {
                Console.WriteLine("========== MENU ==========");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Hien thi danh sach sinh vien");
                Console.WriteLine("3. Xuat ra thong tin cua cac SV deu thuoc khoa 'CNTT'");
                Console.WriteLine("4. Xuat ra thong tin sinh vien co diem TB lon hon bang 5.");
                Console.WriteLine("5. Xuat ra danh sach sinh vien duoc sap xep theo diem trung binh tang dan");
                Console.WriteLine("6. Xuat ra danh sach sinh vien co diem TB lon hon bang 5 va thuoc khoa 'CNTT'");
                Console.WriteLine("7. Xuat ra danh sach sinh vien co diem trung binh cao nhat va thuoc khoa 'CNTT'");
                Console.WriteLine("8. Hay cho biet so luong cua tung xep loai trong danh sach? Biet rang theo thang diem 10.");
                Console.WriteLine("0. Thoat!");
                Console.WriteLine("Chon chuc nang:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice) {
                    case 1:
                        addStudent(students); break;
                    case 2:
                        Console.WriteLine("========== Danh sach thong tin sinh vien chi tiet ==========");
                        DisplayStudentList(students);
                        break;
                    case 3:
                        DisplayStudentByFaculty(students, "CNTT");
                        break;
                    case 4:
                        SVcoDTBCao(students, 5);
                        break;
                    case 5:
                        sortStudentList(students); break;
                    case 6:
                        SVtheoKhoaVaDiem(students, "CNTT", 5);
                        break;
                    case 7:
                        SVTheoKhoaCoDTBMax(students, "CNTT");
                        break;
                    case 8:
                        ThongKeXepLoai(students);
                        break;
                    case 0:
                        exit = true; break;
                    default:
                        Console.WriteLine("Tuy chon khong hop le. Vui long chon lai!");
                        break;
                }
            }
        }
        //1. Them sinh vien
        static void addStudent(List<Student> students)
        {
            Console.WriteLine("========== Nhap thong tin sinh vien ==========");
            Student student = new Student();
            student.input();
            students.Add(student);
            Console.WriteLine("Them sinh vien thanh cong!");
        }
        //2. Hien thi danh sach sinh vien
        static void DisplayStudentList(List<Student> students)
        {
            foreach (Student student in students) {
                student.output();
            }
        }
        //3. Xuat ra thong tin cua cac sinh vien deu thuoc khoa "CNTT"
        static void DisplayStudentByFaculty(List<Student> students, string faculty)
        {
            Console.WriteLine($"Danh sach sinh vien thuoc khoa {faculty}:");
            var studentList = students.Where(x => x.Faculty.Equals(faculty)).ToList();
            DisplayStudentList(studentList);
        }

        //4 - Xuất ra thông tin sinh viên có điểm TB lớn hơn bằng 5.
        static void SVcoDTBCao(List<Student> students, float AverageScore)
        {
            Console.WriteLine($"========== Danh sach sinh vien co diem trung binh lon hon {AverageScore}==========");
            var studentList = students.Where(x => x.AverageScore >= AverageScore).ToList();
            DisplayStudentList(studentList);
        }
        //5 - Xuất ra danh sách sinh viên được sắp xếp theo điểm trung bình tăng dần
        static void sortStudentList(List<Student> students)
        {
            Console.WriteLine("========== Danh sach sinh vien da sap xep ==========");
            var studentList = students.OrderBy(s => s.AverageScore).ToList();
            DisplayStudentList(studentList);
        }
        //6 - Xuất ra danh sách sinh viên có điểm TB lớn hơn bằng 5 và thuộc khoa “CNTT”
        static void SVtheoKhoaVaDiem(List<Student> students, string faculty, float AverageScore)
        {
            Console.WriteLine($"========== Danh sach sinh vien thuoc khoa {faculty} va diem lon hon {AverageScore} ==========");
            var studentList = students.Where(s => s.Faculty.Equals(faculty) 
                                            && s.AverageScore >= AverageScore).ToList();
            DisplayStudentList(studentList);
        }
        //7- Xuất ra danh sách sinh viên có điểm trung bình cao nhất và thuộc khoa “CNTT”
        static void SVTheoKhoaCoDTBMax(List<Student> students, string faculty)
        {
            Console.WriteLine($"Danh sach sinh vien thuoc khoa {faculty} va co diem trung binh cao nhat:");

            var studentListFaculty = students.Where(s => s.Faculty.Equals(faculty)).ToList();

            if (studentListFaculty.Any())
            {
                var studentMaxInFaculty = studentListFaculty.OrderByDescending(s => s.AverageScore).FirstOrDefault();

                studentMaxInFaculty.output();
            }
            else
            {
                Console.WriteLine($"Khong co sinh vien nao thuoc khoa {faculty}.");
            }

        }
        //8- Hãy cho biết số lượng của từng xếp loại trong danh sách? Biết rằng theo thang điểm 10.
        static void ThongKeXepLoai(List<Student> students)
        {
            int xuatSac = students.Count(s => s.AverageScore >= 9.0f && s.AverageScore <= 10.0f);
            int gioi = students.Count(s => s.AverageScore >= 8.0f && s.AverageScore < 9.0f);
            int kha = students.Count(s => s.AverageScore >= 7.0f && s.AverageScore < 8.0f);
            int trungBinh = students.Count(s => s.AverageScore >= 5.0f && s.AverageScore < 7.0f);
            int yeu = students.Count(s => s.AverageScore >= 4.0f && s.AverageScore < 5.0f);
            int kem = students.Count(s => s.AverageScore < 4.0f);

            Console.WriteLine("Thong ke xep loai cua sinh vien:");
            Console.WriteLine($"Xuat sac (9.0 - 10.0): {xuatSac} sinh vien");
            Console.WriteLine($"Gioi (8.0 - 9.0): {gioi} sinh vien");
            Console.WriteLine($"Kha (7.0 -  8.0): {kha} sinh vien");
            Console.WriteLine($"Trung binh (5.0 - 7.0): {trungBinh} sinh vien");
            Console.WriteLine($"Yeu (4.0 - 5.0): {yeu} sinh vien");
            Console.WriteLine($"Kem (duoi 4.0): {kem} sinh vien");
        }
    }
}
