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
            QuyenNguoiDungBus.PhanQuyenManHinh(this.ribbonMenu, "khadaica");
        }

        private void barBtn_ShowTour_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ShowTour form = new frm_ShowTour();
            form.MdiParent = this;
            form.Show();
        }
    }
}
