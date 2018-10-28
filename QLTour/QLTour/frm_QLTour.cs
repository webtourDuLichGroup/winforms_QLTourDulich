using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
using GUI.Constants;

namespace GUI
{
    public partial class frm_QLTour : Form
    {
        private int Onclicked;
        public frm_QLTour()
        {
            InitializeComponent();
        }

        private void frm_QLTour_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            LoaiTourBUS loaiTourBus = new LoaiTourBUS();
            cbo_LoaiTour.DisplayMember = "TenLoaiTour";
            cbo_LoaiTour.ValueMember = "MaLoaiTour";
            cbo_LoaiTour.DataSource = loaiTourBus.LoadLoaiTourToCombobox();
            DiaDiemBUS diaDiemBus = new DiaDiemBUS();
            DataTable table = diaDiemBus.LoadDiaDiem();
            cbo_NoiDen.DisplayMember = "TenDiaDiem";
            cbo_NoiDen.ValueMember = "MaDiaDiem";
            cbo_NoiDen.DataSource = table;
            cbo_NoiDi.DisplayMember = "TenDiaDiem";
            cbo_NoiDi.ValueMember = "MaDiaDiem";
            cbo_NoiDi.DataSource = diaDiemBus.LoadDiaDiem();
            HuongDanVienBUS huongDanVienBus = new HuongDanVienBUS();
            cbo_HuongDanVien.ValueMember = "MaHDV";
            cbo_HuongDanVien.DisplayMember = "TenHDV";
            cbo_HuongDanVien.DataSource = huongDanVienBus.LoadHuongDanVienToCombobox();
            KhachSanBUS khachSanBus = new KhachSanBUS();
            cbo_KhachSan.DisplayMember = "TenKS";
            cbo_KhachSan.ValueMember = "MaKS";
            cbo_KhachSan.DataSource = khachSanBus.LoadKhachSan();
            TourBUS tourBus = new TourBUS();
            gridControl_Tour.DataSource = tourBus.LoadTourToDataGridView();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Onclicked = 1;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            XoaDuLieuCu();
        }

        private bool ThongBaoLoi()
        {
            bool error = false;
            if (String.IsNullOrEmpty(txt_GiaNguoiLon.Text))
            {
                error = true;
                errorProvider_GiaNguoiLon.SetError(txt_GiaNguoiLon, ErrorProviderConstants.EMPTY);
            }
            if (string.IsNullOrEmpty(txt_GiaTreEm.Text))
            {
                error = true;
                errorProvider_GiaTreEm.SetError(txt_GiaTreEm, ErrorProviderConstants.EMPTY);
            }
            if (string.IsNullOrEmpty(txt_TenTour.Text))
            {
                error = true;
                errorProvider_TenTour.SetError(txt_TenTour, ErrorProviderConstants.EMPTY);
            }
            return error;
        }

