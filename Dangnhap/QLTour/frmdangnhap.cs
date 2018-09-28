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
using QLTOUR;

namespace QLTour
{
    public partial class frmdangnhap : Form
    {
        Thread th;
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string tendn = txt_tendn.Text;
            string matkhau = txt_matkhau.Text;

            if (BUS.Thu.dangnhap(tendn,matkhau)==1)
            {
                this.Close();
                th = new Thread(openform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }

        }

        private void openform(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
