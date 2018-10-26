using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAO
{
    public class HuongDanVienDAO
    {
        QlTourDuLichEntities entity = new QlTourDuLichEntities();
        public List<HuongDanVienDTO> LayDSHuongDanVien()
        {
            var result = entity.HUONGDANVIENs.Select(t => new HuongDanVienDTO() { TenHDV = t.TenHDV, MaHDV = t.MaHDV });
            return result.ToList();
        }
    }
}
