using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAO;
using DAO.DataSet1TableAdapters;
using DTO;
namespace DAO
{
    public class DiaDiemDAO
    {
        QlTourDuLichEntities entities = new QlTourDuLichEntities();
        DIADIEMTableAdapter diaDiemAdapter = new DIADIEMTableAdapter();
        public DataTable LayDiaDiem()
        {
            return diaDiemAdapter.GetData();
        }

        public List<DiaDiemDTO> TimDiemDen(int? MaDiemDi)
        {
            var result = (from ht in entities.HANHTRINHs
                          join dd in entities.DIADIEMs
                          on ht.NoiDen equals dd.MaDiaDiem
                          where ht.NoiDi == MaDiemDi
                          select new DiaDiemDTO()
                          {
                              MaDiaDiem = dd.MaDiaDiem,
                              TenDiaDiem = dd.TenDiaDiem
                          });
            return result.ToList<DiaDiemDTO>();
        }
    }
}
