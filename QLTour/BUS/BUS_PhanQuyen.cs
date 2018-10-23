using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
   public class BUS_PhanQuyen
    {
       DAO_PhanQuyen pq = new DAO_PhanQuyen();
       public DataTable LoadTenNhom()
       {
           return pq.LoadTenPhgBan();
       }
       public DataTable LoadDSPB(int pMaPB)
       {
           return pq.LoadDSPB(pMaPB);
       }

       public DataTable LoadPQ(int pMaPB)
       {
           return pq.LoadDSPQ(pMaPB);
       }
       public int Them_PQ(int MaNhom, int MaMH, bool CoQuyen)
       {
           return pq.Them_PQ(MaNhom, MaMH, CoQuyen);
       }
       public DataTable LoadDMPQ()
       {
           return pq.LoadPQ();
       }
       public int Xoa_PQ(int MaNhom, int MaMH)
       {
           return pq.Xoa_PQ(MaNhom, MaMH);
       }
       //public int Xoa_PQ(int manv,int mamh)
       //{
       //    return pq.Xoa_PQ(manv, mamh);
       //}
       //public DataTable LoadPQ()
       //{
       //    return pq.LoadPQ();
       //}
    }
}
