using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frm_NhanVien : Form
    {
        public bool themmoi = false;
        NhanVien nv = new NhanVien();
        public frm_NhanVien()
        {
            InitializeComponent();
            lsv_DanhSachNV.Columns.Add("Mã NV", 60, HorizontalAlignment.Left);
            lsv_DanhSachNV.Columns.Add("Họ Tên", 150, HorizontalAlignment.Left);
            lsv_DanhSachNV.Columns.Add("Ngày sinh", 100, HorizontalAlignment.Left);
            lsv_DanhSachNV.Columns.Add("Địa Chỉ", 200, HorizontalAlignment.Left);
            lsv_DanhSachNV.Columns.Add("Điện thoại", 140, HorizontalAlignment.Left);
            lsv_DanhSachNV.Columns.Add("Bằng Cấp", 125, HorizontalAlignment.Left);
            loadDSNV();
            HienthiBangcap();
        }
        //đổ dữ liệu nhân viên xuống list view
        private void loadDSNV()
        {
            DataTable dt = nv.LayDSNV();//lấy danh sách
            //đổ xuống listview
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsv_DanhSachNV.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());
                item.SubItems.Add(dt.Rows[i][5].ToString());

            }
        }
        void HienthiNhanvien()
        {
            lsv_DanhSachNV.Items.Clear();
            DataTable dt = nv.LayDSNV();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsv_DanhSachNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }
        void setNull()
        {
            txt_hoten.Text = "";
            txt_diachi.Text = "";
            txt_dienthoai.Text = "";
        }
        void setButton(bool val)
        {
            btn_them.Enabled = val;
            btn_xoa.Enabled = val;
            btn_sua.Enabled = val;
            btn_thoat.Enabled = val;
            btn_luu.Enabled = !val;
            btn_huy.Enabled = !val;
        }
        void HienthiBangcap()
        {
            NhanVien nv = new NhanVien();
            DataTable dt = nv.LayBangcap();
            cbo_bangcap.DataSource = dt;
            cbo_bangcap.DisplayMember = "TenBangCap";
            cbo_bangcap.ValueMember = "MaBangCap";
        }

        private void lsv_DanhSachNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachNV.SelectedIndices.Count > 0)
            {
                txt_hoten.Text =
               lsv_DanhSachNV.SelectedItems[0].SubItems[1].Text;
                //Chuyen sang kieu dateTime
                dt_ngaysinh.Value = DateTime.Parse(lsv_DanhSachNV.SelectedItems[0].SubItems[2].Text);
                txt_diachi.Text =lsv_DanhSachNV.SelectedItems[0].SubItems[3].Text;
                txt_dienthoai.Text = lsv_DanhSachNV.SelectedItems[0].SubItems[4].Text;
                //Tìm vị trí của Tên bằng cấp trong Combobox
                cbo_bangcap.SelectedIndex = cbo_bangcap.FindString(lsv_DanhSachNV.SelectedItems[0].SubItems[5].Text);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            txt_hoten.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachNV.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật","Sửa mẫu tin");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachNV.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv.XoaNhanVien(lsv_DanhSachNV.SelectedItems[0].SubItems[0].Text);
                   lsv_DanhSachNV.Items.RemoveAt(
                   lsv_DanhSachNV.SelectedIndices[0]);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}",dt_ngaysinh.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver
            if (themmoi)
            {
                nv.ThemNhanVien(txt_hoten.Text, ngay, txt_diachi.Text,txt_dienthoai.Text, cbo_bangcap.SelectedValue.ToString());
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                nv.CapNhatNhanVien(lsv_DanhSachNV.SelectedItems[0].SubItems[0].Text,txt_hoten.Text, ngay, txt_diachi.Text, txt_dienthoai.Text,cbo_bangcap.SelectedValue.ToString());
                MessageBox.Show("Cập nhật thành công");
            }
            HienthiNhanvien();
            setNull();
        }
    }
}
