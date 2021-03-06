Use [master]
WHILE EXISTS(select NULL from sys.databases where name='QLNT')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLNT') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLNT]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLNT]
GO
USE [QLNT]
GO
/****** Object:  Table [dbo].[BAOCAO]    Script Date: 29.06.2018 19:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAO](
	[MaBaoCao] [int] NOT NULL,
	[NgayBaoCao] [datetime2](7) NOT NULL,
	[MaKhoi] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_BAOCAO] PRIMARY KEY CLUSTERED 
(
	[MaBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETBAOCAO]    Script Date: 29.06.2018 19:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETBAOCAO](
	[MaChiTietBaoCao] [int] NOT NULL,
	[MaPhieu] [nvarchar](10) NOT NULL,
	[MaBaoCao] [int] NOT NULL,
 CONSTRAINT [PK_CHITIETBAOCAO] PRIMARY KEY CLUSTERED 
(
	[MaChiTietBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETLOP]    Script Date: 29.06.2018 19:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETLOP](
	[MaLop] [nvarchar](10) NOT NULL,
	[MaTre] [nvarchar](8) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIOITINH]    Script Date: 29.06.2018 19:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIOITINH](
	[MaGioiTinh] [int] NOT NULL,
	[TenGioiTinh] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_GIOITINH] PRIMARY KEY CLUSTERED 
(
	[MaGioiTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHOI]    Script Date: 29.06.2018 19:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOI](
	[MaKhoi] [nvarchar](10) NOT NULL,
	[TenKhoi] [nvarchar](10) NOT NULL,
	[SoLop] [int] NOT NULL,
 CONSTRAINT [PK_KHOI] PRIMARY KEY CLUSTERED 
(
	[MaKhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOP]    Script Date: 29.06.2018 19:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MaLop] [nvarchar](10) NOT NULL,
	[TenLop] [nvarchar](10) NULL,
	[SiSoLop] [int] NULL,
	[Makhoi] [nvarchar](10) NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUGHINHAN]    Script Date: 29.06.2018 19:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUGHINHAN](
	[MaPhieu] [nvarchar](10) NOT NULL,
	[MaTre] [nvarchar](8) NOT NULL,
	[MaKhoi] [nvarchar](8) NOT NULL,
	[MaTinhTrang] [nvarchar](8) NOT NULL,
	[NgayNhap] [datetime2](7) NOT NULL,
	[GhiChu] [nvarchar](20) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QLQUYDINH]    Script Date: 29.06.2018 19:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLQUYDINH](
	[TuoiToiThieu] [int] NULL,
	[TuoiToiDa] [int] NULL,
	[SiSoToiDa] [int] NULL,
	[SoKhoiToiDa] [int] NULL,
	[SoLopToiDa] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 29.06.2018 19:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[TuoiToiThieu] [int] NOT NULL,
	[TuoiToiDa] [int] NOT NULL,
	[SiSoToiDa] [int] NOT NULL,
	[SoKhoiToiDa] [int] NOT NULL,
	[SoLopToiDa] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TINHTRANG]    Script Date: 29.06.2018 19:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TINHTRANG](
	[MaTinhTrang] [int] NOT NULL,
	[TenTinhTrang] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TINHTRANG] PRIMARY KEY CLUSTERED 
(
	[MaTinhTrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRE]    Script Date: 29.06.2018 19:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRE](
	[MaTre] [nvarchar](8) NOT NULL,
	[HoTenTre] [nvarchar](50) NOT NULL,
	[TenONha] [nvarchar](20) NULL,
	[HoTenPhuHuynh] [nvarchar](50) NULL,
	[NgaySinh] [datetime2](7) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](12) NULL,
	[MaGioiTinh] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
	[NgayNhapHoc] [datetime2](7) NULL,
 CONSTRAINT [PK_TRE] PRIMARY KEY CLUSTERED 
(
	[MaTre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 29.06.2018 19:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Username] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
	[Level] [int] NOT NULL
) ON [PRIMARY]

GO
INSERT [dbo].[LOP] ([MaLop], [MaTre]) VALUES (N'1', N'Mầm 1', 5, N'3')
INSERT [dbo].[CHITIETLOP] ([MaLop], [MaTre]) VALUES (N'1', N'17000001')
INSERT [dbo].[CHITIETLOP] ([MaLop], [MaTre]) VALUES (N'1', N'17000002')
INSERT [dbo].[GIOITINH] ([MaGioiTinh], [TenGioiTinh]) VALUES (1, N'Nam')
INSERT [dbo].[GIOITINH] ([MaGioiTinh], [TenGioiTinh]) VALUES (2, N'Nữ')
INSERT [dbo].[KHOI] ([MaKhoi], [TenKhoi], [SoLop]) VALUES (N'1', N'Chồi', 0)
INSERT [dbo].[KHOI] ([MaKhoi], [TenKhoi], [SoLop]) VALUES (N'2', N'Lá', 0)
INSERT [dbo].[KHOI] ([MaKhoi], [TenKhoi], [SoLop]) VALUES (N'3', N'Mầm', 0)
INSERT [dbo].[PHIEUGHINHAN] ([MaPhieu], [MaTre], [MaKhoi], [MaTinhTrang], [NgayNhap], [GhiChu]) VALUES (N'1800000002', N'17000001', N'1', N'2', CAST(N'2018-06-29 00:00:00.0000000' AS DateTime2), N'None')
INSERT [dbo].[QLQUYDINH] ([TuoiToiThieu], [TuoiToiDa], [SiSoToiDa], [SoKhoiToiDa], [SoLopToiDa]) VALUES (0, 0, 1, 0, 0)
INSERT [dbo].[BAOCAO] ([MaBaoCao], [MaKhoi], [SoLuong], [NgayBaoCao]) VALUES (1, N'', 1, CAST(N'2018-06-30 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[CHITIETBAOCAO] ([MaChiTietBaoCao], [MaBaoCao], [MaPhieu]) VALUES (1, 1, N'1800000002')
INSERT [dbo].[THAMSO] ([TuoiToiThieu], [TuoiToiDa], [SiSoToiDa], [SoKhoiToiDa], [SoLopToiDa]) VALUES (3, 5, 20, 3, 4)
INSERT [dbo].[TINHTRANG] ([MaTinhTrang], [TenTinhTrang]) VALUES (1, N'Ngoan')
INSERT [dbo].[TINHTRANG] ([MaTinhTrang], [TenTinhTrang]) VALUES (2, N'Biếng ăn')
INSERT [dbo].[TINHTRANG] ([MaTinhTrang], [TenTinhTrang]) VALUES (3, N'Bị bệnh')
INSERT [dbo].[TRE] ([MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh], [GhiChu], [NgayNhapHoc]) VALUES (N'17000001', N'Ng Van A', N'AAA', N'Ng Van B', CAST(N'2014-12-30 00:00:00.0000000' AS DateTime2), N'1 LDT', N'1234', 1, N'', CAST(N'2018-05-20 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TRE] ([MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh], [GhiChu], [NgayNhapHoc]) VALUES (N'17000002', N'Nguyen Tay Trung', N'Trung', N'Vu? Nguyen Dang', CAST(N'2017-12-30 00:00:00.0000000' AS DateTime2), N'LTD', N'01229696500', 1, N'', CAST(N'1969-06-09 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TRE] ([MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh], [GhiChu], [NgayNhapHoc]) VALUES (N'17000003', N'Nguyen Chun Chun', N'Chun', N'Vu? Nguyen Dang', CAST(N'2017-12-30 00:00:00.0000000' AS DateTime2), N'LTD', N'01229696500', 1, N'', CAST(N'1969-06-09 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TRE] ([MaTre], [HoTenTre], [TenONha], [HoTenPhuHuynh], [NgaySinh], [DiaChi], [DienThoai], [MaGioiTinh], [GhiChu], [NgayNhapHoc]) VALUES (N'17000005', N'Nguyen Chun Quang', N'Q', N'Vu? Nguyen Dang', CAST(N'2017-12-30 00:00:00.0000000' AS DateTime2), N'LTD', N'01229696500', 1, N'Chăm ngoan', CAST(N'2018-06-06 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[User] ([Username], [Password], [Level]) VALUES (N'admin', N'123456', 3)
