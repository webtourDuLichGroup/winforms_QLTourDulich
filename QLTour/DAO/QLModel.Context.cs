﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QlTourDuLichEntities : DbContext
    {
        public QlTourDuLichEntities()
            : base("name=QlTourDuLichEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CTPHIEUNHAP_TOUR> CTPHIEUNHAP_TOUR { get; set; }
        public DbSet<DIADANH> DIADANHs { get; set; }
        public DbSet<DIADIEM> DIADIEMs { get; set; }
        public DbSet<HANHTRINH> HANHTRINHs { get; set; }
        public DbSet<HOPDONG> HOPDONGs { get; set; }
        public DbSet<HUONGDANVIEN> HUONGDANVIENs { get; set; }
        public DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public DbSet<KHACHSAN> KHACHSANs { get; set; }
        public DbSet<LOAIKHACHHANG> LOAIKHACHHANGs { get; set; }
        public DbSet<LOAIKHACHSAN> LOAIKHACHSANs { get; set; }
        public DbSet<LOAITOUR> LOAITOURs { get; set; }
        public DbSet<MANHINH> MANHINHs { get; set; }
        public DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public DbSet<NHOMNGUOIDUNG> NHOMNGUOIDUNGs { get; set; }
        public DbSet<PHANQUYEN> PHANQUYENs { get; set; }
        public DbSet<PHIEUNHAPTOUR> PHIEUNHAPTOURs { get; set; }
        public DbSet<QUANLINHOMNGUOIDUNG> QUANLINHOMNGUOIDUNGs { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TOUR> TOURs { get; set; }
    }
}
