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
    public partial class Chapter4 : MetroForm
    {
        bool MenuStatus;
        bool IsPress = false;
        public Chapter4()
        {
            InitializeComponent();
            quest1.Visible = false;
            quest2.Visible = false;
            quest3.Visible = false;
            quest4.Visible = false;
            quest5.Visible = false;
            quest6.Visible = false;
            quest7.Visible = false;
            quest8.Visible = false;

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

        private void CloseFormBTN_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContentForm content = new ContentForm();
            content.Show();
            this.Hide();
        }

        private void Answer1(object sender, EventArgs e)
        {
            quest1.Visible = true;
        }

        private void Answer2(object sender, EventArgs e)
        {
            quest2.Visible = true;
        }

        private void Answer3(object sender, EventArgs e)
        {
            quest3.Visible = true;
        }

        private void Answer4(object sender, EventArgs e)
        {
            quest4.Visible = true;
        }

        private void Answer5(object sender, EventArgs e)
        {
            quest5.Visible = true;
        }

        private void Answer6(object sender, EventArgs e)
        {
            quest6.Visible = true;
        }

        private void Answer7(object sender, EventArgs e)
        {
            quest7.Visible = true;
        }

        private void Answer8(object sender, EventArgs e)
        {
            quest8.Visible = true;
        }

        private void quest3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
