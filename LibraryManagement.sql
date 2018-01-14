USE [master]
GO
/****** Object:  Database [LibraryManagement]    Script Date: 1/11/2018 5:54:10 PM ******/
CREATE DATABASE [LibraryManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibraryManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\LibraryManagement.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LibraryManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\LibraryManagement_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LibraryManagement] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LibraryManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LibraryManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LibraryManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LibraryManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LibraryManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LibraryManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [LibraryManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LibraryManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LibraryManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LibraryManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LibraryManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LibraryManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LibraryManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LibraryManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LibraryManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LibraryManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LibraryManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LibraryManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LibraryManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LibraryManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LibraryManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LibraryManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LibraryManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LibraryManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [LibraryManagement] SET  MULTI_USER 
GO
ALTER DATABASE [LibraryManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LibraryManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LibraryManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LibraryManagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LibraryManagement] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'LibraryManagement', N'ON'
GO
USE [LibraryManagement]
GO
/****** Object:  Table [dbo].[BANGCAP]    Script Date: 1/11/2018 5:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGCAP](
	[ma_loai_bang_cap] [nchar](10) NOT NULL,
	[ten_loai_bang_cap] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_loai_bang_cap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BOPHAN]    Script Date: 1/11/2018 5:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOPHAN](
	[ma_bo_phan] [nchar](10) NOT NULL,
	[ten_bo_phan] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_bo_phan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 1/11/2018 5:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[ma_chuc_vu] [nchar](10) NOT NULL,
	[ten_chuc_vu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_chuc_vu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 1/11/2018 5:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[ma_doc_gia] [nchar](10) NOT NULL,
	[ho_ten] [nvarchar](100) NULL,
	[ngay_sinh] [datetime] NULL,
	[nguoi_lap_the] [nchar](10) NULL,
	[ngay_lap_the] [datetime] NULL,
	[ngay_het_hang] [int] NULL,
	[loai_doc_gia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_doc_gia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAIDOCGIA]    Script Date: 1/11/2018 5:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIDOCGIA](
	[ma_loai_doc_gia] [int] NOT NULL,
	[ten_loai_doc_gia] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_loai_doc_gia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAISACH]    Script Date: 1/11/2018 5:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISACH](
	[ma_loai_sach] [int] NOT NULL,
	[ten_loai_sach] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_loai_sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 1/11/2018 5:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[ma_nhan_vien] [nchar](10) NOT NULL,
	[ho_ten] [nvarchar](100) NULL,
	[dien_thoai] [char](11) NULL,
	[ma_chuc_vu] [nchar](10) NULL,
	[ma_bo_phan] [nchar](10) NULL,
	[bang_cap] [nchar](10) NULL,
	[ngay_sinh] [datetime] NULL,
	[dia_chi] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_nhan_vien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUMUONSACH]    Script Date: 1/11/2018 5:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUONSACH](
	[ma_phieu_muon] [nchar](10) NOT NULL,
	[ma_doc_gia] [nchar](10) NOT NULL,
	[ma_sach] [nchar](10) NOT NULL,
	[ngay_muon] [datetime] NULL,
	[so_luong] [int] NULL,
	[nguoi_cho_muon] [nchar](10) NULL,
 CONSTRAINT [PK_PHIEUMUONSACH] PRIMARY KEY CLUSTERED 
(
	[ma_phieu_muon] ASC,
	[ma_doc_gia] ASC,
	[ma_sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUTRASACH]    Script Date: 1/11/2018 5:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTRASACH](
	[ma_phieu_tra] [nchar](10) NOT NULL,
	[ma_doc_gia] [nchar](10) NOT NULL,
	[ma_sach] [nchar](10) NOT NULL,
	[nguoi_nhan_sach] [nchar](10) NULL,
	[ngay_tra] [datetime] NULL,
	[so_luong] [int] NULL,
 CONSTRAINT [PK_PHIEUTRASACH] PRIMARY KEY CLUSTERED 
(
	[ma_phieu_tra] ASC,
	[ma_doc_gia] ASC,
	[ma_sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SACH]    Script Date: 1/11/2018 5:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[ma_sach] [nchar](10) NOT NULL,
	[ten_sach] [nvarchar](100) NULL,
	[the_loai_sach] [int] NULL,
	[nam_xuat_ban] [datetime] NULL,
	[nha_xuat_ban] [nvarchar](50) NULL,
	[tri_gia] [int] NULL,
	[nguoi_nhan_sach] [nchar](10) NULL,
	[so_luong_ban] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD  CONSTRAINT [FK_DOCGIA_LOAIDOCGIA] FOREIGN KEY([loai_doc_gia])
REFERENCES [dbo].[LOAIDOCGIA] ([ma_loai_doc_gia])
GO
ALTER TABLE [dbo].[DOCGIA] CHECK CONSTRAINT [FK_DOCGIA_LOAIDOCGIA]
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD  CONSTRAINT [FK_DOCGIA_NHANVIEN] FOREIGN KEY([nguoi_lap_the])
REFERENCES [dbo].[NHANVIEN] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[DOCGIA] CHECK CONSTRAINT [FK_DOCGIA_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_BANGCAP] FOREIGN KEY([bang_cap])
REFERENCES [dbo].[BANGCAP] ([ma_loai_bang_cap])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_BANGCAP]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_BOPHAN] FOREIGN KEY([ma_bo_phan])
REFERENCES [dbo].[BOPHAN] ([ma_bo_phan])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_BOPHAN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([ma_chuc_vu])
REFERENCES [dbo].[CHUCVU] ([ma_chuc_vu])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCVU]
GO
ALTER TABLE [dbo].[PHIEUMUONSACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUONSACH_DOCGIA] FOREIGN KEY([ma_doc_gia])
REFERENCES [dbo].[DOCGIA] ([ma_doc_gia])
GO
ALTER TABLE [dbo].[PHIEUMUONSACH] CHECK CONSTRAINT [FK_PHIEUMUONSACH_DOCGIA]
GO
ALTER TABLE [dbo].[PHIEUMUONSACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUONSACH_NHANVIEN] FOREIGN KEY([nguoi_cho_muon])
REFERENCES [dbo].[NHANVIEN] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[PHIEUMUONSACH] CHECK CONSTRAINT [FK_PHIEUMUONSACH_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUMUONSACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUONSACH_SACH] FOREIGN KEY([ma_sach])
REFERENCES [dbo].[SACH] ([ma_sach])
GO
ALTER TABLE [dbo].[PHIEUMUONSACH] CHECK CONSTRAINT [FK_PHIEUMUONSACH_SACH]
GO
ALTER TABLE [dbo].[PHIEUTRASACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRASACH_DOCGIA] FOREIGN KEY([ma_doc_gia])
REFERENCES [dbo].[DOCGIA] ([ma_doc_gia])
GO
ALTER TABLE [dbo].[PHIEUTRASACH] CHECK CONSTRAINT [FK_PHIEUTRASACH_DOCGIA]
GO
ALTER TABLE [dbo].[PHIEUTRASACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRASACH_NHANVIEN] FOREIGN KEY([nguoi_nhan_sach])
REFERENCES [dbo].[NHANVIEN] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[PHIEUTRASACH] CHECK CONSTRAINT [FK_PHIEUTRASACH_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUTRASACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRASACH_SACH] FOREIGN KEY([ma_sach])
REFERENCES [dbo].[SACH] ([ma_sach])
GO
ALTER TABLE [dbo].[PHIEUTRASACH] CHECK CONSTRAINT [FK_PHIEUTRASACH_SACH]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_LOAISACH] FOREIGN KEY([the_loai_sach])
REFERENCES [dbo].[LOAISACH] ([ma_loai_sach])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_LOAISACH]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NHANVIEN] FOREIGN KEY([nguoi_nhan_sach])
REFERENCES [dbo].[NHANVIEN] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NHANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[SELECT_NV]    Script Date: 1/11/2018 5:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SELECT_NV]
as 
begin
	select n.ma_nhan_vien, n.ho_ten, n.ngay_sinh, n.dia_chi, n.dien_thoai, b.ten_bo_phan, c.ten_chuc_vu
    from NHANVIEN n, CHUCVU c, BOPHAN b
    where n.ma_bo_phan = b.ma_bo_phan and n.ma_chuc_vu = c.ma_chuc_vu
end

GO
USE [master]
GO
ALTER DATABASE [LibraryManagement] SET  READ_WRITE 
GO
