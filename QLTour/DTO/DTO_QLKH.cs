using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
  public  class DTO_QLKH
    {
        private string _TenKH;

        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; }
        }
        private DateTime _ngsinh;

        public DateTime Ngsinh
        {
            get { return _ngsinh; }
            set { _ngsinh = value; }
        }
        private int _gt;

        public int Gt
        {
            get { return _gt; }
            set { _gt = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _sdt;

        public string Sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        private string _dc;

        public string Dc
        {
            get { return _dc; }
            set { _dc = value; }
        }
        private string _maloaikh;

        public string Maloaikh
        {
            get { return _maloaikh; }
            set { _maloaikh = value; }
        }
        private string _tendoanhnghiep;

        public string Tendoanhnghiep
        {
            get { return _tendoanhnghiep; }
            set { _tendoanhnghiep = value; }
        }
    }
}
