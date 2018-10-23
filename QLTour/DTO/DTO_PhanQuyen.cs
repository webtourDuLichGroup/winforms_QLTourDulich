using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public class DTO_PhanQuyen
    {
        private int _MaNhom;

        public int MaNhom
        {
            get { return _MaNhom; }
            set { _MaNhom = value; }
        }
        private string _TenNhom;

        public string TenNhom
        {
            get { return _TenNhom; }
            set { _TenNhom = value; }
        }
        private string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
        private string _MaNhomNgDung;

        public string MaNhomNgDung
        {
            get { return _MaNhomNgDung; }
            set { _MaNhomNgDung = value; }
        }

    }
}
