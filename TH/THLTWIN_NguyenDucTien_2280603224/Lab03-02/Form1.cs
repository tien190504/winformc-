using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class frm_banverapchieuphim : Form
    {
        int totalAmount = 0;
        public frm_banverapchieuphim()
        {
            InitializeComponent();
            txt_thanhtien.Text = "0 VND";
        }

    
        //Hàm lấy giá ghế dựa trên số ghế
        private int GetSeatPrice(int seatNumber)
        {
            if (seatNumber >= 1 && seatNumber <= 5)
            {
                return 30000;
            }
            else if (seatNumber >= 6 && seatNumber <= 10)
            {
                return 40000;
            }
            else if (seatNumber >= 11 && seatNumber <= 15)
            {
                return 50000;
            }
            else
            {
                return 80000;
            }
        }
     

        private void btn_20_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            if(clicked.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vị trí này đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clicked.BackColor = Color.Blue;
            }
        }
       

       

        private void btn_select_Click(object sender, EventArgs e)
        {
            foreach(Control control in gb_selectSeat.Controls)
            {
                if(control is Button)
                {
                    Button btn = (Button)control;
                    if(btn.BackColor == Color.Blue)
                    {
                        int seatNumber = int.Parse(btn.Text);
                        totalAmount += GetSeatPrice(seatNumber);
                        btn.BackColor = Color.Yellow;
                    }
                }
            }
            txt_thanhtien.Text = totalAmount.ToString() + " VND";
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // Đặt lại ghế đã chọn về màu trắng và đặt tổng tiền về 0
            foreach (Control control in gb_selectSeat.Controls)
            {
                if (control is Button) // Ghế đang chọn
                {
                    Button btn = (Button)control;
                    control.BackColor = Color.White; // Đổi màu về trắng
                }
            }
            txt_thanhtien.Text = "0 VND"; // Cập nhật label hiển thị tổng tiền
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { 
                Application.Exit();
            }
        }
    }
}