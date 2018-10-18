using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TourDTO
    {
        [DisplayName("Mã Tour")]
        public string MaTour { get; set; }

        [DisplayName("Tên Khách sạn")]
        public string TenKhachSan { get; set; }

        [DisplayName("Ngày khởi hành")]
        public DateTime? NgayKH { get; set; }

        [DisplayName("Ngày trở về")]
        public DateTime? NgayKT { get; set; }

        //public string AnhDiaDiem { get; set; }

        [DisplayName("Nơi đi")]
        public string DiemDi { get; set; }

        [DisplayName("Nơi đến")]
        public string DiemDen { get; set; }

        [DisplayName("Giá trẻ em")]
        public decimal? GiaTreEm { get; set; }

        [DisplayName("Giá người lớn")]
        public decimal? GiaNguoiLon { get; set; }

        //public int? MaDiemDi { get; set; }

        //public int? MaDiemDen { get; set; }

    }

    public class TourDuocChonDTO
    {
        public string MaTour { get; set; }

        public int NguoiLon { get; set; }

        public int TreEm { get; set; }

        public string AnhTour { get; set; }

        public decimal? TongTien { get; set; }

        public decimal? GiaTreEm { get; set; }

        public decimal? GiaNguoiLon { get; set; }
    }
}
