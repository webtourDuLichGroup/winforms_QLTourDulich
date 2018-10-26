using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class ChiTietHopDongDAO
    {
        QlTourDuLichEntities entitiy = new QlTourDuLichEntities();

        public void ThemCTHopDong(ChiTietHopDongDTO chiTietHopDongDTO)
        {
            ChiTietHopDong hopDong = new ChiTietHopDong()
            {
                MaCT_HopDong=chiTietHopDongDTO.MaCT_HopDong,
                MaHopDong=chiTietHopDongDTO.MaHopDong,MaTour=chiTietHopDongDTO.MaTour,
                SoLuong=chiTietHopDongDTO.SoLuong,
                ThanhTien=chiTietHopDongDTO.ThanhTien
            };
            entitiy.ChiTietHopDongs.Add(hopDong);
            entitiy.SaveChanges();
        }
    }
}
