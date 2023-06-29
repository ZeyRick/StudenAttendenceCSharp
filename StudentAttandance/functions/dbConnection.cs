using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentAttandance.functions
{
     public class SQLConnection
    {

        private SqlConnection sqlConnection;

        public SQLConnection(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void close()
        {
            sqlConnection.Close();
        }

        public SqlDataReader ExeQueryCmd(SqlCommand command)
        {

            SqlDataReader dataReader;

            sqlConnection.Open();
            command.Connection = sqlConnection;
            dataReader = command.ExecuteReader();

            return dataReader;
        }

        public int ExeNonQueryCmd(SqlCommand command)
        {

            int affectedData;

            sqlConnection.Open();
            command.Connection = sqlConnection;
            affectedData = command.ExecuteNonQuery();


            return affectedData;
        }

        public int getLatestID(string tbl_name, string idCol_name)
        {
            int latestID;

            sqlConnection.Open();
            string sql = "SELECT MAX("+ idCol_name +") AS MaxID FROM " + tbl_name;
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            if (dataReader.Read())
            {
                latestID = Convert.ToInt32(dataReader["MaxID"]) + 1;
            }

            else return -1;
            
            return latestID;
        }
    }
}
