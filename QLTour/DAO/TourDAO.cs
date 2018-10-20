using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class TourDAO
    {
        QlTourDuLichEntities entities = new QlTourDuLichEntities();
        public List<TourDTO> LayDanhSachTour()
        {
            var res = (from t in entities.TOURs
                       join ks in entities.KHACHSANs
                       on t.MaKS equals ks.MaKS
                       join ht in entities.HANHTRINHs
                       on t.MaHanhTrinh equals ht.MaHanhTrinh
                       join dd1 in entities.DIADIEMs
                       on ht.NoiDen equals dd1.MaDiaDiem
                       join dd2 in entities.DIADIEMs
                       on ht.NoiDi equals dd2.MaDiaDiem
                       select new TourDTO()
                       {
                           MaTour = t.MaTour,
                           //AnhDiaDiem=t.AnhDaiDien,
                           NgayKH = t.NgayKhoiHanh,
                           NgayKT = t.NgayKetThuc,
                           TenKhachSan = ks.TenKS,
                           DiemDen = dd1.TenDiaDiem,
                           DiemDi = dd2.TenDiaDiem,
                           GiaNguoiLon = t.GiaNguoiLon,
                           GiaTreEm = t.GiaTreEm
                           //MaDiemDen = dd1.MaDiaDiem,
                           //MaDiemDi = dd2.MaDiaDiem
                       });
            return res.ToList<TourDTO>();
        }

        public List<TourDTO> TimTour(DateTime ngayKH, int? maNoiDi, int? maNoiDen)
        {
            var res = (from t in entities.TOURs
                       join ks in entities.KHACHSANs
                       on t.MaKS equals ks.MaKS
                       join ht in entities.HANHTRINHs
                       on t.MaHanhTrinh equals ht.MaHanhTrinh
                       join dd1 in entities.DIADIEMs
                       on ht.NoiDen equals dd1.MaDiaDiem
                       join dd2 in entities.DIADIEMs
                       on ht.NoiDi equals dd2.MaDiaDiem
                       where t.NgayKhoiHanh == ngayKH && ht.NoiDi == maNoiDi && ht.NoiDen == maNoiDen
                       select new TourDTO()
                       {
                           MaTour = t.MaTour,

                           NgayKH = t.NgayKhoiHanh,
                           NgayKT = t.NgayKetThuc,
                           TenKhachSan = ks.TenKS,
                           DiemDen = dd1.TenDiaDiem,
                           DiemDi = dd2.TenDiaDiem,

                       });


            return res.ToList<TourDTO>();
        }

        public TourChiTietDTO TimTour(string maTour)
        {

                var res = (from t in entities.TOURs
                           where t.MaTour==maTour
                           join ks in entities.KHACHSANs
                           on t.MaKS equals ks.MaKS
                           join ht in entities.HANHTRINHs
                           on t.MaHanhTrinh equals ht.MaHanhTrinh
                           join dd1 in entities.DIADIEMs
                           on ht.NoiDen equals dd1.MaDiaDiem
                           join dd2 in entities.DIADIEMs
                           on ht.NoiDi equals dd2.MaDiaDiem
                           select new TourChiTietDTO()
                           {
                               Tour = new TourDTO()
                               {
                                   MaTour = t.MaTour,
                                   NgayKH = t.NgayKhoiHanh,
                                   NgayKT = t.NgayKetThuc,
                                   TenKhachSan = ks.TenKS,
                                   DiemDen = dd1.TenDiaDiem,
                                   DiemDi = dd2.TenDiaDiem,
                                   GiaNguoiLon = t.GiaNguoiLon,
                                   GiaTreEm = t.GiaTreEm
                               },
                               AnhDiaDiem = t.AnhDaiDien,
                               GiaKhachSan=ks.GiaTien                          
                           });
                return res.First();

        }

    }
}
