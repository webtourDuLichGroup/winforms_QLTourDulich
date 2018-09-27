using DAO;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
namespace BUS
{
    public class QuyenNguoiDungBus
    {
        public static void PhanQuyenManHinh(RibbonControl menu, string username)
        {
            List<QuyenNhomNguoiDungDTO> quyenNhomNguoiDungLst = new List<QuyenNhomNguoiDungDTO>();
            quyenNhomNguoiDungLst = TimQuyenNguoiDung(username);
            if (quyenNhomNguoiDungLst.Count > 0)
            {
                foreach (QuyenNhomNguoiDungDTO quyenNhom in quyenNhomNguoiDungLst)
                {
                    foreach (RibbonPage page in menu.Pages)
                    {
                        bool hienThi = quyenNhom.Quyens.FirstOrDefault(t => t.CoQuyen == true &&page.Tag!=null&& t.MaMH == page.Tag.ToString()) != null;
                        page.Visible = hienThi;
                    }
                }
            }
        }

        public static List<QuyenNhomNguoiDungDTO> TimQuyenNguoiDung(string username)
        {
            QuanLiTourDuLichEntities thucThe = new QuanLiTourDuLichEntities();
            List<string> maNhomList = thucThe.QUANLINHOMNGUOIDUNGs.Select(t => t.MANHOM).ToList();
            List<QuyenNhomNguoiDungDTO> quyenNguoiDungLst = new List<QuyenNhomNguoiDungDTO>();
            foreach (string item in maNhomList)
            {
                try
                {
                    var ketQua = (from phanQuyen in thucThe.PHANQUYENs
                                  where phanQuyen.MANHOM == item
                                  select new Quyen()
                                  {
                                      CoQuyen = phanQuyen.COQUYEN,
                                      MaMH = phanQuyen.MAMANHINH
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

    }
}