        private void XoaDuLieuCu()
        {
            txt_GiaNguoiLon.Text = "";
            txt_GiaTreEm.Text = "";
            txt_TenTour.Text = "";
            dateEdit_NgayKH.Value = DateTime.Now;
            dateEdit_NgayKT.Value = DateTime.Now;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Onclicked = 2;
            btnThem.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            Onclicked = 3;
            btnThem.Enabled = false;
            btn_Sua.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool isError = ThongBaoLoi();
            TourBUS tourBus = new TourBUS();
            switch (Onclicked)
            {
                #region Them Tour
                case 1:
                    {
                        if (!isError)
                        {
                            string maHT;
                            HanhTrinhBUS hanhTrinhBus = new HanhTrinhBUS();
                             HanhTrinhDTO hanhTrinhDTO = hanhTrinhBus.TimHanhTrinh(int.Parse(cbo_NoiDi.SelectedValue.ToString()),
                             int.Parse(cbo_NoiDen.SelectedValue.ToString()));
                            //string maHT = new Random().Next(1, 10000).ToString();
                            if (hanhTrinhDTO==null)//Kiem tra thong tin Hanh Trinh da ton tai
                            {
                                DialogResult result = MessageBox.Show("Hành trình này chưa có sẵn", "Bạn có muốn tạo mới", MessageBoxButtons.YesNo);
                                maHT = new Random().Next(1, 10000).ToString();
                                if (result == DialogResult.OK)//Them hanh trinh moi
                                {
                                    hanhTrinhBus.ThemHanhTrinhMoi(new HanhTrinhDTO()
                                    {
                                        MaHanhTrinh = maHT,
                                        MaNoiDen = int.Parse(cbo_NoiDen.SelectedValue.ToString()),
                                        MaNoiDi = int.Parse(cbo_NoiDi.SelectedValue.ToString())
                                    });
                                }

                            }
                            else
                            {
                                maHT = hanhTrinhDTO.MaHanhTrinh;
                            }
                            ThemTourDTO tourDTO = new ThemTourDTO()
                            {
                                //AnhDiaDiem=,
                                MaHDV = int.Parse(cbo_HuongDanVien.SelectedValue.ToString()),
                                MaKS = cbo_KhachSan.SelectedValue.ToString(),
                                MaLoaiTour = cbo_LoaiTour.SelectedValue.ToString(),
                                MaHanhTrinh = maHT,
                                
                                TourDTO = new TourDTO()
                                {
                                    DiemDen = cbo_NoiDen.SelectedValue.ToString(),
                                    DiemDi = cbo_NoiDi.SelectedValue.ToString(),
                                    GiaNguoiLon = decimal.Parse(txt_GiaNguoiLon.Text),
                                    GiaTreEm = decimal.Parse(txt_GiaTreEm.Text),
                                    NgayKH = dateEdit_NgayKH.Value,
                                    NgayKT = dateEdit_NgayKT.Value,
                                    MaTour = new Random().Next(0, 10000).ToString(),
                                    TenTour = txt_TenTour.Text,
                                    LoaiTour = cbo_LoaiTour.SelectedValue.ToString(),
                                    
                                }
                            };
                            if (tourBus.TimTour(tourDTO.TourDTO.MaTour) != null)
                            {
                                MessageBox.Show(MessageBoxConstants.TRUNGKHOACHINH, "Mã tour này đã tồn tại");
                            }
                            else
                            {
                                try
                                {
                                    tourBus.ThemTour(tourDTO);
                                    MessageBox.Show(MessageBoxConstants.THEMTHANHCONG, "Thêm tour du lịch thành công");
                                    gridControl_Tour.DataSource = tourBus.LoadTourToDataGridView();

                                }
                                catch (Exception)
                                {

                                    MessageBox.Show("Lỗi khóa ngoại", MessageBoxConstants.LOIKHOANGOAI);
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show(MessageBoxConstants.THIEUTHONGTIN, "Nhập lại thông tin");
                        }

                    }
                    break;
                #endregion
                #region Xoa tour
                case 3:
                    {
                        string maTour = gridView_Tour.GetFocusedRowCellValue("MaTour").ToString();
                        try
                        {
                            tourBus.XoaTour(maTour);
                            MessageBox.Show(MessageBoxConstants.XOATHANHCONG, "Tour nay đã bị xóa đi");
                            gridControl_Tour.DataSource = tourBus.LoadTourToDataGridView();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(MessageBoxConstants.LOITHAOTAC, "Xóa chỉ được đổi trạng thái");
                        }
                    }
                    break;
                #endregion
                #region Chinh sua Tour
                case 2:
                    {
                        string maHT;
                        HanhTrinhBUS hanhTrinhBus = new HanhTrinhBUS();
                        HanhTrinhDTO hanhTrinhDTO = hanhTrinhBus.TimHanhTrinh(int.Parse(cbo_NoiDi.SelectedValue.ToString()),
                            int.Parse(cbo_NoiDen.SelectedValue.ToString()));
                        if (hanhTrinhDTO == null)//Kiem tra thong tin Hanh Trinh da ton tai
                        {
                            maHT = new Random().Next(1, 10000).ToString();
                            DialogResult result = MessageBox.Show("Hành trình này chưa có sẵn", "Bạn có muốn tạo mới", MessageBoxButtons.YesNo);
                            if (result == DialogResult.OK)//Them hanh trinh moi
                            {
                                hanhTrinhBus.ThemHanhTrinhMoi(new HanhTrinhDTO()
                                {
                                    MaHanhTrinh = maHT,
                                    MaNoiDen = int.Parse(cbo_NoiDen.SelectedValue.ToString()),
                                    MaNoiDi = int.Parse(cbo_NoiDi.SelectedValue.ToString())
                                });

                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            //maHT = new Random().Next(1, 10000).ToString();
                            maHT = hanhTrinhDTO.MaHanhTrinh;
                        }
                        string maTour = gridView_Tour.GetFocusedRowCellValue("MaTour").ToString();
                        ThemTourDTO tourDTO = new ThemTourDTO()
                        {
                            //AnhDiaDiem=,
                            MaHDV = int.Parse(cbo_HuongDanVien.SelectedValue.ToString()),
                            MaKS = cbo_KhachSan.SelectedValue.ToString(),
                            MaLoaiTour = cbo_LoaiTour.SelectedValue.ToString(),
                            MaHanhTrinh=maHT,
                            TourDTO = new TourDTO()
                            {
                                DiemDen = cbo_NoiDen.SelectedValue.ToString(),
                                DiemDi = cbo_NoiDi.SelectedValue.ToString(),
                                GiaNguoiLon = decimal.Parse(txt_GiaNguoiLon.Text),
                                GiaTreEm = decimal.Parse(txt_GiaTreEm.Text),
                                NgayKH = dateEdit_NgayKH.Value,
                                NgayKT = dateEdit_NgayKT.Value,
                                MaTour = maTour
                            }
                        };
                        try
                        {
                            tourBus.ChinhSuaTour(tourDTO);
                            MessageBox.Show(MessageBoxConstants.CHINHSUATHANHCONG, "Chỉnh sửa thông tin tour thành công");
                            gridControl_Tour.DataSource = tourBus.LoadTourToDataGridView();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(MessageBoxConstants.LOITHAOTAC, "Chỉnh sửa thông tin tour không thành công, vui lòng thử lại");
                        }
                    }
                    break;
                #endregion
                default:
                    break;
            }
            btn_Sua.Enabled = true;
            btnThem.Enabled = true;
            btn_Xoa.Enabled = true;
        }

        private void gridView_Tour_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string tenKhachSan = gridView_Tour.GetFocusedRowCellValue("TenKhachSan").ToString();
            string ngayKH = gridView_Tour.GetFocusedRowCellValue("NgayKH").ToString();
            string ngayKT = gridView_Tour.GetFocusedRowCellValue("NgayKT").ToString();
            string loaiTour = gridView_Tour.GetFocusedRowCellValue("LoaiTour").ToString();
            string noiDi = gridView_Tour.GetFocusedRowCellValue("DiemDi").ToString();
            string noiDen = gridView_Tour.GetFocusedRowCellValue("DiemDen").ToString();
            string giaTreEm = gridView_Tour.GetFocusedRowCellValue("GiaTreEm").ToString();
            string giaNguoiLon = gridView_Tour.GetFocusedRowCellValue("GiaNguoiLon").ToString();
            string tenTour = gridView_Tour.GetFocusedRowCellValue("TenTour").ToString();

            txt_GiaNguoiLon.Text = giaNguoiLon;
            txt_GiaTreEm.Text = giaTreEm;
            dateEdit_NgayKT.Value = DateTime.Parse(ngayKT);
            dateEdit_NgayKH.Value = DateTime.Parse(ngayKH);
            cbo_LoaiTour.Text = loaiTour;
            cbo_KhachSan.Text = tenKhachSan;
            txt_TenTour.Text = tenTour;
            cbo_NoiDen.Text = noiDen;
            cbo_NoiDi.Text = noiDi;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            XoaDuLieuCu();
        }

        private void cbo_NoiDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_NoiDen.DataSource = new DiaDiemBUS().LoadDiemDen(int.Parse(cbo_NoiDi.SelectedValue.ToString()));
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            TourBUS tourBus = new TourBUS();
            gridControl_Tour.DataSource = tourBus.LoadTourToDataGridView();
        }
    }
}
