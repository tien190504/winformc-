using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenDucTien_MayTinhDonGian
{
    public partial class frm_click : Form
    {
        int solanclick = 0;

        public frm_click()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ClickMe_MouseEnter(object sender, EventArgs e)
        {
            btn_ClickMe.Text = "Please Click me!";
            btn_ClickMe.BackColor = Color.DeepPink;
        }

        private void btn_ClickMe_MouseLeave(object sender, EventArgs e)
        {
            btn_ClickMe.Text = "Click me";
            btn_ClickMe.BackColor = Color.White;
        }

        private void btn_ClickMe_MouseClick(object sender, MouseEventArgs e)
        {
            solanclick++;
            lbl_solanclick.Text = solanclick.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                solanclick = 0;
                lbl_solanclick.Text = "số lần click: " + solanclick.ToString();
            }

        }
    }
}
