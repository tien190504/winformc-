using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenDucTien_2280603224
{
    public partial class frm_quantrivien : Form
    {
        // Khai báo các UserControl
        private ucStudentManagement ucStudents;
        private ucTeacherManagement ucTeachers;

        public frm_quantrivien()
        {
            InitializeComponent();

            // Khởi tạo các UserControl
            ucStudents = new ucStudentManagement();
            ucTeachers = new ucTeacherManagement();

            // Thêm các UserControl vào Form
            ucStudents.Dock = DockStyle.Fill; // Để UserControl hiển thị toàn bộ diện tích của Form
            ucTeachers.Dock = DockStyle.Fill;

            p_user.Controls.Add(ucStudents);
            p_user.Controls.Add(ucTeachers);

            // Đảm bảo UserControl nào sẽ hiển thị đầu tiên
            ucStudents.BringToFront();
        }
        private void frm_quantrivien_Load(object sender, EventArgs e)
        {

        }
        // Sự kiện khi nhấn nút Quản lý Học sinh
        private void btnQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            ucStudents.BringToFront();
        }

        // Sự kiện khi nhấn nút Quản lý Giáo viên
        private void btnQuanLyGiaoVien_Click(object sender, EventArgs e)
        {
            ucTeachers.BringToFront();
        }

        

        private void btn_chung_Click(object sender, EventArgs e)
        {

        }
    }

}
