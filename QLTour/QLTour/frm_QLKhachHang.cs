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
    public partial class frm_QLKhachHang : Form
    {
        BUS_QLKH kh = new BUS_QLKH();

        public frm_QLKhachHang()
        {
            InitializeComponent();
        }
        public void ClearTextBox()
        {
            txtShowMaNV.Text = txtTen.Text = txtShowMaNV.Text = txtSDT.Text = txtDC.Text = string.Empty;
            dtNgSinh.Text = string.Empty;

        }

        public void TrangThai(bool b)
        {

            btnSave.Enabled = btnCancel.Enabled = b;
            groupControl1.Enabled = b;
        }


        private void frm_QLKhachHang_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = kh.LoadKH();
            cboLoaiKH.DataSource = kh.LoadTenLoai();
            cboLoaiKH.DisplayMember = "TenLoaiKH";
            cboLoaiKH.ValueMember = "MaLoaiKH";
            TrangThai(false);
        }

        int trangthaibtnSave = 0;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            TrangThai(true);
            ClearTextBox();
            trangthaibtnSave = 1;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TrangThai(true);
            btnInsert.Enabled = false;
            trangthaibtnSave = 2;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {

                MessageBox.Show("Da xoa thanh cong");

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string makh = new Random().Next(0, 100000).ToString();
            //string manvupdate=show
            string tennv = txtTen.Text;
            string email = txtEmail.Text;
            DateTime ngsinh = dtNgSinh.Value;
            int gt = 1; //nữ
            string dc = txtDC.Text;
            string sdt = txtSDT.Text;
            string maloaikh = cboLoaiKH.SelectedValue.ToString();
            string tendn = txtTenDN.Text;
            if (trangthaibtnSave == 1)
            {
                //if ((tennv == string.Empty) || (dc == string.Empty) || (sdt == string.Empty) || (email == string.Empty) || (tendn == string.Empty))
                //{
                //    MessageBox.Show("Dữ liệu chưa đầy đủ");
                //    if (tennv == "")
                //        txtTen.Focus();
                //    else if (dc == "")
                //        txtDC.Focus();
                //    else if (sdt == "")
                //        txtSDT.Focus();
                //}

                //else if ((txtSDT.Text.Trim().Length > 11 || txtSDT.Text.Trim().Length < 10))
                //{
                //    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtSDT.Focus();
                //}
                //else if ((DateTime.Now.Year - dtNgSinh.Value.Year) < 18)
                //{
                //    MessageBox.Show("Ngày tháng năm sinh không hợp lệ. Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    dtNgSinh.Focus();
                //}
                //else
                if (radNam.Checked == true)
                {
                    gt = 0;

                }
                else
                {
                    int them = kh.ThemKH(makh, tennv, ngsinh, gt, email, sdt, dc, maloaikh, tendn);
                    MessageBox.Show("Thêm thành công");
                    dgvKH.DataSource = kh.LoadKH();
                    TrangThai(false);
                    btnInsert.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
                }
            }
            else
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                int sua = kh.SuaKH(txtShowMaNV.Text, tennv, ngsinh, gt, email, sdt, dc, maloaikh, tendn, txtShowMaNV.Text);
                MessageBox.Show("Sửa thành công");
                dgvKH.DataSource = kh.LoadKH();
                TrangThai(false);
                btnInsert.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;

            }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvKH_SelectionChanged(object sender, EventArgs e)
        {
            //try
            {
                if (dgvKH.CurrentRow != null)
                {
                    txtShowMaNV.Text = dgvKH.CurrentRow.Cells["MaKH"].Value.ToString();
                    txtTen.Text = dgvKH.CurrentRow.Cells["TenKH"].Value.ToString();
                    dtNgSinh.Text = dgvKH.CurrentRow.Cells["NgSinh"].Value.ToString();

                    if (int.Parse(dgvKH.CurrentRow.Cells["GioiTinh"].Value.ToString()) == 0)
                        radNam.Checked = true;
                    else
                        radNu.Checked = true;

                    txtEmail.Text = dgvKH.CurrentRow.Cells["Email"].Value.ToString();
                    txtSDT.Text = dgvKH.CurrentRow.Cells["SDTKH"].Value.ToString();
                    txtDC.Text = dgvKH.CurrentRow.Cells["DCKH"].Value.ToString();
                    cboLoaiKH.Text = dgvKH.CurrentRow.Cells["MaLoaiKH"].Value.ToString();
                    txtTenDN.Text = dgvKH.CurrentRow.Cells["TenDoanhNghiep"].Value.ToString();
                }
            }
            //catch (Exception)
            //{

            //    throw;
            //}

        }
    }
}
