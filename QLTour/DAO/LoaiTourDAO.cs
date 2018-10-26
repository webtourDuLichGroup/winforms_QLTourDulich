using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
  public  class LoaiTourDAO
    {
        QlTourDuLichEntities entity = new QlTourDuLichEntities();

        public List<LoaiTourDTO> LayDSLoaiTour()
        {
            var result = entity.LOAITOURs.Select(t => new LoaiTourDTO() { MaLoaiTour = t.MaLoaiTour, TenLoaiTour = t.TenLoaiTour });
            return result.ToList();
        }
    }
}
