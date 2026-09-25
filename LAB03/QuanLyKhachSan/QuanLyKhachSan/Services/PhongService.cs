using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class PhongService
    {
        public DataTable LayDanhSachKhuVuc()
        {
            return Db.Query("SELECT * FROM KhuVuc");
        }

        public DataTable LayDanhSachPhong()
        {
            string sql = @"SELECT p.MaPhong, p.SoPhong, k.TenKhuVuc, p.SoNguoiToiDa, p.DonGiaNgay, p.TrangThai 
                           FROM Phong p JOIN KhuVuc k ON p.MaKhuVuc = k.MaKhuVuc";
            return Db.Query(sql);
        }

        public DataTable LayDanhSachPhongTrong()
        {
            string sql = @"SELECT p.MaPhong, p.SoPhong, k.TenKhuVuc, p.DonGiaNgay 
                           FROM Phong p JOIN KhuVuc k ON p.MaKhuVuc = k.MaKhuVuc 
                           WHERE p.TrangThai = N'Trống'";
            return Db.Query(sql);
        }

        public bool CapNhatTrangThaiPhong(int maPhong, string trangThai)
        {
            string sql = "UPDATE Phong SET TrangThai = @TrangThai WHERE MaPhong = @MaPhong";
            return Db.Execute(sql,
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@MaPhong", maPhong)) > 0;
        }
    }
}