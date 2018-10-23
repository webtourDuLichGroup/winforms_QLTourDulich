using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class HanhTrinhBUS
    {
        public bool KiemTraHanhTrinhCoSan(int maNoiDi, int maNoiDen)
        {
            return new HanhTrinhDAO().TimHanhTrinh(maNoiDi, maNoiDen) != null;
        }

        public HanhTrinhDTO TimHanhTrinh(int maNoiDi, int maNoiDen)
        {
            HANHTRINH hanhTrinh= new HanhTrinhDAO().TimHanhTrinh(maNoiDi, maNoiDen);
            return new HanhTrinhDTO()
            {
                MaHanhTrinh = hanhTrinh.MaHanhTrinh,
                MaNoiDen = hanhTrinh.NoiDen,
                MaNoiDi = hanhTrinh.NoiDi
            };
        }

        public void ThemHanhTrinhMoi(HanhTrinhDTO hanhTrinhDto)
        {
            new HanhTrinhDAO().ThemhanhTrinhMoi(hanhTrinhDto);
        }
    }
}
