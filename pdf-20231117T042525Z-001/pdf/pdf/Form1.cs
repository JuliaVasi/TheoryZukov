using  System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Globalization;
using System.Data.SqlClient;

namespace pdf
{
    public partial class ТехноСервис : Form
    {
        // These can be constructed manually or created in the Designer
        BindingSource bindingSource1=new BindingSource();
        public ТехноСервис()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        { 
            new Form2().Show();
            this.Hide();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            new EditForm().Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create db
            string connectionString = "Data Source = DB.sqlite; Version = 3;";
            SQLiteConnection sQLiteConnection = new SQLiteConnection(connectionString);
            sQLiteConnection.Open();

            string query = "Create Table if not exists Entries (" +
               "ID integer primary key, startDate text, finishDate text, " +
               "requestStatus text, eqType text, serialNumber integer, " +
               "problemDesr text, clienName text, clientNumber text, " +
               "priority text, worker text, orderedSpares text, " +
               "mulificReason text, help text)";

            SQLiteCommand command = new SQLiteCommand(query, sQLiteConnection);
            command.ExecuteNonQuery();
            sQLiteConnection.Close();

            Database database=new Database();
            var dbConn = new SQLiteConnection("Data Source= DB.sqlite");

            var dataAdapter = new SQLiteDataAdapter("SELECT * from [Entries]",dbConn);

            // This binding can be done manually in constructor/on Load event, or also done via properties in the Designer
            dataGridView1.DataSource = bindingSource1;

            // Now, on form load or other event, the .Fill method of SQLiteDataAdapter
            // can be used just like the System.Data.SqlClient.SqlDataAdapter class
            
                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                
                     dataGridView1.Columns[0].HeaderText = "ID заявки";
                     dataGridView1.Columns[1].HeaderText = "Подача заявки";
                     dataGridView1.Columns[2].HeaderText = "Закрытие заявки";

                     dataGridView1.Columns[3].HeaderText = "Статус";
                     dataGridView1.Columns[4].HeaderText = "Тип оборудования";
                     dataGridView1.Columns[5].HeaderText = "Серийный номер";

                     dataGridView1.Columns[6].HeaderText = "Описание проблемы";
                     dataGridView1.Columns[7].HeaderText = "ФИО клиента";
                     dataGridView1.Columns[8].HeaderText = "Телефон клиента";

                     dataGridView1.Columns[9].HeaderText = "Приоритет заявки";
                     dataGridView1.Columns[10].HeaderText = "Исполнитель";
                     dataGridView1.Columns[11].HeaderText = "Заказ запчасти";

                     dataGridView1.Columns[12].HeaderText = "Заказ Причина неисправности";
                     dataGridView1.Columns[13].HeaderText = "Оказанная помощь";
           

            dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
          //  dataGridView1.AutoSize()

        }
    }
}
