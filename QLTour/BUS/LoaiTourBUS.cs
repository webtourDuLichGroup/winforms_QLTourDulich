﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class LoaiTourBUS
    {
        public List<LoaiTourDTO> LoadLoaiTourToCombobox()
        {
            return new LoaiTourDAO().LayDSLoaiTour();
        }
    }
}
