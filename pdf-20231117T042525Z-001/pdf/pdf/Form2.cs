using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdf
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxPriority.Items.Add("Высокий");
            comboBoxPriority.Items.Add("Низкий");
            comboBoxPriority.Items.Add("Средний");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new ТехноСервис().Show();
            this.Hide();
        }

        private void saveBtn2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(eqTextBox.Text))
            {
                eqTypeLabel.ForeColor = Color.Red;
                MessageBox.Show("Заполните все поля");
            }
            if (string.IsNullOrEmpty(serialNumber.Text))
            {
                serialNumber.ForeColor = Color.Red;
                MessageBox.Show("Заполните все поля");
            }
            if (string.IsNullOrEmpty(problemDescLabel.Text))
            {
                problemDescLabel.ForeColor = Color.Red;
                MessageBox.Show("Заполните все поля");
            }
            if (string.IsNullOrEmpty(nameLabel.Text))
            {
                nameLabel.ForeColor = Color.Red;
                MessageBox.Show("Заполните все поля");
            }
            if (string.IsNullOrEmpty(phoneLabel.Text))
            {
                phoneLabel.ForeColor = Color.Red;
                MessageBox.Show("Заполните все поля");
            }
            if(comboBoxPriority.SelectedItem==null)
            {
                priorityLabel.ForeColor = Color.Red;
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                string connectionString = "Data Source = DB.sqlite; Version = 3;";
                SQLiteConnection sQLiteConnection = new SQLiteConnection(connectionString);
                sQLiteConnection.Open();
                
                string saveQuery = "INSERT INTO  Entries (" +
                    "startDate , finishDate , requestStatus ," +
                    " eqType , serialNumber , problemDesr , clienName , " +
                    "clientNumber , priority , worker , orderedSpares , mulificReason , help ) " +
                    "VALUES (" +
                   "'"+ new StringBuilder(DateTime.Today.ToString()).ToString(0, 10)+"', " +
                   "'null', " +
                   "'Актуально', " +
                   "'" + eqTextBox.Text.ToString() + "', " +
                   "'" + serialNumber.Text.ToString() + "', " +
                   "'" + problemDesc.Text.ToString() + "', " +
                 "'" + client.Text.ToString() + "', " +
                  "'" + clientNumber.Text.ToString() + "', " +
                   "'"+comboBoxPriority.SelectedItem.ToString()+"', " +
                   "'null', " +
                   "'null', " +
                   "'null', " +
                   "'null' " +
                   ")";

                // find comboBoxPriority and set 
                SQLiteCommand command = new SQLiteCommand(saveQuery, sQLiteConnection);
                command.ExecuteNonQuery();
                sQLiteConnection.Close();

                MessageBox.Show("Заявка сохранена");
                new ТехноСервис().Show();
                this.Hide();
            }           
            }
        }
    }

