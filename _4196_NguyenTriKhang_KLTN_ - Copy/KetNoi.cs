using System.Data.SqlClient;
using System.Data;

namespace _4196_NguyenTriKhang_KLTN_
{
    internal class KetNoi
    {
        //private readonly string connectString = @"Data Source=.;TrustServerCertificate=True";

        public SqlConnection GetConnect()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["_4196_NguyenTriKhang_KLTN_.Properties.Settings.QLRBWConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
        public SqlDataReader ExecuteReader(string sqlQuery, params SqlParameter[] parameters)
        {
            SqlConnection conn = GetConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}