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

namespace Teoriya_veroyatnosty.Forms
{
    public partial class Calculator : MetroForm
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public int Factor(int numb)
        {
            int res = 1;
            for (int i = numb; i > 1; i--)
                res *= i;
            return res;
        }

        private void ListBTN_Click(object sender, EventArgs e)  
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) 
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

        private void AboutBTN_Click(object sender, EventArgs e) 
        {
            About about = new About();
            about.Show();
            this.Hide();
        }

        private void SrcBTN_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }

        private void CloseFormBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SetNumber(object sender, EventArgs e)
        {
            Button button = (Button)sender;        

            if (TextBoxScreen.Text == "0")
                TextBoxScreen.Text = button.Text;
            else
                TextBoxScreen.Text += button.Text;       
        }

        private void SetAction(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            TextBoxScreen.Text += button.Text;
        }

        private void SetEndNumber(object sender, EventArgs e)
        {
            if (TextBoxScreen.Text.Contains('+'))
            {
                try
                {
                    string[] s = TextBoxScreen.Text.Split('+');
                    double first = Convert.ToDouble(s[0]);
                    double second = Convert.ToDouble(s[1]);

                    double result = first + second;
                    TextBoxResult.Text = result.ToString();
                    TextBoxScreen.Text = TextBoxResult.Text;
                }
                catch
                {
                    TextBoxResult.Text = "Ошибка!";
                }               
            }
            else if (TextBoxScreen.Text.Contains("-"))
            {
                try
                {
                    string[] s = TextBoxScreen.Text.Split('-');
                    double first = Convert.ToDouble(s[0]);
                    double second = Convert.ToDouble(s[1]);

                    double result = first - second;
                    TextBoxResult.Text = result.ToString();
                    TextBoxScreen.Text = TextBoxResult.Text;
                }
                catch
                {
                    TextBoxResult.Text = "Ошибка!";
                }               
            }
            else if (TextBoxScreen.Text.Contains("*"))
            {
                try
                {
                    string[] s = TextBoxScreen.Text.Split('*');
                    double first = Convert.ToDouble(s[0]);
                    double second = Convert.ToDouble(s[1]);

                    double result = first * second;
                    TextBoxResult.Text = result.ToString();
                    TextBoxScreen.Text = TextBoxResult.Text;
                }
                catch
                {
                    TextBoxResult.Text = "Ошибка!";
                }               
            }
            else if (TextBoxScreen.Text.Contains("/"))
            {
                try
                {
                    string[] s = TextBoxScreen.Text.Split('/');
                    double first = Convert.ToDouble(s[0]);
                    double second = Convert.ToDouble(s[1]);

                    double result = first / second;
                    TextBoxResult.Text = result.ToString();
                    TextBoxScreen.Text = TextBoxResult.Text;
                }
                catch
                {
                    TextBoxResult.Text = "Ошибка!";
                }                
            }
            else if (TextBoxScreen.Text.Contains("%"))
            {
                try
                {
                    string[] s = TextBoxScreen.Text.Split('%');
                    double first = Convert.ToDouble(s[0]);
                    double second = Convert.ToDouble(s[1]);

                    double result = (first / 100) * second;
                    TextBoxResult.Text = result.ToString();
                    TextBoxScreen.Text = TextBoxResult.Text;
                }
                catch
                {
                    TextBoxResult.Text = "Ошибка!";
                }           
            }
            else if (TextBoxScreen.Text.Contains("^"))
            {
                try
                {
                    string[] s = TextBoxScreen.Text.Split('^');
                    double first = Convert.ToDouble(s[0]);
                    double second = Convert.ToDouble(s[1]);

                    double result = Math.Pow(first, second);
                    TextBoxResult.Text = result.ToString();
                    TextBoxScreen.Text = TextBoxResult.Text;
                }
                catch
                {
                    TextBoxResult.Text = "Ошибка!";
                }
            }
            else if (TextBoxScreen.Text.Contains("±"))
            {
                try
                {
                    string[] s = TextBoxScreen.Text.Split('±');
                    double first = Convert.ToDouble(s[0]);
                    double second = Convert.ToDouble(s[1]);

                    double result = -1 * first;
                    TextBoxResult.Text = result.ToString();
                    TextBoxScreen.Text = TextBoxResult.Text;
                }
                catch
                {
                    TextBoxResult.Text = "Ошибка!";
                }       
            }
            else if (TextBoxScreen.Text.Contains("!"))
            {
                try
                {
                    string[] s = TextBoxScreen.Text.Split('!');
                    int first = Convert.ToInt32(s[0]);
                    int result = Factor(Convert.ToInt32(first));
                    TextBoxResult.Text = result.ToString();
                    TextBoxScreen.Text = TextBoxResult.Text;
                }
                catch
                {
                    TextBoxResult.Text = "Ошибка!";
                }               
            }
            else if (TextBoxScreen.Text.Contains("√"))
            {
                try
                {
                    string[] s = TextBoxScreen.Text.Split('√');
                    int first = Convert.ToInt32(s[0]);
                    int result = Convert.ToInt32(Math.Sqrt(first));
                    TextBoxResult.Text = result.ToString();
                    TextBoxResult.Text = TextBoxScreen.Text;
                }
                catch
                {
                    TextBoxResult.Text = "Ошибка!";
                }
            }
        }

        private void BtnClear(object sender, EventArgs e)
        {
            TextBoxScreen.Text = "0";
        }

        private void btnOneClear_Click(object sender, EventArgs e)
        {
            char[] chars = new char[TextBoxScreen.Text.Length - 1];
            TextBoxScreen.Text.CopyTo(0, chars, 0, chars.Length);
            TextBoxScreen.Text = new string(chars);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Sqrt(object sender, EventArgs e)
        {
            
        }

        private void SetZnak(object sender, EventArgs e)
        {
            if (TextBoxScreen.Text != "")
                if (TextBoxScreen.Text[0] == '-')
                    TextBoxScreen.Text = TextBoxScreen.Text.Remove(0, 1);
                else TextBoxScreen.Text = '-' + TextBoxScreen.Text;
        }
    }
}
