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
using Teoriya_veroyatnosty.Content;

namespace Teoriya_veroyatnosty.Forms
{
    public partial class ContentForm : MetroForm
    {
        bool MenuStatus;
        public ContentForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void MenuBTN_Click_1(object sender, EventArgs e)
        {
            TimerMenu.Start();
        }

        private void ListBTN_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void RightMenu_Paint(object sender, PaintEventArgs e)
        {
            //
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
            Chapter1 chapter1 = new Chapter1();
            chapter1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Chapter2 chapter2 = new Chapter2();
            chapter2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Chapter3 chapter3 = new Chapter3();
            chapter3.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Chapter4 chapter4 = new Chapter4();
            chapter4.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Chapter5 chapter5 = new Chapter5(); 
            chapter5.Show();
            this.Hide();
        }
    }
}
