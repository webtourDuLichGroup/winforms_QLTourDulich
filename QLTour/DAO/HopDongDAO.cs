using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAO
{
    public class HopDongDAO
    {
        QlTourDuLichEntities entity = new QlTourDuLichEntities();
        public void ThemHopDong(HopDongDTO hopDongDTO)
        {
            HOPDONG hopdong = new HOPDONG()
            {
                GhiChu=hopDongDTO.GhiChu,
                MaHD=hopDongDTO.MaHD,
                MaKH=hopDongDTO.MaKH,
                SoNguoiLon=hopDongDTO.SoNguoiLon,
                SoTreEm=hopDongDTO.SoTreEm,
                ThoiGianDat=hopDongDTO.ThoiGianDat,
                TinhTrang=hopDongDTO.TinhTrang,
                TongTien=hopDongDTO.TongTien,
            };
            entity.HOPDONGs.Add(hopdong);
            entity.SaveChanges();
        }
    }
}
