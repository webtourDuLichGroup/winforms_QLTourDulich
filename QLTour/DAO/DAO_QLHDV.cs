using DAO.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
  public  class DAO_QLHDV
    {
      HUONGDANVIENTableAdapter hdv = new HUONGDANVIENTableAdapter();
        HUONGDANVIEN1TableAdapter hdanVien = new HUONGDANVIEN1TableAdapter();
      public DataTable LoadHDV()
      {
            object kq = hdanVien.GetData();
          return hdv.GetData();
      }
      public int InsertHDV(string TenHDV,string SDT,string DC,DateTime NgSinh,string gt,string anh,int tt,string ghichu,DateTime ngvaolam,string ngonngu)
      {
          return hdv.ThemHDV(TenHDV, SDT, DC, NgSinh, gt, anh, tt, ghichu, ngvaolam, ngonngu);
      }
      public int EditHDV(string TenHDV, string SDT, string DC, DateTime NgSinh, string gt, string anh, int tt, string ghichu, DateTime ngvaolam, string ngonngu, int pMaHDV)
      {
          return hdv.Sua(TenHDV, SDT, DC, NgSinh, gt, anh, tt, ghichu, ngvaolam, ngonngu, pMaHDV);
      }
      public int DeleteHDV(int pMaHDV)
      {
          return hdv.Xoa(pMaHDV);
      }
    }
}
