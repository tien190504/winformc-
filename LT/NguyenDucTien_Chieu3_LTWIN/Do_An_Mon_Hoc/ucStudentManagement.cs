using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraLayout.Customization;
using NguyenDucTien_2280603224.Entities;

namespace NguyenDucTien_2280603224
{
    public partial class ucStudentManagement : UserControl
    {
        DBContext context = new DBContext();
        public List<Sinh_Vien> listsv;
        public ucStudentManagement()
        {
            InitializeComponent();
            LoadData();
            cbo_khoa.SelectedIndex = 0;
        }
        private void LoadData()
        {
            using (var context = new DBContext())
            {
                // Lấy danh sách sinh viên và thông tin người dùng
                var data = (from sv in context.Sinh_Vien
                            join u in context.Users on sv.Ma_Sinh_Vien equals u.Ma_Sinh_Vien
                            select new
                            {
                                UserID = u.UserID,
                                UserName = u.UserName,
                                Password = u.Password,
                                MaSoSV = sv.Ma_Sinh_Vien,
                                Ho = u.Ho,
                                Ten = u.Ten,
                                GioiTinh = u.Gioi_Tinh,
                                NgaySinh = u.Ngay_Sinh,
                                Email = u.Email,
                                SoDienThoai = u.So_Dien_Thoai,
                                DiaChi = u.Dia_Chi,
                                Khoa = sv.Khoa,
                                //Trang_Thai_Hoc_Tap = sv.Trang_Thai_Hoc_Tap
                            }).ToList();

                // Gọi hàm BindGrid để gán dữ liệu cho DataGridView
                BindGrid(data.Cast<object>().ToList());
            }
        }

        private void BindGrid(List<object> list)
        {
            dgv_sinhvien.Rows.Clear();
            foreach (var item in list)
            {
                var obj = (dynamic)item; // Chuyển đổi item thành dynamic để truy cập các thuộc tính

                int index = dgv_sinhvien.Rows.Add();
                dgv_sinhvien.Rows[index].Cells[0].Value = obj.UserID;       // User ID
                dgv_sinhvien.Rows[index].Cells[1].Value = obj.UserName;     // User Name
                dgv_sinhvien.Rows[index].Cells[2].Value = obj.Password;      // Password
                dgv_sinhvien.Rows[index].Cells[3].Value = obj.MaSoSV;       // Mã Số SV
                dgv_sinhvien.Rows[index].Cells[4].Value = obj.Ho;           // Họ
                dgv_sinhvien.Rows[index].Cells[5].Value = obj.Ten;          // Tên
                dgv_sinhvien.Rows[index].Cells[6].Value = obj.GioiTinh ? "Nam" : "Nữ"; // Giới Tính
                dgv_sinhvien.Rows[index].Cells[7].Value = obj.NgaySinh;     // Ngày Sinh
                dgv_sinhvien.Rows[index].Cells[8].Value = obj.Email;        // Email
                dgv_sinhvien.Rows[index].Cells[9].Value = obj.SoDienThoai;  // Số Điện Thoại
                dgv_sinhvien.Rows[index].Cells[10].Value = obj.DiaChi;      // Địa Chỉ
                dgv_sinhvien.Rows[index].Cells[11].Value = obj.Khoa;        // Khoa
                //dgv_sinhvien.Rows[index].Cells[12].Value = obj.trang_thai_hoc_tap;
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            using (var context = new DBContext())
            {
                try
                {
                    // Lấy giá trị khoa đã chọn
                    string selectedKhoa = cbo_khoa.Text; // Sử dụng Text để lấy giá hiển thị

                    // Kiểm tra các trường đầu vào không để trống
                    if (string.IsNullOrWhiteSpace(txt_mssv.Text))
                    {
                        MessageBox.Show("Mã sinh viên không được để trống.");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txt_userid.Text))
                    {
                        MessageBox.Show("User ID không được để trống.");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(selectedKhoa)) // Kiểm tra selectedKhoa
                    {
                        MessageBox.Show("Khoa không được để trống.");
                        return;
                    }

                    // Tạo đối tượng sinh viên mới
                    var newStudent = new Sinh_Vien
                    {
                        Ma_Sinh_Vien = txt_mssv.Text,
                        Khoa = selectedKhoa, // Lấy giá trị Khoa đã chọn
                        Ngay_Nhap_Hoc = DateTime.Now,
                        Trang_Thai_Hoc_Tap = 1
                    };

                    // Tạo đối tượng người dùng mới
                    var newUser = new User
                    {
                        UserID = txt_userid.Text,
                        Ma_Sinh_Vien = newStudent.Ma_Sinh_Vien,
                        UserName = txt_username.Text,
                        Password = txt_password.Text,
                        Ho = txt_ho.Text,
                        Ten = txt_ten.Text,
                        So_Dien_Thoai = txt_sodienthoai.Text,
                        Email = txt_email.Text,
                        Dia_Chi = txt_diachi.Text,
                        Gioi_Tinh = rb_nam.Checked,
                        Ngay_Sinh = dtp_ngaysinh.Value,
                        Ngay_Cap = DateTime.Now,
                        Trang_Thai_Hoat_Dong = true
                    };

                    // Thêm sinh viên và người dùng vào ngữ cảnh
                    context.Users.Add(newUser);
                    context.Sinh_Vien.Add(newStudent);

                    // Lưu thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();

                    // Tải lại dữ liệu vào DataGridView
                    LoadData();

                    MessageBox.Show("Thêm sinh viên và người dùng thành công!");
                }
                catch (DbUpdateException ex)
                {
                    // Xử lý lỗi cập nhật

                    MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.InnerException?.Message);
                }
                catch (DbEntityValidationException ex)
                {
                    // Xử lý lỗi xác thực
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Thuộc tính: {validationError.PropertyName} Lỗi: {validationError.ErrorMessage}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khóa ngoại khi thêm sinh viên");
                }
            }
        }







