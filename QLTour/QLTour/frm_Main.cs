using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
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
            QuyenNguoiDungBus.A();
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
            frm_KhachSan form = new frm_KhachSan();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_LoaiKhachSan form = new frm_LoaiKhachSan();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_DatTour form = new frm_DatTour();
            form.MdiParent = this;
            form.Show();
        }
    }
}
