﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class HuongDanVienBUS
    {
        public List<HuongDanVienDTO>  LoadHuongDanVienToCombobox()
        {
            return new HuongDanVienDAO().LayDSHuongDanVien();
        }
    }
}
