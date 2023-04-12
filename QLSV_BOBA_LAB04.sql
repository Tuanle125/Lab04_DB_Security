﻿CREATE DATABASE QLSV_BOBA_LAB04
GO 

USE [QLSV_BOBA_LAB04]
GO

CREATE TABLE SINHVIEN(
	MASV NVARCHAR(20) PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	NGAYSINH DATETIME,
	DIACHI NVARCHAR(200),
	MALOP VARCHAR(20),
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARBINARY(MAX) NOT NULL,
)
CREATE TABLE NHANVIEN(
	MANV VARCHAR(20) PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	EMAIL VARCHAR(20),
	LUONG VARBINARY(MAX),
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARBINARY(MAX) NOT NULL,
	PUBKEY XML ,
	PRIKEY XML,
)
CREATE TABLE LOP(
	MALOP VARCHAR(20) PRIMARY KEY,
	TENLOP NVARCHAR(100) NOT NULL,
	MANV VARCHAR(20) 
	
)
CREATE TABLE HOCPHAN(
	MAHP VARCHAR(20) PRIMARY KEY,
	TENHP NVARCHAR(100) NOT NULL,
	SOTC INT
)
CREATE TABLE BANGDIEM(
	MASV VARCHAR(20),
	MALOP VARCHAR(20),
	DIEMTHI VARBINARY(MAX),	
	PRIMARY KEY (MASV,MALOP)
)

--Sinh Viên
/*Vì đề lab04 không yêu cầu mã hóa Sinh Viên như nào 
nên nhóm quyết đinh mã hóa MATKHAU Sinh Viên bằng MD5 từ SQL
*/
CREATE PROC SP_CHECK_SINHVIEN
@TENDN VARCHAR(20),@MATKHAU VARBINARY(MAX)
AS
BEGIN
	SELECT MATKHAU,MASV FROM SINHVIEN WHERE TENDN = @TENDN AND MATKHAU = @MATKHAU;
END
GO
-- DROP PROC
CREATE PROC SP_INS_SINHVIEN
@MASV NVARCHAR(50), @HOTEN NVARCHAR(100), @NGAYSINH DATETIME, @DIACHI NVARCHAR(100), @MALOP VARCHAR(50),@TENDN VARCHAR(50),@MATKHAU VARCHAR(50)
AS
BEGIN
	DECLARE @MKMAHOA VARBINARY(MAX) = HASHBYTES('MD5',@MATKHAU)
	INSERT INTO SINHVIEN
	VALUES(@MASV,@HOTEN,@NGAYSINH,@DIACHI,@MALOP,@TENDN,@MKMAHOA)
END
GO

CREATE PROC SP_SEL_SINHVIEN
@MALOP VARCHAR(20)
AS
BEGIN
	SELECT MASV,HOTEN,NGAYSINH,DIACHI,TENDN FROM SINHVIEN WHERE SINHVIEN.MALOP =@MALOP;
END
GO

--Nhân Viên 
CREATE PROC SP_INS_PUBLIC_ENCRYPT_NHANVIEN 
@MANV VARCHAR(20), @HOTEN NVARCHAR(100),
@EMAIL VARCHAR(50), @LUONG VARBINARY(MAX),
@TENDN VARCHAR(50), @MATKHAU VARBINARY(MAX),
@PUBKEY varchar(MAX),@PRIKEY varchar(MAX)
AS
BEGIN
	INSERT INTO  NHANVIEN
	VALUES (@MANV, @HOTEN,@EMAIL,@LUONG,@TENDN,@MATKHAU,CAST(@PUBKEY AS XML),CAST(@PRIKEY AS XML))
END
GO

CREATE PROC SP_SEL_PUBLIC_ENCRYPT_NHANVIEN
@TENDN VARCHAR(50),@MATKHAU VARCHAR(MAX)
AS
BEGIN
	SELECT MANV, HOTEN, EMAIL,CAST(LUONG AS VARCHAR(MAX)) AS LUONG FROM NHANVIEN 
