using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
<<<<<<< HEAD
using BUS;
=======

>>>>>>> master
namespace GUI
{
    public partial class frm_QuanLiNhanVien : DevExpress.XtraEditors.XtraForm
    {
        BUS_QLNV nv = new BUS_QLNV();
        int trangthaibtnSave = 0;
        public frm_QuanLiNhanVien()
        {
            InitializeComponent();
        }
        int b;
        public void TrangThai(bool b)
        {

            btnSave.Enabled = btnCancel.Enabled = b;
            groupControl1.Enabled = b;
        }
        public void loadGrid()
        {
            DataTable tb = new DataTable();
            tb = nv.LoadDLNV();
            dataGridView1.DataSource = tb;
        }
        
        private void frm_QuanLiNhanVien_Load(object sender, EventArgs e)
        {
            loadGrid();
            cboPhgBan.DataSource = nv.LoadPhongBan();
            cboPhgBan.DisplayMember = "TenNhom";
            cboPhgBan.ValueMember = "MaNhom";
            TrangThai(false);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    txtShowMaNV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtMK1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    dtNgSinh.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                    if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Nam")
                        radNam.Checked = true;
                    else
                        radNu.Checked = true;
                    picAnhDaiDien.ImageLocation = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    txtDC.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    txtSDT.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    txtMK2.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    cboPhgBan.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }
        public void ClearTextBox()
        {
            txtShowMaNV.Text = txtTen.Text = txtShowMaNV.Text = txtSDT.Text = txtDC.Text = string.Empty;
            dtNgSinh.Text = string.Empty;
            picAnhDaiDien.ImageLocation = string.Empty;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            TrangThai(true);
            ClearTextBox();
            trangthaibtnSave = 1;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtMK1.Enabled = false;
            txtMK2.Enabled = false;
        }
        private int DanhSoTT()
        {
            int MaxMa = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                int so = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                if (MaxMa < so)
                    MaxMa = so;
            }
            return MaxMa + 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = DanhSoTT().ToString();
                //string manvupdate=show
                string tennv = txtTen.Text;
                string mk1 = txtMK1.Text;
                DateTime ngsinh = dtNgSinh.Value;
                string gt = "Nữ";
                string anhdaidien = picAnhDaiDien.ImageLocation;
                string dc = txtDC.Text;
                string sdt = txtSDT.Text;
                int tt = 1; //Mặc định là 1 (nhân viên đang hoạt động)
                string mk2 = txtMK2.Text;
                int maphg = int.Parse(cboPhgBan.SelectedValue.ToString());
                //string s = txtSDT.Text.Substring(0, 1);
                if (trangthaibtnSave == 1)
                {
                    if ((tennv == string.Empty) || (dc == string.Empty) || (sdt == string.Empty))
                    {
                        MessageBox.Show("Dữ liệu chưa đầy đủ");
                        if (tennv == "")
                            txtTen.Focus();
                        else if (dc == "")
                            txtDC.Focus();
                        else if (sdt == "")
                            txtSDT.Focus();
                    }

                    else if ((txtSDT.Text.Trim().Length > 11 || txtSDT.Text.Trim().Length < 10))
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSDT.Focus();
                    }
                    else if ((DateTime.Now.Year - dtNgSinh.Value.Year) < 18)
                    {
                        MessageBox.Show("Ngày tháng năm sinh không hợp lệ. Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dtNgSinh.Focus();
                    }
                    else
                        if (radNam.Checked == true)
                        {
                            gt = "Nam";

                        }
                        else
                        {
                            int them = nv.ThemNV(manv, tennv, mk1, ngsinh, gt, anhdaidien, dc, sdt, tt, mk2, maphg);

                            MessageBox.Show("Thêm thành công");
                            loadGrid();
                            TrangThai(false);
                            btnInsert.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
                        }
                }
                else
                {
                    DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    int sua = nv.Update(tennv, mk1, ngsinh, gt, anhdaidien, dc, sdt, tt, mk2, maphg, txtShowMaNV.Text);
                    MessageBox.Show("Sửa thành công");
                    loadGrid();
                    TrangThai(false);
                    btnInsert.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;

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
            TrangThai(true);
            btnInsert.Enabled = false;
            trangthaibtnSave = 2;
            txtMK1.Enabled = txtMK2.Enabled = false;
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                nv.CapNhatTT(txtShowMaNV.Text);
                MessageBox.Show("Da xoa thanh cong");
                loadGrid();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}