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
using DTO;
using DevExpress.XtraBars.Ribbon;

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
            QuyenNguoiDungBus quyenNguoiDungBus = new QuyenNguoiDungBus();
            List<QuyenDTO> quyenNhomNguoiDungLst = quyenNguoiDungBus.LayQuyenNguoiDung(Program.Username);
            if (quyenNhomNguoiDungLst.Count > 0)
            {
                foreach (RibbonPage page in ribbonMenu.Pages)
                {
                    QuyenDTO quyen = quyenNhomNguoiDungLst.FirstOrDefault(t => (t.MaMH == int.Parse(page.Tag.ToString()) && t.CoQuyen == true));
                    bool hienThi = quyen != null;
                    page.Visible = hienThi;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Không thể truy cập", "Bạn không có một quyền nào được thực hiện trong ứng dụng này.", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.OK)
                {
                    //
                }
            }
        }

        private void barBtn_QLTourDuLich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_QLTour form = new frm_QLTour();
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
            frm_QLHuongDanVien form = new frm_QLHuongDanVien();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_QLNhanVien form = new frm_QLNhanVien();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Tour form = new frm_Tour();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_QLKhachHang form = new frm_QLKhachHang();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Tour form = new frm_Tour();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_PhanQuyenNguoiDung form = new frm_PhanQuyenNguoiDung();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frm_HDong form = new frm_HDong();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_DangNhap dn = new frm_DangNhap();
            dn.Show();
            
            
        }
    }
}
