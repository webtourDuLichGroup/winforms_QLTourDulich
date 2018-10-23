using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAO
{
    public class KhachSanDAO
    {
        QlTourDuLichEntities entity = new QlTourDuLichEntities();

        public List<KhachSanDTO> LayDsKhachSan()
        {
            var result = entity.KHACHSANs.Select(t => new KhachSanDTO() { MaKS = t.MaKS, TenKS = t.TenKS });
            return result.ToList();
        }
    }
}
