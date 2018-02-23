using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ProyectoSQLServer
{
    class DatabaseConnection
    {
        private OleDbConnection connection;
        private OleDbCommand command;
        private OleDbDataAdapter adapter;

        public DatabaseConnection(string server, string database)
        {
            connection = new OleDbConnection(@"Provider=SQLNCLI11;Server=" + server + ";Database=" + database + ";Trusted_Connection=yes");
        }

        public void InsertInto(string tableName, string order, string value)
        {
            string query = "INSERT INTO " + tableName + "(" + order + ") VALUES (" + value + ")";
            connection.Open();
            command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteFrom(string tableName, string id)
        {
            string query = "DELETE FROM " + tableName + "WHERE id_" + tableName + "=" + id;
            connection.Open();
            command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateSet(string tableName, string id, string values)
        {
            string query = "UPDATE " + tableName + " SET " + values + " WHERE id_" + tableName + "=" + id;
            connection.Open();
            command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable Refresh(string tableName)
        {
            DataTable table;
            string query = "SELECT * FROM " + tableName;
            connection.Open();
            command = new OleDbCommand(query, connection);
            adapter = new OleDbDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
    }
}
