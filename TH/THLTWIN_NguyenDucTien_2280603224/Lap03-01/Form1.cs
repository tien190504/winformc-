using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap03_01
{
    public partial class frm_xemvideo : Form
    {
        public frm_xemvideo()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format($"Hôm nay là ngày {DateTime.Now.ToString("dd/mm/yy")}, Bây giờ là {DateTime.Now.ToString("hh:mm:ss tt")}");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "AVI file|*.avi|MPEG File|*.mpeg|Wav File|*.wav|Midi File|*.midi|Mp4 File|*.mp4|MP3|*.mp3"; if (dlg.ShowDialog() == DialogResult.OK )
            {
                axWindowsMediaPlayer1.URL = dlg.FileName ;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { 
                Application.Exit();
            }
        }
    }
}
