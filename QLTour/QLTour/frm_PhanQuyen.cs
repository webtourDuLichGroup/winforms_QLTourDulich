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
    public partial class frm_PhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        BUS_PhanQuyen pq = new BUS_PhanQuyen();
        public frm_PhanQuyen()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imageSlider1_Click(object sender, EventArgs e)
        {

        }

        private void colorPickEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grCT_Paint(object sender, PaintEventArgs e)
        {

        }
        void LoadDL()
        {
            cboPhgBan.DataSource = pq.LoadTenNhom();
            cboPhgBan.DisplayMember = "TenNhom";
            cboPhgBan.ValueMember = "MaNhom";


        }
        private void frm_PhanQuyen_Load(object sender, EventArgs e)
        {
            LoadDL();
            //dgrPQ.DataSource = pq.LoadChucNangPQ(int.Parse(cboPhgBan.SelectedValue.ToString()));


        }

        private void cboPhgBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboPhgBan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int maphg = int.Parse(cboPhgBan.SelectedValue.ToString());
            dgrPB.DataSource = pq.LoadDSPB(maphg);
            dgrPQ.DataSource = pq.LoadPQ(maphg);
            



        }
        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grPhgNS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void On_qltour_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void On_qltour_Click(object sender, EventArgs e)
        {
            //On_qltour.Visible = false;
            //Off_qltour.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            //    else
            //    {
            //        int del = pq.Xoa_PQ(manhom, mamh);

            //    }
            //    MessageBox.Show("Cập nhật quyền thành công");
            //    LoadDL();
            //    pq.LoadPQ(int.Parse(cboPhgBan.SelectedValue.ToString()));
            //}

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                bool coquyen;
                int manhom = int.Parse(cboPhgBan.SelectedValue.ToString());
                int mamh = int.Parse(gridView3.GetFocusedRowCellValue("MaMH").ToString());
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (r == DialogResult.Yes)
                {
                    if (CoQuyen.Checked == true)
                    {
                        //for(int i=0;i<gridView3.RowCount-1;i++)
                        //{
                        //if (gridView3.GetRowCellValue(i,"CoQuyen").ToString())
                        coquyen = true;
                        int them = pq.Them_PQ(manhom, mamh, coquyen);
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        coquyen = false;
                        int xoa = pq.Xoa_PQ(manhom, mamh);
                        MessageBox.Show("Thiết lập quyền thành công");

                    }
                    LoadDL();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
