namespace Lab03_02
{
    partial class frm_soanthaovanban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_soanthaovanban));
            this.richText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ts_hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_taovanbanmoi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_moteptin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_luuteptin = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_dinhdang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_taovanbanmoi = new System.Windows.Forms.ToolStripButton();
            this.tsb_moteptin = new System.Windows.Forms.ToolStripButton();
            this.tsb_luuteptin = new System.Windows.Forms.ToolStripButton();
            this.cbb_font = new System.Windows.Forms.ToolStripComboBox();
            this.cbb_size = new System.Windows.Forms.ToolStripComboBox();
            this.tsb_bold = new System.Windows.Forms.ToolStripButton();
            this.tsb_italic = new System.Windows.Forms.ToolStripButton();
            this.tsb_underline = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(12, 72);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(776, 366);
            this.richText.TabIndex = 0;
            this.richText.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_hethong,
            this.ts_dinhdang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ts_hethong
            // 
            this.ts_hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_taovanbanmoi,
            this.tsm_moteptin,
            this.toolStripSeparator1,
            this.tsm_luuteptin,
            this.thoátToolStripMenuItem});
            this.ts_hethong.Name = "ts_hethong";
            this.ts_hethong.Size = new System.Drawing.Size(85, 24);
            this.ts_hethong.Text = "Hệ thống";
            // 
            // ts_taovanbanmoi
            // 
            this.ts_taovanbanmoi.Image = ((System.Drawing.Image)(resources.GetObject("ts_taovanbanmoi.Image")));
            this.ts_taovanbanmoi.Name = "ts_taovanbanmoi";
            this.ts_taovanbanmoi.Size = new System.Drawing.Size(321, 26);
            this.ts_taovanbanmoi.Text = "Tạo văn bản mới                 CTRL-N";
            this.ts_taovanbanmoi.Click += new System.EventHandler(this.tsb_taovanbanmoi_Click);
            // 
            // tsm_moteptin
            // 
            this.tsm_moteptin.Image = ((System.Drawing.Image)(resources.GetObject("tsm_moteptin.Image")));
            this.tsm_moteptin.Name = "tsm_moteptin";
            this.tsm_moteptin.Size = new System.Drawing.Size(321, 26);
            this.tsm_moteptin.Text = "Mở tệp tin";
            this.tsm_moteptin.Click += new System.EventHandler(this.tsm_moteptin_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(318, 6);
            // 
            // tsm_luuteptin
            // 
            this.tsm_luuteptin.Image = ((System.Drawing.Image)(resources.GetObject("tsm_luuteptin.Image")));
            this.tsm_luuteptin.Name = "tsm_luuteptin";
            this.tsm_luuteptin.Size = new System.Drawing.Size(321, 26);
            this.tsm_luuteptin.Text = "Lưu nội dung văn bản         CTRL-S";
            this.tsm_luuteptin.Click += new System.EventHandler(this.tsm_luuteptin_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // ts_dinhdang
            // 
            this.ts_dinhdang.Name = "ts_dinhdang";
            this.ts_dinhdang.Size = new System.Drawing.Size(92, 24);
            this.ts_dinhdang.Text = "Định dạng";
            this.ts_dinhdang.Click += new System.EventHandler(this.địnhDạngToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_taovanbanmoi,
            this.tsb_moteptin,
            this.tsb_luuteptin,
            this.cbb_font,
            this.cbb_size,
            this.tsb_bold,
            this.tsb_italic,
            this.tsb_underline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_taovanbanmoi
            // 
            this.tsb_taovanbanmoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_taovanbanmoi.Image = ((System.Drawing.Image)(resources.GetObject("tsb_taovanbanmoi.Image")));
            this.tsb_taovanbanmoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_taovanbanmoi.Name = "tsb_taovanbanmoi";
            this.tsb_taovanbanmoi.Size = new System.Drawing.Size(29, 25);
            this.tsb_taovanbanmoi.Text = "toolStripButton1";
            this.tsb_taovanbanmoi.Click += new System.EventHandler(this.tsb_taovanbanmoi_Click);
            // 
            // tsb_moteptin
            // 
            this.tsb_moteptin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_moteptin.Image = ((System.Drawing.Image)(resources.GetObject("tsb_moteptin.Image")));
            this.tsb_moteptin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_moteptin.Name = "tsb_moteptin";
            this.tsb_moteptin.Size = new System.Drawing.Size(29, 25);
            this.tsb_moteptin.Text = "toolStripButton1";
            this.tsb_moteptin.Click += new System.EventHandler(this.tsm_moteptin_Click);
            // 
            // tsb_luuteptin
            // 
            this.tsb_luuteptin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_luuteptin.Image = ((System.Drawing.Image)(resources.GetObject("tsb_luuteptin.Image")));
            this.tsb_luuteptin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_luuteptin.Name = "tsb_luuteptin";
            this.tsb_luuteptin.Size = new System.Drawing.Size(29, 25);
            this.tsb_luuteptin.Text = "toolStripButton2";
            this.tsb_luuteptin.Click += new System.EventHandler(this.tsm_luuteptin_Click);
            // 
            // cbb_font
            // 
            this.cbb_font.Name = "cbb_font";
            this.cbb_font.Size = new System.Drawing.Size(121, 28);
            this.cbb_font.SelectedIndexChanged += new System.EventHandler(this.cbb_font_SelectedIndexChanged);
            this.cbb_font.Click += new System.EventHandler(this.cbb_font_Click);
            // 
            // cbb_size
            // 
            this.cbb_size.Name = "cbb_size";
            this.cbb_size.Size = new System.Drawing.Size(121, 28);
            this.cbb_size.SelectedIndexChanged += new System.EventHandler(this.cbb_size_SelectedIndexChanged);
            this.cbb_size.Click += new System.EventHandler(this.cbb_size_Click);
            // 
            // tsb_bold
            // 
            this.tsb_bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_bold.Image = ((System.Drawing.Image)(resources.GetObject("tsb_bold.Image")));
            this.tsb_bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_bold.Name = "tsb_bold";
            this.tsb_bold.Size = new System.Drawing.Size(29, 25);
            this.tsb_bold.Text = "toolStripButton3";
            this.tsb_bold.Click += new System.EventHandler(this.tsb_bold_Click);
            // 
            // tsb_italic
            // 
            this.tsb_italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_italic.Image = ((System.Drawing.Image)(resources.GetObject("tsb_italic.Image")));
            this.tsb_italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_italic.Name = "tsb_italic";
            this.tsb_italic.Size = new System.Drawing.Size(29, 25);
            this.tsb_italic.Text = "toolStripButton4";
            this.tsb_italic.Click += new System.EventHandler(this.tsb_italic_Click);
            // 
            // tsb_underline
            // 
            this.tsb_underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_underline.Image = ((System.Drawing.Image)(resources.GetObject("tsb_underline.Image")));
            this.tsb_underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_underline.Name = "tsb_underline";
            this.tsb_underline.Size = new System.Drawing.Size(29, 25);
            this.tsb_underline.Text = "toolStripButton5";
            this.tsb_underline.Click += new System.EventHandler(this.tsb_underline_Click);
            // 
            // frm_soanthaovanban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_soanthaovanban";
            this.Text = "Trình soạn thảo văn bản";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ts_hethong;
        private System.Windows.Forms.ToolStripMenuItem ts_taovanbanmoi;
        private System.Windows.Forms.ToolStripMenuItem tsm_moteptin;
        private System.Windows.Forms.ToolStripMenuItem tsm_luuteptin;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem ts_dinhdang;
        private System.Windows.Forms.ToolStripButton tsb_taovanbanmoi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_luuteptin;
        private System.Windows.Forms.ToolStripComboBox cbb_font;
        private System.Windows.Forms.ToolStripComboBox cbb_size;
        private System.Windows.Forms.ToolStripButton tsb_bold;
        private System.Windows.Forms.ToolStripButton tsb_italic;
        private System.Windows.Forms.ToolStripButton tsb_underline;
        private System.Windows.Forms.ToolStripButton tsb_moteptin;
    }
}

