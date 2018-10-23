using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAO
{
    public class QuyenNguoiDungDAO
    {
        QlTourDuLichEntities entity = new QlTourDuLichEntities();

        public static List<QuyenNhomNguoiDungDTO> TimQuyenNguoiDung(string username)
        {
            QlTourDuLichEntities thucThe = new QlTourDuLichEntities();
            List<int?> maNhomList = thucThe.QUANLINHOMNGUOIDUNGs.Select(t => t.MaNhom).ToList();
            List<QuyenNhomNguoiDungDTO> quyenNguoiDungLst = new List<QuyenNhomNguoiDungDTO>();
            foreach (int item in maNhomList)
            {
                try
                {
                    var ketQua = (from phanQuyen in thucThe.PHANQUYENs
                                  where phanQuyen.MaNhom == item
                                  select new QuyenDTO()
                                  {
                                      CoQuyen = phanQuyen.CoQuyen,
                                      MaMH = phanQuyen.MaMH

                                  }).ToList();
                    quyenNguoiDungLst.Add(new QuyenNhomNguoiDungDTO(item, ketQua));
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return quyenNguoiDungLst;
        }


        public List<QuyenDTO> TimQuyenNhomNguoiDung(string maNguoiDung)
        {
            var ketQua = (from nd in entity.NGUOIDUNGs
                          join ql in entity.QUANLINHOMNGUOIDUNGs
                          on nd.MaNV equals ql.MaNV
                          join nh in entity.NHOMNGUOIDUNGs
                          on ql.MaNhom equals nh.MaNhom
                          join pq in entity.PHANQUYENs
                          on nh.MaNhom equals pq.MaNhom
                          where nd.TenDangNhap == maNguoiDung
                          select new QuyenDTO()
                          {
                              MaMH = pq.MaMH,
                              CoQuyen = pq.CoQuyen
                          });
            return ketQua.ToList();
        }
    }
}
