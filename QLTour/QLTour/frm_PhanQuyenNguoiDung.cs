using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using GUI.Constants;

namespace GUI
{
    public partial class frm_PhanQuyenNguoiDung : Form
    {
        BUS_PhanQuyen pq = new BUS_PhanQuyen();

        public frm_PhanQuyenNguoiDung()
        {
            InitializeComponent();
        }

        void LoadDL()
        {
            cboPhgBan.DisplayMember = "TenNhom";
            cboPhgBan.ValueMember = "MaNhom";
            cboPhgBan.DataSource = pq.LoadTenNhom();

        }

        private void frm_PhanQuyenNguoiDung_Load(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            List<string> quyenLst = new List<string>();
            for (int i = 0; i < dgv_windows.RowCount - 1; i++)
            {
                int maNhom = int.Parse(cboPhgBan.SelectedValue.ToString());
                int maMH = int.Parse(dgv_windows.Rows[i].Cells["MaMH"].Value.ToString());

                if (dgv_windows.Rows[i].Cells[1].Value.ToString().Equals("True"))
                {
                    bool quyenChinhSua = dgv_windows.Rows[i].Cells[1].Value.ToString().Equals("True");
                    if (!pq.KiemTraQuyenND(maNhom, maMH))
                    {
                        try
                        {
                            pq.Them_PQ(maNhom, maMH, true);
                            //MessageBox.Show(MessageBoxConstants.CHINHSUATHANHCONG);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(MessageBoxConstants.LOITHAOTAC, MessageBoxConstants.LOIDULIEU);
                        }
                    }
                }
                else
                {
                    if (pq.KiemTraQuyenND(maNhom, maMH))
                    {
                        try
                        {
                            pq.Xoa_PQ(maNhom, maMH);
                           // MessageBox.Show(MessageBoxConstants.CHINHSUATHANHCONG);
                        }
                        catch (Exception)
                        {

                            MessageBox.Show(MessageBoxConstants.LOITHAOTAC, MessageBoxConstants.LOIDULIEU);
                        }
                    }
                }
                
            }
            MessageBox.Show("Cập nhật quyền thành công!");
        }

        private void cboPhgBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maphg = int.Parse(cboPhgBan.SelectedValue.ToString());
            dgrPB.DataSource = pq.LoadDSPB(maphg);

            dgv_windows.DataSource = pq.LoadPQ(maphg);
        }
    }
}
