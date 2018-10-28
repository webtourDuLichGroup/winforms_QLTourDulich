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
    public partial class frm_QLHuongDanVien : Form
    {
        BUS_QLHDV hdv = new BUS_QLHDV();
        int trangthaibtnSave = 0;
        public frm_QLHuongDanVien()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            trangthaibtnSave = 1;
            TrangThai(true);
            btnEdit.Enabled = btnDelete.Enabled = false;
            cleartxt();
        }
        private void LoadHDV()
        {
            DataTable tb = new DataTable();
            tb = hdv.LoadHDV();
            dgrHDV.DataSource = tb;
            TrangThai(false);
        }

        public void TrangThai(bool b)
        {
            groupControl4.Enabled = b;
            btnSave.Enabled = btnCancel.Enabled = b;

        }

        public void cleartxt()
        {
            txtTenHDV.Text = txtSDT.Text = txtDC.Text = dtNgSinh.Text = picAnhDaiDien.ImageLocation = txtGhiChu.Text = txtNN.Text = dtNgVaoLam.Text = lblShowMaHDV.Text = string.Empty;
        }

        private void frm_QLHuongDanVien_Load(object sender, EventArgs e)
        {
            LoadHDV();
        }

        private void dgrHDV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgrHDV.CurrentRow != null)
                {
                    lblShowMaHDV.Text = dgrHDV.CurrentRow.Cells[0].Value.ToString();
                    txtTenHDV.Text = dgrHDV.CurrentRow.Cells[1].Value.ToString();
                    txtSDT.Text = dgrHDV.CurrentRow.Cells[2].Value.ToString();
                    txtDC.Text = dgrHDV.CurrentRow.Cells[3].Value.ToString();
                    dtNgSinh.Text = dgrHDV.CurrentRow.Cells[4].Value.ToString();
                    if (dgrHDV.CurrentRow.Cells[5].Value.ToString() == "Nam")
                        radNamHDV.Checked = true;
                    else
                        radNuHDV.Checked = true;
                    picAnhDaiDien.ImageLocation = dgrHDV.CurrentRow.Cells[6].Value.ToString();
                    txtGhiChu.Text = dgrHDV.CurrentRow.Cells[8].Value.ToString();
                    dtNgVaoLam.Text = dgrHDV.CurrentRow.Cells[9].Value.ToString();
                    txtNN.Text = dgrHDV.CurrentRow.Cells[10].Value.ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void picAnhDaiDien_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png";
            dialog.Title = "Chọn ảnh nhân viên";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picAnhDaiDien.ImageLocation = dialog.FileName;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            trangthaibtnSave = 2;
            TrangThai(true);
            btnInsert.Enabled = btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {

                    hdv.DeleteHDV(int.Parse(lblShowMaHDV.Text));
                    MessageBox.Show("Da xoa thanh cong");
                    LoadHDV();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadHDV();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string TenHDV = txtTenHDV.Text;
                string SDT = txtSDT.Text;
                string DC = txtDC.Text;
                DateTime NgSinh = dtNgSinh.Value;
                string gt = "Nữ";
                string anh = picAnhDaiDien.ImageLocation;
                int tt = 1;//trạng thái =1 khi còn làm
                string ghichu = txtGhiChu.Text;
                DateTime ngvaolam = dtNgVaoLam.Value;
                string ngonngu = txtNN.Text;
                if (radNamHDV.Checked == true)
                {
                    gt = "Nam";


                }
                if (trangthaibtnSave == 1)
                {
                    if ((TenHDV == string.Empty) || (DC == string.Empty) || (SDT == string.Empty) || (ngonngu == string.Empty))
                    {
                        MessageBox.Show("Dữ liệu chưa đầy đủ");
                        if (TenHDV == "")
                            txtTenHDV.Focus();
                        else if (DC == "")
                            txtDC.Focus();
                        else if (SDT == "")
                            txtSDT.Focus();
                        else if ((txtSDT.Text.Trim().Length > 11 || txtSDT.Text.Trim().Length < 10))
                        {
                            MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSDT.Focus();
                        }
                        //else if ((DateTime.Now.Year - dtNgSinh.Value.Year) < 18)
                        //{
                        //    MessageBox.Show("Ngày tháng năm sinh không hợp lệ. Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    dtNgSinh.Focus();
                        //}
                    }
                    else
                    {

                        int them = hdv.InsertHDV(TenHDV, SDT, DC, NgSinh, gt, anh, tt, ghichu, ngvaolam, ngonngu);
                        MessageBox.Show("Thêm thành công");
                        TrangThai(true);
                        btnEdit.Enabled = btnDelete.Enabled = true;
                        cleartxt();
                        LoadHDV();
                    }


                    
                }
                else
                {
                    DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thay đổi thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        int sua = hdv.EditHDV(TenHDV, SDT, DC, NgSinh, gt, anh, tt, ghichu, ngvaolam, ngonngu, int.Parse(lblShowMaHDV.Text));
                        MessageBox.Show("Sửa thành công");
                        LoadHDV();
                        btnInsert.Enabled = btnDelete.Enabled = true;

                    }
                }
            }

            catch (Exception)
            {

                throw;
            }
        }

        private void txtTenHDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            Control ctr = (Control)sender;
            if ((Char.IsDigit(e.KeyChar)) && (!Char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
                error.SetError(ctr, "Chỉ được chữ và không có ký tự đặc biệt");
            }
            else
            {
                error.Clear();
            }
        }
    }
}
