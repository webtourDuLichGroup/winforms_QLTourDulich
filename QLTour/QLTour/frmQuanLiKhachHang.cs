using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLTour
{
    public partial class frmQuanLiKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLiKhachHang()
        {
            InitializeComponent();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlTourDuLichDataSet);

        }

        private void frmQuanLiKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlTourDuLichDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qlTourDuLichDataSet.KHACHHANG);

        }
    }
}