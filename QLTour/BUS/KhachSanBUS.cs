using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class KhachSanBUS
    {
        public List<KhachSanDTO> LoadKhachSan()
        {
            return new KhachSanDAO().LayDsKhachSan();
        }
    }
}
