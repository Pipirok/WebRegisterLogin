using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using WebRegisterLogin.Models;

namespace WebRegisterLogin
{
    public class UserDAL
    {
        private static SqlConnection conn = new SqlConnection(DALC.SqlConnectionURI);

        public static UserModel GetUserByUsername(string username)
        {
            if (conn.State != ConnectionState.Open) conn.Open();

            SqlCommand command = new SqlCommand("GetUserByUsername", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@username", username);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            if (ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            return new UserModel(ds.Tables[0].Rows[0].Field<string>("username"), ds.Tables[0].Rows[0].Field<string>("password"), ds.Tables[0].Rows[0].Field<DateTime>("register_date").ToLongDateString(), ds.Tables[0].Rows[0].Field<int>("id"));            
        }

        public static bool AddUser(string username, string password)
        {
            
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand command = new SqlCommand("AddUser", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            
           
        }
    }
}