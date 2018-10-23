using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    
  public  class BUS_QLNV
    {
      DAO_QLNV nv = new DAO_QLNV();
      public DataTable LoadDLNV()
      {
          return nv.LoadDLSV();
      }
      public DataTable LoadPhongBan()
      {
          return nv.LoadPhgBan();
      }
      public int ThemNV(string pMaNV, string pTenNV, string MatKhau, DateTime NgaySinh, string GioiTinh, string AnhDaiDien, string DiaChi, string SDT, int TrangThai, string MatKhauCap2, int MaPhgBan)
      {
          return nv.Insert(pMaNV, pTenNV, MatKhau, NgaySinh, GioiTinh, AnhDaiDien, DiaChi, SDT, TrangThai, MatKhauCap2, MaPhgBan);
      }
      public int Update(string TenNV, string MatKhau, DateTime NgaySinh, string GioiTinh, string AnhDaiDien, string DiaChi, string SDT, int TrangThai, string MatKhauCap2, int MaPhgBan, string pMaNV)
      { 
          return nv.Update(TenNV, MatKhau, NgaySinh, GioiTinh, AnhDaiDien, DiaChi, SDT, TrangThai, MatKhauCap2, MaPhgBan, pMaNV);
      }
      public DataTable KT_KC(string pMaNV)
      {
          return KT_KC(pMaNV);
      }
      public int CapNhatTT(string pMaNV)
      {
          return nv.CapNhatTT(pMaNV);
      }
    }
}
