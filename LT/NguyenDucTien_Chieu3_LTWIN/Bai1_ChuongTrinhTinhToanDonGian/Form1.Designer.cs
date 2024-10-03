namespace Bai1_ChuongTrinhTinhToanDonGian
{
    partial class Form1
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
            this.btn_cong = new System.Windows.Forms.Button();
            this.lbl_m = new System.Windows.Forms.Label();
            this.txt_soM = new System.Windows.Forms.TextBox();
            this.lbl_n = new System.Windows.Forms.Label();
            this.txt_soN = new System.Windows.Forms.TextBox();
            this.lbl_chuongtrinh = new System.Windows.Forms.Label();
            this.btn_tru = new System.Windows.Forms.Button();
            this.btn_nhan = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_chia = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lbl_ketqua = new System.Windows.Forms.Label();
            this.txt_ketqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cong
            // 
            this.btn_cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cong.Location = new System.Drawing.Point(98, 358);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(100, 50);
            this.btn_cong.TabIndex = 0;
            this.btn_cong.Text = "+";
            this.btn_cong.UseVisualStyleBackColor = true;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // lbl_m
            // 
            this.lbl_m.AutoSize = true;
            this.lbl_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_m.Location = new System.Drawing.Point(133, 119);
            this.lbl_m.Name = "lbl_m";
            this.lbl_m.Size = new System.Drawing.Size(40, 36);
            this.lbl_m.TabIndex = 1;
            this.lbl_m.Text = "M";
            // 
            // txt_soM
            // 
            this.txt_soM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soM.Location = new System.Drawing.Point(291, 116);
            this.txt_soM.Name = "txt_soM";
            this.txt_soM.Size = new System.Drawing.Size(300, 41);
            this.txt_soM.TabIndex = 2;
            this.txt_soM.TextChanged += new System.EventHandler(this.txt_soN_TextChanged);
            this.txt_soM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soN_KeyPress);
            // 
            // lbl_n
            // 
            this.lbl_n.AutoSize = true;
            this.lbl_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n.Location = new System.Drawing.Point(136, 185);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(37, 36);
            this.lbl_n.TabIndex = 1;
            this.lbl_n.Text = "N";
            // 
            // txt_soN
            // 
            this.txt_soN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soN.Location = new System.Drawing.Point(291, 180);
            this.txt_soN.Name = "txt_soN";
            this.txt_soN.Size = new System.Drawing.Size(300, 41);
            this.txt_soN.TabIndex = 2;
            this.txt_soN.TextChanged += new System.EventHandler(this.txt_soN_TextChanged);
            this.txt_soN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soN_KeyPress);
            // 
            // lbl_chuongtrinh
            // 
            this.lbl_chuongtrinh.AutoSize = true;
            this.lbl_chuongtrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chuongtrinh.Location = new System.Drawing.Point(199, 24);
            this.lbl_chuongtrinh.Name = "lbl_chuongtrinh";
            this.lbl_chuongtrinh.Size = new System.Drawing.Size(466, 58);
            this.lbl_chuongtrinh.TabIndex = 1;
            this.lbl_chuongtrinh.Text = "MÁY TÍNH CƠ BẢN";
            // 
            // btn_tru
            // 
            this.btn_tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tru.Location = new System.Drawing.Point(204, 358);
            this.btn_tru.Name = "btn_tru";
            this.btn_tru.Size = new System.Drawing.Size(100, 50);
            this.btn_tru.TabIndex = 0;
            this.btn_tru.Text = "-";
            this.btn_tru.UseVisualStyleBackColor = true;
            this.btn_tru.Click += new System.EventHandler(this.btn_tru_Click);
            // 
            // btn_nhan
            // 
            this.btn_nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhan.Location = new System.Drawing.Point(310, 358);
            this.btn_nhan.Name = "btn_nhan";
            this.btn_nhan.Size = new System.Drawing.Size(100, 50);
            this.btn_nhan.TabIndex = 0;
            this.btn_nhan.Text = "*";
            this.btn_nhan.UseVisualStyleBackColor = true;
            this.btn_nhan.Click += new System.EventHandler(this.btn_nhan_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(522, 358);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 50);
            this.btn_xoa.TabIndex = 0;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_chia
            // 
            this.btn_chia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chia.Location = new System.Drawing.Point(416, 358);
            this.btn_chia.Name = "btn_chia";
            this.btn_chia.Size = new System.Drawing.Size(100, 50);
            this.btn_chia.TabIndex = 0;
            this.btn_chia.Text = "/";
            this.btn_chia.UseVisualStyleBackColor = true;
            this.btn_chia.Click += new System.EventHandler(this.btn_chia_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(628, 358);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(130, 50);
            this.btn_thoat.TabIndex = 0;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click_1);
            // 
            // lbl_ketqua
            // 
            this.lbl_ketqua.AutoSize = true;
            this.lbl_ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ketqua.Location = new System.Drawing.Point(136, 269);
            this.lbl_ketqua.Name = "lbl_ketqua";
            this.lbl_ketqua.Size = new System.Drawing.Size(117, 36);
            this.lbl_ketqua.TabIndex = 1;
            this.lbl_ketqua.Text = "Kết quả";
            // 
            // txt_ketqua
            // 
            this.txt_ketqua.Enabled = false;
            this.txt_ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ketqua.Location = new System.Drawing.Point(291, 264);
            this.txt_ketqua.Name = "txt_ketqua";
            this.txt_ketqua.Size = new System.Drawing.Size(300, 41);
            this.txt_ketqua.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 528);
            this.Controls.Add(this.txt_ketqua);
            this.Controls.Add(this.txt_soN);
            this.Controls.Add(this.txt_soM);
            this.Controls.Add(this.lbl_ketqua);
            this.Controls.Add(this.lbl_n);
            this.Controls.Add(this.lbl_chuongtrinh);
            this.Controls.Add(this.lbl_m);
            this.Controls.Add(this.btn_chia);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_nhan);
            this.Controls.Add(this.btn_tru);
            this.Controls.Add(this.btn_cong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cong;
        private System.Windows.Forms.Label lbl_m;
        private System.Windows.Forms.TextBox txt_soM;
        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.TextBox txt_soN;
        private System.Windows.Forms.Label lbl_chuongtrinh;
        private System.Windows.Forms.Button btn_tru;
        private System.Windows.Forms.Button btn_nhan;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_chia;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lbl_ketqua;
        private System.Windows.Forms.TextBox txt_ketqua;
    }
}

