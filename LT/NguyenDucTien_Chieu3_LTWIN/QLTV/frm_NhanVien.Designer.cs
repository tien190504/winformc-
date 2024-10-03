namespace QLTV
{
    partial class frm_NhanVien
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
            this.btn_them = new System.Windows.Forms.Button();
            this.gb_ttNV = new System.Windows.Forms.GroupBox();
            this.cbo_bangcap = new System.Windows.Forms.ComboBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_dienthoai = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.lbl_bangcap = new System.Windows.Forms.Label();
            this.lbl_dienthoai = new System.Windows.Forms.Label();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.lbl_qlnv = new System.Windows.Forms.Label();
            this.lsv_DanhSachNV = new System.Windows.Forms.ListView();
            this.gb_ttNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(208, 147);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(95, 40);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // gb_ttNV
            // 
            this.gb_ttNV.Controls.Add(this.cbo_bangcap);
            this.gb_ttNV.Controls.Add(this.btn_them);
            this.gb_ttNV.Controls.Add(this.btn_thoat);
            this.gb_ttNV.Controls.Add(this.btn_huy);
            this.gb_ttNV.Controls.Add(this.btn_luu);
            this.gb_ttNV.Controls.Add(this.btn_sua);
            this.gb_ttNV.Controls.Add(this.btn_xoa);
            this.gb_ttNV.Controls.Add(this.txt_dienthoai);
            this.gb_ttNV.Controls.Add(this.txt_diachi);
            this.gb_ttNV.Controls.Add(this.txt_hoten);
            this.gb_ttNV.Controls.Add(this.dt_ngaysinh);
            this.gb_ttNV.Controls.Add(this.lbl_bangcap);
            this.gb_ttNV.Controls.Add(this.lbl_dienthoai);
            this.gb_ttNV.Controls.Add(this.lbl_diachi);
            this.gb_ttNV.Controls.Add(this.lbl_ngaysinh);
            this.gb_ttNV.Controls.Add(this.lbl_hoten);
            this.gb_ttNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ttNV.Location = new System.Drawing.Point(13, 45);
            this.gb_ttNV.Name = "gb_ttNV";
            this.gb_ttNV.Size = new System.Drawing.Size(1027, 188);
            this.gb_ttNV.TabIndex = 6;
            this.gb_ttNV.TabStop = false;
            this.gb_ttNV.Text = "Thông Tin Nhân Viên";
            // 
            // cbo_bangcap
            // 
            this.cbo_bangcap.FormattingEnabled = true;
            this.cbo_bangcap.Location = new System.Drawing.Point(695, 68);
            this.cbo_bangcap.Name = "cbo_bangcap";
            this.cbo_bangcap.Size = new System.Drawing.Size(326, 33);
            this.cbo_bangcap.TabIndex = 8;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(631, 147);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 40);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(552, 147);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 40);
            this.btn_huy.TabIndex = 3;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(471, 147);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 40);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(390, 147);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 40);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(309, 147);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 40);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_dienthoai
            // 
            this.txt_dienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dienthoai.Location = new System.Drawing.Point(695, 24);
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.Size = new System.Drawing.Size(326, 30);
            this.txt_dienthoai.TabIndex = 1;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(162, 103);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(362, 30);
            this.txt_diachi.TabIndex = 1;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoten.Location = new System.Drawing.Point(162, 24);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(362, 30);
            this.txt_hoten.TabIndex = 1;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngaysinh.Location = new System.Drawing.Point(162, 63);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(362, 30);
            this.dt_ngaysinh.TabIndex = 0;
            // 
            // lbl_bangcap
            // 
            this.lbl_bangcap.AutoSize = true;
            this.lbl_bangcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bangcap.Location = new System.Drawing.Point(582, 66);
            this.lbl_bangcap.Name = "lbl_bangcap";
            this.lbl_bangcap.Size = new System.Drawing.Size(100, 25);
            this.lbl_bangcap.TabIndex = 1;
            this.lbl_bangcap.Text = "Bằng Cấp";
            // 
            // lbl_dienthoai
            // 
            this.lbl_dienthoai.AutoSize = true;
            this.lbl_dienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dienthoai.Location = new System.Drawing.Point(582, 27);
            this.lbl_dienthoai.Name = "lbl_dienthoai";
            this.lbl_dienthoai.Size = new System.Drawing.Size(107, 25);
            this.lbl_dienthoai.TabIndex = 1;
            this.lbl_dienthoai.Text = "Điện Thoại";
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diachi.Location = new System.Drawing.Point(33, 108);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(71, 25);
            this.lbl_diachi.TabIndex = 1;
            this.lbl_diachi.Text = "Địa chỉ";
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaysinh.Location = new System.Drawing.Point(33, 59);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(99, 25);
            this.lbl_ngaysinh.TabIndex = 1;
            this.lbl_ngaysinh.Text = "Ngày sinh";
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoten.Location = new System.Drawing.Point(33, 27);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(77, 25);
            this.lbl_hoten.TabIndex = 1;
            this.lbl_hoten.Text = "Họ Tên";
            // 
            // lbl_qlnv
            // 
            this.lbl_qlnv.AutoSize = true;
            this.lbl_qlnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qlnv.Location = new System.Drawing.Point(289, 9);
            this.lbl_qlnv.Name = "lbl_qlnv";
            this.lbl_qlnv.Size = new System.Drawing.Size(302, 38);
            this.lbl_qlnv.TabIndex = 5;
            this.lbl_qlnv.Text = "Quản Lý Nhân Viên";
            // 
            // lsv_DanhSachNV
            // 
            this.lsv_DanhSachNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_DanhSachNV.FullRowSelect = true;
            this.lsv_DanhSachNV.GridLines = true;
            this.lsv_DanhSachNV.HideSelection = false;
            this.lsv_DanhSachNV.Location = new System.Drawing.Point(13, 239);
            this.lsv_DanhSachNV.Name = "lsv_DanhSachNV";
            this.lsv_DanhSachNV.Size = new System.Drawing.Size(1027, 264);
            this.lsv_DanhSachNV.TabIndex = 4;
            this.lsv_DanhSachNV.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachNV.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachNV.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachNV_SelectedIndexChanged);
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 529);
            this.Controls.Add(this.gb_ttNV);
            this.Controls.Add(this.lbl_qlnv);
            this.Controls.Add(this.lsv_DanhSachNV);
            this.Name = "frm_NhanVien";
            this.Text = "frm_NhanVien";
            this.gb_ttNV.ResumeLayout(false);
            this.gb_ttNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox gb_ttNV;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox txt_dienthoai;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.Label lbl_bangcap;
        private System.Windows.Forms.Label lbl_dienthoai;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.Label lbl_ngaysinh;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.Label lbl_qlnv;
        private System.Windows.Forms.ListView lsv_DanhSachNV;
        private System.Windows.Forms.ComboBox cbo_bangcap;
    }
}