using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO.DataSetTableAdapters;
using System.Data;
namespace DAO
{
    
    //NHOMNGUOIDUNGTableAdapter pb = new NHOMNGUOIDUNGTableAdapter();
  public  class DAO_QLNV
    {
      NGUOIDUNGTableAdapter nv = new NGUOIDUNGTableAdapter();
      NHOMNGUOIDUNGTableAdapter pb = new NHOMNGUOIDUNGTableAdapter();
      HANHTRINHTableAdapter ht = new HANHTRINHTableAdapter();
      public DataTable LoadDLSV()
      {
          return nv.GetDataByNV();
      }
      public DataTable LoadPhgBan()
      {
          return pb.GetDataByTenNhom();
      }
      public int Insert(string pMaNV, string pTenNV, string MatKhau, DateTime NgaySinh, string GioiTinh, string AnhDaiDien, string DiaChi, string SDT, int TrangThai, string MatKhauCap2, int MaPhgBan)
      {
          return nv.Them(pMaNV, pTenNV, MatKhau, NgaySinh, GioiTinh, AnhDaiDien, DiaChi, SDT, TrangThai, MatKhauCap2, MaPhgBan);
      }
      public int Update(string TenNV, string MatKhau, DateTime NgaySinh, string GioiTinh, string AnhDaiDien, string DiaChi, string SDT, int TrangThai, string MatKhauCap2, int MaPhgBan, string pMaNV)
      {
          return nv.Sua(TenNV,  MatKhau,  NgaySinh,  GioiTinh,  AnhDaiDien,  DiaChi,  SDT,TrangThai, MatKhauCap2,  MaPhgBan,  pMaNV);
      }
      public DataTable KT_KhoaChinh(string pMaNV)
      {
          return nv.KT_PK(pMaNV);
      }
      public int CapNhatTT(string pMaNV)
      {
          return nv.CapNhatTrangThaiNV(pMaNV);
      }
      
    }
}
