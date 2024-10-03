using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenDucTien_week2
{
    public partial class frm_MayTinh : Form
    {
        public frm_MayTinh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txt_number1.Text);
                float number2 = float.Parse(txt_number2.Text);
                float kq = number1 + number2;
                txt_ketqua.Text = kq.ToString();
            } catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txt_number1.Text);
                float number2 = float.Parse(txt_number2.Text);
                float kq = number1 - number2;
                txt_ketqua.Text = kq.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txt_number1.Text);
                float number2 = float.Parse(txt_number2.Text);
                float kq = number1 * number2;
                txt_ketqua.Text = kq.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txt_number1.Text);
                float number2 = float.Parse(txt_number2.Text);
                if (number2 == 0) {
                    Console.WriteLine("Khong duoc chia cho 0");
                }
                float kq = number1 / number2;

                txt_ketqua.Text = kq.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void lbl_number1_Click(object sender, EventArgs e)
        {

        }
    }
}
