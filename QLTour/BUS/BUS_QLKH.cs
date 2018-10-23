using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public    class BUS_QLKH
    {
        DAO_QLKH kh = new DAO_QLKH();
        public DataTable LoadKH()
        {
            return kh.LoadKH();
        }
        public DataTable LoadTenLoai()
        {
            return kh.LoadDSLoaiKH();
        }
        public int ThemKH(string makh, string tenkh, DateTime ngsinh, int gt, string email, string sdtkh, string dckh, string loaikh, string tendn)
        {
            return kh.ThemKH(makh, tenkh, ngsinh, gt, email, sdtkh, dckh, loaikh, tendn);
        }
        public int SuaKH(string makh, string tenkh, DateTime ngsinh, int gt, string email, string sdtkh, string dckh, string loaikh, string tendn, string pMaKH)
        {
            return kh.SuaKH(makh, tenkh, ngsinh, gt, email, sdtkh, dckh, loaikh, tendn, pMaKH);
        }
    }
}
