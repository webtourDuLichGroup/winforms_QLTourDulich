using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TourDTO
    {
        [DisplayName("Tên Tour")]
        public string TenTour { get; set; }

        [DisplayName("Loại Tour")]
        public string LoaiTour { get; set; }

        [DisplayName("Mã Tour")]
        public string MaTour { get; set; }

        [DisplayName("Tên Khách sạn")]
        public string TenKhachSan { get; set; }

        [DisplayName("Ngày khởi hành")]
        public DateTime? NgayKH { get; set; }

        [DisplayName("Ngày trở về")]
        public DateTime? NgayKT { get; set; }


        [DisplayName("Nơi đi")]
        public string DiemDi { get; set; }

        [DisplayName("Nơi đến")]
        public string DiemDen { get; set; }

        [DisplayName("Giá trẻ em")]
        public decimal? GiaTreEm { get; set; }

        [DisplayName("Giá người lớn")]
        public decimal? GiaNguoiLon { get; set; } 

    }

    public class TourDuocChonDTO
    {
        public string MaTour { get; set; }

        public int NguoiLon { get; set; }

        public int TreEm { get; set; }

        public decimal? TongTien { get; set; }

        public decimal? GiaTreEm { get; set; }

        public decimal? GiaNguoiLon { get; set; }
    }

    public class TourChiTietDTO
    {
        public TourDTO Tour { get; set; }

        public decimal? GiaKhachSan { get; set; }

        public string AnhDiaDiem { get; set; }
    }

    public class ThemTourDTO
    {
        public string MaHanhTrinh { get; set; }

        public TourDTO TourDTO { get; set; }

        public string MaKS { get; set; }

        public int? MaHDV { get; set; }

        public string AnhDiaDiem { get; set; }

        public string MaLoaiTour { get; set; }
    }
}
