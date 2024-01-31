using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopVasileva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.catalogTableAdapter.Fill(this.dataSet1.Catalog);
            for(int i = 0; i < catalogDataGridView.Rows.Count - 1; i++)
            {

                UserControlGoods userControl = new UserControlGoods();
                userControl.picture.Image = Image.FromFile(Convert.ToString(catalogDataGridView[1, i].Value));
                userControl.LabelPrice.Text = Convert.ToString(catalogDataGridView[2, i].Value)+" руб.";
                userControl.ID.Text = Convert.ToString(catalogDataGridView[0, i].Value);
                userControl.TextBoxDesc.Text = Convert.ToString(catalogDataGridView[3, i].Value);
                userControl.TextBoxTitle.Text = Convert.ToString(catalogDataGridView[4, i].Value);
                userControl.ImgPath.Text = Convert.ToString(catalogDataGridView[1, i].Value);

                if (catalogDataGridView[5, i].Value.Equals("ж"))
                    flowLayoutPanel1.Controls.Add(userControl);
                 else
                    flowLayoutPanel2.Controls.Add(userControl);
            }
        }

        private void catalogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.catalogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void basketBtn1_Click(object sender, EventArgs e)
        {
            new BasketFormcs().Show();
        }
    }
}
