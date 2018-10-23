using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class NguoiDungDAO
    {
        QlTourDuLichEntities entity = new QlTourDuLichEntities();

        public bool KTraDangNhap(string username, string matKhau)
        {
            return entity.NGUOIDUNGs.Where(t => t.TenDangNhap == username && t.MatKhau == matKhau)
                .FirstOrDefault() != null;
        }


    }
}
