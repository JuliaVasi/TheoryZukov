using PdfSharp.Drawing;
using PdfSharp.Pdf;
using ShopVasileva.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ShopVasileva
{
    public partial class BasketFormcs : Form
    {
        int orderSumm = 0;
        public BasketFormcs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void BasketFormcs_Load(object sender, EventArgs e)
        {
            using (SqlConnection openCon = new SqlConnection("Data Source=(localdb)\\MSSqlLocalDB;Initial Catalog=ClothesShop;Integrated Security=True"))
            {
                using (SqlCommand query = new SqlCommand("Delete  from Basket where goodId like 5 or goodId like 6"))
                {
                    query.Connection = openCon;
                    /*                query.Parameters.Add("@goodId", SqlDbType.NVarChar, 100).Value = id.Text.ToString();
                                    query.Parameters.Add("@image", SqlDbType.NVarChar, 100).Value = id.Text.ToString();
                                    query.Parameters.Add("@price", SqlDbType.NVarChar, 100).Value = id.Text.ToString();
                                    query.Parameters.Add("@description", SqlDbType.NVarChar, 1000).Value = id.Text.ToString();
                                    query.Parameters.Add("@title", SqlDbType.NVarChar, 300).Value = id.Text.ToString();*/

                    openCon.Open();
                    query.ExecuteNonQuery();
                    openCon.Close();
                }

            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Basket". При необходимости она может быть перемещена или удалена.
            this.basketTableAdapter.Fill(this.dataSet1.Basket);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {


                UserControlBasket userControl = new UserControlBasket();
                userControl.picture.Image = Image.FromFile(Convert.ToString(dataGridView1[1, i].Value));
                userControl.LabelPrice.Text = Convert.ToString(dataGridView1[2, i].Value) + " руб.";
                userControl.ID.Text = Convert.ToString(dataGridView1[0, i].Value);
                userControl.TextBoxDesc.Text = Convert.ToString(dataGridView1[3, i].Value);
                userControl.TextBoxTitle.Text = Convert.ToString(dataGridView1[4, i].Value);

                flowLayoutPanel1.Controls.Add(userControl);
                orderSumm += Convert.ToInt32(Convert.ToString(dataGridView1[2, i].Value));
            }

            orderprice.Text = "Итого к оплате: " + orderSumm.ToString() + " руб.";

        }

        private void buybtn_Click(object sender, EventArgs e)
        {

            Random r = new Random();
            
            var document = new PdfDocument();
            var page = document.AddPage();
            var gfx = XGraphics.FromPdfPage(page);
            var Titlefont = new XFont("Verdana", 15, XFontStyle.Bold);
            var textFont = new XFont("Verdana", 8, XFontStyle.Bold);
            gfx.DrawString("Заказ", Titlefont, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.TopCenter);
            gfx.DrawString("Код заказа: " + r.Next(100, 999).ToString(), textFont, XBrushes.Black, new XRect(0, 10, page.Width, page.Height), XStringFormats.TopRight);
            gfx.DrawString("Номер заказа: " + r.Next(4, 15), textFont, XBrushes.Black, new XRect(0, 20, page.Width, page.Height), XStringFormats.TopRight);
            gfx.DrawString("Код заказа: " + r.Next(100, 999).ToString(), textFont, XBrushes.Black, new XRect(0, 30, page.Width, page.Height), XStringFormats.TopRight);
            gfx.DrawString("Дата заказа: " + DateTime.Today.ToString(), textFont, XBrushes.Black, new XRect(0, 40, page.Width, page.Height), XStringFormats.TopRight);
            //gfx.DrawString("Дата заказа: "+ DateTime.UtcNow.Date +r.ToString(), textFont, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.TopRight);

            string orderText = "";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                orderText += Convert.ToString(dataGridView1[4, i].Value)+" "+ (Convert.ToString(dataGridView1[2, i].Value))+ " руб.; ";
                
             /*   gfx.DrawString(Convert.ToString(dataGridView1[2, i].Value) + " руб.", textFont, XBrushes.Black, 
                    new XRect(0,60+ i * 10, page.Width, page.Height), XStringFormats.CenterRight);   */          
                //gfx.DrawString(" Итого........................................", textFont, XBrushes.Black, new XRect(0, 60 + dataGridView1.Rows.Count - 1 * 10, page.Width, page.Height), XStringFormats.CenterLeft);
                //gfx.DrawString(orderSumm + " руб.", textFont, XBrushes.Black, new XRect(0, 60 + dataGridView1.Rows.Count - 1 * 10, page.Width, page.Height), XStringFormats.CenterRight);
            }
            gfx.DrawString(orderText , textFont, XBrushes.Black,new XRect(0, 60, page.Width, page.Height), XStringFormats.TopCenter);
            document.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Талон.pdf");
            using (SqlConnection openCon = new SqlConnection("Data Source=(localdb)\\MSSqlLocalDB;Initial Catalog=ClothesShop;Integrated Security=True"))
            {
                using (SqlCommand query = new SqlCommand(" truncate table Basket"))
                {
                    query.Connection = openCon;

                    openCon.Open();
                    query.ExecuteNonQuery();
                    openCon.Close();
                }

            }

            MessageBox.Show("Заказ оформлен");
            this.Hide();
        }
    }
}
