CREATE DATABASE QuanLyKhoHang
GO
USE QuanLyKhoHang
GO

CREATE TABLE loai_hang(
	id INT  IDENTITY(1,1) PRIMARY KEY,
	ten NVARCHAR(100)
)
GO
CREATE TABLE nha_cung_cap(
	id INT  IDENTITY(1,1) PRIMARY KEY ,
	ten NVARCHAR(100),
	sdt VARCHAR(50),
	phuong NVARCHAR(50),
	quan NVARCHAR(50),
	city NVARCHAR(50)
)
GO
CREATE TABLE nhan_vien(
	id INT IDENTITY(1,1) PRIMARY KEY,
	ten NVARCHAR(100),
	tuoi INT,
	sex BIT,
	dia_chi NVARCHAR(50),
	luong INT,
	sdt VARCHAR(50),
	manager_id INT FOREIGN KEY(manager_id) REFERENCES dbo.nhan_vien(id)	
)
GO
CREATE TABLE phieu_nhap(
	id INT PRIMARY KEY IDENTITY(1,1),
	ncc_id INT FOREIGN KEY(ncc_id) REFERENCES dbo.nha_cung_cap(id),
	ngay_nhap DATE,
    	nhan_vien_id INT FOREIGN KEY(nhan_vien_id) REFERENCES dbo.nhan_vien(id)
)

GO
CREATE TABLE quay(
	id INT IDENTITY(1,1) PRIMARY KEY,
	ten NVARCHAR(50),
	nhan_vien_id INT FOREIGN KEY(nhan_vien_id) REFERENCES dbo.nhan_vien(id)
)
GO
CREATE TABLE mat_hang(
	id INT IDENTITY(1,1) PRIMARY KEY,
	ten NVARCHAR(100),
	quay_id INT FOREIGN KEY(quay_id) REFERENCES dbo.quay(id),
	loai_hang_id INT FOREIGN KEY(loai_hang_id) REFERENCES dbo.loai_hang(id)
	
)
GO

CREATE TABLE chi_tiet_phieu_nhap(
	phieu_nhap_id INT FOREIGN KEY(phieu_nhap_id) REFERENCES dbo.phieu_nhap(id),
	mat_hang_id INT  FOREIGN KEY(mat_hang_id) REFERENCES dbo.mat_hang(id),
	so_luong INT,
	don_gia INT
)
GO
CREATE TABLE phieu_tra(
	id INT PRIMARY KEY IDENTITY(1,1),
	quay_id INT FOREIGN KEY(quay_id) REFERENCES dbo.quay(id),
	ngay_tra DATE,
  	 nhan_vien_id INT FOREIGN KEY(nhan_vien_id) REFERENCES dbo.nhan_vien(id)
)
GO
CREATE TABLE chi_tiet_phieu_tra(
	phieu_tra_id INT FOREIGN KEY(phieu_tra_id) REFERENCES dbo.phieu_tra(id),
	mat_hang_id INT  FOREIGN KEY(mat_hang_id) REFERENCES dbo.mat_hang(id),
	so_luong INT
)
GO