﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietHopDongDTO
    {
        public string MaCT_HopDong { get; set; }

        public string MaHopDong { get; set; }

        public string MaTour { get; set; }

        public int? SoLuongTreEm { get; set; }

        public int? SoLuongNguoiLon { get; set; }

        public decimal? ThanhTien { get; set; }
    }
}
