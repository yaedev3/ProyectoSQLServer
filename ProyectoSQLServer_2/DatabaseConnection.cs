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

        /**
         * Constructor de la clase DatabaseConnection, hace la conexion inicial con la base de datos.
         * string server - Servidor de nuestra computadora.
         * string database - Nombre de la base de datos.
         * */
        public DatabaseConnection(string server, string database)
        {
            connection = new OleDbConnection(@"Provider=SQLNCLI11;Server=" + server + ";Database=" + database + ";Trusted_Connection=yes");
        }

        internal int login(string text1, string text2)
        {
            throw new NotImplementedException();
        }

        /**
         * Hace una consulta INSERT INTO a una tabla 
         * Ejemplo: INSERT INTO Cliente (Nombre,Domicilio,Telefono,Ocupacion) VALUES ('Juan Perez','Himno Nacional','8281545','Estudiante')
         * Formato:INSERT INTO tableName (order) VALUES (value)
         * string tableName - Nombre de la tabla.
         * string order - Nombre de los atributos en el orden que se van a insertar separados por una ",".
         * string value - Valores de los atributos que se van a insertar separados por una "," y las cadenas entre comillas simples.
         * */
        public void InsertInto(string tableName, string order, string value)
        {
            string query = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", tableName, order, value);
            connection.Open();
            command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /**
        * Enriquez Capetillo Gerardo Arturo
        * Hace una consulta DELETE de una tabla que tenga el id seleccionado.
        * Ejemplo: DELETE FROM Agente WHERE idAgente = 4
        * Formato: DELETE FROM tableName WHERE idtableName = id
        * string tableName - 
        * string id - 
        * */
        public void DeleteFrom(string tableName, string id)
        {
            string query = string.Format("DELETE FROM {0} WHERE id{1} = {2}", tableName, tableName, id);
            connection.Open();
            command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteFromAuto(string tableName, string key ,string id)
        {
            string query = string.Format("DELETE FROM {0} WHERE {1} = '{2}'", tableName, key, id);
            connection.Open();
            command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /**
        * Enriquez Capetillo Gerardo Arturo
        * Hace una consulta UPDATE a una tabla y asigna los valores a un registro con el id seleccionado.
        * Sirve para todas las tablas menos para la de Auto.
        * Ejemplo: UPDATE Proveedor SET Nombre='Jose Rodriguez',Direccion='Niño Artillero',Telefono='444123541' WHERE idProveedor = 10
        * Formato: UPDATE tableName SET values WHERE idtableName = id
        * string tableName - Nombre de la tabla.
        * string id - Identificador del registro.
        * string values - Valores a asignar, Nombre del atributo igualado a su valor a asignar separados por ","
        * y las cadenas entre comillas simples.
        * */
        public void UpdateSet(string tableName, string id, string values)
        {
            string query = string.Format("UPDATE {0} SET {1} WHERE id{2} = {3}", tableName, values, tableName, id);
            connection.Open();
            command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateSetAuto(string tableName, string key ,string id, string values)
        {
            string query = string.Format("UPDATE {0} SET {1} WHERE {2} = '{3}'", tableName, values, key, id);
            connection.Open();
            command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /**
        * Enriquez Capetillo Gerardo Arturo
        * Hace una consulta SELECT a una tabla y con un criterio en especifico y regresa una tabla con 
        * la informacion sacada por la consulta.
        * Ejemplo : SELECT Nombre, Direccion FROM Cliente
        * Formato: SELECT attribute FROM tableName
        * string tableName - Nombre de la tabla.
        * string attribute - Atributos separados por una ","
        * return - Tabla con la informacion de la consulta.
        * */
        public DataTable Refresh(string tableName, string attribute)
        {
            DataTable table;
            string query = string.Format("SELECT {0} FROM {1}", attribute, tableName);
            connection.Open();
            command = new OleDbCommand(query, connection);
            adapter = new OleDbDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        /**
       * Enriquez Capetillo Gerardo Arturo
       * Hace una consulta SELECT a una tabla y con un criterio en especifico y regresa una tabla con 
       * la informacion sacada por la consulta ademas contiene restricciones hechas por WHERE
       * Ejemplo : SELECT Nombre, Direccion FROM Cliente WHERE idCliente = 100 AND Nombre = 'Juan Lopez'
       * Formato: SELECT attribute FROM tableName WHERE where
       * string tableName - Nombre de la tabla.
       * string attribute - Atributos separados por una ","
       * return - Tabla con la informacion de la consulta.
       * string where - Condiciones para restriccion de datos, cada condicion debe ir separa por un AND 
       * */
        public DataTable Refresh(string tableName, string attribute, string where)
        {
            DataTable table;
            string query = string.Format("SELECT {0} FROM {1} WHERE {2}", attribute, tableName, where);
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