END
GO
--DROP PROC SP_SEL_PUBLIC_ENCRYPT_NHANVIEN
CREATE PROC SP_CHECK_NHANVIEN_PASSWORD
@TENDN VARCHAR(20),@MATKHAU VARBINARY(MAX)
AS
BEGIN
	SELECT MATKHAU,MANV FROM NHANVIEN WHERE TENDN = @TENDN AND MATKHAU = @MATKHAU;
END
GO

CREATE PROC SP_SEL_NAME_NHANVIEN
AS
BEGIN
	SELECT HOTEN FROM NHANVIEN
END
GO

CREATE PROC SP_CHECK_NVCHAMDIEM
@MALOP VARCHAR(20)
AS
BEGIN
	SELECT MANV FROM LOP WHERE MALOP=@MALOP;
END
GO 

CREATE PROC SP_SEL_PUB_NHANVIEN
@MANV VARCHAR(20)
AS
BEGIN
	SELECT cast(PUBKEY as nvarchar(max)) FROM NHANVIEN WHERE MANV =@MANV;
END
GO
EXEC SP_SEL_PUB_NHANVIEN 'NV01'
CREATE PROC SP_SEL_PRI_NHANVIEN
@MANV VARCHAR(20)
AS
BEGIN
	SELECT cast(PRIKEY as nvarchar(max)) FROM NHANVIEN WHERE MANV =@MANV;
END
GO

CREATE PROC SP_SEL_LISTNV 
AS
BEGIN
	SELECT MANV,HOTEN,EMAIL,  TENDN FROM NHANVIEN 
END
GO
--Drop proc SP_SEL_LISTNV

GO
--Sửa Nhân viên
CREATE PROC SP_UPDATE_NV
@MANV VARCHAR(20), @HOTEN NVARCHAR(100), @EMAIL NVARCHAR(100), @TENDN NVARCHAR(100)
AS
BEGIN 
	UPDATE NHANVIEN
	SET MANV=@MANV ,HOTEN=@HOTEN , EMAIL = @EMAIL, TENDN = @TENDN WHERE MANV=@MANV
END 
GO
--Drop proc SP_UPDATE_NV
CREATE PROC SP_CHECK_NV
@MANV VARCHAR(20)
AS
BEGIN
	SELECT MANV FROM NHANVIEN WHERE MANV=@MANV
END
GO

--Lớp
CREATE PROC SP_INS_LOP
@MALOP VARCHAR(20), @TENLOP NVARCHAR(100), @HOTEN NVARCHAR(100)
AS
BEGIN
	DECLARE @MANV VARCHAR(20) = (SELECT MANV FROM NHANVIEN WHERE HOTEN=@HOTEN);
	INSERT INTO LOP
	VALUES(@MALOP,@TENLOP,@MANV)
END
GO


CREATE PROC SP_SEL_LOP
AS
BEGIN
	SELECT MALOP, TENLOP ,HOTEN FROM LOP, NHANVIEN WHERE LOP.MANV = NHANVIEN.MANV;
END
GO

CREATE PROC SP_CHECK_LOP
@MALOP VARCHAR(20)
AS
BEGIN
	SELECT MALOP FROM LOP WHERE MALOP=@MALOP
END
GO
 
CREATE PROC SP_UPD_LOP
@MALOP VARCHAR(20), @TENLOP NVARCHAR(100), @HOTEN NVARCHAR(100)
AS
BEGIN
	DECLARE @MANV VARCHAR(20) = (SELECT MANV FROM NHANVIEN WHERE HOTEN=@HOTEN);
	UPDATE LOP
	SET MANV=@MANV ,TENLOP=@TENLOP WHERE MALOP=@MALOP
END 
GO

CREATE PROC SP_DEL_LOP
@MALOP VARCHAR(20)
AS
BEGIN 
	DELETE FROM LOP WHERE MALOP = @MALOP;
END
GO

CREATE PROC SP_SEL_NAME_LOP @MANV NVARCHAR(100)
AS
BEGIN
	SELECT TENLOP FROM LOP WHERE LOP.MANV = @MANV
END
GO
--DROP PROC SP_SEL_NAME_LOP

