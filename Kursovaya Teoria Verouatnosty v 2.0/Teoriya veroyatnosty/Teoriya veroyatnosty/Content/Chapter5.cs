using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Teoriya_veroyatnosty.Forms;

namespace Teoriya_veroyatnosty.Content
{
    public partial class Chapter5 : MetroForm
    {
        public Chapter5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "\\Chapter1.mp4";
            axWindowsMediaPlayer1.URL = path;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://skillbox.ru/media/code/teoriya-veroyatnostey-kak-nauchitsya-predskazyvat-sluchaynye-sobytiya/");
        }

        private void CloseFormBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContentForm content = new ContentForm();
            content.Show();
            this.Close();  
        }
    }
}
