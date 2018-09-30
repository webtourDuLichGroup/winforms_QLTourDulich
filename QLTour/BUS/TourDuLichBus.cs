using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class TourDuLichBus
    {
        public static List<TourDuLichDTO> GetTourDuLichs()
        {
            List<TourDuLichDTO> ketQua = new List<TourDuLichDTO>();
            QuanLiTourDuLichEntities thucThe = new QuanLiTourDuLichEntities();
            try
            {

                ketQua = (from tour in thucThe.TOURs
                          join ht in thucThe.HANHTRINHs
                          on tour.MAHANTRINH equals ht.MAHANTRINH
                          from diaDiem in thucThe.DIADIEMs
                          where ht.NOIDI == diaDiem.MADIADIEM
                          || ht.NOIDEN == diaDiem.MADIADIEM
                          select new TourDuLichDTO()
                          {
                              MoTa=tour.MOTA,
                              TenTour=tour.TENTOUR
                          }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return ketQua;
        }
    }
}
