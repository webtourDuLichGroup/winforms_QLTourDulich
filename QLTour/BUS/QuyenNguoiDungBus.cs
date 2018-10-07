using DAO;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO.DataSet1TableAdapters;
using System.Data;

namespace BUS
{
    public class QuyenNguoiDungBus
    {
        public static void PhanQuyenManHinh(RibbonControl menu, string username)
        {
            //List<QuyenNhomNguoiDungDTO> quyenNhomNguoiDungLst = new List<QuyenNhomNguoiDungDTO>();
            //quyenNhomNguoiDungLst = TimQuyenNguoiDung(username);
            //if (quyenNhomNguoiDungLst.Count > 0)
            //{
            //    foreach (QuyenNhomNguoiDungDTO quyenNhom in quyenNhomNguoiDungLst)
            //    {
            //        foreach (RibbonPage page in menu.Pages)
            //        {
            //            bool hienThi = quyenNhom.Quyens.FirstOrDefault(t => t.CoQuyen == true && page.Tag != null && t.MaMH == page.Tag.ToString()) != null;
            //            page.Visible = hienThi;
            //        }
            //    }
            //}
        }

        public static List<QuyenNhomNguoiDungDTO> TimQuyenNguoiDung(string username)
        {
            QlTourDuLichEntities thucThe = new QlTourDuLichEntities();
            List<int?> maNhomList = thucThe.QUANLINHOMNGUOIDUNGs.Select(t => t.MaNhom).ToList();
            List<QuyenNhomNguoiDungDTO> quyenNguoiDungLst = new List<QuyenNhomNguoiDungDTO>();
            //foreach (int item in maNhomList)
            //{
            //    try
            //    {
            //        var ketQua = (from phanQuyen in thucThe.PHANQUYENs
            //                      where phanQuyen.MaNhom == item
            //                      select new Quyen()
            //                      {
            //                          CoQuyen = phanQuyen.CoQuyen;
            //                          MaMH = phanQuyen.MaMH;
            //                      }).ToList();
            //        quyenNguoiDungLst.Add(new QuyenNhomNguoiDungDTO(item, ketQua));
            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }
            //}
            return quyenNguoiDungLst;
            
        }

      public static  void A()
        {
            //DataSet1 dataSet = new DataSet1();
            //TOURTableAdapter adapter = new TOURTableAdapter();
            //DataTable table = new DataTable();
            //table = adapter.GetDataBy123();
        }
    }
}
