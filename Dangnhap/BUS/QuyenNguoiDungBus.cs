using DAO;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    class QuyenNguoiDungBus
    {
       public void PhanQuyenManHinh(RibbonControl menu)
        {
            QuanLiTourDuLichEntities ql = new QuanLiTourDuLichEntities();
            object x = ql.NGUOIDUNGs.Select(t => t.TENDANGNHAP).ToList();
        }
       
    }
}
