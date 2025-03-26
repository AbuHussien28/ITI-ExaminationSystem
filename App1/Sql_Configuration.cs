using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Configuration;

namespace App1
{
    class Sql_Configuration
    {
        private static Sql_Configuration instance;
        private SqlConnection con;

        public static Sql_Configuration getInstance()
        {
            if (instance == null)
            {
                instance = new Sql_Configuration();
            }
            return instance;
        }

        private Sql_Configuration()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ITIExam"].ConnectionString); 
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public SqlConnection getConnection()
        {
            return con;
        }
        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

    
