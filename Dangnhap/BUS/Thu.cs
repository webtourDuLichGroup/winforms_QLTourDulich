using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;


namespace BUS
{
    public   class Thu
    {

       

        public static int dangnhap(string tendn, string matkhau)
        {
            var info = DAO.KTDangNhap.dangnhap(tendn,matkhau);
            if (info == true)
                return 1;
            return 0;

        }
       
    }
}
