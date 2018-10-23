using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using GUI;
namespace GUI
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            //QuyenNguoiDungBus.PhanQuyenManHinh(this.ribbonMenu, "khadaica");
        }

        private void barBtn_QLTourDuLich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Tour form = new frm_Tour();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhMucDichVu form = new frmDanhMucDichVu();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLiHuongDanVien form = new frmQuanLiHuongDanVien();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           //frm_QuanLiNhanVien 
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Tour form = new frm_Tour();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLiKhachHang form = new frmQuanLiKhachHang();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_PhanQuyen form = new frm_PhanQuyen();
            form.MdiParent = this;
            form.Show();
        }
    }
}
