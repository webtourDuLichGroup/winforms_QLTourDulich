using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class HanhTrinhDAO
    {
        QlTourDuLichEntities entity = new QlTourDuLichEntities();

        public HANHTRINH TimHanhTrinh(int maNoiDi, int maNoiDen)
        {
            return entity.HANHTRINHs.Where(t => (t.NoiDen == maNoiDen && t.NoiDi == maNoiDen)).FirstOrDefault();
        }

        public void ThemhanhTrinhMoi(HanhTrinhDTO pHanhTrinh)
        {
            HANHTRINH hanhtrinh = new HANHTRINH()
            {
                MaHanhTrinh=pHanhTrinh.MaHanhTrinh,
                NoiDen=pHanhTrinh.MaNoiDen,
                NoiDi=pHanhTrinh.MaNoiDi
            };
            entity.HANHTRINHs.Add(hanhtrinh);
            entity.SaveChanges();
        }
    }
}
