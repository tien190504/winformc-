using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> {
                new Student("SV1", "Tran Thi B", "Kinh Te", 8.5f),
                new Student("SV2", "Le Van C", "Hoa Hoc", 7.8f),
                new Student("SV3", "Hoang Van G", "CNTT", 3.9f),
                new Student("SV4", "Nguyen Van A", "CNTT", 9.2f),
                new Student("SV5", "Pham Thi D", "Toan", 6.9f),
                new Student("SV6", "Vu Van E", "Ly", 5.5f),
                new Student("SV7", "Ngo Thi F", "Sinh", 4.5f)
            };
            List<Teacher> teachers = new List<Teacher> {
                new Teacher("GV1", "Le Thi H", "Quan 9"),
                new Teacher("GV2", "Cao Minh T", "Quan 7"),
                new Teacher("GV3", "Ho Thi K", "Thu Duc"),
                new Teacher("GV4", "Le Minh Q", "Quan 1"),
                new Teacher("GV5", "Do Hai N", "Quan 3"),

            };


            bool exit = false;
            while (!exit) {
                Console.WriteLine("============MENU============");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Them giao vien");
                Console.WriteLine("3. Xuat danh sach sinh vien");
                Console.WriteLine("4. Xuat danh sach giao vien");
                Console.WriteLine("5. So luong tung danh sach(tong so sinh vien, tong so giao vien)");
                Console.WriteLine("6. Xuat danh sach cac sinh vien thuoc khoa CNTT");
                Console.WriteLine("7. Xuat ra danh sach giao vien co dia chi chua thong tin 'Quan 9");
                Console.WriteLine("8. Xuat ra danh sach sinh vien co diem trung binh cao nhat va thuoc khoa CNTT");
                Console.WriteLine("9. Hay cho biet so luong cua tung xep loai trong danh sach? Biet rang theo thang diem 10");
                Console.WriteLine("0. Thoat!");
                Console.WriteLine("Chon chuc nang:");

                int choice = int.Parse(Console.ReadLine());
                switch (choice) {
                    case 1:
                        addStudent(students);
                        break;
                    case 2:
                        addTeacher(teachers);
                        break;
                    case 3:
                        DisplayStudentList(students); break;    
                    case 4:
                        DisplayTeacherList(teachers);
                        break;
                    case 5:
                        DisplayCount(students,teachers); break;
                    case 6:
                        DisplayStudentByFaculty(students, "CNTT");
                        break;
                    case 7:
                        DisplayTeacherByAddress(teachers, "Quan 9");
                        break;
                    case 8:
                        DisplayTopStudentInDepartment(students, "CNTT"); break;
                    case 9:
                        ThongKeXepLoai(students); break;
                    case 0:
                        exit = true;
                        break;
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
        //2. Them giao vien
        static void addTeacher(List<Teacher> teachers)
        {
            Console.WriteLine("========== Nhap thong tin giao vien ==========");
            Teacher teacher = new Teacher();
            teacher.input();
            teachers.Add(teacher);
            Console.WriteLine("Them giao vien thanh cong!");
        }
        //3. Xuat danh sach sinh vien
        static void DisplayStudentList(List<Student> students)
        {
            foreach (Student student in students)
            {
                student.output();
            }
        }


        //4. Xuat danh sach giao vien
        static void DisplayTeacherList(List<Teacher> teachers)
        {
            foreach (Teacher teacher in teachers)
            {
                teacher.output();
            }
        }


        //5- Số lượng từng danh sách(tổng số sinh viên, tổng số giáo viên)
        static void DisplayCount(List<Student> students, List<Teacher> teachers)
        {
            Console.WriteLine($"Tong so sinh vien: {students.Count}");
            Console.WriteLine($"Tong so giao vien:{teachers.Count}");
        }



        //6- Xuất danh sách các Sinh Viên thuộc khoa “CNTT”. 
        static void DisplayStudentByFaculty(List<Student> students, string faculty)
        {
            Console.WriteLine($"Danh sach sinh vien thuoc khoa {faculty}:");
            var studentList = students.Where(x => x.Faculty.Equals(faculty)).ToList();
            DisplayStudentList(studentList);
        }


        //7- Xuất ra danh sách giáo viên có địa chỉ chứa thông tin “Quận 9” 
        static void DisplayTeacherByAddress(List<Teacher> teachers, string address)
        {
            Console.WriteLine($"Danh sach giao vien co dia chi {address}");
            var teacherList = teachers.Where(t => t.Address.Equals(address)).ToList();
            DisplayTeacherList(teacherList);
        }

        //8- Xuất ra danh sách sinh viên có điểm trung bình cao nhất và thuộc khoa “CNTT” 
        static void DisplayTopStudentInDepartment(List<Student> students, string faculty)
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
        //9- Hãy cho biết số lượng của từng xếp loại trong danh sách? Biết rằng theo thang điểm 10.
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
