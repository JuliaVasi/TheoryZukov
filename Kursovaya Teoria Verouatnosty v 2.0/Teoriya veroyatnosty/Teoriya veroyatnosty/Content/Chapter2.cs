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
    public partial class Chapter2 : MetroForm
    {
        bool MenuStatus;
        public Chapter2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContentForm contentForm = new ContentForm();
            contentForm.Show();
            this.Close();
        }

        private void MenuBTN_Click(object sender, EventArgs e)
        {
            TimerMenu.Start();
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

        private void CloseFormBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void Chapter2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ContentForm contentForm = new ContentForm();
            contentForm.Show();
            this.Close();
        }
    }
}
