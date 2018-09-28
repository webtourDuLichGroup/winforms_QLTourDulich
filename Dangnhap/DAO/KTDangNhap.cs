using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
   public  class KTDangNhap
    {
       public static bool dangnhap(string tendn, string matkhau)
       {
           QuanLiTourDuLichEntities a = new QuanLiTourDuLichEntities();
           var x = from ac in a.NGUOIDUNGs
                   where ac.TENDANGNHAP == tendn && ac.MATKHAU == matkhau
                   select ac;
           if (x.Any())
           {
               return true;
           }
           else
           {
               return false;
           }

       }
    }
}
