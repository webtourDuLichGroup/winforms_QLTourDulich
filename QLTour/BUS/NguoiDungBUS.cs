using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class NguoiDungBUS
    {
        public bool KTraDangNhap(string username,string password)
        {
            return new NguoiDungDAO().KTraDangNhap(username, password);
        }
    }
}
