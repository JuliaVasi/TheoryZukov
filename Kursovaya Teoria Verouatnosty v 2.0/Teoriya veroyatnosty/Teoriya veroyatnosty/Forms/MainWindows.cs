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

namespace Teoriya_veroyatnosty
{
    public partial class MainForm : MetroForm
    {
        bool MenuStatus;
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetTimer(object sender, EventArgs e)
        {
            if (MenuStatus)
            {
                RightMenu.Width -= 10;
                if (RightMenu.Width == RightMenu.MinimumSize.Width)
                {
                    MenuStatus = false;
                    TimerMenu.Stop();
                }
            }
            else
            {
                RightMenu.Width += 10;
                if (RightMenu.Width == RightMenu.MaximumSize.Width)
                {
                    MenuStatus = true;
                    TimerMenu.Stop();
                }
            }
        }

        private void MenuBTN_Click(object sender, EventArgs e)
        {
            TimerMenu.Start();
        }

        private void ListBTN_Click(object sender, EventArgs e)
        {
            ContentForm content = new ContentForm();
            content.Show();
            this.Hide();
        }

        private void TestBTN_Click(object sender, EventArgs e)
        {
            TestForm test = new TestForm();
            test.Show();
            this.Hide();
        }

        private void CalcBTN_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
        }

        private void AboutBTN_Click(object sender, EventArgs e)
        {
            About about = new About(); 
            about.Show();

        }

        private void SrcBTN_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }

        private void CloseFormBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
