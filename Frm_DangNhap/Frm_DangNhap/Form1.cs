using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_DangNhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void ProcessLogin()
        {
            int result;
            result = CauHinh.Check_User(txtUsername.Text, txtPassword.Text);
            //sai tên hoặc pass

            if (result == 0)
            {
                MessageBox.Show("Sai"+""+lblUsername.Text+""+ "Hoặc"+""+lblPassword.Text);
                return;
            }
            //tk bị khóa
            else if(result==1)

            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công");

                FrmMain main = new FrmMain();
                this.Hide();
                main.Show();
            }

        }
        private void btnOK_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Không được bổ trống: " + lblUsername.Text.ToLower());
                this.txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Không được bổ trống: " + lblPassword.Text.ToLower());
                this.txtPassword.Focus();

                return;
            }
            if (CauHinh.Check_Config() == 0)
            {
                ProcessLogin();
            }
            if (CauHinh.Check_Config() == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                FrmFindServer findserver = new FrmFindServer();
                this.Hide();
                findserver.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
