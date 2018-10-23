using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
   public class BUS_QLHDV
    {
       DAO_QLHDV hdv = new DAO_QLHDV();
       public DataTable LoadHDV()
       {
           return hdv.LoadHDV();
       }
       public int InsertHDV(string TenHDV, string SDT, string DC, DateTime NgSinh, string gt, string anh, int tt, string ghichu, DateTime ngvaolam, string ngonngu)
       {
           return hdv.InsertHDV(TenHDV, SDT, DC, NgSinh, gt, anh, tt, ghichu, ngvaolam, ngonngu);
       }
       public int EditHDV(string TenHDV, string SDT, string DC, DateTime NgSinh, string gt, string anh, int tt, string ghichu, DateTime ngvaolam, string ngonngu,int pMaHDV)
       {
           return hdv.EditHDV(TenHDV, SDT, DC, NgSinh, gt, anh, tt, ghichu, ngvaolam, ngonngu,pMaHDV);
       }
       public int DeleteHDV(int pMaHDV)
       {
           return hdv.DeleteHDV(pMaHDV);
       }
    }
}
