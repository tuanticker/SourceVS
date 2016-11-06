using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BaiThiC
{
   public class Collection
    {
        protected SqlConnection connection;
        private SqlCommand SqlCom = new SqlCommand();
        private SqlCommandBuilder SqlComBui = new SqlCommandBuilder();

        private string Link_ConnectSQL = @"Data Source=PHAMANH-LAPTOP;Initial Catalog=QLBH_NEW;Integrated Security=True";
        public Collection() 
        {
            try
            {
                SqlConnection con = new SqlConnection(Link_ConnectSQL);
                connection = con;
                SqlCom.Connection = connection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public bool OpenConection()
        {
            try
            {
                if (!connection.State.Equals(ConnectionState.Open)) { connection.Open(); }
            }
            catch { return false; }
            return true;
        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch { return false; }
            return true;
        }
        public SqlDataReader SqlReadAll_Line_ExecuteReader(string Command)
        {
            SqlCom.CommandText = Command;
            OpenConection();
            SqlDataReader Sr = SqlCom.ExecuteReader();
            return Sr;
        }
        public bool Execute_Non_Querry(string Command)
        {
            try
            {

                SqlCom.CommandText = Command;
                OpenConection();
                SqlCom.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            return true;
        }
        public DataTable UsingDataTable_Get(string Command)
        {
            OpenConection();
            DataTable Dt = new DataTable();
            SqlDataAdapter SqlAdter = new SqlDataAdapter(Command, Link_ConnectSQL);
            SqlAdter.Fill(Dt);
            return Dt;
        }
        public bool UsingDataTable_Update(string Command, DataTable Dt_Update)
        {
            SqlDataAdapter SqlAdter = new SqlDataAdapter(Command, Link_ConnectSQL);
            using (SqlCommandBuilder SqlComBui = new SqlCommandBuilder(SqlAdter))
            {
                SqlAdter.Update(Dt_Update);
            }
            return true;
        }
        
    }
}
