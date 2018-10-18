using System;
using System.Collections.Generic;
using System.Data;
using DAO;
using DTO;
namespace BUS
{

    public class DatTourBUS
    {
        public List<TourDTO> LoadTourToDataGridView()
        {
            return new TourDAO().LayDanhSachTour();
        }

        public DataTable LoadDiaDiem()
        {
            return new DiaDiemDAO().LayDiaDiem();
        }
        
        public List<DiaDiemDTO> LoadDiemDen(int? idNoiDi)
        {
            return new DiaDiemDAO().TimDiemDen(idNoiDi);
        }

        public List<TourDTO> TimTour(DateTime ngayKH, int? maNoiDi, int? maNoiDen)
        {
            return new TourDAO().TimTour(ngayKH, maNoiDi, maNoiDen);
        }
    }

}