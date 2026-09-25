using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSan.Data
{
    public static class Db
    {
        // Lấy chuỗi kết nối từ App.config
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["QuanLyKhachSanDB"].ConnectionString;
            }
        }

        // Mở kết nối SQL
        public static SqlConnection OpenConnection()
        {
            var cn = new SqlConnection(ConnectionString);
            cn.Open();
            return cn;
        }

        // Truy vấn dữ liệu trả về DataTable (SELECT)
        public static DataTable Query(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            using (var da = new SqlDataAdapter(cmd))
            {
                if (ps != null && ps.Length > 0)
                    cmd.Parameters.AddRange(ps);

                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Thực thi lệnh không trả về bảng (INSERT, UPDATE, DELETE)
        public static int Execute(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null && ps.Length > 0)
                    cmd.Parameters.AddRange(ps);

                return cmd.ExecuteNonQuery();
            }
        }

        // Lấy 1 giá trị đơn lẻ (COUNT, SUM, MAX, ID vừa tạo)
        public static object Scalar(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null && ps.Length > 0)
                    cmd.Parameters.AddRange(ps);

                return cmd.ExecuteScalar();
            }
        }
    }
}