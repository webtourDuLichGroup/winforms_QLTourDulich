using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public class DTO_QLNV
    {
        private int _MaNV;
        private string _TenNV;
        private string _MK;

        private string _NgSinh;
        private string _GT;
        private string _AnhDaiDien;
        private string _DC;
        private string _SDT;
        private int _TrangThai;
        private string _MK2;
        private string _TenPhgBan;
        private string _MaPhgBan;

        public string MaPhgBan
        {
            get { return _MaPhgBan; }
            set { _MaPhgBan = value; }
        }
        public string TenPhgBan
        {
            get { return _TenPhgBan; }
            set { _TenPhgBan = value; }
        }
        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        public string TenNV
        {
            get { return _TenNV; }
            set { _TenNV = value; }
        }

        public string MK
        {
            get { return _MK; }
            set { _MK = value; }
        }

        public string NgSinh
        {
            get { return _NgSinh; }
            set { _NgSinh = value; }
        }

        public string GT
        {
            get { return _GT; }
            set { _GT = value; }
        }

        public string AnhDaiDien
        {
            get { return _AnhDaiDien; }
            set { _AnhDaiDien = value; }
        }

        public string DC
        {
            get { return _DC; }
            set { _DC = value; }
        }

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        public int TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        public string MK2
        {
            get { return _MK2; }
            set { _MK2 = value; }
        }
        
    }
}
