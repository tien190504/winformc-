namespace NguyenDucTien_MayTinhDonGian
{
    partial class frm_click
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
            this.lbl_chuongtrinhclick = new System.Windows.Forms.Label();
            this.lbl_solanclick = new System.Windows.Forms.Label();
            this.btn_ClickMe = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_chuongtrinhclick
            // 
            this.lbl_chuongtrinhclick.AutoSize = true;
            this.lbl_chuongtrinhclick.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chuongtrinhclick.Location = new System.Drawing.Point(12, 68);
            this.lbl_chuongtrinhclick.Name = "lbl_chuongtrinhclick";
            this.lbl_chuongtrinhclick.Size = new System.Drawing.Size(888, 58);
            this.lbl_chuongtrinhclick.TabIndex = 0;
            this.lbl_chuongtrinhclick.Text = "CHƯƠNG TRÌNH ĐẾM CLICK CHUỘT";
            // 
            // lbl_solanclick
            // 
            this.lbl_solanclick.AutoSize = true;
            this.lbl_solanclick.Location = new System.Drawing.Point(325, 364);
            this.lbl_solanclick.Name = "lbl_solanclick";
            this.lbl_solanclick.Size = new System.Drawing.Size(105, 20);
            this.lbl_solanclick.TabIndex = 0;
            this.lbl_solanclick.Text = "Số lần click: ";
            // 
            // btn_ClickMe
            // 
            this.btn_ClickMe.Location = new System.Drawing.Point(318, 232);
            this.btn_ClickMe.Name = "btn_ClickMe";
            this.btn_ClickMe.Size = new System.Drawing.Size(235, 50);
            this.btn_ClickMe.TabIndex = 1;
            this.btn_ClickMe.Text = "Click me";
            this.btn_ClickMe.UseVisualStyleBackColor = true;
            this.btn_ClickMe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_ClickMe_MouseClick);
            this.btn_ClickMe.MouseEnter += new System.EventHandler(this.btn_ClickMe_MouseEnter);
            this.btn_ClickMe.MouseLeave += new System.EventHandler(this.btn_ClickMe_MouseLeave);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(627, 227);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(125, 90);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // frm_click
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 478);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_ClickMe);
            this.Controls.Add(this.lbl_solanclick);
            this.Controls.Add(this.lbl_chuongtrinhclick);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_click";
            this.Text = "Click me";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_chuongtrinhclick;
        private System.Windows.Forms.Label lbl_solanclick;
        private System.Windows.Forms.Button btn_ClickMe;
        private System.Windows.Forms.Button btn_xoa;
    }
}

