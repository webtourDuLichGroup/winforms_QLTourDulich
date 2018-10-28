using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class TourDAO
    {
        QlTourDuLichEntities entity = new QlTourDuLichEntities();
        public List<TourDTO> LayDanhSachTour()
        {
            var res = (from t in entity.TOURs
                       join ks in entity.KHACHSANs
                       on t.MaKS equals ks.MaKS
                       join l in entity.LOAITOURs
                       on t.MaLoaiTour equals l.MaLoaiTour
                       join ht in entity.HANHTRINHs
                       on t.MaHanhTrinh equals ht.MaHanhTrinh
                       join dd1 in entity.DIADIEMs
                       on ht.NoiDen equals dd1.MaDiaDiem
                       join dd2 in entity.DIADIEMs
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
                           GiaTreEm = t.GiaTreEm,
                           LoaiTour=l.TenLoaiTour,
                           TenTour=t.TenTour
                           //MaDiemDen = dd1.MaDiaDiem,
                           //MaDiemDi = dd2.MaDiaDiem
                       });
            return res.ToList<TourDTO>();
        }

        public List<TourDTO> TimTour(DateTime ngayKH, int? maNoiDi, int? maNoiDen)
        {
            var res = (from t in entity.TOURs
                       join ks in entity.KHACHSANs
                       on t.MaKS equals ks.MaKS
                       join ht in entity.HANHTRINHs
                       on t.MaHanhTrinh equals ht.MaHanhTrinh
                       join dd1 in entity.DIADIEMs
                       on ht.NoiDen equals dd1.MaDiaDiem
                       join dd2 in entity.DIADIEMs
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

            var res = (from t in entity.TOURs
                       where t.MaTour == maTour
                       join ks in entity.KHACHSANs
                       on t.MaKS equals ks.MaKS
                       join ht in entity.HANHTRINHs
                       on t.MaHanhTrinh equals ht.MaHanhTrinh
                       join dd1 in entity.DIADIEMs
                       on ht.NoiDen equals dd1.MaDiaDiem
                       join dd2 in entity.DIADIEMs
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
                           GiaKhachSan = ks.GiaTien,
                           TGDen=t.NgayKetThuc,
                           TGDi=t.NgayKetThuc
                       });
            return res.FirstOrDefault();

        }

        public void ThemTour(ThemTourDTO tourDTO)
        {
            TOUR tour = new TOUR()
            {
                MaTour = tourDTO.TourDTO.MaTour,
                AnhDaiDien = tourDTO.AnhDiaDiem,
                GiaNguoiLon = tourDTO.TourDTO.GiaNguoiLon,
                GiaTreEm = tourDTO.TourDTO.GiaTreEm,
                MaHanhTrinh=tourDTO.MaHanhTrinh,
                TenTour=tourDTO.TourDTO.TenTour,
                MaHDV=tourDTO.MaHDV,
                MaKS = tourDTO.MaKS,
                MaLoaiTour = tourDTO.MaLoaiTour,
                NgayKetThuc = tourDTO.TourDTO.NgayKT,
                NgayKhoiHanh = tourDTO.TourDTO.NgayKH,

            };
            entity.TOURs.Add(tour);
            entity.SaveChanges();
        }

        public void XoaTour(string MaTour)
        {
            entity.TOURs.Remove(entity.TOURs.Where(t => t.MaTour == MaTour).FirstOrDefault());
            entity.SaveChanges();

        }

        public void ChinhSuaTour(ThemTourDTO tourDTO)
        {
            TOUR tour = entity.TOURs.Where(t => t.MaTour == tourDTO.TourDTO.MaTour).FirstOrDefault();
            tour.MaTour = tourDTO.TourDTO.MaTour;
            tour.AnhDaiDien = tourDTO.AnhDiaDiem;
            tour.GiaNguoiLon = tourDTO.TourDTO.GiaNguoiLon;
            tour.GiaTreEm = tourDTO.TourDTO.GiaTreEm;
            tour.MaHanhTrinh = tourDTO.MaHanhTrinh;
            tour.MaHDV = tourDTO.MaHDV;
            tour.MaKS = tourDTO.MaKS;
            tour.MaLoaiTour = tourDTO.MaLoaiTour;
            tour.NgayKetThuc = tourDTO.TourDTO.NgayKT;
            tour.NgayKhoiHanh = tourDTO.TourDTO.NgayKH;
            entity.SaveChanges();
        }
    }
}
