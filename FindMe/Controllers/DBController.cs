using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SwitchControl.Models;

namespace SwitchControl.Controllers
{
    class DBController
    {
        private MySqlConnection sqlConnection = null;
        private String selectQueryString = null;
        private String connectionString = null;
        private MySqlDataAdapter sqlDataAdapter = null;
        //private MySqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        //private BindingSource bindingSource = null;

        public DBController(MySettings appSettings)
        {
            connectionString = appSettings.ConnString;
        }

        public bool TestConnection()
        {
            bool connState = true;
            sqlConnection = new MySqlConnection(connectionString);
            try {
                sqlConnection.Open(); 
            }
            catch
            {
                connState = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return connState;
        }

        public DataTable ReadTable(string inQuery)
        {
            sqlConnection = new MySqlConnection(connectionString);
            selectQueryString = inQuery;
            sqlConnection.Open();
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            // sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            sqlConnection.Close();

            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataColumn GetIPList()
        {
            string str;
             foreach (DataRow myRow in dataTable.Rows)
            //DataRow myRow = dataTable.Rows[0];
                //foreach (DataColumn myColumn in dataTable.Columns)
                    str = myRow["ip"].ToString();

           //dataTable.Columns[1];
            return dataTable.Columns[1]; // ["ip"];
        }




    }
}
