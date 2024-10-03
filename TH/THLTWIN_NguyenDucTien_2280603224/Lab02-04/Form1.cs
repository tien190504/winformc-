using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab02_04
{
    public partial class frm_qltk : Form
    {
        public frm_qltk()
        {
            InitializeComponent();
        }

        private void frm_qltk_Load(object sender, EventArgs e)
        {
            txt_tongtien.Text = "0";
            this.dgv_ttkh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ttkh_CellContentClick);
        }

        // Hàm lấy dòng đã chọn theo số tài khoản
        public int getSelectRow(string accountNumber)
        {
            for (int i = 0; i < dgv_ttkh.Rows.Count; i++)
            {
                if (dgv_ttkh.Rows[i].Cells[1].Value != null && dgv_ttkh.Rows[i].Cells[1].Value.ToString() == accountNumber)
                {
                    return i; // Trả về chỉ số dòng nếu tìm thấy
                }
            }
            return -1; // Không tìm thấy
        }

        // Hàm thêm hoặc cập nhật thông tin
        private void insertUpdate(int selectRow)
        {
            dgv_ttkh.Rows[selectRow].Cells[1].Value = txt_sotaikhoan.Text;
            dgv_ttkh.Rows[selectRow].Cells[2].Value = txt_tentk.Text;
            dgv_ttkh.Rows[selectRow].Cells[3].Value = txt_diachikh.Text;
            dgv_ttkh.Rows[selectRow].Cells[4].Value = txt_sotien.Text;

            // Cập nhật số thứ tự
            for (int i = 0; i < dgv_ttkh.Rows.Count; i++)
            {
                dgv_ttkh.Rows[i].Cells[0].Value = (i + 1).ToString(); // Bắt đầu từ 1
            }

            UpdateTotalAmount(); // Cập nhật tổng tiền
        }

        private void btn_themCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_sotaikhoan.Text) || string.IsNullOrEmpty(txt_tentk.Text) || string.IsNullOrEmpty(txt_diachikh.Text) || string.IsNullOrEmpty(txt_sotien.Text))
                {
                    throw new Exception("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN KHÁCH HÀNG");
                }

                int selectedRow = getSelectRow(txt_sotaikhoan.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgv_ttkh.Rows.Add();
                    insertUpdate(selectedRow);
                    MessageBox.Show("Thêm dữ liệu mới thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    insertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Cập nhật tổng tiền
        private void UpdateTotalAmount()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgv_ttkh.Rows)
            {
                if (row.Cells[4].Value != null && decimal.TryParse(row.Cells[4].Value.ToString(), out decimal amount))
                {
                    total += amount;
                }
            }
            txt_tongtien.Text = total.ToString();
        }
        // thêm nút xóa
        private void btn_xoa_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem người dùng đã chọn dòng nào trong DataGridView chưa
            if (dgv_ttkh.SelectedRows.Count > 0)
            {
                // Hiển thị thông báo xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Xóa dòng đã chọn
                    foreach (DataGridViewRow row in dgv_ttkh.SelectedRows)
                    {
                        dgv_ttkh.Rows.RemoveAt(row.Index);
                    }

                    // Cập nhật tổng tiền sau khi xóa
                    UpdateTotalAmount();
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Thêm nút thoát
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo xác nhận trước khi thoát
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Thoát ứng dụng
            }
        }

        private void dgv_ttkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng người dùng đã chọn một dòng hợp lệ
            {
                DataGridViewRow selectedRow = dgv_ttkh.Rows[e.RowIndex];
                txt_sotaikhoan.Text = selectedRow.Cells[1].Value.ToString();
                txt_tentk.Text = selectedRow.Cells[2].Value.ToString();
                txt_diachikh.Text = selectedRow.Cells[3].Value.ToString();
                txt_sotien.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        }
    }
