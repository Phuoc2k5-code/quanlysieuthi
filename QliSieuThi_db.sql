--CREATE DATABASE QliSieuThi_db
--GO

USE QliSieuThi_db
GO

--quanli(maqli,tenql,tentk,mk,ngaysinh,sdt)
--nhanvien(manv,tennv,macv,ngaysinh,sdt)
--congviec(macv,tencv)
--sanpham(masp,tensp,malsp,soluong,dongiaban,dongianhap)
--loaisanpham(malsp,tenlsp)
--hoadon(mahd,tengl,ngaylap)
--cthd(macthd,mahd,masp,soluong)

CREATE TABLE quanli
(
	maql INT PRIMARY KEY IDENTITY(1,1),
	tenql VARCHAR(100) NOT NULL,
	tentk VARCHAR(100) NOT NULL,
	mk VARCHAR(30) NOT NULL,
	ngaysinh DATE, --‘YYYY-MM-DD’
	sdt VARCHAR(12)
)
GO

CREATE TABLE congviec
(
	macv INT PRIMARY KEY IDENTITY(1,1),
	tencv VARCHAR(100) NOT NULL,
)
GO

CREATE TABLE nhanvien
(
	manv INT PRIMARY KEY IDENTITY(1,1),
	tennv VARCHAR(100) NOT NULL,
	macv INT FOREIGN KEY REFERENCES congviec(macv),
	ngaysinh DATE, --‘YYYY-MM-DD’
	sdt VARCHAR(12)
)
GO

CREATE TABLE loaisanpham
(
	malsp INT PRIMARY KEY IDENTITY(1,1),
	tenlsp VARCHAR(100) NOT NULL,
)
GO

CREATE TABLE sanpham
(
	masp INT PRIMARY KEY IDENTITY(1,1),
	tensp VARCHAR(100) NOT NULL,
	malsp INT FOREIGN KEY REFERENCES loaisanpham(malsp),
	soluong INT DEFAULT 0,
	dongiaban INT DEFAULT 0,
	dongianhap INT DEFAULT 0
)
GO

CREATE TABLE hoadon
(
	mahd INT PRIMARY KEY IDENTITY(1,1),
	tennl VARCHAR(100) NOT NULL, 
	ngaylap DATE
)
GO

CREATE TABLE cthd
(
	maql INT PRIMARY KEY IDENTITY(1,1),
	mahd INT FOREIGN KEY REFERENCES	hoadon(mahd),
	masp INT FOREIGN KEY REFERENCES sanpham(masp),
	soluong INT DEFAULT 0
)
GO


