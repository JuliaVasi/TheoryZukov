
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pdf
{
    public class Database
    {
     
        public  Database()
        {
            string connectionString = "Data Source=DB.sqlite;Version=3;";
            SQLiteConnection m_dbConnection = new SQLiteConnection(connectionString);
            m_dbConnection.Open();

            string sql = "Create Table if not exists Entries (" +
                "ID integer primary key, startDate text, finishDate text, " +
                "requestStatus text, eqType text, serialNumber integer, " +
                "problemDesr text, clienName text, clientNumber text, " +
                "priority text, worker text, orderedSpares text, " +
                "mulificReason text, help text)";
          
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            command=new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            m_dbConnection.Close();
        }
        

    }
}
