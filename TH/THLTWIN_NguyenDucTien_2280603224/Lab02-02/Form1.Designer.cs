namespace Lab02_02
{
    partial class frm_QuanLyThongTinSV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_tongsvnu = new System.Windows.Forms.TextBox();
            this.txt_tongsvnam = new System.Windows.Forms.TextBox();
            this.lbl_nu = new System.Windows.Forms.Label();
            this.lbl_tongsvnam = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_themsua = new System.Windows.Forms.Button();
            this.dgv_Student = new System.Windows.Forms.DataGridView();
            this.dgv_c_mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_c_hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_c_gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_c_dtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_c_khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_quanlythongtinsv = new System.Windows.Forms.Label();
            this.gb_Title = new System.Windows.Forms.GroupBox();
            this.cmb_chuyennganh = new System.Windows.Forms.ComboBox();
            this.txt_dtb = new System.Windows.Forms.TextBox();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.lbl_chuyennganh = new System.Windows.Forms.Label();
            this.lbl_diemtrungbinh = new System.Windows.Forms.Label();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.lbl_MSSV = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).BeginInit();
            this.gb_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_tongsvnu);
            this.panel1.Controls.Add(this.txt_tongsvnam);
            this.panel1.Controls.Add(this.lbl_nu);
            this.panel1.Controls.Add(this.lbl_tongsvnam);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_themsua);
            this.panel1.Controls.Add(this.dgv_Student);
            this.panel1.Controls.Add(this.lbl_quanlythongtinsv);
            this.panel1.Controls.Add(this.gb_Title);
            this.panel1.Location = new System.Drawing.Point(30, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 509);
            this.panel1.TabIndex = 0;
            // 
            // txt_tongsvnu
            // 
            this.txt_tongsvnu.Enabled = false;
            this.txt_tongsvnu.Location = new System.Drawing.Point(940, 438);
            this.txt_tongsvnu.Name = "txt_tongsvnu";
            this.txt_tongsvnu.Size = new System.Drawing.Size(47, 22);
            this.txt_tongsvnu.TabIndex = 8;
            // 
            // txt_tongsvnam
            // 
            this.txt_tongsvnam.Enabled = false;
            this.txt_tongsvnam.Location = new System.Drawing.Point(840, 438);
            this.txt_tongsvnam.Name = "txt_tongsvnam";
            this.txt_tongsvnam.Size = new System.Drawing.Size(55, 22);
            this.txt_tongsvnam.TabIndex = 7;
            // 
            // lbl_nu
            // 
            this.lbl_nu.AutoSize = true;
            this.lbl_nu.Location = new System.Drawing.Point(910, 441);
            this.lbl_nu.Name = "lbl_nu";
            this.lbl_nu.Size = new System.Drawing.Size(24, 16);
            this.lbl_nu.TabIndex = 6;
            this.lbl_nu.Text = "Nữ";
            // 
            // lbl_tongsvnam
            // 
            this.lbl_tongsvnam.AutoSize = true;
            this.lbl_tongsvnam.Location = new System.Drawing.Point(742, 441);
            this.lbl_tongsvnam.Name = "lbl_tongsvnam";
            this.lbl_tongsvnam.Size = new System.Drawing.Size(92, 16);
            this.lbl_tongsvnam.TabIndex = 5;
            this.lbl_tongsvnam.Text = "Tổng SV Nam";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(290, 411);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_themsua
            // 
            this.btn_themsua.Location = new System.Drawing.Point(42, 411);
            this.btn_themsua.Name = "btn_themsua";
            this.btn_themsua.Size = new System.Drawing.Size(100, 24);
            this.btn_themsua.TabIndex = 3;
            this.btn_themsua.Text = "Thêm/Sửa";
            this.btn_themsua.UseVisualStyleBackColor = true;
            this.btn_themsua.Click += new System.EventHandler(this.btn_themsua_Click);
            // 
            // dgv_Student
            // 
            this.dgv_Student.AllowUserToAddRows = false;
            this.dgv_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_c_mssv,
            this.dgv_c_hoten,
            this.dgv_c_gioitinh,
            this.dgv_c_dtb,
            this.dgv_c_khoa});
            this.dgv_Student.Location = new System.Drawing.Point(413, 72);
            this.dgv_Student.Name = "dgv_Student";
            this.dgv_Student.RowHeadersWidth = 51;
            this.dgv_Student.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Student.RowTemplate.Height = 24;
            this.dgv_Student.Size = new System.Drawing.Size(641, 363);
            this.dgv_Student.TabIndex = 2;
            this.dgv_Student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Student_CellContentClick);
            // 
            // dgv_c_mssv
            // 
            this.dgv_c_mssv.HeaderText = "MSSV";
            this.dgv_c_mssv.MinimumWidth = 6;
            this.dgv_c_mssv.Name = "dgv_c_mssv";
            this.dgv_c_mssv.Width = 125;
            // 
            // dgv_c_hoten
            // 
            this.dgv_c_hoten.HeaderText = "Họ Tên";
            this.dgv_c_hoten.MinimumWidth = 6;
            this.dgv_c_hoten.Name = "dgv_c_hoten";
            this.dgv_c_hoten.Width = 125;
            // 
            // dgv_c_gioitinh
            // 
            this.dgv_c_gioitinh.HeaderText = "Giới Tính";
            this.dgv_c_gioitinh.MinimumWidth = 6;
            this.dgv_c_gioitinh.Name = "dgv_c_gioitinh";
            this.dgv_c_gioitinh.Width = 125;
            // 
            // dgv_c_dtb
            // 
            this.dgv_c_dtb.HeaderText = "ĐTB";
            this.dgv_c_dtb.MinimumWidth = 6;
            this.dgv_c_dtb.Name = "dgv_c_dtb";
            this.dgv_c_dtb.Width = 125;
            // 
            // dgv_c_khoa
            // 
            this.dgv_c_khoa.HeaderText = "Khoa";
            this.dgv_c_khoa.MinimumWidth = 6;
            this.dgv_c_khoa.Name = "dgv_c_khoa";
            this.dgv_c_khoa.Width = 125;
            // 
            // lbl_quanlythongtinsv
            // 
            this.lbl_quanlythongtinsv.AutoSize = true;
            this.lbl_quanlythongtinsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quanlythongtinsv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_quanlythongtinsv.Location = new System.Drawing.Point(283, 16);
            this.lbl_quanlythongtinsv.Name = "lbl_quanlythongtinsv";
            this.lbl_quanlythongtinsv.Size = new System.Drawing.Size(444, 38);
            this.lbl_quanlythongtinsv.TabIndex = 1;
            this.lbl_quanlythongtinsv.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // gb_Title
            // 
            this.gb_Title.Controls.Add(this.cmb_chuyennganh);
            this.gb_Title.Controls.Add(this.txt_dtb);
            this.gb_Title.Controls.Add(this.rb_nu);
            this.gb_Title.Controls.Add(this.rb_nam);
            this.gb_Title.Controls.Add(this.txt_hoten);
            this.gb_Title.Controls.Add(this.txt_mssv);
            this.gb_Title.Controls.Add(this.lbl_chuyennganh);
            this.gb_Title.Controls.Add(this.lbl_diemtrungbinh);
            this.gb_Title.Controls.Add(this.lbl_gioitinh);
            this.gb_Title.Controls.Add(this.lbl_hoten);
            this.gb_Title.Controls.Add(this.lbl_MSSV);
            this.gb_Title.Location = new System.Drawing.Point(3, 72);
            this.gb_Title.Name = "gb_Title";
            this.gb_Title.Size = new System.Drawing.Size(381, 331);
            this.gb_Title.TabIndex = 0;
            this.gb_Title.TabStop = false;
            this.gb_Title.Text = "Thông Tin Sinh Viên";
            // 
            // cmb_chuyennganh
            // 
            this.cmb_chuyennganh.FormattingEnabled = true;
            this.cmb_chuyennganh.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmb_chuyennganh.Location = new System.Drawing.Point(159, 284);
            this.cmb_chuyennganh.Name = "cmb_chuyennganh";
            this.cmb_chuyennganh.Size = new System.Drawing.Size(117, 24);
            this.cmb_chuyennganh.TabIndex = 1;
            // 
            // txt_dtb
            // 
            this.txt_dtb.Location = new System.Drawing.Point(159, 235);
            this.txt_dtb.Name = "txt_dtb";
            this.txt_dtb.Size = new System.Drawing.Size(100, 22);
            this.txt_dtb.TabIndex = 10;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Checked = true;
            this.rb_nu.Location = new System.Drawing.Point(287, 191);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(45, 20);
            this.rb_nu.TabIndex = 9;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(159, 193);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(57, 20);
            this.rb_nam.TabIndex = 8;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(159, 128);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(216, 22);
            this.txt_hoten.TabIndex = 6;
            // 
            // txt_mssv
            // 
            this.txt_mssv.Location = new System.Drawing.Point(159, 61);
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(216, 22);
            this.txt_mssv.TabIndex = 5;
            // 
            // lbl_chuyennganh
            // 
            this.lbl_chuyennganh.AutoSize = true;
            this.lbl_chuyennganh.Location = new System.Drawing.Point(44, 292);
            this.lbl_chuyennganh.Name = "lbl_chuyennganh";
            this.lbl_chuyennganh.Size = new System.Drawing.Size(95, 16);
            this.lbl_chuyennganh.TabIndex = 4;
            this.lbl_chuyennganh.Text = "Chuyên Ngành";
            // 
            // lbl_diemtrungbinh
            // 
            this.lbl_diemtrungbinh.AutoSize = true;
            this.lbl_diemtrungbinh.Location = new System.Drawing.Point(47, 241);
            this.lbl_diemtrungbinh.Name = "lbl_diemtrungbinh";
            this.lbl_diemtrungbinh.Size = new System.Drawing.Size(59, 16);
            this.lbl_diemtrungbinh.TabIndex = 3;
            this.lbl_diemtrungbinh.Text = "Điểm TB";
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.AutoSize = true;
            this.lbl_gioitinh.Location = new System.Drawing.Point(44, 195);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(60, 16);
            this.lbl_gioitinh.TabIndex = 2;
            this.lbl_gioitinh.Text = "Giới Tính";
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Location = new System.Drawing.Point(44, 134);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(52, 16);
            this.lbl_hoten.TabIndex = 1;
            this.lbl_hoten.Text = "Họ Tên";
            // 
            // lbl_MSSV
            // 
            this.lbl_MSSV.AutoSize = true;
            this.lbl_MSSV.Location = new System.Drawing.Point(44, 67);
            this.lbl_MSSV.Name = "lbl_MSSV";
            this.lbl_MSSV.Size = new System.Drawing.Size(85, 16);
            this.lbl_MSSV.TabIndex = 0;
            this.lbl_MSSV.Text = "Mã Sinh Viên";
            // 
            // frm_QuanLyThongTinSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 564);
            this.Controls.Add(this.panel1);
            this.Name = "frm_QuanLyThongTinSV";
            this.Text = "Quan Ly Thong Tin Sinh Vien";
            this.Load += new System.EventHandler(this.frm_QuanLyThongTinSV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).EndInit();
            this.gb_Title.ResumeLayout(false);
            this.gb_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_Title;
        private System.Windows.Forms.Label lbl_MSSV;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.Label lbl_gioitinh;
        private System.Windows.Forms.Label lbl_diemtrungbinh;
        private System.Windows.Forms.Label lbl_chuyennganh;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.TextBox txt_dtb;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.ComboBox cmb_chuyennganh;
        private System.Windows.Forms.Label lbl_quanlythongtinsv;
        private System.Windows.Forms.DataGridView dgv_Student;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_themsua;
        private System.Windows.Forms.Label lbl_nu;
        private System.Windows.Forms.Label lbl_tongsvnam;
        private System.Windows.Forms.TextBox txt_tongsvnu;
        private System.Windows.Forms.TextBox txt_tongsvnam;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_c_mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_c_hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_c_gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_c_dtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_c_khoa;
    }
}

