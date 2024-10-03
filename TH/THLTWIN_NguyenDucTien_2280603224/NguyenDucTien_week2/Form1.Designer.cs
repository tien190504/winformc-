namespace NguyenDucTien_week2
{
    partial class frm_MayTinh
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
            this.btn_chia = new System.Windows.Forms.Button();
            this.btn_nhan = new System.Windows.Forms.Button();
            this.btn_tru = new System.Windows.Forms.Button();
            this.txt_ketqua = new System.Windows.Forms.TextBox();
            this.lbl_ketqua = new System.Windows.Forms.Label();
            this.btn_cong = new System.Windows.Forms.Button();
            this.txt_number2 = new System.Windows.Forms.TextBox();
            this.txt_number1 = new System.Windows.Forms.TextBox();
            this.lbl_number2 = new System.Windows.Forms.Label();
            this.lbl_number1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_chia);
            this.panel1.Controls.Add(this.btn_nhan);
            this.panel1.Controls.Add(this.btn_tru);
            this.panel1.Controls.Add(this.txt_ketqua);
            this.panel1.Controls.Add(this.lbl_ketqua);
            this.panel1.Controls.Add(this.btn_cong);
            this.panel1.Controls.Add(this.txt_number2);
            this.panel1.Controls.Add(this.txt_number1);
            this.panel1.Controls.Add(this.lbl_number2);
            this.panel1.Controls.Add(this.lbl_number1);
            this.panel1.Location = new System.Drawing.Point(56, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 365);
            this.panel1.TabIndex = 0;
            // 
            // btn_chia
            // 
            this.btn_chia.Location = new System.Drawing.Point(585, 207);
            this.btn_chia.Name = "btn_chia";
            this.btn_chia.Size = new System.Drawing.Size(75, 23);
            this.btn_chia.TabIndex = 22;
            this.btn_chia.Text = "/";
            this.btn_chia.UseVisualStyleBackColor = true;
            this.btn_chia.Click += new System.EventHandler(this.btn_chia_Click);
            // 
            // btn_nhan
            // 
            this.btn_nhan.Location = new System.Drawing.Point(417, 206);
            this.btn_nhan.Name = "btn_nhan";
            this.btn_nhan.Size = new System.Drawing.Size(75, 23);
            this.btn_nhan.TabIndex = 21;
            this.btn_nhan.Text = "*";
            this.btn_nhan.UseVisualStyleBackColor = true;
            this.btn_nhan.Click += new System.EventHandler(this.btn_nhan_Click);
            // 
            // btn_tru
            // 
            this.btn_tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tru.Location = new System.Drawing.Point(201, 206);
            this.btn_tru.Name = "btn_tru";
            this.btn_tru.Size = new System.Drawing.Size(75, 23);
            this.btn_tru.TabIndex = 20;
            this.btn_tru.Text = "-";
            this.btn_tru.UseVisualStyleBackColor = true;
            this.btn_tru.Click += new System.EventHandler(this.btn_tru_Click);
            // 
            // txt_ketqua
            // 
            this.txt_ketqua.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_ketqua.Enabled = false;
            this.txt_ketqua.ForeColor = System.Drawing.Color.Red;
            this.txt_ketqua.Location = new System.Drawing.Point(201, 294);
            this.txt_ketqua.Name = "txt_ketqua";
            this.txt_ketqua.Size = new System.Drawing.Size(292, 22);
            this.txt_ketqua.TabIndex = 19;
            // 
            // lbl_ketqua
            // 
            this.lbl_ketqua.AutoSize = true;
            this.lbl_ketqua.Location = new System.Drawing.Point(80, 301);
            this.lbl_ketqua.Name = "lbl_ketqua";
            this.lbl_ketqua.Size = new System.Drawing.Size(54, 16);
            this.lbl_ketqua.TabIndex = 18;
            this.lbl_ketqua.Text = "Ket Qua";
            this.lbl_ketqua.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_cong
            // 
            this.btn_cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cong.Location = new System.Drawing.Point(11, 206);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(75, 23);
            this.btn_cong.TabIndex = 14;
            this.btn_cong.Text = "+";
            this.btn_cong.UseVisualStyleBackColor = true;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // txt_number2
            // 
            this.txt_number2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_number2.ForeColor = System.Drawing.Color.Red;
            this.txt_number2.Location = new System.Drawing.Point(201, 119);
            this.txt_number2.Name = "txt_number2";
            this.txt_number2.Size = new System.Drawing.Size(292, 22);
            this.txt_number2.TabIndex = 13;
            this.txt_number2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_number1
            // 
            this.txt_number1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_number1.ForeColor = System.Drawing.Color.Red;
            this.txt_number1.Location = new System.Drawing.Point(201, 47);
            this.txt_number1.Name = "txt_number1";
            this.txt_number1.Size = new System.Drawing.Size(292, 22);
            this.txt_number1.TabIndex = 12;
            this.txt_number1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_number2
            // 
            this.lbl_number2.AutoSize = true;
            this.lbl_number2.Location = new System.Drawing.Point(77, 125);
            this.lbl_number2.Name = "lbl_number2";
            this.lbl_number2.Size = new System.Drawing.Size(65, 16);
            this.lbl_number2.TabIndex = 11;
            this.lbl_number2.Text = "Number 2";
            // 
            // lbl_number1
            // 
            this.lbl_number1.AutoSize = true;
            this.lbl_number1.Location = new System.Drawing.Point(77, 53);
            this.lbl_number1.Name = "lbl_number1";
            this.lbl_number1.Size = new System.Drawing.Size(65, 16);
            this.lbl_number1.TabIndex = 10;
            this.lbl_number1.Text = "Number 1";
            this.lbl_number1.Click += new System.EventHandler(this.lbl_number1_Click);
            // 
            // frm_MayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frm_MayTinh";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ketqua;
        private System.Windows.Forms.Label lbl_ketqua;
        private System.Windows.Forms.Button btn_cong;
        private System.Windows.Forms.TextBox txt_number2;
        private System.Windows.Forms.TextBox txt_number1;
        private System.Windows.Forms.Label lbl_number2;
        private System.Windows.Forms.Label lbl_number1;
        private System.Windows.Forms.Button btn_tru;
        private System.Windows.Forms.Button btn_chia;
        private System.Windows.Forms.Button btn_nhan;
    }
}