        private void btn_sua_Click(object sender, EventArgs e)
        {
            using (var context = new DBContext())
            {
                try
                {
                    // Find student by Ma_Sinh_Vien
                    var maSinhVien = txt_mssv.Text;
                    var student = context.Sinh_Vien.FirstOrDefault(sv => sv.Ma_Sinh_Vien == maSinhVien);

                    if (student != null)
                    {
                        // Update student information
                        //student.Khoa = txt_khoa.Text;
                        //student.Ngay_Nhap_Hoc = dateNgayNhapHoc.Value;
                        student.Trang_Thai_Hoc_Tap = 1; // Example status update

                        // Find the associated user by Ma_Sinh_Vien
                        var user = context.Users.FirstOrDefault(u => u.Ma_Sinh_Vien == maSinhVien);
                        if (user != null)
                        {
                            // Update user information
                            user.UserName = txt_username.Text;
                            user.Password = txt_password.Text;
                            user.Ho = txt_ho.Text;
                            user.Ten = txt_ten.Text;
                            user.So_Dien_Thoai = txt_sodienthoai.Text;
                            user.Email = txt_email.Text;
                            user.Dia_Chi = txt_diachi.Text;
                            user.Gioi_Tinh = rb_nam.Checked;
                            user.Ngay_Sinh = dtp_ngaysinh.Value;
                        }

                        // Save changes
                        context.SaveChanges();
                        LoadData();
                        MessageBox.Show("Cập nhật sinh viên và người dùng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa sinh viên: " + ex.Message);
                }
            }
        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            using (var context = new DBContext())
            {
                try
                {
                    var maSinhVien = txt_mssv.Text;

                    // Find the student by Ma_Sinh_Vien
                    var student = context.Sinh_Vien.FirstOrDefault(sv => sv.Ma_Sinh_Vien == maSinhVien);

                    if (student != null)
                    {
                        // Find the associated user
                        var user = context.Users.FirstOrDefault(u => u.Ma_Sinh_Vien == maSinhVien);
                        if (user != null)
                        {
                            // Remove the user
                            context.Users.Remove(user);
                        }

                        // Remove the student
                        context.Sinh_Vien.Remove(student);

                        // Save changes to the database
                        context.SaveChanges();

                        // Refresh DataGridView
                        LoadData();

                        MessageBox.Show("Xóa sinh viên và người dùng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên để xóa.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sinh viên: sinh viên đang có liên kết với bảng khác" + "");
                }
            }
        }

        private void dgv_sinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ số hàng đã chọn
            {
                var selectedRow = dgv_sinhvien.Rows[e.RowIndex]; // Lấy hàng đã chọn

                // Gán giá trị từ các ô trong hàng đã chọn vào các ô nhập liệu
                txt_userid.Text = selectedRow.Cells[0].Value?.ToString(); // User ID
                txt_username.Text = selectedRow.Cells[1].Value?.ToString(); // User Name
                txt_password.Text = selectedRow.Cells[2].Value?.ToString(); // Password
                txt_mssv.Text = selectedRow.Cells[3].Value?.ToString(); // Mã số sinh viên
                txt_ho.Text = selectedRow.Cells[4].Value?.ToString(); // Họ
                txt_ten.Text = selectedRow.Cells[5].Value?.ToString(); // Tên
                rb_nam.Checked = selectedRow.Cells[6].Value?.ToString() == "Nam"; // Giới tính
                rb_nu.Checked = !rb_nam.Checked; // Đặt trạng thái giới tính ngược lại

                // Chuyển đổi giá trị ngày sinh sang kiểu DateTime
                if (DateTime.TryParse(selectedRow.Cells[7].Value?.ToString(), out DateTime ngaysinh))
                {
                    dtp_ngaysinh.Value = ngaysinh; // Đặt giá trị cho DateTimePicker
                }

                txt_email.Text = selectedRow.Cells[8].Value?.ToString(); // Email
                txt_sodienthoai.Text = selectedRow.Cells[9].Value?.ToString(); // Số điện thoại
                txt_diachi.Text = selectedRow.Cells[10].Value?.ToString(); // Địa chỉ

                // Tìm và đặt khoa trong ComboBox theo tên khoa
                cbo_khoa.Text = selectedRow.Cells[11].Value?.ToString(); // Đặt giá trị cho ComboBox khoa
            }
        }
    }
}
