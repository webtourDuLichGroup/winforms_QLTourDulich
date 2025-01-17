USE [master]
GO
/****** Object:  Database [QlTourDuLich]    Script Date: 11/16/2018 2:11:36 AM ******/
CREATE DATABASE [QlTourDuLich]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QlTourDuLich', FILENAME = N'F:\InstalledProgram\SQL Express 2012\MSSQL11.SQLEXPRESS\MSSQL\DATA\QlTourDuLich.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QlTourDuLich_log', FILENAME = N'F:\InstalledProgram\SQL Express 2012\MSSQL11.SQLEXPRESS\MSSQL\DATA\QlTourDuLich_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QlTourDuLich] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QlTourDuLich].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QlTourDuLich] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QlTourDuLich] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QlTourDuLich] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QlTourDuLich] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QlTourDuLich] SET ARITHABORT OFF 
GO
ALTER DATABASE [QlTourDuLich] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QlTourDuLich] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QlTourDuLich] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QlTourDuLich] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QlTourDuLich] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QlTourDuLich] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QlTourDuLich] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QlTourDuLich] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QlTourDuLich] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QlTourDuLich] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QlTourDuLich] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QlTourDuLich] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QlTourDuLich] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QlTourDuLich] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QlTourDuLich] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QlTourDuLich] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QlTourDuLich] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QlTourDuLich] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QlTourDuLich] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QlTourDuLich] SET  MULTI_USER 
GO
ALTER DATABASE [QlTourDuLich] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QlTourDuLich] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QlTourDuLich] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QlTourDuLich] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QlTourDuLich]
GO
/****** Object:  Table [dbo].[ChiTietHopDong]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHopDong](
	[MaCT_HopDong] [varchar](10) NOT NULL,
	[MaHopDong] [varchar](10) NULL,
	[MaTour] [varchar](10) NULL,
	[SLTreEm] [int] NULL,
	[SLNguoiLon] [int] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_ChiTietHopDong] PRIMARY KEY CLUSTERED 
(
	[MaCT_HopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTPHIEUNHAP_TOUR]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTPHIEUNHAP_TOUR](
	[SLTreEm] [int] NULL,
	[Ma_CTPNhap] [int] IDENTITY(1,1) NOT NULL,
	[MaTour] [varchar](10) NULL,
	[SLNguoiLon] [int] NULL,
	[MaPNhap] [varchar](10) NULL,
 CONSTRAINT [PK_CTPHIEUNHAP_TOUR] PRIMARY KEY CLUSTERED 
(
	[Ma_CTPNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DIADANH]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DIADANH](
	[MaDiaDanh] [varchar](10) NOT NULL,
	[TenDiaDanh] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_DiaDanh] PRIMARY KEY CLUSTERED 
(
	[MaDiaDanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DIADIEM]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DIADIEM](
	[MaDiaDiem] [int] IDENTITY(1,1) NOT NULL,
	[TenDiaDiem] [nvarchar](100) NOT NULL,
	[MaDiaDanh] [varchar](10) NULL,
 CONSTRAINT [PK_DD] PRIMARY KEY CLUSTERED 
(
	[MaDiaDiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANHTRINH]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANHTRINH](
	[MaHanhTrinh] [varchar](11) NOT NULL,
	[NoiDi] [int] NULL,
	[NoiDen] [int] NULL,
 CONSTRAINT [PK_HT] PRIMARY KEY CLUSTERED 
(
	[MaHanhTrinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOPDONG]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOPDONG](
	[MaHD] [varchar](10) NOT NULL,
	[MaKH] [varchar](30) NULL,
	[ThoiGianDat] [datetime] NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_MaHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HUONGDANVIEN]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HUONGDANVIEN](
	[MaHDV] [int] IDENTITY(1,1) NOT NULL,
	[TenHDV] [nvarchar](50) NULL,
	[SDT] [nvarchar](12) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[AnhDaiDien] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
	[GhiChu] [nvarchar](50) NULL,
	[NgayVaoLam] [datetime] NULL,
	[NgonNgu] [nvarchar](50) NULL,
 CONSTRAINT [PK_HDV] PRIMARY KEY CLUSTERED 
(
	[MaHDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [varchar](30) NOT NULL,
	[TenKH] [nvarchar](100) NULL,
	[NgSinh] [datetime] NULL,
	[GioiTinh] [int] NULL,
	[Email] [varchar](50) NULL,
	[SDTKH] [char](11) NULL,
	[DCKH] [nvarchar](100) NULL,
	[MaLoaiKH] [varchar](10) NULL,
	[TenDoanhNghiep] [nvarchar](100) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_KH] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHSAN]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHSAN](
	[MaKS] [varchar](10) NOT NULL,
	[TenKS] [nvarchar](50) NULL,
	[MaLoaiKS] [varchar](10) NULL,
	[MaDiaDiem] [int] NULL,
	[GiaTien] [money] NULL,
 CONSTRAINT [PK_KS] PRIMARY KEY CLUSTERED 
(
	[MaKS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIKHACHHANG]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAIKHACHHANG](
	[MaLoaiKH] [varchar](10) NOT NULL,
	[TenLoaiKH] [nvarchar](50) NULL,
	[UuDai] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_LKH] PRIMARY KEY CLUSTERED 
(
	[MaLoaiKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIKHACHSAN]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAIKHACHSAN](
	[MaLoaiKS] [varchar](10) NOT NULL,
	[TenLoaiKS] [nvarchar](50) NULL,
 CONSTRAINT [PK_LKS] PRIMARY KEY CLUSTERED 
(
	[MaLoaiKS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAITOUR]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAITOUR](
	[MaLoaiTour] [varchar](10) NOT NULL,
	[TenLoaiTour] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_LT] PRIMARY KEY CLUSTERED 
(
	[MaLoaiTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MANHINH]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MANHINH](
	[MaMH] [int] IDENTITY(1,1) NOT NULL,
	[TenMH] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_MH] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[MaNV] [varchar](10) NOT NULL,
	[TenDangNhap] [varchar](30) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[AnhDaiDien] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](11) NULL,
	[TrangThai] [int] NULL,
	[MatKhauCap2] [nvarchar](50) NULL,
 CONSTRAINT [PK_ND] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOMNGUOIDUNG]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHOMNGUOIDUNG](
	[MaNhom] [int] IDENTITY(1,1) NOT NULL,
	[TenNhom] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NND] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[MaNhom] [int] NOT NULL,
	[MaMH] [int] NOT NULL,
	[CoQuyen] [bit] NULL,
 CONSTRAINT [PK_PHANQUYEN] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUNHAPTOUR]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAPTOUR](
	[MaPN] [varchar](10) NOT NULL,
	[TenPN] [nvarchar](50) NULL,
	[Ngaynhap] [date] NULL,
	[MaNV] [varchar](10) NULL,
 CONSTRAINT [PK_PNT] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QUANLINHOMNGUOIDUNG]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QUANLINHOMNGUOIDUNG](
	[MaQlNguoiDung] [varchar](10) NOT NULL,
	[MaNhom] [int] NULL,
	[MaNV] [varchar](10) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_QLNND] PRIMARY KEY CLUSTERED 
(
	[MaQlNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TOUR]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TOUR](
	[MaTour] [varchar](10) NOT NULL,
	[MaKS] [varchar](10) NULL,
	[TenTour] [nvarchar](100) NULL,
	[NgayKhoiHanh] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
	[GiaTreEm] [money] NULL,
	[GiaNguoiLon] [money] NULL,
	[MoTa] [nvarchar](100) NULL,
	[MaLoaiTour] [varchar](10) NULL,
	[MaHanhTrinh] [varchar](11) NULL,
	[MaHDV] [int] NULL,
	[AnhDaiDien] [varchar](50) NULL,
	[SoLuongDuKhach] [int] NULL,
 CONSTRAINT [PK_TOUR] PRIMARY KEY CLUSTERED 
(
	[MaTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[TourView]    Script Date: 11/16/2018 2:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TourView] AS
SELECT MaTour,TenTour,GiaNguoiLon,GiaTreEm,NoiDi,NoiDen,MoTa
FROM TOUR t,HANHTRINH ht
WHERE t.MaHanhTrinh=ht.MaHanhTrinh

GO
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'0673', N'112', N'13', 24, 77, 1.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'0674', N'112', N'13', 24, 77, 2.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1155', N'533', N'11', 0, 1, 8200000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1156', N'713', N'12', 0, 1, 17700000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1224', N'713', N'10', 0, 1, 5700000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1269', N'780', N'6966', 0, 1, 2500001.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'130', N'1413', N'11', 0, 1, 8200000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1320', N'1413', N'13', 0, 1, 30500000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1379', N'780', N'11', 0, 1, 8200000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1401', N'1193', N'15', 0, 1, 7500000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1408', N'872', N'10', 0, 1, 5700000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1461', N'1094', N'12', 0, 1, 17700000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1614', N'938', N'14', 0, 1, 28500000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1617', N'241', N'15', 0, 1, 7500000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1702', N'737', N'6966', 2, 10, 25000012.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1738', N'220', N'10', 0, 1, 5700000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1789', N'1119', N'10', 0, 1, 5700000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1839', N'1936', N'15', 3, 2, 22500000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1844', N'13', N'10', 0, 1, 5700000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1914', N'1094', N'11', 0, 100, 820000000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1947', N'176', N'17', 0, 1, 13700000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'1978', N'192', N'11', 0, 1, 8200000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'212', N'781875', N'11', 2, 2, 3.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'2323', N'781875', N'6966', 3, 4, 4.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'329', N'1251', N'10', 0, 1, 5700000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'35', N'1094', N'13', 0, 1, 30500000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'434', N'112', N'12', 3, 3, 6.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'4343', N'781875', N'6966', 3, 3, 5.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'445', N'1936', N'10', 0, 1, 5700000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'543', N'284', N'10', 0, 1, 5700000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'569', N'1193', N'13', 0, 1, 30500000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'602', N'112', N'6966', 2, 1, 6.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'626', N'378', N'11', 0, 1, 8200000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'63', N'220', N'3', 0, 1, 9200000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'643', N'1119', N'13', 0, 1, 30500000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'7016', N'781875', N'11', 1, 1, 7.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'712', N'1669', N'6966', 0, 100, 250000100.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'713', N'1369', N'10', 0, 1, 5700000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'764', N'413', N'11', 0, 1, 8200000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'803', N'330', N'11', 0, 1, 8200000.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'8664', N'781875', N'10', 7, 8, 8.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'8686', N'781875', N'12', 6, 6, 9.0000)
INSERT [dbo].[ChiTietHopDong] ([MaCT_HopDong], [MaHopDong], [MaTour], [SLTreEm], [SLNguoiLon], [ThanhTien]) VALUES (N'8765', N'112', N'12', 24, 77, 10.0000)
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'1', N'Địa đạo Củ Chi')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'10', N'Thánh địa Mỹ Sơn')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'11', N'Cầu Rồng')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'12', N'Bà Nà Hill')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'13', N'Chợ Đà Lạt')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'14', N'Cánh đồng hoa Lavender')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'15', N'Chùa Ve Chai')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'16', N'Nhà thờ đá Sapa')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'17', N'Thung lũng Mường Hoa Núi')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'18', N'Nhà thờ đá Sapa')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'19', N'Cáp treo Fansipan')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'2', N'bảo tàng Chứng tích chiến tranh')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'20', N'Núi Hàm Rồng')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'21', N'Vipearl Land')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'22', N'Tháp Po Nagar')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'23', N'Chùa Long Sơn')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'24', N'hòn Lao')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'25', N'Đồi cát bay Mũi Né')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'26', N'Tháp Po Sah Inư')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'27', N'Bãi biển đồi dương')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'28', N'Bãi tắm sao')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'29', N'Vườn quốc gia Phú Quốc')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'3', N'Chợ ấm thực Bến Thành')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'30', N'Kinh thành Huế')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'31', N'Chùa Thiên Mụ')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'32', N'Lăng Tự Đức')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'33', N'Vịnh Hạ Long')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'34', N'Paradise Cruise')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'4', N'Bà Rịa-Vũng Tàu')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'5', N'Nhà hát lớn Hà Nội')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'6', N'Lăng Chủ tịch Hồ Chí Minh')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'7', N'Nhà thờ Hàm Long')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'8', N'Chợ Đồng Xuân')
INSERT [dbo].[DIADANH] ([MaDiaDanh], [TenDiaDanh]) VALUES (N'9', N'Ngũ Hành Sơn')
SET IDENTITY_INSERT [dbo].[DIADIEM] ON 

INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [MaDiaDanh]) VALUES (1, N'TPHCM', NULL)
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [MaDiaDanh]) VALUES (2, N'Hà Nội', NULL)
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [MaDiaDanh]) VALUES (3, N'Đà Nẵng', NULL)
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [MaDiaDanh]) VALUES (4, N'Đà Lạt', NULL)
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [MaDiaDanh]) VALUES (5, N'Sapa', NULL)
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [MaDiaDanh]) VALUES (6, N'Nha Trang', NULL)
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [MaDiaDanh]) VALUES (7, N'Phan Thiết', NULL)
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [MaDiaDanh]) VALUES (8, N'Phú Quốc', NULL)
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [MaDiaDanh]) VALUES (9, N'Huế', NULL)
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [MaDiaDanh]) VALUES (10, N'Hạ Long', NULL)
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [MaDiaDanh]) VALUES (11, N'Quảng Nam', NULL)
SET IDENTITY_INSERT [dbo].[DIADIEM] OFF
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'1', 1, 2)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'10', 2, 10)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'11', 3, 1)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'12', 3, 2)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'13', 3, 4)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'14', 3, 5)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'15', 3, 6)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'16', 4, 7)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'17', 4, 8)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'18', 4, 9)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'19', 4, 10)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'2', 1, 3)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'20', 5, 1)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'21', 5, 2)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'212', 2, 4)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'22', 5, 3)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'23', 5, 4)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'24', 5, 6)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'25', 6, 7)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'26', 6, 8)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'27', 6, 9)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'278', 11, 2)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'28', 6, 10)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'29', 7, 1)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'3', 1, 4)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'30', 7, 2)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'31', 7, 3)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'32', 8, 4)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'33', 8, 5)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'34', 8, 6)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'35', 9, 7)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'36', 9, 8)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'37', 9, 10)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'38', 10, 4)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'39', 10, 7)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'4', 1, 5)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'40', 10, 2)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'422', 6, 2)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'5', 1, 6)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'6', 2, 6)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'7', 2, 7)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'8', 2, 8)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'842', 11, 1)
INSERT [dbo].[HANHTRINH] ([MaHanhTrinh], [NoiDi], [NoiDen]) VALUES (N'9', 2, 9)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'1058', N'1460758030722381', CAST(0x0000A99A001D4055 AS DateTime), NULL, NULL, 0.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'1094', N'1885', CAST(0x0000A99100925C50 AS DateTime), NULL, NULL, 824790000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'11', N'1885', CAST(0x0000A991009521F8 AS DateTime), NULL, NULL, 0.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'1119', N'1885', CAST(0x0000A99100A203DC AS DateTime), NULL, NULL, 34390000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'112', N'1885', CAST(0x0000A988009D0D43 AS DateTime), NULL, NULL, 2500003.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'1193', N'1460758030722381', CAST(0x0000A99901715BCD AS DateTime), NULL, NULL, 36100000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'1215', N'1885', CAST(0x0000A99100944E07 AS DateTime), NULL, NULL, 0.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'1251', N'1885', CAST(0x0000A99100957CEB AS DateTime), NULL, NULL, 5415000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'13', N'1885', CAST(0x0000A99100C5CC4E AS DateTime), NULL, NULL, 5415000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'1369', N'1885', CAST(0x0000A9910094B781 AS DateTime), NULL, NULL, 5415000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'1413', N'1885', CAST(0x0000A99100A0B581 AS DateTime), NULL, NULL, 36765000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'1615', N'1885', CAST(0x0000A99100930D97 AS DateTime), NULL, NULL, 0.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'166', N'1885', CAST(0x0000A9910093C1FA AS DateTime), NULL, NULL, 0.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'1669', N'1885', CAST(0x0000A99001561577 AS DateTime), NULL, NULL, 237500095.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'176', N'1885', CAST(0x0000A99100D86A92 AS DateTime), NULL, NULL, 13015000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'1881', N'1885', CAST(0x0000A9910093D6EC AS DateTime), NULL, NULL, 0.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'192', NULL, CAST(0x0000A99900AAAB3F AS DateTime), NULL, NULL, 7790000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'1936', N'54', CAST(0x0000A99100E377E5 AS DateTime), NULL, NULL, 26790000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'1999', N'1460758030722381', CAST(0x0000A999016ED7AD AS DateTime), NULL, NULL, 34865000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'220', N'1885', CAST(0x0000A99100C37559 AS DateTime), NULL, NULL, 14155000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'241', NULL, CAST(0x0000A99900AC1E95 AS DateTime), NULL, NULL, 7125000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'284', N'1885', CAST(0x0000A99100961551 AS DateTime), NULL, NULL, 5415000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'29', N'1885', CAST(0x0000A99100954571 AS DateTime), NULL, NULL, 0.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'330', NULL, CAST(0x0000A99900ED5792 AS DateTime), NULL, NULL, 7790000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'378', N'1460758030722381', CAST(0x0000A99A001C2645 AS DateTime), NULL, NULL, 7790000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'413', N'1885', CAST(0x0000A99100964B26 AS DateTime), NULL, NULL, 7790000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'533', NULL, CAST(0x0000A99900F553C3 AS DateTime), NULL, NULL, 7790000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'629', N'1885', CAST(0x0000A991009482FA AS DateTime), NULL, NULL, 0.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'713', N'1885', CAST(0x0000A99100C02039 AS DateTime), NULL, NULL, 22230000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'737', N'1885', CAST(0x0000A99100C8743E AS DateTime), NULL, NULL, 23750011.4000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'742', N'1885', CAST(0x0000A9910093DBED AS DateTime), NULL, NULL, 0.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'780', N'1885', CAST(0x0000A99100A1C1C6 AS DateTime), NULL, NULL, 10165000.9500)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'781875', N'39656', CAST(0x0000A988009D6360 AS DateTime), NULL, NULL, 40000000000000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'872', N'1885', CAST(0x0000A99100C4A244 AS DateTime), NULL, NULL, 5415000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'938', N'1885', CAST(0x0000A99100C7EC95 AS DateTime), NULL, NULL, 27075000.0000)
INSERT [dbo].[HOPDONG] ([MaHD], [MaKH], [ThoiGianDat], [TinhTrang], [GhiChu], [TongTien]) VALUES (N'954', N'1885', CAST(0x0000A99100C6AC13 AS DateTime), NULL, NULL, 0.0000)
SET IDENTITY_INSERT [dbo].[HUONGDANVIEN] ON 

INSERT [dbo].[HUONGDANVIEN] ([MaHDV], [TenHDV], [SDT], [DiaChi], [NgaySinh], [GioiTinh], [AnhDaiDien], [TrangThai], [GhiChu], [NgayVaoLam], [NgonNgu]) VALUES (1, N'Nguyễn Trần Chanh Nguyên', N'0908187023', N'', CAST(0x0000713B01105E90 AS DateTime), N'Nữ', N'C:\Users\tranthibay\Desktop\BugCoding\travel\ameri', 1, N'', CAST(0x0000A97E01105E90 AS DateTime), N'')
INSERT [dbo].[HUONGDANVIEN] ([MaHDV], [TenHDV], [SDT], [DiaChi], [NgaySinh], [GioiTinh], [AnhDaiDien], [TrangThai], [GhiChu], [NgayVaoLam], [NgonNgu]) VALUES (2, N'Nguyễn Thị Cẩm Tú', N'', N'', CAST(0x0000A97E01144C08 AS DateTime), N'Nữ', N'C:\Users\tranthibay\Desktop\BugCoding\travel\ameri', 0, N'', CAST(0x0000A97E01144C08 AS DateTime), N'')
INSERT [dbo].[HUONGDANVIEN] ([MaHDV], [TenHDV], [SDT], [DiaChi], [NgaySinh], [GioiTinh], [AnhDaiDien], [TrangThai], [GhiChu], [NgayVaoLam], [NgonNgu]) VALUES (3, N'Dương Văn Hóa', N'', N'', CAST(0x0000A97E01145694 AS DateTime), N'Nữ', N'C:\WNC\DEMO_QLNV\Images\duong.jpg', 1, N'', CAST(0x0000A97E01145694 AS DateTime), N'Viet Nam')
INSERT [dbo].[HUONGDANVIEN] ([MaHDV], [TenHDV], [SDT], [DiaChi], [NgaySinh], [GioiTinh], [AnhDaiDien], [TrangThai], [GhiChu], [NgayVaoLam], [NgonNgu]) VALUES (4, N'Lưu Chí Vỹ', N'', N'', CAST(0x0000A97E01146366 AS DateTime), N'Nữ', N'C:\WNC\DEMO_QLNV\Images\hiep.jpg', 1, N'', CAST(0x0000A97E01146366 AS DateTime), N'')
INSERT [dbo].[HUONGDANVIEN] ([MaHDV], [TenHDV], [SDT], [DiaChi], [NgaySinh], [GioiTinh], [AnhDaiDien], [TrangThai], [GhiChu], [NgayVaoLam], [NgonNgu]) VALUES (5, N'Nguyễn Trần Tuyết Minh', N'0909090909', N'05615156', CAST(0x00007EF401146E04 AS DateTime), N'Nữ', N'C:\Users\tranthibay\Desktop\BugCoding\travel\ameri', 1, N'786546546', CAST(0x0000A97E01146E04 AS DateTime), N'')
INSERT [dbo].[HUONGDANVIEN] ([MaHDV], [TenHDV], [SDT], [DiaChi], [NgaySinh], [GioiTinh], [AnhDaiDien], [TrangThai], [GhiChu], [NgayVaoLam], [NgonNgu]) VALUES (6, N'Nguyễn THị Cẩm Tú', N'', N'', CAST(0x0000A97E011479BC AS DateTime), N'Nữ', N'C:\WNC\DEMO_QLNV\Images\luyen.jpg', 1, N'', CAST(0x0000A97E011479BC AS DateTime), N'')
INSERT [dbo].[HUONGDANVIEN] ([MaHDV], [TenHDV], [SDT], [DiaChi], [NgaySinh], [GioiTinh], [AnhDaiDien], [TrangThai], [GhiChu], [NgayVaoLam], [NgonNgu]) VALUES (7, N'Đặng Thị Nặng', N'', N'', CAST(0x0000A97E01149004 AS DateTime), N'Nữ', N'C:\WNC\DEMO_QLNV\Images\nguyen.jpg', 1, N'', CAST(0x0000A97E01149004 AS DateTime), N'')
INSERT [dbo].[HUONGDANVIEN] ([MaHDV], [TenHDV], [SDT], [DiaChi], [NgaySinh], [GioiTinh], [AnhDaiDien], [TrangThai], [GhiChu], [NgayVaoLam], [NgonNgu]) VALUES (8, N'Trần Minh Châu', N'', N'', CAST(0x0000A97E01149900 AS DateTime), N'Nữ', N'C:\WNC\DEMO_QLNV\Images\phan.jpg', 1, N'', CAST(0x0000A97E01149900 AS DateTime), N'')
INSERT [dbo].[HUONGDANVIEN] ([MaHDV], [TenHDV], [SDT], [DiaChi], [NgaySinh], [GioiTinh], [AnhDaiDien], [TrangThai], [GhiChu], [NgayVaoLam], [NgonNgu]) VALUES (9, N'Trần Chung Chánh', N'', N'', CAST(0x0000A97E0114A300 AS DateTime), N'Nữ', N'C:\WNC\DEMO_QLNV\Images\quang.jpg', 1, N'', CAST(0x0000A97E0114A300 AS DateTime), N'')
INSERT [dbo].[HUONGDANVIEN] ([MaHDV], [TenHDV], [SDT], [DiaChi], [NgaySinh], [GioiTinh], [AnhDaiDien], [TrangThai], [GhiChu], [NgayVaoLam], [NgonNgu]) VALUES (10, N'Trần Trung Nguyên', N'', N'', CAST(0x0000A97E0114AC88 AS DateTime), N'Nữ', N'C:\WNC\DEMO_QLNV\Images\thoai.jpg', 1, N'', CAST(0x0000A97E0114AC89 AS DateTime), N'')
SET IDENTITY_INSERT [dbo].[HUONGDANVIEN] OFF
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'1460758030722381', N'Ròm Khả', NULL, NULL, N'khathts@yahoo.com.vn', N'0983449617 ', N'Quảng Nam', NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'1885', N'Nguyễn Văn A', NULL, NULL, N'voduy@gmail.com', N'12345678987', N'Quận Tân Phú Tphcm', NULL, NULL, N'123')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'39656', N'KHA DAI CA', CAST(0x0000A988009D472A AS DateTime), 1, N'A@GMAIL.COM', N'2345678    ', N'Quận Tân Phú Tphcm', N'1', NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'4', N'Nguyễn Thị Cẩm Tú', NULL, 1, NULL, NULL, N'Quận Tân Phú Tphcm', N'1', N'Chưa xác định', NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'412', N'Dương Võ Thanh Bạch', NULL, NULL, N'DuongBachg@gmail.com', N'963541042  ', N'Quận Tân Phú Tphcm', NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'437942', N'r', CAST(0x0000A9880098788B AS DateTime), 1, N'hghgh', N'456789     ', N'Quận Tân Phú Tphcm', N'1', NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'478', N'bo duy quang', NULL, NULL, N'quang@gmail.com', N'0908186132 ', N'Quận Tân Phú Tphcm', NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'489946', N'tran kha dai ca', CAST(0x0000A988007D1890 AS DateTime), 1, N'212121', N'1212121    ', N'Quận Tân Phú Tphcm', N'1', NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'54', N'võ duy quang', NULL, 1, N'quangvoduy32@gmail.com', N'0983444444 ', N'Hiệp đức Quảng Nam', NULL, NULL, N'123456')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'6', N'Trần Tuấn Lợi', CAST(0x0000A98500AD9086 AS DateTime), 1, N'1234567', N'1234567    ', N'Quận Tân Phú Tphcm', N'1', NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'7', N'Nguyễn Trần Tuyết Minh', NULL, 1, NULL, NULL, N'Quận Tân Phú Tphcm', N'2', N'Chưa xác định', NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'713', N'Trần Thanh Khoa', NULL, NULL, N'khoa@gmail.com', N'0914875414 ', N'Quận Tân Phú Tphcm', NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'715393', N'Bạch bạch ', CAST(0x0000A9880088D95E AS DateTime), 1, N'bach@gma', N'0906       ', N'Quận Tân Phú Tphcm', N'1', NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'728', N'Nguyễn Thái Bảo', NULL, NULL, N'bao32@gmail.com', N'963541042  ', N'100/06 nguyễn quí anh', NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'8', N'Lưu Chí Vỹ', NULL, 1, NULL, NULL, N'Quận Tân Phú Tphcm', N'2', N'Chưa xác định', NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'842012', N'd', CAST(0x0000A988008BCAA6 AS DateTime), 1, N'jhh', N'98         ', N'Quận Tân Phú Tphcm', N'1', NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgSinh], [GioiTinh], [Email], [SDTKH], [DCKH], [MaLoaiKH], [TenDoanhNghiep], [Password]) VALUES (N'961', N'Duong Vo Thanh Bach', NULL, NULL, N'bach@gmail.com', N'0906580274 ', N'Quận Tân Phú Tphcm', NULL, NULL, NULL)
INSERT [dbo].[KHACHSAN] ([MaKS], [TenKS], [MaLoaiKS], [MaDiaDiem], [GiaTien]) VALUES (N'1', N'Liberty Central SaiGon', N'5', 1, 2500000.0000)
INSERT [dbo].[KHACHSAN] ([MaKS], [TenKS], [MaLoaiKS], [MaDiaDiem], [GiaTien]) VALUES (N'10', N'Ponys', N'1', 6, 300000.0000)
INSERT [dbo].[KHACHSAN] ([MaKS], [TenKS], [MaLoaiKS], [MaDiaDiem], [GiaTien]) VALUES (N'11', N'Ocean Place Muine Resort', N'4', 7, 1099000.0000)
INSERT [dbo].[KHACHSAN] ([MaKS], [TenKS], [MaLoaiKS], [MaDiaDiem], [GiaTien]) VALUES (N'12', N'Ocean Pearl', N'4', 8, 1320000.0000)
INSERT [dbo].[KHACHSAN] ([MaKS], [TenKS], [MaLoaiKS], [MaDiaDiem], [GiaTien]) VALUES (N'13', N'Valentine', N'2', 9, 500000.0000)
INSERT [dbo].[KHACHSAN] ([MaKS], [TenKS], [MaLoaiKS], [MaDiaDiem], [GiaTien]) VALUES (N'14', N'Royal Lotus', N'5', 10, 2500000.0000)
INSERT [dbo].[KHACHSAN] ([MaKS], [TenKS], [MaLoaiKS], [MaDiaDiem], [GiaTien]) VALUES (N'2', N'SaiGon Inn', N'1', 1, 200000.0000)
INSERT [dbo].[KHACHSAN] ([MaKS], [TenKS], [MaLoaiKS], [MaDiaDiem], [GiaTien]) VALUES (N'3', N'O Gallery Premier Hotel & Spa', N'5', 2, 2700000.0000)
INSERT [dbo].[KHACHSAN] ([MaKS], [TenKS], [MaLoaiKS], [MaDiaDiem], [GiaTien]) VALUES (N'4', N'Splendid', N'3', 2, 500000.0000)
INSERT [dbo].[KHACHSAN] ([MaKS], [TenKS], [MaLoaiKS], [MaDiaDiem], [GiaTien]) VALUES (N'5', N'Legacy', N'3', 3, 3500000.0000)
INSERT [dbo].[KHACHSAN] ([MaKS], [TenKS], [MaLoaiKS], [MaDiaDiem], [GiaTien]) VALUES (N'6', N'Mường Thanh', N'1', 3, 1200000.0000)
INSERT [dbo].[KHACHSAN] ([MaKS], [TenKS], [MaLoaiKS], [MaDiaDiem], [GiaTien]) VALUES (N'7', N'An An', N'2', 4, 3900000.0000)
INSERT [dbo].[KHACHSAN] ([MaKS], [TenKS], [MaLoaiKS], [MaDiaDiem], [GiaTien]) VALUES (N'8', N'Sài Gòn-Đà Lạt', N'1', 4, 1375000.0000)
INSERT [dbo].[KHACHSAN] ([MaKS], [TenKS], [MaLoaiKS], [MaDiaDiem], [GiaTien]) VALUES (N'9', N'Diamond Sapa', N'3', 5, 900000.0000)
INSERT [dbo].[LOAIKHACHHANG] ([MaLoaiKH], [TenLoaiKH], [UuDai], [GhiChu]) VALUES (N'1', N'Khách cá nhân', N'Không có chương trình', N'Không có ghi chú gì')
INSERT [dbo].[LOAIKHACHHANG] ([MaLoaiKH], [TenLoaiKH], [UuDai], [GhiChu]) VALUES (N'2', N'Khách đoàn thể', N'Không có chương trình', N'Không có ghi chú gì')
INSERT [dbo].[LOAIKHACHSAN] ([MaLoaiKS], [TenLoaiKS]) VALUES (N'1', N'*')
INSERT [dbo].[LOAIKHACHSAN] ([MaLoaiKS], [TenLoaiKS]) VALUES (N'2', N'**')
INSERT [dbo].[LOAIKHACHSAN] ([MaLoaiKS], [TenLoaiKS]) VALUES (N'3', N'***')
INSERT [dbo].[LOAIKHACHSAN] ([MaLoaiKS], [TenLoaiKS]) VALUES (N'4', N'****')
INSERT [dbo].[LOAIKHACHSAN] ([MaLoaiKS], [TenLoaiKS]) VALUES (N'5', N'*****')
INSERT [dbo].[LOAITOUR] ([MaLoaiTour], [TenLoaiTour]) VALUES (N'1', N'Trong nước')
INSERT [dbo].[LOAITOUR] ([MaLoaiTour], [TenLoaiTour]) VALUES (N'2', N'Ngoài nước')
SET IDENTITY_INSERT [dbo].[MANHINH] ON 

INSERT [dbo].[MANHINH] ([MaMH], [TenMH], [GhiChu]) VALUES (1, N'Quản lí nhân viên', N'')
INSERT [dbo].[MANHINH] ([MaMH], [TenMH], [GhiChu]) VALUES (2, N'Quản lí phân quyền', N'')
INSERT [dbo].[MANHINH] ([MaMH], [TenMH], [GhiChu]) VALUES (3, N'Quản lí hướng dẫn viên', N'')
INSERT [dbo].[MANHINH] ([MaMH], [TenMH], [GhiChu]) VALUES (4, N'Quản lí bán tour', N'')
INSERT [dbo].[MANHINH] ([MaMH], [TenMH], [GhiChu]) VALUES (5, N'Quản lí hợp đồng', N'')
INSERT [dbo].[MANHINH] ([MaMH], [TenMH], [GhiChu]) VALUES (6, N'Quản lí doanh thu', N'')
INSERT [dbo].[MANHINH] ([MaMH], [TenMH], [GhiChu]) VALUES (7, N'Quản lí danh sách khách hàng', N'')
INSERT [dbo].[MANHINH] ([MaMH], [TenMH], [GhiChu]) VALUES (8, N'Quản lí hợp đồng', N'')
INSERT [dbo].[MANHINH] ([MaMH], [TenMH], [GhiChu]) VALUES (9, N'Quản lí danh mục tour', N'')
INSERT [dbo].[MANHINH] ([MaMH], [TenMH], [GhiChu]) VALUES (11, N'Quản lí các danh mục dịch vụ đi kèm', NULL)
SET IDENTITY_INSERT [dbo].[MANHINH] OFF
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'1', N'Duong Võ Thanh Bach', N'1111', CAST(0x0000000000000000 AS DateTime), N'Nữ', N'Images\bach.jpg', N'TPHCM', N'0906580274', 0, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'10', N'1', N'1', CAST(0x00009FCB00000000 AS DateTime), N'Nữ', N'C:\WNC\DEMO_QLNV\Images\anh.jpg', N'bb', N'3456', 0, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'11', N'Võ Duy Quang', N'1111', CAST(0x0000000000000000 AS DateTime), N'Nam', N'C:\WNC\DEMO_QLNV\Images\quang.jpg', N'B?n Tre', N'0902879933', 1, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'1127', N'456', N'1111', CAST(0x0000A98300B82039 AS DateTime), N'Nữ', N'', N'456', N'456', 0, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'12', N'Võ Duy Quang', N'1111', CAST(0x0000000000000000 AS DateTime), N'Nữ', N'C:\WNC\DEMO_QLNV\Images\quang.jpg', N'B?n Tre', N'0902879933', 0, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'13', N'Võ Duy Quang', N'1111', CAST(0x0000000000000000 AS DateTime), N'Nữ', N'Images\quang.jpg', N'B?n Tre', N'0902879933', 0, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'2', N'Tran Kha', N'1111', CAST(0x0000000000000000 AS DateTime), N'Nam', N'Images\kha.jpg', N'TPHCM', N'0908187023', 1, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'204', N'B?ch b?ch', N'1111', CAST(0x0000A9870107C244 AS DateTime), N'Nam', N'', N'ffff', N'0906580274', 0, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'2469', N'fff', N'1111', CAST(0x0000A9880097C7BC AS DateTime), N'Nam', N'', N'fff', N'02323', 1, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'3', N'Võ Duy Quang', N'1111', CAST(0x0000000000000000 AS DateTime), N'Nam', N'Images\quang.jpg', N'B?n Tre', N'0902879933', 1, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'4', N'Trinh Thi Anh', N'1111', CAST(0x0000000000000000 AS DateTime), N'Nữ', N'Images\anh.jpg', N'Ti?n Giang', N'0906580274', 1, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'5', N'Nguyen Kim Luyen', N'1111', CAST(0x0000000000000000 AS DateTime), N'Nữ', N'Images\luyen.jpg', N'Cà Mau', N'0906580274', 1, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'5560', N'123', N'1111', CAST(0x00009D1000BD8274 AS DateTime), N'Nữ', N'', N'123', N'123', 0, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'6', N'To Thi Phuong Nguyen', N'1111', CAST(0x0000000000000000 AS DateTime), N'Nữ', N'Images\nguyen.jpg', N'C?n Tho', N'0906581587', 1, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'6784', N'11', N'1111', CAST(0x0000A98300B7FE58 AS DateTime), N'Nữ', N'', N'1', N'1', 1, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'7', N'Dang Minh Duong', N'1111', CAST(0x0000000000000000 AS DateTime), N'Nam', N'Images\duong.jpg', N'C?n Tho', N'0906580876', 1, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'8', N'Tran Quang Thoai', N'1111', CAST(0x0000000000000000 AS DateTime), N'Nữ', N'Images\thoai.jpg', N'TPHCM', N'0906580274', 1, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'9', N'Le Tan Hiep', N'1111', CAST(0x0000000000000000 AS DateTime), N'Nữ', N'Images\hiep.jpg', N'TPHCM', N'0906580274', 1, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'9127', N'chodiren', N'1111', CAST(0x0000A984010839CC AS DateTime), N'Nam', N'', N'jljkl', N'ljkl', 0, N'2222')
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'admin', N'admin', N'admin', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[NGUOIDUNG] ([MaNV], [TenDangNhap], [MatKhau], [NgaySinh], [GioiTinh], [AnhDaiDien], [DiaChi], [SDT], [TrangThai], [MatKhauCap2]) VALUES (N'user', N'user', N'user', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[NHOMNGUOIDUNG] ON 

INSERT [dbo].[NHOMNGUOIDUNG] ([MaNhom], [TenNhom], [GhiChu]) VALUES (1, N'Phòng kế hoạch', N'')
INSERT [dbo].[NHOMNGUOIDUNG] ([MaNhom], [TenNhom], [GhiChu]) VALUES (2, N'Phòng kinh doanh', N'')
INSERT [dbo].[NHOMNGUOIDUNG] ([MaNhom], [TenNhom], [GhiChu]) VALUES (3, N'Phòng nhân sự', N'')
INSERT [dbo].[NHOMNGUOIDUNG] ([MaNhom], [TenNhom], [GhiChu]) VALUES (6, N'user', NULL)
INSERT [dbo].[NHOMNGUOIDUNG] ([MaNhom], [TenNhom], [GhiChu]) VALUES (7, N'admin', NULL)
SET IDENTITY_INSERT [dbo].[NHOMNGUOIDUNG] OFF
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (1, 3, 1)
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (2, 2, 1)
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (2, 3, 1)
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (2, 4, 1)
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (2, 5, 1)
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (2, 6, 1)
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (2, 7, 1)
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (2, 8, 1)
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (2, 9, 1)
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (2, 11, 1)
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (6, 2, 1)
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (6, 3, 1)
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (7, 1, 1)
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (7, 4, 1)
INSERT [dbo].[PHANQUYEN] ([MaNhom], [MaMH], [CoQuyen]) VALUES (7, 5, 1)
INSERT [dbo].[PHIEUNHAPTOUR] ([MaPN], [TenPN], [Ngaynhap], [MaNV]) VALUES (N'1', N'', CAST(0xCB3E0B00 AS Date), N'4')
INSERT [dbo].[PHIEUNHAPTOUR] ([MaPN], [TenPN], [Ngaynhap], [MaNV]) VALUES (N'2', N'', CAST(0xCB3E0B00 AS Date), N'5')
INSERT [dbo].[PHIEUNHAPTOUR] ([MaPN], [TenPN], [Ngaynhap], [MaNV]) VALUES (N'3', N'', CAST(0xCB3E0B00 AS Date), N'6')
INSERT [dbo].[PHIEUNHAPTOUR] ([MaPN], [TenPN], [Ngaynhap], [MaNV]) VALUES (N'4', N'', CAST(0xCB3E0B00 AS Date), N'1')
INSERT [dbo].[PHIEUNHAPTOUR] ([MaPN], [TenPN], [Ngaynhap], [MaNV]) VALUES (N'5', N'', CAST(0xCB3E0B00 AS Date), N'2')
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'11', 6, N'user', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'12', 7, N'admin', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'13', 6, N'admin', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'14', 1, N'1', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'15', 2, N'10', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'16', 3, N'11', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'17', 1, N'1127', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'18', 2, N'12', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'19', 3, N'13', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'20', 1, N'2', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'21', 2, N'204', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'22', 3, N'3', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'23', 1, N'4', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'24', 2, N'5', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'25', 3, N'5560', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'26', 1, N'6', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'27', 2, N'6784', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'28', 3, N'7', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'29', 1, N'8', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'30', 2, N'9', NULL)
INSERT [dbo].[QUANLINHOMNGUOIDUNG] ([MaQlNguoiDung], [MaNhom], [MaNV], [GhiChu]) VALUES (N'31', 3, N'9127', NULL)
INSERT [dbo].[TOUR] ([MaTour], [MaKS], [TenTour], [NgayKhoiHanh], [NgayKetThuc], [GiaTreEm], [GiaNguoiLon], [MoTa], [MaLoaiTour], [MaHanhTrinh], [MaHDV], [AnhDaiDien], [SoLuongDuKhach]) VALUES (N'10', N'3', N'Tour du lịch tuyệt vời ', CAST(0x0000A9B400000000 AS DateTime), CAST(0x0000A9B400000000 AS DateTime), 3000000.0000, 3000000.0000, N'', N'1', N'25', 8, N'sapa.jpg', 20)
INSERT [dbo].[TOUR] ([MaTour], [MaKS], [TenTour], [NgayKhoiHanh], [NgayKetThuc], [GiaTreEm], [GiaNguoiLon], [MoTa], [MaLoaiTour], [MaHanhTrinh], [MaHDV], [AnhDaiDien], [SoLuongDuKhach]) VALUES (N'11', N'2', N'Thành phố tham quan', CAST(0x0000A97100000000 AS DateTime), CAST(0x0000A97600000000 AS DateTime), 5000000.0000, 8000000.0000, N'', N'1', N'39', 8, N'phanthiet.jpg', 20)
INSERT [dbo].[TOUR] ([MaTour], [MaKS], [TenTour], [NgayKhoiHanh], [NgayKetThuc], [GiaTreEm], [GiaNguoiLon], [MoTa], [MaLoaiTour], [MaHanhTrinh], [MaHDV], [AnhDaiDien], [SoLuongDuKhach]) VALUES (N'12', N'3', N'Đất nước sạch nhất thế giới', CAST(0x0000AC7400000000 AS DateTime), CAST(0x0000A99F00000000 AS DateTime), 10000000.0000, 15000000.0000, N'', N'2', N'38', 1, N'halong.jpg', 15)
INSERT [dbo].[TOUR] ([MaTour], [MaKS], [TenTour], [NgayKhoiHanh], [NgayKetThuc], [GiaTreEm], [GiaNguoiLon], [MoTa], [MaLoaiTour], [MaHanhTrinh], [MaHDV], [AnhDaiDien], [SoLuongDuKhach]) VALUES (N'13', N'4', N'Đất nước du lịch tôn giáo', CAST(0x0000A9C800000000 AS DateTime), CAST(0x0000A9C800000000 AS DateTime), 19900000.0000, 30000000.0000, N'', N'2', N'16', 10, N'phuquoc.jpg', 20)
INSERT [dbo].[TOUR] ([MaTour], [MaKS], [TenTour], [NgayKhoiHanh], [NgayKetThuc], [GiaTreEm], [GiaNguoiLon], [MoTa], [MaLoaiTour], [MaHanhTrinh], [MaHDV], [AnhDaiDien], [SoLuongDuKhach]) VALUES (N'14', N'5', N'Thiên đường Kohrong ', CAST(0x0000AA6D00000000 AS DateTime), CAST(0x0000AA7200000000 AS DateTime), 15000000.0000, 25000000.0000, N'', N'2', N'2', 1, N'danang.jpg', 15)
INSERT [dbo].[TOUR] ([MaTour], [MaKS], [TenTour], [NgayKhoiHanh], [NgayKetThuc], [GiaTreEm], [GiaNguoiLon], [MoTa], [MaLoaiTour], [MaHanhTrinh], [MaHDV], [AnhDaiDien], [SoLuongDuKhach]) VALUES (N'15', N'1', N'Du lịch sông nước', CAST(0x0000A87B00000000 AS DateTime), CAST(0x0000A87E00000000 AS DateTime), 2500000.0000, 5000000.0000, NULL, N'1', N'3', 5, N'cantho.jpg', NULL)
INSERT [dbo].[TOUR] ([MaTour], [MaKS], [TenTour], [NgayKhoiHanh], [NgayKetThuc], [GiaTreEm], [GiaNguoiLon], [MoTa], [MaLoaiTour], [MaHanhTrinh], [MaHDV], [AnhDaiDien], [SoLuongDuKhach]) VALUES (N'16', N'1', N'Suối nước nóng', CAST(0x0000A99100000000 AS DateTime), CAST(0x0000A99500000000 AS DateTime), 4000000.0000, 8000000.0000, NULL, N'2', N'13', 9, N'sapa.jpg', NULL)
INSERT [dbo].[TOUR] ([MaTour], [MaKS], [TenTour], [NgayKhoiHanh], [NgayKetThuc], [GiaTreEm], [GiaNguoiLon], [MoTa], [MaLoaiTour], [MaHanhTrinh], [MaHDV], [AnhDaiDien], [SoLuongDuKhach]) VALUES (N'17', N'3', N'Du lịch tâm linh', CAST(0x0000A93900000000 AS DateTime), CAST(0x0000A94700000000 AS DateTime), 5500000.0000, 11000000.0000, NULL, N'1', N'20', 3, N'phanthiet.jpg', NULL)
INSERT [dbo].[TOUR] ([MaTour], [MaKS], [TenTour], [NgayKhoiHanh], [NgayKetThuc], [GiaTreEm], [GiaNguoiLon], [MoTa], [MaLoaiTour], [MaHanhTrinh], [MaHDV], [AnhDaiDien], [SoLuongDuKhach]) VALUES (N'3', N'6', N'Thành phố đáng sống nhất ', CAST(0x0000A98F00000000 AS DateTime), CAST(0x0000A98F00000000 AS DateTime), 123456789.0000, 8000000.0000, N'', N'1', N'2', 1, N'hue.jpg', 20)
INSERT [dbo].[TOUR] ([MaTour], [MaKS], [TenTour], [NgayKhoiHanh], [NgayKetThuc], [GiaTreEm], [GiaNguoiLon], [MoTa], [MaLoaiTour], [MaHanhTrinh], [MaHDV], [AnhDaiDien], [SoLuongDuKhach]) VALUES (N'6966', N'1', N'Chuyến đi về miền cực lạc', CAST(0x0000A98D00000000 AS DateTime), CAST(0x0000A98D00000000 AS DateTime), 1.0000, 1.0000, NULL, N'1', N'11', 1, N'langchai.jpg', NULL)
ALTER TABLE [dbo].[KHACHHANG] ADD  CONSTRAINT [DF__KHACHHANG__GioiT__30F848ED]  DEFAULT ((1)) FOR [GioiTinh]
GO
ALTER TABLE [dbo].[KHACHHANG] ADD  CONSTRAINT [DF_MALOAI]  DEFAULT ('1') FOR [MaLoaiKH]
GO
ALTER TABLE [dbo].[KHACHHANG] ADD  CONSTRAINT [DF__KHACHHANG__TenDo__31EC6D26]  DEFAULT (N'Chưa xác định') FOR [TenDoanhNghiep]
GO
ALTER TABLE [dbo].[LOAIKHACHHANG] ADD  CONSTRAINT [DF__LOAIKHACH__UuDai__32E0915F]  DEFAULT (N'Không có chương trình') FOR [UuDai]
GO
ALTER TABLE [dbo].[LOAIKHACHHANG] ADD  CONSTRAINT [DF__LOAIKHACH__GhiCh__33D4B598]  DEFAULT (N'Không có ghi chú gì') FOR [GhiChu]
GO
ALTER TABLE [dbo].[PHANQUYEN] ADD  CONSTRAINT [DF_CoQuyen]  DEFAULT ((0)) FOR [CoQuyen]
GO
ALTER TABLE [dbo].[ChiTietHopDong]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHopDong_HOPDONG] FOREIGN KEY([MaHopDong])
REFERENCES [dbo].[HOPDONG] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHopDong] CHECK CONSTRAINT [FK_ChiTietHopDong_HOPDONG]
GO
ALTER TABLE [dbo].[ChiTietHopDong]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHopDong_TOUR] FOREIGN KEY([MaTour])
REFERENCES [dbo].[TOUR] ([MaTour])
GO
ALTER TABLE [dbo].[ChiTietHopDong] CHECK CONSTRAINT [FK_ChiTietHopDong_TOUR]
GO
ALTER TABLE [dbo].[CTPHIEUNHAP_TOUR]  WITH CHECK ADD  CONSTRAINT [FK_CTPHIEUNHAP_MaPN] FOREIGN KEY([MaPNhap])
REFERENCES [dbo].[PHIEUNHAPTOUR] ([MaPN])
GO
ALTER TABLE [dbo].[CTPHIEUNHAP_TOUR] CHECK CONSTRAINT [FK_CTPHIEUNHAP_MaPN]
GO
ALTER TABLE [dbo].[CTPHIEUNHAP_TOUR]  WITH CHECK ADD  CONSTRAINT [FK_CTPHIEUNHAP_MaTour] FOREIGN KEY([MaTour])
REFERENCES [dbo].[TOUR] ([MaTour])
GO
ALTER TABLE [dbo].[CTPHIEUNHAP_TOUR] CHECK CONSTRAINT [FK_CTPHIEUNHAP_MaTour]
GO
ALTER TABLE [dbo].[DIADIEM]  WITH CHECK ADD  CONSTRAINT [FK_DIADIEM_DIADANH] FOREIGN KEY([MaDiaDanh])
REFERENCES [dbo].[DIADANH] ([MaDiaDanh])
GO
ALTER TABLE [dbo].[DIADIEM] CHECK CONSTRAINT [FK_DIADIEM_DIADANH]
GO
ALTER TABLE [dbo].[HANHTRINH]  WITH CHECK ADD  CONSTRAINT [FK_HT_NDen] FOREIGN KEY([NoiDen])
REFERENCES [dbo].[DIADIEM] ([MaDiaDiem])
GO
ALTER TABLE [dbo].[HANHTRINH] CHECK CONSTRAINT [FK_HT_NDen]
GO
ALTER TABLE [dbo].[HANHTRINH]  WITH CHECK ADD  CONSTRAINT [FK_HT_NDi] FOREIGN KEY([NoiDi])
REFERENCES [dbo].[DIADIEM] ([MaDiaDiem])
GO
ALTER TABLE [dbo].[HANHTRINH] CHECK CONSTRAINT [FK_HT_NDi]
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_HD_MaKH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_HD_MaKH]
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [PK_KH_LOAI] FOREIGN KEY([MaLoaiKH])
REFERENCES [dbo].[LOAIKHACHHANG] ([MaLoaiKH])
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [PK_KH_LOAI]
GO
ALTER TABLE [dbo].[KHACHSAN]  WITH CHECK ADD  CONSTRAINT [FK_KS_DD] FOREIGN KEY([MaDiaDiem])
REFERENCES [dbo].[DIADIEM] ([MaDiaDiem])
GO
ALTER TABLE [dbo].[KHACHSAN] CHECK CONSTRAINT [FK_KS_DD]
GO
ALTER TABLE [dbo].[KHACHSAN]  WITH CHECK ADD  CONSTRAINT [FK_KS_LKS] FOREIGN KEY([MaLoaiKS])
REFERENCES [dbo].[LOAIKHACHSAN] ([MaLoaiKS])
GO
ALTER TABLE [dbo].[KHACHSAN] CHECK CONSTRAINT [FK_KS_LKS]
GO
ALTER TABLE [dbo].[PHANQUYEN]  WITH CHECK ADD  CONSTRAINT [FK_PQ_MH] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MANHINH] ([MaMH])
GO
ALTER TABLE [dbo].[PHANQUYEN] CHECK CONSTRAINT [FK_PQ_MH]
GO
ALTER TABLE [dbo].[PHANQUYEN]  WITH CHECK ADD  CONSTRAINT [FK_PQ_MN] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NHOMNGUOIDUNG] ([MaNhom])
GO
ALTER TABLE [dbo].[PHANQUYEN] CHECK CONSTRAINT [FK_PQ_MN]
GO
ALTER TABLE [dbo].[PHIEUNHAPTOUR]  WITH CHECK ADD  CONSTRAINT [FK_PNT_MANV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NGUOIDUNG] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAPTOUR] CHECK CONSTRAINT [FK_PNT_MANV]
GO
ALTER TABLE [dbo].[QUANLINHOMNGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_QLNND_NND] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NHOMNGUOIDUNG] ([MaNhom])
GO
ALTER TABLE [dbo].[QUANLINHOMNGUOIDUNG] CHECK CONSTRAINT [FK_QLNND_NND]
GO
ALTER TABLE [dbo].[QUANLINHOMNGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_QUANLINHOMNGUOIDUNG_NGUOIDUNG] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NGUOIDUNG] ([MaNV])
GO
ALTER TABLE [dbo].[QUANLINHOMNGUOIDUNG] CHECK CONSTRAINT [FK_QUANLINHOMNGUOIDUNG_NGUOIDUNG]
GO
ALTER TABLE [dbo].[TOUR]  WITH CHECK ADD  CONSTRAINT [FK_TOUR_HDV] FOREIGN KEY([MaHDV])
REFERENCES [dbo].[HUONGDANVIEN] ([MaHDV])
GO
ALTER TABLE [dbo].[TOUR] CHECK CONSTRAINT [FK_TOUR_HDV]
GO
ALTER TABLE [dbo].[TOUR]  WITH CHECK ADD  CONSTRAINT [FK_TOUR_HT] FOREIGN KEY([MaHanhTrinh])
REFERENCES [dbo].[HANHTRINH] ([MaHanhTrinh])
GO
ALTER TABLE [dbo].[TOUR] CHECK CONSTRAINT [FK_TOUR_HT]
GO
ALTER TABLE [dbo].[TOUR]  WITH CHECK ADD  CONSTRAINT [FK_TOUR_KHACHSAN] FOREIGN KEY([MaKS])
REFERENCES [dbo].[KHACHSAN] ([MaKS])
GO
ALTER TABLE [dbo].[TOUR] CHECK CONSTRAINT [FK_TOUR_KHACHSAN]
GO
ALTER TABLE [dbo].[TOUR]  WITH CHECK ADD  CONSTRAINT [FK_TOUR_LOAI] FOREIGN KEY([MaLoaiTour])
REFERENCES [dbo].[LOAITOUR] ([MaLoaiTour])
GO
ALTER TABLE [dbo].[TOUR] CHECK CONSTRAINT [FK_TOUR_LOAI]
GO
USE [master]
GO
ALTER DATABASE [QlTourDuLich] SET  READ_WRITE 
GO
