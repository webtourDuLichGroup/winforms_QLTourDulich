using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class QuyenNhomNguoiDungDTO
    {
        public QuyenNhomNguoiDungDTO(string maNhomNguoiDung, List<Quyen> quyens)
        {
            MaNhomNguoiDung = maNhomNguoiDung;
            Quyens = quyens;
        }

        public string MaNhomNguoiDung { get; set; }
        public List<Quyen> Quyens { get; set; }
    }

    public class Quyen
    {
        //public Quyen(string maMH, bool coQuyen)
        //{
        //    MaMH = maMH;
        //    CoQuyen = coQuyen;
        //}

        public string MaMH { get; set; }
        public bool CoQuyen { get; set; }
    }
}
