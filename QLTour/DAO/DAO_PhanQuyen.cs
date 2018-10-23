using DAO.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
   public class DAO_PhanQuyen
    {
       NHOMNGUOIDUNGTableAdapter nhom = new NHOMNGUOIDUNGTableAdapter();
       QUANLINHOMNGUOIDUNGTableAdapter phgban=new QUANLINHOMNGUOIDUNGTableAdapter();
       PHANQUYENTableAdapter pq = new PHANQUYENTableAdapter();
       
       public DataTable LoadTenPhgBan()
       {
           return nhom.GetDataByTenNhom();
       }
       public DataTable LoadDSPB(int pMaPhg)
       {
           return phgban.LoadDSPB(pMaPhg);
       }
       public DataTable LoadDSPQ(int pMaPhg)
       {
           return pq.GetData(pMaPhg);
       }
       public DataTable LoadPQ()
       {
           return pq.LoadPQ();
       }
       public int Them_PQ(int MaNhom, int MaMH, bool CoQuyen)
       {
           return pq.Them_PhanQuyen(MaNhom, MaMH, CoQuyen);
       }
       public int Xoa_PQ(int MaNhom, int MaMH)
       {
           return pq.XoaPQ(MaNhom, MaMH);
       }
       //public int Xoa_PQ(int pMaNV,int pMaMH)
       //{
       //    return pq.XoaPQ(pMaNV, pMaMH);
       //}
       //public DataTable LoadPQ()
       //{
       //    return pq.LoadPQ();
       //}
      

      
       
    }
}
