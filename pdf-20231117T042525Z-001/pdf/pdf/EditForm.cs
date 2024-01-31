using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pdf
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void client_TextChanged(object sender, EventArgs e)
        {

        }

        private void problemDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void eqTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serialNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new ТехноСервис().Show();
            this.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DB.sqlite; Version = 3;";
            SQLiteConnection sQLiteConnection = new SQLiteConnection(connectionString);
            sQLiteConnection.Open();


            string saveQuery = "update  Entries set " +

               "finishDate = '" + finishdate.Text.ToString()+"', " +
               " requestStatus = '"+requestStatusCombobox.SelectedItem.ToString()+"', " +
               "eqType='" + eqTextBox.Text.ToString() + "', " +
               "serialNumber='" + serialNumber.Text.ToString() + "', " +
               "problemDesr='" + problemDescTextBox.Text.ToString() + "', " +
             "clienName='" + client.Text.ToString() + "', " +
              "clientNumber='" + clientNumber.Text.ToString() + "', " +
              "priority='" + comboBox1Priority.SelectedItem.ToString() + "', " +
              "worker='" + workerTextBox.Text.ToString() + "', " +
              "orderedSpares='" + sparesTextBox.Text.ToString() + "', " +
              "mulificReason='" + reasonTextBox.Text.ToString() + "', " +
               "help='" + helptextBox.Text.ToString() + "' " +
               " where ID = " +idTextBox.Text.ToString()+";";

            SQLiteCommand command = new SQLiteCommand(saveQuery, sQLiteConnection);
            command.ExecuteNonQuery();
            sQLiteConnection.Close();

            MessageBox.Show("Изменения сохранены");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            comboBox1Priority.Items.Add("Высокий");
            comboBox1Priority.Items.Add("Низкий");
            comboBox1Priority.Items.Add("Средний");


            requestStatusCombobox.Items.Add("Актуально");
            requestStatusCombobox.Items.Add("Завершено");

        }

        private void findEntry_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection connection = new SQLiteConnection("Data Source = DB.sqlite; Version = 3;");
            connection.Open();



            if(idTextBox.Text.Length > 0  && int.TryParse(idTextBox.Text, out int id))
            {
                string query = "Select * from Entries where ID = '"  +idTextBox.Text+ "';";
                startdate.ReadOnly = true;
                idTextBox.ReadOnly = true;

                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader= command.ExecuteReader();

                while (reader.Read()) { 
                    startdate.Text = reader.GetString(1);
                    finishdate.Text = reader.GetString(2);
                    requestStatusCombobox.SelectedItem= reader.GetString(3);
                    eqTextBox.Text = reader.GetString(4);
                    serialNumber.Text = reader.GetValue(5).ToString();
                    problemDescTextBox.Text = reader.GetString(6);
                    client.Text = reader.GetString(7);
                    clientNumber.Text = reader.GetString(8);
                    comboBox1Priority.SelectedItem=reader.GetString(9);
                    workerTextBox.Text = reader.GetString(10);
                    sparesTextBox.Text = reader.GetString(11);
                    reasonTextBox.Text = reader.GetString(12);
                    helptextBox.Text = reader.GetString(13);
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Заявки с данным id не существует");
            }
          
        }

        private void findValue(int id,object column)
        {
            
        }
    }
}
