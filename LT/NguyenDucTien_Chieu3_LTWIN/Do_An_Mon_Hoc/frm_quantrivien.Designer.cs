namespace NguyenDucTien_2280603224
{
    partial class frm_quantrivien
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_qlhs = new System.Windows.Forms.Button();
            this.btn_qlgv = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.p_user = new DevExpress.XtraEditors.PanelControl();
            this.btn_chung = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_user)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_qlhs
            // 
            this.btn_qlhs.BackColor = System.Drawing.Color.Blue;
            this.btn_qlhs.ForeColor = System.Drawing.Color.Transparent;
            this.btn_qlhs.Location = new System.Drawing.Point(6, 44);
            this.btn_qlhs.Name = "btn_qlhs";
            this.btn_qlhs.Size = new System.Drawing.Size(164, 35);
            this.btn_qlhs.TabIndex = 0;
            this.btn_qlhs.Text = "Quản Lý Sinh Viên";
            this.btn_qlhs.UseVisualStyleBackColor = false;
            this.btn_qlhs.Click += new System.EventHandler(this.btnQuanLyHocSinh_Click);
            // 
            // btn_qlgv
            // 
            this.btn_qlgv.BackColor = System.Drawing.Color.Blue;
            this.btn_qlgv.ForeColor = System.Drawing.Color.Transparent;
            this.btn_qlgv.Location = new System.Drawing.Point(6, 85);
            this.btn_qlgv.Name = "btn_qlgv";
            this.btn_qlgv.Size = new System.Drawing.Size(164, 35);
            this.btn_qlgv.TabIndex = 0;
            this.btn_qlgv.Text = "Quản Lý Giảng Viên";
            this.btn_qlgv.UseVisualStyleBackColor = false;
            this.btn_qlgv.Click += new System.EventHandler(this.btnQuanLyGiaoVien_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.btn_chung);
            this.panelContainer.Controls.Add(this.btn_qlgv);
            this.panelContainer.Controls.Add(this.btn_qlhs);
            this.panelContainer.Location = new System.Drawing.Point(12, 12);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(170, 648);
            this.panelContainer.TabIndex = 2;
            // 
            // p_user
            // 
            this.p_user.Location = new System.Drawing.Point(188, 12);
            this.p_user.Name = "p_user";
            this.p_user.Size = new System.Drawing.Size(1159, 648);
            this.p_user.TabIndex = 3;
            // 
            // btn_chung
            // 
            this.btn_chung.BackColor = System.Drawing.Color.Blue;
            this.btn_chung.ForeColor = System.Drawing.Color.White;
            this.btn_chung.Location = new System.Drawing.Point(3, 3);
            this.btn_chung.Name = "btn_chung";
            this.btn_chung.Size = new System.Drawing.Size(164, 35);
            this.btn_chung.TabIndex = 1;
            this.btn_chung.Text = "Chung";
            this.btn_chung.UseVisualStyleBackColor = false;
            this.btn_chung.Click += new System.EventHandler(this.btn_chung_Click);
            // 
            // frm_quantrivien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 672);
            this.Controls.Add(this.p_user);
            this.Controls.Add(this.panelContainer);
            this.Name = "frm_quantrivien";
            this.Text = "Quản Trị Viên";
            this.Load += new System.EventHandler(this.frm_quantrivien_Load);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_qlhs;
        private System.Windows.Forms.Button btn_qlgv;
        private System.Windows.Forms.Panel panelContainer;
        private DevExpress.XtraEditors.PanelControl p_user;
        private System.Windows.Forms.Button btn_chung;
    }
}

