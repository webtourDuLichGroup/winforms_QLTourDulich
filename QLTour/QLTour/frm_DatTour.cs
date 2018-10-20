using BUS;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUI.Constants;

namespace GUI
{
    public partial class frm_DatTour : Form
    {
        public frm_DatTour()
        {
            InitializeComponent();
        }

        private void frm_DatTour_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DatTourBUS tourBus = new DatTourBUS();
            TourChiTietDTO tourChiTiet = tourBus.TimTour(frm_Tour.BookedTour.MaTour);
            lbl_GiaKS.Text = tourChiTiet.GiaKhachSan.ToString();
            lbl_GiaNguoiLon.Text = tourChiTiet.Tour.GiaNguoiLon.ToString();
            lbl_GiaTreEm.Text = tourChiTiet.Tour.GiaTreEm.ToString();
            lbl_MaTour.Text = tourChiTiet.Tour.MaTour;
            lbl_NgayKH.Text = tourChiTiet.Tour.NgayKH.Value.ToShortDateString();
            lbl_NgayKT.Text = tourChiTiet.Tour.NgayKT.Value.ToShortDateString();
            lbl_NoiDen.Text = tourChiTiet.Tour.DiemDen;
            lbl_NoiDi.Text = tourChiTiet.Tour.DiemDi;
            lbl_TenKS.Text = tourChiTiet.Tour.TenKhachSan;
            txt_NguoiLon.Text = frm_Tour.BookedTour.NguoiLon.ToString();
            txt_TreEm.Text = frm_Tour.BookedTour.TreEm.ToString();
            txt_TongTien.Text = frm_Tour.BookedTour.TongTien.ToString();
            var sex = new BindingList<KeyValuePair<string, int>>();
            sex.Add(new KeyValuePair<string, int>("Nam", 1));
            sex.Add(new KeyValuePair<string, int>("Nữ", 0));
            cbo_GioiTinh.DisplayMember = "Key";
            cbo_GioiTinh.ValueMember = "Value";
            cbo_GioiTinh.DataSource = sex;

        }

        private bool KTraThongTinNhap()
        {
            return (KTraNhapTextBox(txt_HoTen, error_Hoten) && KTraNhapTextBox(txt_DiaChi, erro_DiaChi) && KTraNhapTextBox(txt_Sdt, error_Sdt));
        }

        private bool KTraNhapTextBox(TextBox txt, ErrorProvider error)
        {
            if (String.IsNullOrEmpty(txt.Text))
            {
                error_Hoten.SetError(txt, ErrorProviderConstants.EMPTY);
                return false;
            }
            error.Clear();
            return true;
        }

        private bool KTraNhapTextBox(TextEdit txt, ErrorProvider error)
        {
            if (String.IsNullOrEmpty(txt.Text))
            {
                error_Hoten.SetError(txt, ErrorProviderConstants.EMPTY);
                return false;
            }
            error.Clear();
            return true;
        }

        private void btn_DatTour_Click(object sender, EventArgs e)
        {
            if (KTraThongTinNhap())
            {
                DatTourBUS datTourBUS = new DatTourBUS();
                Random random = new Random();
                string maKH = random.Next(0, 1000000).ToString();
                string maHD = random.Next(0, 1000).ToString() + txt_Sdt.Text;
                KhachHangDTO khachHang = new KhachHangDTO()
                {
                    DiaChi = txt_DiaChi.Text,
                    Email = txt_Email.Text,
                    GioiTinh = int.Parse(cbo_GioiTinh.SelectedValue.ToString()),
                    MaKH = maKH,
                    MaloaiKH = "1",
                    NgaySinh = dateTime_NamSinh.Value,
                    Sdt = txt_Sdt.Text,
                    TenKH = txt_HoTen.Text
                };
                HopDongDTO hopDong = new HopDongDTO()
                {
                    MaHD = maHD,
                    MaKH = maKH,
                    SoNguoiLon = int.Parse(txt_NguoiLon.Text),
                    SoTreEm = int.Parse(txt_TreEm.Text),
                    TongTien = frm_Tour.BookedTour.TongTien,
                    ThoiGianDat = DateTime.Now
                };
                ChiTietHopDongDTO chiTietHopDong = new ChiTietHopDongDTO()
                {
                    MaCT_HopDong = random.Next(-100, 10000).ToString(),
                    MaHopDong = maHD,
                    MaTour = frm_Tour.BookedTour.MaTour,
                    SoLuong = hopDong.SoNguoiLon + hopDong.SoTreEm,//sai cho nay
                    ThanhTien = frm_Tour.BookedTour.GiaNguoiLon * hopDong.SoNguoiLon + frm_Tour.BookedTour.GiaTreEm * hopDong.SoTreEm
                };
                try
                {
                    datTourBUS.ThanhToanTour(khachHang, hopDong, chiTietHopDong);
                    MessageBox.Show("Thông báo", "Đặt tour thành công", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Chú ý", MessgeBoxConstants.LOIDULIEU, MessageBoxButtons.OK);
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
