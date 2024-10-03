using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class frm_QuanLyThongTinSV : Form
    {
        public frm_QuanLyThongTinSV()
        {
            InitializeComponent();
        }


        private void frm_QuanLyThongTinSV_Load(object sender, EventArgs e)
        {
            cmb_chuyennganh.SelectedIndex = 0;
            txt_tongsvnam.Text = "0";
            txt_tongsvnu.Text = "0";
        }


        // THÊM SINH VIÊN
        public int getSelectRow(string studentID)
        {
            for (int i = 0; i < dgv_Student.Rows.Count; i++)
            {
                if (dgv_Student.Rows[i].Cells[0].Value?.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgv_Student.Rows[selectedRow].Cells[0].Value = txt_mssv.Text;
            dgv_Student.Rows[selectedRow].Cells[1].Value = txt_hoten.Text;
            dgv_Student.Rows[selectedRow].Cells[2].Value = rb_nu.Checked ? "Nữ" : "Nam";

            dgv_Student.Rows[selectedRow].Cells[3].Value = float.Parse(txt_dtb.Text).ToString();

            dgv_Student.Rows[selectedRow].Cells[4].Value = cmb_chuyennganh.Text;
            UpdateStudentCount();
        }
        //SỬA SINH VIÊN
        private void btn_themsua_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_mssv.Text == "" || txt_hoten.Text == "" || txt_dtb.Text == "")
                {
                    throw new Exception("VUI LONG NHAP DAY DU THONG TIN SINH VIEN");
                }
                int selectedRow = getSelectRow(txt_mssv.Text);
                if(selectedRow == -1)
                {
                    selectedRow = dgv_Student.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Them du lieu moi thanh cong", "Thong Bao", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cap nhat du lieu thanh cong!", "Thong Bao", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        // Xóa sinh viên

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = getSelectRow(txt_mssv.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy mã sinh viên cần xóa!");
                }
                else
                {
                    DialogResult de = MessageBox.Show("Bạn có muốn xóa?", "Yes/No", MessageBoxButtons.YesNo);
                    if (de == DialogResult.Yes)
                    {
                        dgv_Student.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa sinh viên thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                UpdateStudentCount();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // 2.4 Viết code cho sự kiện ở DataGridView, người dùng chọn 1 dòng thì thể hiện ngược lại thông tin của các sinh viên đã chọn ở phần nhập liệu(bên trái).
        private void dgv_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_Student.Rows[e.RowIndex];

                txt_mssv.Text = selectedRow.Cells[0].Value?.ToString();
                txt_hoten.Text = selectedRow.Cells[1].Value?.ToString();
                if(selectedRow.Cells[2].Value?.ToString() == "Nữ")
                {
                    rb_nu.Checked = true;
                }
                else
                {
                    rb_nam.Checked = true;
                }
                txt_dtb.Text = selectedRow.Cells[3].Value?.ToString();
                cmb_chuyennganh.Text = selectedRow.Cells[4].Value?.ToString();


            }
        }
        //2.5 Tính toán lại số sinh viên Nam, Nữ phù hợp với các ngữ cảnh khi thay đổi dữ liệu
        private void UpdateStudentCount()
        {
            int maleCount = 0;
            int femaleCount = 0;

            // Duyệt qua các dòng trong DataGridView
            foreach (DataGridViewRow row in dgv_Student.Rows)
            {
                // Kiểm tra nếu giá trị giới tính không null
                if (row.Cells[2].Value != null)
                {
                    string gender = row.Cells[2].Value.ToString();
                    if (gender == "Nam")
                    {
                        maleCount++;
                    }
                    else if (gender == "Nữ")
                    {
                        femaleCount++;
                    }
                }
            }
            txt_tongsvnam.Text = maleCount.ToString();
            txt_tongsvnu.Text = femaleCount.ToString();
        }

    }
}
