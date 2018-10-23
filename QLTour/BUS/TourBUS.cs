using System;
using System.Collections.Generic;
using System.Data;
using DAO;
using DTO;
namespace BUS
{

    public class TourBUS
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

        public TourChiTietDTO TimTour(string maTour)
        {
            return new TourDAO().TimTour(maTour);
        }

        public void ThanhToanTour(KhachHangDTO khachHang,HopDongDTO hopDong,ChiTietHopDongDTO chiTietHopDong)
        {
            new KhachHangDAO().ThemKhachHangMoi(khachHang);
            new HopDongDAO().ThemHopDong(hopDong);
            new ChiTietHopDongDAO().ThemCTHopDong(chiTietHopDong);
        }

        public void ThemTour(ThemTourDTO tourDTO)
        {
            new TourDAO().ThemTour(tourDTO);
        }

        public void XoaTour(string MaTour)
        {
            new TourDAO().XoaTour(MaTour);
        }

        public void ChinhSuaTour(ThemTourDTO tourDTO)
        {
            new TourDAO().ChinhSuaTour(tourDTO);
        }
    }

}