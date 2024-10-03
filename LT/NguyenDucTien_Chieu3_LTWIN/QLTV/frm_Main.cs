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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        //Hàm ân các form chưa dùng tới
        private void hideForm()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Hide();
            }
        }
        private void tsb_NhanVien_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach(Form f in this.MdiChildren)
            {
                if(f.Name == "frm_NhanVien")
                {
                    f.Activate();//
                    f.BringToFront();//Nổi lên trên cột
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            frm_NhanVien nv = new frm_NhanVien();
            nv.MdiParent = this;
            nv.WindowState = FormWindowState.Maximized;
            nv.Show();
        }

        private void tsb_DocGia_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frm_DocGia")
                {
                    f.Activate();//
                    f.BringToFront();//Nổi lên trên cột
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            frm_DocGia nv = new frm_DocGia();
            nv.MdiParent = this;
            nv.WindowState = FormWindowState.Maximized;
            nv.Show();
        }

        private void tsb_Sach_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frm_Sach")
                {
                    f.Activate();//
                    f.BringToFront();//Nổi lên trên cột
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            frm_Sach nv = new frm_Sach();
            nv.MdiParent = this;
            nv.WindowState = FormWindowState.Maximized;
            nv.Show();
        }

        private void tsb_BangCap_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frm_BangCap")
                {
                    f.Activate();//
                    f.BringToFront();//Nổi lên trên cột
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            frm_BangCap nv = new frm_BangCap();
            nv.MdiParent = this;
            nv.WindowState = FormWindowState.Maximized;
            nv.Show();
        }

        private void tsb_PhieuMuon_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frm_PhieuMuonSach")
                {
                    f.Activate();//
                    f.BringToFront();//Nổi lên trên cột
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            frm_PhieuMuonSach nv = new frm_PhieuMuonSach();
            nv.MdiParent = this;
            nv.WindowState = FormWindowState.Maximized;
            nv.Show();
        }

        private void tsb_PhieuThu_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frm_PhieuThu")
                {
                    f.Activate();//
                    f.BringToFront();//Nổi lên trên cột
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            frm_PhieuThuTien nv = new frm_PhieuThuTien();
            nv.MdiParent = this;
            nv.WindowState = FormWindowState.Maximized;
            nv.Show();
        }

        private void tsb_CTPM_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frm_ChiTietPhieuMuon")
                {
                    f.Activate();//
                    f.BringToFront();//Nổi lên trên cột
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            frm_CTPhieuMuon nv = new frm_CTPhieuMuon();
            nv.MdiParent = this;
            nv.WindowState = FormWindowState.Maximized;
            nv.Show();
        }

        private void tsb_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { 
                Application.Exit();
            }
        }
    }
}
