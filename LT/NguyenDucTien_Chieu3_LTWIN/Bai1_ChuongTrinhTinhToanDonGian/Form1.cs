using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_ChuongTrinhTinhToanDonGian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            offButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Hàm kiểm tra xem người dùng đã nhập chưa
        private bool checkNull()
        {
            if (txt_soM.Text == "" || txt_soN.Text == "")
            {
                return false;
            }
            return true;
        }
        //Hàm kiểm tra xem người dùng không được nhập chữ

        private void txt_soN_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '\b'))
                {
                    e.Handled = true;
                    MessageBox.Show("Không được nhập chữ", "Lỗi", MessageBoxButtons.OK);
                }
            }
        }

        //Hàm reset button
        private void resetButton()
        {
            btn_cong.BackColor = Color.White;
            btn_tru.BackColor = Color.White;
            btn_nhan.BackColor = Color.White;
            btn_chia.BackColor = Color.White;
        }
        //Hàm ẩn các button
        private void offButton()
        {
            btn_cong.Enabled = false;
            btn_tru.Enabled = false;
            btn_nhan.Enabled = false;
            btn_chia.Enabled = false;
        }

        private void onButton()
        {
            btn_cong.Enabled = true;
            btn_tru.Enabled = true;
            btn_nhan.Enabled = true;
            btn_chia.Enabled = true;
        }
        private void btn_cong_Click(object sender, EventArgs e)
        {
            if (!checkNull())
            {
                MessageBox.Show("Chưa nhập giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_soM.Focus();
            }

            else
            {
                resetButton();
                btn_cong.BackColor = Color.Blue;
                float soM = float.Parse(txt_soM.Text);
                float soN = float.Parse(txt_soN.Text);
                float kq = soM + soN;

                txt_ketqua.Text = kq.ToString();
            }

        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            if (!checkNull())
            {
                MessageBox.Show("Chưa nhập giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_soM.Focus();
            }

            else
            {  
                resetButton();
                btn_tru.BackColor = Color.Blue;
                float soM = float.Parse(txt_soM.Text);
                float soN = float.Parse(txt_soN.Text);
                float kq = soM - soN;

                txt_ketqua.Text = kq.ToString();
            }
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            if (!checkNull())
            {
                MessageBox.Show("Chưa nhập giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_soM.Focus();
            }

            else
            {
                resetButton();
                btn_nhan.BackColor = Color.Blue;
                float soM = float.Parse(txt_soM.Text);
                float soN = float.Parse(txt_soN.Text);
                float kq = soM * soN;

                txt_ketqua.Text = kq.ToString();
            }
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            if (!checkNull())
            {
                MessageBox.Show("Chưa nhập giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_soM.Focus();
            }

            else
            {
                resetButton();
                btn_chia.BackColor = Color.Blue;
                float soM = float.Parse(txt_soM.Text);
                float soN = float.Parse(txt_soN.Text);

                if(soN == 0)
                {
                    MessageBox.Show("Không được chia cho 0");
                }
                float kq = soM / soN;
                txt_ketqua.Text = kq.ToString();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_ketqua.Text = txt_soM.Text = txt_soN.Text = string.Empty;
        }

      
        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txt_soN_TextChanged(object sender, EventArgs e)
        {
            if(!checkNull())
            {
                offButton();
            }
            else
            {
                onButton();
            }
        }
    }
}
