using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("==== MENU ====");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Danh sach sinh vien");
                Console.WriteLine("3. Xuat sinh vien thuoc khoa CNTT");
                Console.WriteLine("4. Danh sach sinh vien co diem trung binh lon hon 5");
                Console.WriteLine("5. Xuat danh sach sinh vien da duoc sap xep tang dan");
                Console.WriteLine("6. Xuat danh sach sinh vien co diem trung binh lon hon bang 5 va thuoc khoa ");
                Console.WriteLine("7. Xuat ra danh sach sinh vien có điem trung binh cao nhat và thuoc khoa\r\n“CNTT” ");
                Console.WriteLine("8.Hay cho biet so luong cua tung xep loai trong danh sach? Biet rang theo thang\r\nđiem 10.");
                Console.WriteLine("11. tai du lieu tu file");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("Chon chuc nang:");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddSampleStudents(students);
                        break;
                    case 2:
                        DisplayStudent(students);
                        break;
                    case 3:
                        DisplayStudentsByFaculty(students, "CNTT");
                        break;
                    case 4:
                        DisplayStudentsWithHighAverageScore(students, 5);
                        break;
                    case 5:
                        SortStudentAverageScore(students);
                        break;
                    case 6:
                        DisplayStudentsByFacultyAndScore(students, "CNTT", 5);
                        break;
                    case 7:
                        DisplayStudentsWithHighestAverageScoreByFaculty(students, "CNTT");
                        break;
                    case 8:
                        DisplayStudentCountByGrade(students);
                        break;
                    case 11:
                        LoadStudentsFromFile(students, "dulieusinhvien.doc");
                        break;

                    case 0:
                        exit = true;
                        Console.WriteLine("Ket thuc chuong trinh");
                        break;
                    default:
                        Console.WriteLine("Tuy chon khong hop le. Vui long nhap lai!");
                        break;
                }

            }

        }

        static void AddSampleStudents(List<Student> studentList)
        {
            // Dữ liệu mẫu để thêm vào danh sách
            var sampleStudents = new List<Student>
            {
                new Student("123456", "Nguyen Van A", "CNTT", 9.2f),
                new Student("234567", "Tran Thi B", "Kinh Te", 8.5f),
                new Student("345678", "Le Van C", "Hoa Hoc", 7.8f),
                new Student("456789", "Pham Thi D", "Toan", 6.9f),
                new Student("567890", "Vu Van E", "Ly", 5.5f),
                new Student("678901", "Ngo Thi F", "Sinh", 4.5f),
                new Student("789012", "Hoang Van G", "CNTT", 3.9f)
            };

            // Thêm dữ liệu mẫu vào danh sách
            studentList.AddRange(sampleStudents);
            Console.WriteLine("Đa them sinh vien mau!");
        }
        //case 1
        static void AddStudent(List<Student> students)
        {
            Console.WriteLine("Nhap thong tin sinh vien:");
            Student sv = new Student();
            sv.Input();
            students.Add(sv);
            Console.WriteLine("Them sinh vien thanh cong!");
        }
        //case 2
        static void DisplayStudent(List<Student> students)
        {
            Console.WriteLine("==== Danh sach sinh vien chi tiet ====");
            foreach (Student sv in students)
            {
                sv.show();
            }
        }
        //case 3
        static void DisplayStudentsByFaculty(List<Student> students, string faculty)
        {
            Console.WriteLine($"=== Danh sach sinh vien thuoc khoa {faculty} ===");
            foreach (Student sv in students)
            {
                if (faculty.Equals(sv.Faculty))
                {
                    sv.show();
                }
            }
        }

        //case 4
        static void DisplayStudentsWithHighAverageScore(List<Student> students, float minaverage)
        {
            Console.WriteLine("=== Danh sach sinh vien co diem trung binh lon hon 5");
            foreach (Student sv in students)
            {
                if (sv.Avg >= minaverage)
                {
                    sv.show();
                }
            }
        }
        //case 5
        static void SortStudentAverageScore(List<Student> students)
        {
            Console.WriteLine("=== Danh sach sinh vien da sap xep ===");
            var sortStudent = students.OrderBy(x => x.Avg).ToList();
            DisplayStudent(students);
        }

        //case 6
        static void DisplayStudentsByFacultyAndScore(List<Student> students, string faculty, float minAverage)
        {
            Console.WriteLine("=== Danh sach sinh vien co diem trung binh lon hon 5 va thuoc khoa CNTT");
            foreach (Student sv in students)
            {
                if (sv.Faculty == faculty && sv.Avg >= minAverage)
                {
                    sv.show();
                }
            }
        }
        //case 7
        static void DisplayStudentsWithHighestAverageScoreByFaculty(List<Student> students, string faculty)
        {
            var studentsInFaculty = students.Where(sv => sv.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();

            if (studentsInFaculty.Count == 0)
            {
                Console.WriteLine($"Không có sinh viên thuộc khoa {faculty}.");
                return;
            }

            // Tìm sinh viên có điểm trung bình cao nhất
            var highestAverageStudent = studentsInFaculty.OrderByDescending(sv => sv.Avg).FirstOrDefault();

            // Hiển thị thông tin của sinh viên có điểm trung bình cao nhất
            if (highestAverageStudent != null)
            {
                Console.WriteLine($"Sinh viên có điểm trung bình cao nhất trong khoa {faculty}:");
                highestAverageStudent.show();
            }
        }
        //case 8
        static void DisplayStudentCountByGrade(List<Student> students)
        {
            var gradeCount = new Dictionary<string, int>
            {
                {"Xuat sac", 0},
                {"Gioi", 0},
                {"Kha", 0},
                {"Trung binh", 0},
                {"Yeu", 0}
            };
            foreach (Student sv in students)
            {
                string grade;
                if (sv.Avg >= 9.0f)
                {
                    grade = "Xuat sac";
                }
                else if (sv.Avg >= 8.0f)
                {
                    grade = "Gioi";
                }
                else if (sv.Avg >= 7.0f)
                {
                    grade = "Kha";
                }
                else if (sv.Avg >= 5.0f)
                {
                    grade = "Trung binh";
                }
                else
                {
                    grade = "Yeu";
                }
                if (gradeCount.ContainsKey(grade))
                {
                    gradeCount[grade]++;
                }
            }
            Console.WriteLine("So luong sinh vien xep theo loai");
            foreach (var entry in gradeCount)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

        //case 11: tải dữ liệu từ file
        static void LoadStudentsFromFile(List<Student> students, string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File {filePath} khong ton tai.");
                return;
            }

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Loại bỏ dấu nháy kép và phân tách dữ liệu bằng dấu phẩy
                        line = line.Trim('"');
                        string[] parts = line.Split(new[] { ',' }, 4);

                        if (parts.Length == 4)
                        {
                            string id = parts[0].Trim();
                            string name = parts[1].Trim();
                            string faculty = parts[2].Trim();
                            float avg = float.Parse(parts[3].Trim(), CultureInfo.InvariantCulture);
                            // Tạo sinh viên và thêm vào danh sách
                            Student student = new Student
                            {
                                StudentID = id,
                                Name = name,
                                Faculty = faculty,
                                Avg = avg
                            };
                            students.Add(student);
                        }
                    }
                }
                Console.WriteLine("Đa tai du lieu sinh vien tu file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loi khi đoc file: {ex.Message}");
            }
        }
    }
}
