using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace WindowsFormsApplication1
{
    class AccessConnect
    {
        String conn_string = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database11.accdb;
Persist Security Info=False;";
        private OleDbConnection connection;
        private OleDbCommand command;
        OleDbDataAdapter da;
        DataTable dt;
        OleDbDataReader reader;

        public AccessConnect(string connectionString)
        {
            this.connection = new OleDbConnection(connectionString);
        }
        public void connectOpen()
        {
            connection.Open();
        }
        public void newCommand(string SQLText)
        {
            command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = SQLText;
        }
        public DataTable fillInTable()
        {
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void Execute()
        {
            command.ExecuteNonQuery();
        }
        public void connectClose()
        {
            connection.Close();
        }
    }
}
