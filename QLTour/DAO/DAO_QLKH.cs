using DAO.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
   public class DAO_QLKH
    {
       KHACHHANGTableAdapter kh = new KHACHHANGTableAdapter();
       LOAIKHACHHANGTableAdapter loai = new LOAIKHACHHANGTableAdapter();
       public DataTable LoadKH()
       {
           return kh.GetDataKH();
       }
       public DataTable LoadDSLoaiKH()
       {
           return loai.GetData();
       }
       public int ThemKH(string makh, string tenkh, DateTime ngsinh, int gt, string email, string sdtkh, string dckh, string loaikh, string tendn)
       {
           return kh.ThemKH( makh, tenkh,  ngsinh,  gt, email, sdtkh,  dckh,  loaikh, tendn);
       }
       public int SuaKH(string makh, string tenkh, DateTime ngsinh, int gt, string email, string sdtkh, string dckh, string loaikh, string tendn,string pMaKH)
       {
           return kh.SuaKH(makh, tenkh, ngsinh, gt, email, sdtkh, dckh, loaikh, tendn,pMaKH);
       }
    }
}
