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

namespace ShopVasileva
{
    public partial class UserControlBasket : UserControl
    {
        public UserControlBasket()
        {
            InitializeComponent();
        }

        public TextBox TextBoxTitle { get { return textBoxTitle; } set { textBoxTitle = value; } }
        public TextBox TextBoxDesc { get { return textBoxDescription; } set { textBoxDescription = value; } }
        public Label LabelPrice { get { return labelPrice; } set { labelPrice = value; } }
    //    public Label LabelPrice2 { get { return price; } set { price = value; } }
        //public Label LabelImgPath { get { return imgpath; } set { imgpath = value; } }
        public Label ID { get { return id; } set { id = value; } }
        public PictureBox picture { get { return pictureBox1; } set { pictureBox1 = value; } }
        public Button btn { get { return btn; } set { btn = value; } }



        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection openCon = new SqlConnection("Data Source=(localdb)\\MSSqlLocalDB;Initial Catalog=ClothesShop;Integrated Security=True"))
            {
                using (SqlCommand query = new SqlCommand("Delete from Basket where goodId like " + id.Text.ToString() +" "))
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
            this.Visible= false;
            MessageBox.Show("Выбранный товар удален");
            /*                  using (SqlCommand command = new SqlCommand("DELETE FROM Basket", openCon))
                    {
                        command.ExecuteNonQuery();
                    }*/
        }
    }
}
