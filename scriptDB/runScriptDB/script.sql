USE [master]
GO
WHILE EXISTS(select NULL from sys.databases where name='quanlycafe')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'quanlycafe') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [quanlycafe]
END
GO
/****** Object:  Database [quanlycafe]    Script Date: 14/01/2019 5:17:37 PM ******/
CREATE DATABASE [quanlycafe]
GO
USE [quanlycafe]
GO
/****** Object:  Table [dbo].[chitietcongthuc]    Script Date: 14/01/2019 5:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietcongthuc](
	[id_chitietcongthuc] [int] IDENTITY(1,1) NOT NULL,
	[id_thucuong] [int] NOT NULL,
	[dinhluong] [float] NOT NULL,
	[idkhonguyenlieu] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_chitietcongthuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chitiethoadon]    Script Date: 14/01/2019 5:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitiethoadon](
	[id_chitiethoadon] [int] IDENTITY(1,1) NOT NULL,
	[id_hoadon] [int] NULL,
	[id_thucuong] [int] NULL,
	[soluong] [int] NOT NULL,
	[dongia] [money] NULL,
	[thanhtien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_chitiethoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chitietnguyenlieudadung]    Script Date: 14/01/2019 5:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietnguyenlieudadung](
	[idchitietnguyenlieudadung] [int] IDENTITY(1,1) NOT NULL,
	[idnguyenlieudadung] [int] NULL,
	[idkhonguyenlieu] [int] NULL,
	[dinhluong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idchitietnguyenlieudadung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chitietnhapkho]    Script Date: 14/01/2019 5:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietnhapkho](
	[idchitietnhapkho] [int] IDENTITY(1,1) NOT NULL,
	[tendonvi_so_luong] [char](8) NOT NULL,
	[soluong] [int] NOT NULL,
	[dinhluong] [float] NOT NULL,
	[dongia] [money] NOT NULL,
	[idnhapkho] [int] NOT NULL,
	[idkhonguyenlieu] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idchitietnhapkho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cuahang]    Script Date: 14/01/2019 5:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cuahang](
	[idcuahang] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](100) NULL,
	[diachi] [nvarchar](300) NULL,
	[dienthoai] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idcuahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[giamgia]    Script Date: 14/01/2019 5:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giamgia](
	[id_giamgia] [int] IDENTITY(1,1) NOT NULL,
	[hesogiamgia] [float] NULL,
	[ngaybatdau] [date] NULL,
	[ngayketthuc] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_giamgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 14/01/2019 5:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[id_hoadon] [int] IDENTITY(1,1) NOT NULL,
	[tongtien] [money] NOT NULL,
	[ngaylap] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khonguyenlieu]    Script Date: 14/01/2019 5:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khonguyenlieu](
	[idkhonguyenlieu] [int] IDENTITY(1,1) NOT NULL,
	[tennguyenlieu] [nvarchar](50) NULL,
	[tendonvi_dinh_luong] [char](8) NULL,
	[dinhluong] [float] NULL,
	[dinh_luong_toi_da] [float] NULL,
	[dinh_luong_toi_thieu] [float] NULL,
	[xoa_flag] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idkhonguyenlieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nguyenlieudadung]    Script Date: 14/01/2019 5:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nguyenlieudadung](
	[idnguyenlieudadung] [int] IDENTITY(1,1) NOT NULL,
	[ngaynhap] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idnguyenlieudadung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 14/01/2019 5:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[id_nhanvien] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[ngaysinh] [date] NULL,
	[cmnd] [nvarchar](20) NOT NULL,
	[diachi] [nvarchar](50) NULL,
	[luong] [money] NOT NULL,
	[tentaikhoan] [varchar](30) NOT NULL,
	[matkhau] [varchar](24) NOT NULL,
	[quyen] [int] NULL,
	[xoa_flag] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_nhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhapkho]    Script Date: 14/01/2019 5:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhapkho](
	[idnhapkho] [int] IDENTITY(1,1) NOT NULL,
	[ngaynhap] [datetime] NOT NULL,
	[id_nhanvien] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idnhapkho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhomthucuong]    Script Date: 14/01/2019 5:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhomthucuong](
	[id_nhomthucuong] [int] IDENTITY(1,1) NOT NULL,
	[tennhomthucuong] [nvarchar](50) NOT NULL,
	[xoa_flag] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_nhomthucuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thucuong]    Script Date: 14/01/2019 5:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thucuong](
	[id_thucuong] [int] IDENTITY(1,1) NOT NULL,
	[tenthucuong] [nvarchar](50) NULL,
	[giaban] [money] NULL,
	[id_nhomthucuong] [int] NULL,
	[xoa_flag] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_thucuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[chitietcongthuc] ON 

INSERT [dbo].[chitietcongthuc] ([id_chitietcongthuc], [id_thucuong], [dinhluong], [idkhonguyenlieu]) VALUES (1, 7, 200, 3)
INSERT [dbo].[chitietcongthuc] ([id_chitietcongthuc], [id_thucuong], [dinhluong], [idkhonguyenlieu]) VALUES (2, 6, 200, 1)
INSERT [dbo].[chitietcongthuc] ([id_chitietcongthuc], [id_thucuong], [dinhluong], [idkhonguyenlieu]) VALUES (3, 5, 50, 2)
INSERT [dbo].[chitietcongthuc] ([id_chitietcongthuc], [id_thucuong], [dinhluong], [idkhonguyenlieu]) VALUES (4, 5, 100, 3)
INSERT [dbo].[chitietcongthuc] ([id_chitietcongthuc], [id_thucuong], [dinhluong], [idkhonguyenlieu]) VALUES (5, 4, 150, 3)
INSERT [dbo].[chitietcongthuc] ([id_chitietcongthuc], [id_thucuong], [dinhluong], [idkhonguyenlieu]) VALUES (6, 3, 100, 2)
INSERT [dbo].[chitietcongthuc] ([id_chitietcongthuc], [id_thucuong], [dinhluong], [idkhonguyenlieu]) VALUES (7, 3, 50, 3)
INSERT [dbo].[chitietcongthuc] ([id_chitietcongthuc], [id_thucuong], [dinhluong], [idkhonguyenlieu]) VALUES (8, 2, 300, 1)
INSERT [dbo].[chitietcongthuc] ([id_chitietcongthuc], [id_thucuong], [dinhluong], [idkhonguyenlieu]) VALUES (9, 1, 300, 1)
SET IDENTITY_INSERT [dbo].[chitietcongthuc] OFF
SET IDENTITY_INSERT [dbo].[chitiethoadon] ON 

INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (1, 1, 1, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (2, 1, 2, 1, 35000.0000, 35000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (3, 1, 3, 1, 25000.0000, 25000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (4, 1, 5, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (5, 2, 5, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (6, 2, 4, 1, 20000.0000, 20000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (7, 2, 3, 1, 25000.0000, 25000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (8, 2, 2, 1, 35000.0000, 35000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (9, 2, 1, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (10, 3, 7, 1, 47000.0000, 47000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (11, 3, 6, 1, 40000.0000, 40000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (12, 3, 5, 2, 45000.0000, 90000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (13, 3, 4, 1, 20000.0000, 20000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (14, 4, 1, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (15, 4, 2, 1, 35000.0000, 35000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (16, 4, 3, 1, 25000.0000, 25000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (17, 4, 4, 1, 20000.0000, 20000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (18, 4, 5, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (19, 4, 6, 1, 40000.0000, 40000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (20, 4, 7, 1, 47000.0000, 47000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (21, 5, 7, 1, 47000.0000, 47000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (22, 5, 6, 1, 40000.0000, 40000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (23, 5, 5, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (24, 5, 4, 1, 20000.0000, 20000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (25, 5, 3, 1, 25000.0000, 25000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (26, 5, 2, 1, 35000.0000, 35000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (27, 5, 1, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (28, 6, 1, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (29, 6, 2, 1, 35000.0000, 35000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (30, 6, 3, 1, 25000.0000, 25000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (31, 6, 4, 1, 20000.0000, 20000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (32, 6, 5, 2, 45000.0000, 90000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (33, 6, 6, 1, 40000.0000, 40000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (34, 6, 7, 1, 47000.0000, 47000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (35, 7, 7, 1, 47000.0000, 47000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (36, 7, 6, 1, 40000.0000, 40000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (37, 7, 5, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (38, 7, 4, 1, 20000.0000, 20000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (39, 7, 3, 1, 25000.0000, 25000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (40, 7, 2, 1, 35000.0000, 35000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (41, 7, 1, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (42, 8, 1, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (43, 8, 2, 1, 35000.0000, 35000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (44, 8, 3, 1, 25000.0000, 25000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (45, 8, 4, 1, 20000.0000, 20000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (46, 8, 5, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (47, 8, 6, 1, 40000.0000, 40000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (48, 8, 7, 1, 47000.0000, 47000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (49, 9, 7, 1, 47000.0000, 47000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (50, 9, 6, 1, 40000.0000, 40000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (51, 9, 5, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (52, 9, 4, 1, 20000.0000, 20000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (53, 9, 3, 1, 25000.0000, 25000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (54, 9, 2, 1, 35000.0000, 35000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (55, 9, 1, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (56, 10, 1, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (57, 10, 2, 1, 35000.0000, 35000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (58, 10, 3, 1, 25000.0000, 25000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (59, 10, 4, 1, 20000.0000, 20000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (60, 10, 5, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (61, 10, 7, 1, 47000.0000, 47000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (62, 11, 7, 1, 47000.0000, 47000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (63, 11, 6, 1, 40000.0000, 40000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (64, 11, 5, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (65, 11, 4, 1, 20000.0000, 20000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (66, 11, 3, 1, 25000.0000, 25000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (67, 11, 2, 1, 35000.0000, 35000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (68, 11, 1, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (69, 12, 4, 1, 20000.0000, 20000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (70, 12, 5, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (71, 12, 6, 1, 40000.0000, 40000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (72, 12, 7, 1, 47000.0000, 47000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (73, 12, 1, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (74, 12, 2, 1, 35000.0000, 35000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (75, 13, 7, 1, 47000.0000, 47000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (76, 13, 6, 1, 40000.0000, 40000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (77, 13, 5, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (78, 13, 4, 1, 20000.0000, 20000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (79, 13, 3, 1, 25000.0000, 25000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (80, 13, 1, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (81, 13, 2, 1, 35000.0000, 35000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (82, 14, 7, 1, 47000.0000, 47000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (83, 14, 6, 1, 40000.0000, 40000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (84, 14, 5, 1, 45000.0000, 45000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (85, 14, 4, 1, 20000.0000, 20000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (86, 14, 3, 1, 25000.0000, 25000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (87, 14, 2, 1, 35000.0000, 35000.0000)
INSERT [dbo].[chitiethoadon] ([id_chitiethoadon], [id_hoadon], [id_thucuong], [soluong], [dongia], [thanhtien]) VALUES (88, 14, 1, 1, 45000.0000, 45000.0000)
SET IDENTITY_INSERT [dbo].[chitiethoadon] OFF
SET IDENTITY_INSERT [dbo].[chitietnguyenlieudadung] ON 

INSERT [dbo].[chitietnguyenlieudadung] ([idchitietnguyenlieudadung], [idnguyenlieudadung], [idkhonguyenlieu], [dinhluong]) VALUES (1, 1, 1, 1500)
INSERT [dbo].[chitietnguyenlieudadung] ([idchitietnguyenlieudadung], [idnguyenlieudadung], [idkhonguyenlieu], [dinhluong]) VALUES (2, 1, 2, 500)
INSERT [dbo].[chitietnguyenlieudadung] ([idchitietnguyenlieudadung], [idnguyenlieudadung], [idkhonguyenlieu], [dinhluong]) VALUES (3, 1, 3, 1000)
INSERT [dbo].[chitietnguyenlieudadung] ([idchitietnguyenlieudadung], [idnguyenlieudadung], [idkhonguyenlieu], [dinhluong]) VALUES (4, 2, 1, 500)
INSERT [dbo].[chitietnguyenlieudadung] ([idchitietnguyenlieudadung], [idnguyenlieudadung], [idkhonguyenlieu], [dinhluong]) VALUES (5, 3, 1, 200)
INSERT [dbo].[chitietnguyenlieudadung] ([idchitietnguyenlieudadung], [idnguyenlieudadung], [idkhonguyenlieu], [dinhluong]) VALUES (6, 3, 2, 300)
SET IDENTITY_INSERT [dbo].[chitietnguyenlieudadung] OFF
SET IDENTITY_INSERT [dbo].[chitietnhapkho] ON 

INSERT [dbo].[chitietnhapkho] ([idchitietnhapkho], [tendonvi_so_luong], [soluong], [dinhluong], [dongia], [idnhapkho], [idkhonguyenlieu]) VALUES (1, N'thùng   ', 2, 100, 200.0000, 1, 1)
SET IDENTITY_INSERT [dbo].[chitietnhapkho] OFF
SET IDENTITY_INSERT [dbo].[cuahang] ON 

INSERT [dbo].[cuahang] ([idcuahang], [ten], [diachi], [dienthoai]) VALUES (1, N'2Land Coffee1', N'123 Nguyễn Huệ, Quận 1, tp HCM', N'18001090')
SET IDENTITY_INSERT [dbo].[cuahang] OFF
SET IDENTITY_INSERT [dbo].[giamgia] ON 

INSERT [dbo].[giamgia] ([id_giamgia], [hesogiamgia], [ngaybatdau], [ngayketthuc]) VALUES (1, 15, CAST(N'2019-01-15' AS Date), CAST(N'2019-01-18' AS Date))
SET IDENTITY_INSERT [dbo].[giamgia] OFF
SET IDENTITY_INSERT [dbo].[hoadon] ON 

INSERT [dbo].[hoadon] ([id_hoadon], [tongtien], [ngaylap]) VALUES (1, 150000.0000, CAST(N'2019-01-14T16:31:38.587' AS DateTime))
INSERT [dbo].[hoadon] ([id_hoadon], [tongtien], [ngaylap]) VALUES (2, 170000.0000, CAST(N'2019-02-14T16:31:48.637' AS DateTime))
INSERT [dbo].[hoadon] ([id_hoadon], [tongtien], [ngaylap]) VALUES (3, 197000.0000, CAST(N'2019-03-14T16:43:53.003' AS DateTime))
INSERT [dbo].[hoadon] ([id_hoadon], [tongtien], [ngaylap]) VALUES (4, 257000.0000, CAST(N'2019-04-14T16:44:12.990' AS DateTime))
INSERT [dbo].[hoadon] ([id_hoadon], [tongtien], [ngaylap]) VALUES (5, 257000.0000, CAST(N'2019-05-14T16:44:20.517' AS DateTime))
INSERT [dbo].[hoadon] ([id_hoadon], [tongtien], [ngaylap]) VALUES (6, 302000.0000, CAST(N'2019-06-14T16:44:29.807' AS DateTime))
INSERT [dbo].[hoadon] ([id_hoadon], [tongtien], [ngaylap]) VALUES (7, 257000.0000, CAST(N'2019-07-14T16:44:37.330' AS DateTime))
INSERT [dbo].[hoadon] ([id_hoadon], [tongtien], [ngaylap]) VALUES (8, 257000.0000, CAST(N'2019-08-14T16:44:44.127' AS DateTime))
INSERT [dbo].[hoadon] ([id_hoadon], [tongtien], [ngaylap]) VALUES (9, 257000.0000, CAST(N'2019-09-14T16:44:53.867' AS DateTime))
INSERT [dbo].[hoadon] ([id_hoadon], [tongtien], [ngaylap]) VALUES (10, 217000.0000, CAST(N'2019-10-14T16:44:59.840' AS DateTime))
INSERT [dbo].[hoadon] ([id_hoadon], [tongtien], [ngaylap]) VALUES (11, 257000.0000, CAST(N'2019-11-14T16:45:10.013' AS DateTime))
INSERT [dbo].[hoadon] ([id_hoadon], [tongtien], [ngaylap]) VALUES (12, 232000.0000, CAST(N'2019-12-14T16:45:18.860' AS DateTime))
INSERT [dbo].[hoadon] ([id_hoadon], [tongtien], [ngaylap]) VALUES (13, 257000.0000, CAST(N'2019-01-22T16:51:02.390' AS DateTime))
INSERT [dbo].[hoadon] ([id_hoadon], [tongtien], [ngaylap]) VALUES (14, 257000.0000, CAST(N'2019-01-30T16:51:10.860' AS DateTime))
SET IDENTITY_INSERT [dbo].[hoadon] OFF
SET IDENTITY_INSERT [dbo].[khonguyenlieu] ON 

INSERT [dbo].[khonguyenlieu] ([idkhonguyenlieu], [tennguyenlieu], [tendonvi_dinh_luong], [dinhluong], [dinh_luong_toi_da], [dinh_luong_toi_thieu], [xoa_flag]) VALUES (1, N'Trà', N'gam     ', 4900, 6000, 300, 0)
INSERT [dbo].[khonguyenlieu] ([idkhonguyenlieu], [tennguyenlieu], [tendonvi_dinh_luong], [dinhluong], [dinh_luong_toi_da], [dinh_luong_toi_thieu], [xoa_flag]) VALUES (2, N'Sữa', N'mililit ', 1700, 5000, 250, 0)
INSERT [dbo].[khonguyenlieu] ([idkhonguyenlieu], [tennguyenlieu], [tendonvi_dinh_luong], [dinhluong], [dinh_luong_toi_da], [dinh_luong_toi_thieu], [xoa_flag]) VALUES (3, N'Cafe', N'gam     ', 4500, 3000, 500, 0)
INSERT [dbo].[khonguyenlieu] ([idkhonguyenlieu], [tennguyenlieu], [tendonvi_dinh_luong], [dinhluong], [dinh_luong_toi_da], [dinh_luong_toi_thieu], [xoa_flag]) VALUES (4, N'Syrup nho', N'mililit ', 50, 1200, 300, 0)
SET IDENTITY_INSERT [dbo].[khonguyenlieu] OFF
SET IDENTITY_INSERT [dbo].[nguyenlieudadung] ON 

INSERT [dbo].[nguyenlieudadung] ([idnguyenlieudadung], [ngaynhap]) VALUES (1, CAST(N'2019-01-19T16:49:13.057' AS DateTime))
INSERT [dbo].[nguyenlieudadung] ([idnguyenlieudadung], [ngaynhap]) VALUES (2, CAST(N'2019-01-25T16:55:34.817' AS DateTime))
INSERT [dbo].[nguyenlieudadung] ([idnguyenlieudadung], [ngaynhap]) VALUES (3, CAST(N'2019-01-14T17:06:19.530' AS DateTime))
SET IDENTITY_INSERT [dbo].[nguyenlieudadung] OFF
SET IDENTITY_INSERT [dbo].[nhanvien] ON 

INSERT [dbo].[nhanvien] ([id_nhanvien], [hoten], [ngaysinh], [cmnd], [diachi], [luong], [tentaikhoan], [matkhau], [quyen], [xoa_flag]) VALUES (1, N'admin', CAST(N'1900-01-01' AS Date), N'123456', N'', 0.0000, N'admin', N'123456', 1, 0)
INSERT [dbo].[nhanvien] ([id_nhanvien], [hoten], [ngaysinh], [cmnd], [diachi], [luong], [tentaikhoan], [matkhau], [quyen], [xoa_flag]) VALUES (2, N'user', CAST(N'1900-01-01' AS Date), N'123456', N'', 0.0000, N'user', N'123456', 0, 0)
SET IDENTITY_INSERT [dbo].[nhanvien] OFF
SET IDENTITY_INSERT [dbo].[nhapkho] ON 

INSERT [dbo].[nhapkho] ([idnhapkho], [ngaynhap], [id_nhanvien]) VALUES (1, CAST(N'2019-01-14T17:02:30.240' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[nhapkho] OFF
SET IDENTITY_INSERT [dbo].[nhomthucuong] ON 

INSERT [dbo].[nhomthucuong] ([id_nhomthucuong], [tennhomthucuong], [xoa_flag]) VALUES (1, N'Trà sữa', 0)
INSERT [dbo].[nhomthucuong] ([id_nhomthucuong], [tennhomthucuong], [xoa_flag]) VALUES (2, N'Cafe', 0)
INSERT [dbo].[nhomthucuong] ([id_nhomthucuong], [tennhomthucuong], [xoa_flag]) VALUES (3, N'Expresso', 0)
SET IDENTITY_INSERT [dbo].[nhomthucuong] OFF
SET IDENTITY_INSERT [dbo].[thucuong] ON 

INSERT [dbo].[thucuong] ([id_thucuong], [tenthucuong], [giaban], [id_nhomthucuong], [xoa_flag]) VALUES (1, N'Trà KOI', 45000.0000, 1, 0)
INSERT [dbo].[thucuong] ([id_thucuong], [tenthucuong], [giaban], [id_nhomthucuong], [xoa_flag]) VALUES (2, N'Trà sữa vanila', 35000.0000, 1, 0)
INSERT [dbo].[thucuong] ([id_thucuong], [tenthucuong], [giaban], [id_nhomthucuong], [xoa_flag]) VALUES (3, N'Cafe sữa', 25000.0000, 2, 0)
INSERT [dbo].[thucuong] ([id_thucuong], [tenthucuong], [giaban], [id_nhomthucuong], [xoa_flag]) VALUES (4, N'Cafe đen', 20000.0000, 2, 0)
INSERT [dbo].[thucuong] ([id_thucuong], [tenthucuong], [giaban], [id_nhomthucuong], [xoa_flag]) VALUES (5, N'Capuchino', 45000.0000, 3, 0)
INSERT [dbo].[thucuong] ([id_thucuong], [tenthucuong], [giaban], [id_nhomthucuong], [xoa_flag]) VALUES (6, N'Expresso nóng', 40000.0000, 2, 0)
INSERT [dbo].[thucuong] ([id_thucuong], [tenthucuong], [giaban], [id_nhomthucuong], [xoa_flag]) VALUES (7, N'Expresso đá', 47000.0000, 2, 0)
SET IDENTITY_INSERT [dbo].[thucuong] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__thucuong__3CFB9BFCC9B37F39]    Script Date: 14/01/2019 5:17:37 PM ******/
ALTER TABLE [dbo].[thucuong] ADD UNIQUE NONCLUSTERED 
(
	[tenthucuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[nhanvien] ADD  DEFAULT ((0)) FOR [quyen]
GO
ALTER TABLE [dbo].[chitietcongthuc]  WITH CHECK ADD FOREIGN KEY([id_thucuong])
REFERENCES [dbo].[thucuong] ([id_thucuong])
GO
ALTER TABLE [dbo].[chitietcongthuc]  WITH CHECK ADD FOREIGN KEY([idkhonguyenlieu])
REFERENCES [dbo].[khonguyenlieu] ([idkhonguyenlieu])
GO
ALTER TABLE [dbo].[chitiethoadon]  WITH CHECK ADD FOREIGN KEY([id_hoadon])
REFERENCES [dbo].[hoadon] ([id_hoadon])
GO
ALTER TABLE [dbo].[chitiethoadon]  WITH CHECK ADD FOREIGN KEY([id_thucuong])
REFERENCES [dbo].[thucuong] ([id_thucuong])
GO
ALTER TABLE [dbo].[chitietnguyenlieudadung]  WITH CHECK ADD FOREIGN KEY([idkhonguyenlieu])
REFERENCES [dbo].[khonguyenlieu] ([idkhonguyenlieu])
GO
ALTER TABLE [dbo].[chitietnguyenlieudadung]  WITH CHECK ADD FOREIGN KEY([idnguyenlieudadung])
REFERENCES [dbo].[nguyenlieudadung] ([idnguyenlieudadung])
GO
ALTER TABLE [dbo].[chitietnhapkho]  WITH CHECK ADD FOREIGN KEY([idkhonguyenlieu])
REFERENCES [dbo].[khonguyenlieu] ([idkhonguyenlieu])
GO
ALTER TABLE [dbo].[chitietnhapkho]  WITH CHECK ADD FOREIGN KEY([idnhapkho])
REFERENCES [dbo].[nhapkho] ([idnhapkho])
GO
ALTER TABLE [dbo].[nhapkho]  WITH CHECK ADD FOREIGN KEY([id_nhanvien])
REFERENCES [dbo].[nhanvien] ([id_nhanvien])
GO
ALTER TABLE [dbo].[thucuong]  WITH CHECK ADD FOREIGN KEY([id_nhomthucuong])
REFERENCES [dbo].[nhomthucuong] ([id_nhomthucuong])
GO
USE [master]
GO
ALTER DATABASE [quanlycafe] SET  READ_WRITE 
GO
