using System.Data.SqlClient;
using System.Data;

namespace _4196_NguyenTriKhang_KLTN_
{
    internal class KetNoi
    {
        private readonly string connectString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

        public SqlConnection GetConnect()
        {
            SqlConnection conn = new SqlConnection(connectString);
            conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["_4196_NguyenTriKhang_KLTN_.Properties.Settings.QLRBWConnectionString"].ConnectionString;
            return conn;
        }

        public DataTable InThongTin(string sqlQuery)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = GetConnect())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn))
                {
                    adapter.Fill(data);
                }
            }
            return data;
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