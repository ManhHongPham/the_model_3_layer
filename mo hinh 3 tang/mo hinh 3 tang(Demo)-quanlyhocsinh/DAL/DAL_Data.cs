using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class DAL_Data
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-UQT325M\SQLEXPRESS;Initial Catalog=quanlyhocsinh;Integrated Security=True");
        }
        public DataTable GetTable( string sql)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }
        public void ExecuteNonQuery(string sql)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }

    }
}
