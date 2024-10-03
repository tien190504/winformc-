using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class frm_soanthaovanban : Form
    {
        public frm_soanthaovanban()
        {
            InitializeComponent();
            cbb_font.Text = "Tohama";
            cbb_size.Text = "14";
        }



        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richText.ForeColor = fontDlg.Color;
                richText.Font = fontDlg.Font;
            }
        }
        //click vào font
        private void cbb_font_Click(object sender, EventArgs e)
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            foreach (FontFamily font in installedFontCollection.Families)
            {
                cbb_font.Items.Add(font.Name);
            }
            cbb_font.SelectedItem = "Tahoma";
        }
        //click vào size
        private void cbb_size_Click(object sender, EventArgs e)
        {
            int[] fontSize = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            cbb_size.Items.Clear();
            foreach (int size in fontSize)
            {
                cbb_size.Items.Add(size);
            }
            cbb_size.SelectedItem = 14;
        }



        //Thay đổi size

        private void cbb_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richText.SelectionLength > 0) // Kiểm tra xem có văn bản nào đang được chọn hay không
            {
                // Lấy kích thước font được chọn
                float selectedSize = float.Parse(cbb_size.SelectedItem.ToString());
                // Tạo font mới với tên font và kiểu hiện tại của văn bản được chọn
                Font currentFont = richText.SelectionFont;

                if (currentFont != null) // Kiểm tra nếu đã có font được áp dụng
                {
                    Font newFont = new Font(currentFont.FontFamily, selectedSize, currentFont.Style);
                    // Áp dụng kích thước mới cho đoạn văn bản được chọn mà không thay đổi kiểu in đậm, in nghiêng
                    richText.SelectionFont = newFont;
                }
            }
        }
        //thay đổi font
        private void cbb_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richText.SelectionLength > 0) // Kiểm tra xem có văn bản nào đang được chọn hay không
            {
                // Lấy tên font được chọn
                string selectedFont = cbb_font.SelectedItem.ToString();
                // Tạo font mới với kích thước hiện tại của văn bản được chọn
                Font currentFont = richText.SelectionFont;
                Font newFont = new Font(selectedFont, currentFont.Size);

                // Áp dụng font mới cho đoạn văn bản được chọn
                richText.SelectionFont = newFont;
            }
        }


        //Tạo văn bản mới
        private void tsb_taovanbanmoi_Click(object sender, EventArgs e)
        {
            richText.Clear();

            richText.SelectionFont = new Font("Tohama", 14);
            cbb_font.SelectedItem = "Tohama";
            cbb_size.SelectedItem = 14;
        }



        //mở tệp tin *.txt
        private void tsm_moteptin_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Chỉ định bộ lọc tập tin (cho phép mở *.txt và *.rtf)
            openFileDialog.Filter = "Text files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            openFileDialog.Title = "Open a text or RTF file";

            // Hiển thị hộp thoại và kiểm tra xem người dùng có chọn tập tin hay không
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn tập tin người dùng đã chọn
                string filePath = openFileDialog.FileName;
                string fileExtension = System.IO.Path.GetExtension(filePath).ToLower();

                // Kiểm tra định dạng tập tin để mở
                if (fileExtension == ".txt")
                {
                    // Mở và đọc tập tin văn bản (*.txt)
                    richText.Text = System.IO.File.ReadAllText(filePath);
                }
                else if (fileExtension == ".rtf")
                {
                    // Mở và đọc tập tin Rich Text Format (*.rtf)
                    richText.LoadFile(filePath, RichTextBoxStreamType.RichText);
                }
            }
        }


        //lưu tệp tin
        private void tsm_luuteptin_Click(object sender, EventArgs e)
        {
            string filepath = null;
            if (string.IsNullOrEmpty(filepath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rich text Format (*rtf) | *rtf";
                saveFileDialog.Title = "Save the document";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = saveFileDialog.FileName;
                    richText.SaveFile(filepath, RichTextBoxStreamType.RichText);
                    MessageBox.Show("File đã được lưu", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void tsb_bold_Click(object sender, EventArgs e)
        {
            Font currentFont = richText.SelectionFont; // Lấy font hiện tại
            if (currentFont != null)
            {
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Bold; // XOR để thêm hoặc xóa Bold
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void tsb_italic_Click(object sender, EventArgs e)
        {
            Font currentFont = richText.SelectionFont; // Lấy font hiện tại
            if (currentFont != null)
            {
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Italic; // XOR để thêm hoặc xóa Bold
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void tsb_underline_Click(object sender, EventArgs e)
        {
            Font currentFont = richText.SelectionFont; // Lấy font hiện tại
            if (currentFont != null)
            {
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Underline; // XOR để thêm hoặc xóa Bold
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }
    }
}
