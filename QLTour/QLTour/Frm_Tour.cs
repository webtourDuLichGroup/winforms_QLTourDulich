using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DTO;
using GUI.Constants;

namespace GUI
{
    public partial class frm_Tour :Form
    {
        public static TourDuocChonDTO BookedTour;
        public frm_Tour()
        {
            InitializeComponent();
            BookedTour = new TourDuocChonDTO();
        }

        private void LoaData()
        {
            TourBUS tourBus = new TourBUS();
            dgv_Tour.DataSource = tourBus.LoadTourToDataGridView();
            DataTable diaDiem = tourBus.LoadDiaDiem();
            cbo_NoiDi.DisplayMember = "TenDiaDiem";
            cbo_NoiDi.ValueMember = "MaDiaDiem";
            cbo_NoiDi.DataSource = diaDiem;

            cbo_NoiDen.DisplayMember = "TenDiaDiem";
            cbo_NoiDen.ValueMember = "MaDiaDiem";
            cbo_NoiDen.DataSource = tourBus.LoadDiemDen(int.Parse(cbo_NoiDi.SelectedValue.ToString()));

        }

        private void frm_Tour_Load(object sender, EventArgs e)
        {
            LoaData();
        }

        private void cbo_NoiDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            TourBUS tourBus = new TourBUS();
            cbo_NoiDen.DataSource = tourBus.LoadDiemDen(int.Parse(cbo_NoiDi.SelectedValue.ToString()));
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_NguoiLon.Text))
            {
                errorProvider1.SetError(txt_NguoiLon, MessageBoxConstants.EMPTY);
            }
            if (String.IsNullOrEmpty(txt_TreEm.Text))
            {
                errorProvider2.SetError(txt_NguoiLon, MessageBoxConstants.EMPTY);
            }
            TourBUS tourBus = new TourBUS();
            dgv_Tour.DataSource = tourBus.TimTour(dateEdit_NgayDi.DateTime.Date, int.Parse(cbo_NoiDi.SelectedValue.ToString()), int.Parse(cbo_NoiDen.SelectedValue.ToString()));

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_NguoiLon.Text) || String.IsNullOrEmpty(txt_TreEm.Text))
            {
                MessageBox.Show(MessageBoxConstants.THIEUTHONGTIN);
            }
            else
            {
                DXMouseEventArgs ea = e as DXMouseEventArgs;
                GridView view = sender as GridView;
                GridHitInfo info = view.CalcHitInfo(ea.Location);
                TourDTO tour = (TourDTO)info.RowInfo.RowKey;
                BookedTour.MaTour = tour.MaTour;
                BookedTour.NguoiLon = int.Parse(txt_NguoiLon.Text);
                BookedTour.TreEm = int.Parse(txt_TreEm.Text);
                BookedTour.GiaNguoiLon = tour.GiaNguoiLon;
                BookedTour.GiaTreEm = tour.GiaTreEm;
                BookedTour.TongTien = BookedTour.NguoiLon * BookedTour.GiaNguoiLon + BookedTour.TreEm * BookedTour.GiaTreEm;
                frm_DatTour form = new frm_DatTour();
                form.ShowDialog(this);
            }

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            TourBUS tourBus = new TourBUS();
            dgv_Tour.DataSource = tourBus.LoadTourToDataGridView();
        }
    }
}
