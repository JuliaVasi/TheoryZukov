using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Data.SqlClient;
using System.Reflection;

namespace ShopVasileva

{
    public partial class UserControlGoods : UserControl
    {
        public UserControlGoods()
        {
            InitializeComponent();

        }

        public TextBox TextBoxTitle { get { return textBoxTitle; } set { textBoxTitle = value; } }
        public TextBox TextBoxDesc { get { return textBoxDescription; } set { textBoxDescription = value; } }
        public Label LabelPrice { get { return labelPrice; } set { labelPrice = value; } }
        public Label ID { get { return id; } set { id = value; } }
        public Label ImgPath { get { return imgpath; } set { imgpath = value; } }
        public PictureBox picture { get { return pictureBox1; } set { pictureBox1=value; } }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlGoods_Load(object sender, EventArgs e)
        {

        }

        private void buyBtn_Click(object sender, EventArgs e)
        {

            using (SqlConnection openCon = new SqlConnection("Data Source=(localdb)\\MSSqlLocalDB;Initial Catalog=ClothesShop;Integrated Security=True"))
            {
                string saveGood = "INSERT into Basket (goodId, image, price, description, title) " +
                    "VALUES (@goodId, @image, @price, @description, @title)";

                StringBuilder b = new StringBuilder();
                b.Append(labelPrice.Text.ToString());
                string price = b.ToString(0, b.Length-5);

                using (SqlCommand query = new SqlCommand(saveGood))
                {
                    query.Connection = openCon;
                   query.Parameters.Add("@goodId", SqlDbType.NVarChar, 100).Value = id.Text.ToString();
                    query.Parameters.Add("@image", SqlDbType.NVarChar, 100).Value = imgpath.Text.ToString();
                    query.Parameters.Add("@price", SqlDbType.NVarChar, 100).Value = price;
                    query.Parameters.Add("@description", SqlDbType.NVarChar, 1000).Value = textBoxDescription.Text.ToString();
                    query.Parameters.Add("@title", SqlDbType.NVarChar, 300).Value = textBoxTitle.Text.ToString();

                    openCon.Open();
                    query.ExecuteNonQuery();
                    openCon.Close();
                    MessageBox.Show("Товар добавлен в корзину");
                }
            }

              }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
