using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;


namespace BUS
{
    public   class Thu
    {

       

        public static bool dangnhap(string tendn, string matkhau)
        {
            bool info = DAO.KTDangNhap.dangnhap(tendn,matkhau);
            return info;

        }
       
    }
}
