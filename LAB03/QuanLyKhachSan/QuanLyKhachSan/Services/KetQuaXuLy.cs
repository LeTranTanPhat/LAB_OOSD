using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Services
{
    public class KetQuaXuLy
    {
        public bool ThanhCong { get; set; }
        public string ThongBao { get; set; }

        public static KetQuaXuLy Ok(string thongBao = "Thao tác thành công.")
        {
            return new KetQuaXuLy { ThanhCong = true, ThongBao = thongBao };
        }

        public static KetQuaXuLy Fail(string thongBao)
        {
            return new KetQuaXuLy { ThanhCong = false, ThongBao = thongBao };
        }
    }
}
