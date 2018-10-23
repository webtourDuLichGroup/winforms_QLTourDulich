using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BUS
{
    public class DiaDiemBUS
    {
        public DataTable LoadDiaDiem()
        {
            return new DiaDiemDAO().LayDiaDiem();
        }

        public List<DiaDiemDTO> LoadDiemDen(int? idNoiDi)
        {
            return new DiaDiemDAO().TimDiemDen(idNoiDi);
        }
    }
}
