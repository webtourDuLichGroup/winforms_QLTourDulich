using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using System.Threading;
using GUI;

namespace GUI
{
    public partial class frm_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        Thread th;
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            //string tendn = txtMK.Text;
            //string matkhau = txt_matkhau.Text;

            //if (BUS.DangNhapBus.DangNhap(tendn,matkhau))
            //{
            //    this.Close();
            //    th = new Thread(OpenForm);
            //    th.SetApartmentState(ApartmentState.STA);
            //    th.Start();
            //}
            //else
            //{
            //    MessageBox.Show("Đăng nhập thất bại");
            //}

        }

        private void OpenForm(object obj)
        {
            Application.Run(new frm_Main());
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
