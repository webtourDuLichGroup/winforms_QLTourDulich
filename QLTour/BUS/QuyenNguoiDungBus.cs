using DAO;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

using System.Data;

namespace BUS
{
    public class QuyenNguoiDungBus
    {
        //public static void PhanQuyenManHinh(RibbonControl menu, string username)
        //{
        //    List<QuyenNhomNguoiDungDTO> quyenNhomNguoiDungLst = new List<QuyenNhomNguoiDungDTO>();
        //    quyenNhomNguoiDungLst = TimQuyenNguoiDung(username);
        //    if (quyenNhomNguoiDungLst.Count > 0)
        //    {
        //        foreach (QuyenNhomNguoiDungDTO quyenNhom in quyenNhomNguoiDungLst)
        //        {
        //            foreach (RibbonPage page in menu.Pages)
        //            {
        //                bool hienThi = quyenNhom.Quyens.FirstOrDefault(t => t.CoQuyen == true && page.Tag != null && t.MaMH == page.Tag.ToString()) != null;
        //                page.Visible = hienThi;
        //            }
        //        }
        //    }
        //}

        public List<QuyenDTO> LayQuyenNguoiDung(string maNV)
        {
            return new QuyenNguoiDungDAO().TimQuyenNhomNguoiDung(maNV);
        }
    }
}
    