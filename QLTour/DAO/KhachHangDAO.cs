using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAO
{
    public class KhachHangDAO
    {
        QlTourDuLichEntities entity = new QlTourDuLichEntities();

        public void ThemKhachHangMoi(KhachHangDTO khachHangDTO)
        {
            KHACHHANG kh = new KHACHHANG()
            {
                MaKH = khachHangDTO.MaKH,
                DCKH=khachHangDTO.DiaChi,
                Email=khachHangDTO.Email,
                GioiTinh=khachHangDTO.GioiTinh,
                MaLoaiKH=khachHangDTO.MaloaiKH,
                NgSinh=khachHangDTO.NgaySinh,
                SDTKH=khachHangDTO.Sdt,
                TenKH=khachHangDTO.TenKH,
                TenDoanhNghiep=khachHangDTO.TenDoanhNghiep
            };
            entity.KHACHHANGs.Add(kh);
            entity.SaveChanges();
        }
    }
}