CREATE PROC SP_UPDATESV_NOPASSWORD
@MASV NVARCHAR(50), @HOTEN NVARCHAR(100), @NGAYSINH DATETIME, @DIACHI NVARCHAR(100), @MALOP VARCHAR(50),@TENDN VARCHAR(50)
AS
BEGIN
	UPDATE SINHVIEN
	SET HOTEN= @HOTEN ,NGAYSINH =@NGAYSINH, DIACHI =@DIACHI,MALOP = @MALOP,TENDN =@TENDN WHERE MASV=@MASV 
END
GO

CREATE PROC SP_UPDATESV_PASSWORD
@MASV NVARCHAR(50), @HOTEN NVARCHAR(100), @NGAYSINH DATETIME, @DIACHI NVARCHAR(100), @MALOP VARCHAR(50),@TENDN VARCHAR(50) ,@MATKHAU VARCHAR(50)
AS
BEGIN
	DECLARE @MKMAHOA VARBINARY(MAX) = HASHBYTES('MD5',@MATKHAU);
	UPDATE SINHVIEN
	SET HOTEN= @HOTEN ,NGAYSINH =@NGAYSINH, DIACHI =@DIACHI,MALOP = @MALOP,TENDN =@TENDN,MATKHAU =@MKMAHOA WHERE MASV=@MASV 
END
GO

CREATE PROC SP_DSLOP
@TENLOP NVARCHAR(100)
AS
BEGIN
	SELECT MALOP,MANV  FROM  LOP WHERE TENLOP =@TENLOP  
END
GO

CREATE PROC SP_CNT_SV_LOP
@MALOP VARCHAR(50)
AS
BEGIN
	SELECT COUNT(MASV) AS SOLUONG FROM SINHVIEN,LOP WHERE LOP.MALOP =@MALOP AND SINHVIEN.MALOP = LOP.MALOP 
END
go

CREATE PROC SP_INS_SINHVIEN
@MASV VARCHAR(50), @HOTEN NVARCHAR(100), @NGAYSINH DATETIME, @DIACHI NVARCHAR(100), @MALOP VARCHAR(50),@TENDN VARCHAR(50),@MATKHAU VARBINARY(MAX)
AS
BEGIN 
	INSERT INTO SINHVIEN
	VALUES(@MASV,@HOTEN,@NGAYSINH,@DIACHI,@MALOP,@TENDN,@MATKHAU)
END
GO

CREATE PROC SP_CHECK_SINHVIEN
@TENDN VARCHAR(20),@MATKHAU VARBINARY(MAX)
AS
BEGIN
	SELECT MATKHAU,MASV FROM SINHVIEN WHERE TENDN = @TENDN AND MATKHAU = @MATKHAU;
END
GO

-- QL DIEM --
CREATE PROC SP_SEL_DIEM
@MALOP VARCHAR(20),@MANV nVARCHAR(20)
AS
BEGIN
	--DECLARE @MANV VARCHAR(20) = (SELECT MANV FROM LOP WHERE MALOP=@MALOP );
	SELECT SINHVIEN.MASV,HOTEN, DIEMTHI
	FROM BANGDIEM,SINHVIEN WHERE BANGDIEM.MASV =SINHVIEN.MASV and BANGDIEM.MALOP = @MALOP
END
GO

CREATE PROC SP_INS_BANGDIEM
@MASV VARCHAR(20), @MALOP VARCHAR(20), @DIEM VARBINARY(MAX)
AS
BEGIN
	INSERT INTO BANGDIEM
	VALUES(@masv, @malop, @diem)
END
GO

CREATE PROC SP_UPD_DIEM
@MASV VARCHAR(20),@MALOP VARCHAR(20),@DIEM VARBINARY(MAX)
AS
BEGIN
	UPDATE BANGDIEM SET DIEMTHI= @DIEM where MASV=@MASV
END
GO

CREATE PROC SP_SEL_PUBKEY_NV
@MANV VARCHAR(20)
AS
BEGIN
	SELECT PUBKEY FROM NHANVIEN WHERE MANV = @MANV
END
GO

CREATE PROC SP_SEL_PRIKEY_NV
@MANV VARCHAR(20)
AS
BEGIN
	SELECT PRIKEY FROM NHANVIEN WHERE MANV = @MANV
END
GO





