using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class QuyenNguoiDungDTO
    {
        public QuyenNguoiDungDTO(string maNhomNguoiDung, List<Quyen> nhomQuyen)
        {
            MaNhomNguoiDung = maNhomNguoiDung;
            NhomQuyen = nhomQuyen;
        }

        public string MaNhomNguoiDung { get; set; }
        public List<Quyen> NhomQuyen { get; set; }
    }

    public class Quyen
    {
        public string Ma;
    }
}
