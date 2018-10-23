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

    

        private void OpenForm(object obj)
        {
            Application.Run(new frm_Main());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txt_Username.Text = "";
            txt_MatKhau.Text = "";
            txt_Username.Focus();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            NguoiDungBUS nguoiDungBus = new NguoiDungBUS();
            if (nguoiDungBus.KTraDangNhap(txt_Username.Text, txt_MatKhau.Text))
            {
                Program.Username = txt_Username.Text;
                this.Close();
                th = new Thread(OpenForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }

        }
    }
}
