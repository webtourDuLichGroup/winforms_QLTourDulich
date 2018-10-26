using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class QuyenNhomNguoiDungDTO
    {
        public QuyenNhomNguoiDungDTO(int maNhomNguoiDung, List<QuyenDTO> quyens)
        {
            MaNhomNguoiDung = maNhomNguoiDung;
            Quyens = quyens;
        }

        public int MaNhomNguoiDung { get; set; }
        public List<QuyenDTO> Quyens { get; set; }
    }

    public class QuyenDTO
    {
        public int? MaMH { get; set; }
        public bool? CoQuyen { get; set; }
    }
}
