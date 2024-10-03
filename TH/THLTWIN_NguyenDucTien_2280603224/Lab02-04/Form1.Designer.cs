namespace Lab02_04
{
    partial class frm_qltk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_qltt = new System.Windows.Forms.Label();
            this.lbl_sotaikhoan = new System.Windows.Forms.Label();
            this.lbl_tentk = new System.Windows.Forms.Label();
            this.lbl_diachikh = new System.Windows.Forms.Label();
            this.lbl_sotientrongtk = new System.Windows.Forms.Label();
            this.txt_sotaikhoan = new System.Windows.Forms.TextBox();
            this.txt_tentk = new System.Windows.Forms.TextBox();
            this.txt_diachikh = new System.Windows.Forms.TextBox();
            this.txt_sotien = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_themCapNhat = new System.Windows.Forms.Button();
            this.dgv_ttkh = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_tongtien = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttkh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_qltt
            // 
            this.lbl_qltt.AutoSize = true;
            this.lbl_qltt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qltt.ForeColor = System.Drawing.Color.Blue;
            this.lbl_qltt.Location = new System.Drawing.Point(-2, 9);
            this.lbl_qltt.Name = "lbl_qltt";
            this.lbl_qltt.Size = new System.Drawing.Size(721, 58);
            this.lbl_qltt.TabIndex = 0;
            this.lbl_qltt.Text = "Quản Lý Thông Tin Tài Khoản";
            // 
            // lbl_sotaikhoan
            // 
            this.lbl_sotaikhoan.AutoSize = true;
            this.lbl_sotaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sotaikhoan.Location = new System.Drawing.Point(103, 87);
            this.lbl_sotaikhoan.Name = "lbl_sotaikhoan";
            this.lbl_sotaikhoan.Size = new System.Drawing.Size(109, 20);
            this.lbl_sotaikhoan.TabIndex = 1;
            this.lbl_sotaikhoan.Text = "Số Tài Khoản";
            // 
            // lbl_tentk
            // 
            this.lbl_tentk.AutoSize = true;
            this.lbl_tentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tentk.Location = new System.Drawing.Point(95, 122);
            this.lbl_tentk.Name = "lbl_tentk";
            this.lbl_tentk.Size = new System.Drawing.Size(117, 20);
            this.lbl_tentk.TabIndex = 1;
            this.lbl_tentk.Text = "Tên Tài Khoản";
            // 
            // lbl_diachikh
            // 
            this.lbl_diachikh.AutoSize = true;
            this.lbl_diachikh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diachikh.Location = new System.Drawing.Point(61, 167);
            this.lbl_diachikh.Name = "lbl_diachikh";
            this.lbl_diachikh.Size = new System.Drawing.Size(151, 20);
            this.lbl_diachikh.TabIndex = 1;
            this.lbl_diachikh.Text = "Địa chỉ khách hàng";
            // 
            // lbl_sotientrongtk
            // 
            this.lbl_sotientrongtk.AutoSize = true;
            this.lbl_sotientrongtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sotientrongtk.Location = new System.Drawing.Point(36, 212);
            this.lbl_sotientrongtk.Name = "lbl_sotientrongtk";
            this.lbl_sotientrongtk.Size = new System.Drawing.Size(176, 20);
            this.lbl_sotientrongtk.TabIndex = 1;
            this.lbl_sotientrongtk.Text = "Số tiền trong tài khoản";
            // 
            // txt_sotaikhoan
            // 
            this.txt_sotaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sotaikhoan.Location = new System.Drawing.Point(260, 80);
            this.txt_sotaikhoan.Name = "txt_sotaikhoan";
            this.txt_sotaikhoan.Size = new System.Drawing.Size(428, 27);
            this.txt_sotaikhoan.TabIndex = 2;
            // 
            // txt_tentk
            // 
            this.txt_tentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tentk.Location = new System.Drawing.Point(260, 119);
            this.txt_tentk.Name = "txt_tentk";
            this.txt_tentk.Size = new System.Drawing.Size(428, 27);
            this.txt_tentk.TabIndex = 2;
            // 
            // txt_diachikh
            // 
            this.txt_diachikh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachikh.Location = new System.Drawing.Point(260, 160);
            this.txt_diachikh.Name = "txt_diachikh";
            this.txt_diachikh.Size = new System.Drawing.Size(428, 27);
            this.txt_diachikh.TabIndex = 2;
            // 
            // txt_sotien
            // 
            this.txt_sotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sotien.Location = new System.Drawing.Point(260, 205);
            this.txt_sotien.Name = "txt_sotien";
            this.txt_sotien.Size = new System.Drawing.Size(428, 27);
            this.txt_sotien.TabIndex = 2;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(614, 238);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(533, 238);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_themCapNhat
            // 
            this.btn_themCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themCapNhat.Location = new System.Drawing.Point(372, 238);
            this.btn_themCapNhat.Name = "btn_themCapNhat";
            this.btn_themCapNhat.Size = new System.Drawing.Size(155, 23);
            this.btn_themCapNhat.TabIndex = 3;
            this.btn_themCapNhat.Text = "Thêm / Cập Nhật";
            this.btn_themCapNhat.UseVisualStyleBackColor = true;
            this.btn_themCapNhat.Click += new System.EventHandler(this.btn_themCapNhat_Click);
            // 
            // dgv_ttkh
            // 
            this.dgv_ttkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ttkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_ttkh.Location = new System.Drawing.Point(59, 267);
            this.dgv_ttkh.Name = "dgv_ttkh";
            this.dgv_ttkh.RowHeadersWidth = 51;
            this.dgv_ttkh.RowTemplate.Height = 24;
            this.dgv_ttkh.Size = new System.Drawing.Size(680, 138);
            this.dgv_ttkh.TabIndex = 4;
            this.dgv_ttkh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ttkh_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã tài khoàn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // lbl_tongtien
            // 
            this.lbl_tongtien.AutoSize = true;
            this.lbl_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tongtien.Location = new System.Drawing.Point(478, 421);
            this.lbl_tongtien.Name = "lbl_tongtien";
            this.lbl_tongtien.Size = new System.Drawing.Size(78, 20);
            this.lbl_tongtien.TabIndex = 5;
            this.lbl_tongtien.Text = "Tổng tiền";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(588, 419);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(151, 22);
            this.txt_tongtien.TabIndex = 6;
            // 
            // frm_qltk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.lbl_tongtien);
            this.Controls.Add(this.dgv_ttkh);
            this.Controls.Add(this.btn_themCapNhat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txt_sotien);
            this.Controls.Add(this.txt_diachikh);
            this.Controls.Add(this.txt_tentk);
            this.Controls.Add(this.txt_sotaikhoan);
            this.Controls.Add(this.lbl_sotientrongtk);
            this.Controls.Add(this.lbl_diachikh);
            this.Controls.Add(this.lbl_tentk);
            this.Controls.Add(this.lbl_sotaikhoan);
            this.Controls.Add(this.lbl_qltt);
            this.Name = "frm_qltk";
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frm_qltk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttkh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_qltt;
        private System.Windows.Forms.Label lbl_sotaikhoan;
        private System.Windows.Forms.Label lbl_tentk;
        private System.Windows.Forms.Label lbl_diachikh;
        private System.Windows.Forms.Label lbl_sotientrongtk;
        private System.Windows.Forms.TextBox txt_sotaikhoan;
        private System.Windows.Forms.TextBox txt_tentk;
        private System.Windows.Forms.TextBox txt_diachikh;
        private System.Windows.Forms.TextBox txt_sotien;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_themCapNhat;
        private System.Windows.Forms.DataGridView dgv_ttkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lbl_tongtien;
        private System.Windows.Forms.TextBox txt_tongtien;
    }
}

