using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public class DTO_QLHDV
    {
        private int _MaHDV;
        private string _TenHDV;
        private string _SDT;
        private string _NgonNgu;
        private string _DCHDV;
        private DateTime _NgSinhHDV;
        private string _GTHDV;
        private string _AnhDaiDienHDV;
        private int _TrangThai;
        private string _GhiChu;
        private DateTime _NgVaoLam;
        public int MaHDV
        {
            get { return _MaHDV; }
            set { _MaHDV = value; }
        }
        

        public string TenHDV
        {
            get { return _TenHDV; }
            set { _TenHDV = value; }
        }
        

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        

        public string DCHDV
        {
            get { return _DCHDV; }
            set { _DCHDV = value; }
        }
        

        public DateTime NgSinhHDV
        {
            get { return _NgSinhHDV; }
            set { _NgSinhHDV = value; }
        }
        

        public string GTHDV
        {
            get { return _GTHDV; }
            set { _GTHDV = value; }
        }
        

        public string AnhDaiDienHDV
        {
            get { return _AnhDaiDienHDV; }
            set { _AnhDaiDienHDV = value; }
        }
       

        public int TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
        

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
        

        public DateTime NgVaoLam
        {
            get { return _NgVaoLam; }
            set { _NgVaoLam = value; }
        }
        

        public string NgonNgu
        {
            get { return _NgonNgu; }
            set { _NgonNgu = value; }
        }
    }
}
