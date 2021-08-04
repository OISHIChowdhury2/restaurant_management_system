using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace projectoop
{


    public static class DataAccess
    {
        public static DataTable Data(string query)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QBT73M3\SQLEXPRESS;Initial Catalog=projectoop;Integrated Security=True");
            conn.Open();
            //string query = "select * from Department";
            //string s = "Username is" + uname+".";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            return ds.Tables[0];
        }
        public static void Execute(string query)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QBT73M3\SQLEXPRESS;Initial Catalog=projectoop;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
        public static string ExecuteInsert(string query)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QBT73M3\SQLEXPRESS;Initial Catalog=projectoop;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
           query = "select SCOPE_IDENTITY() as 'ID';";
            cmd.CommandText = query;
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
           return dt.Rows[0]["ID"].ToString();
        }



    }
}
