-- =============================================
-- Create DanhSach LopHoc theo MaGV dạy
-- =============================================

CREATE PROCEDURE DanhSachLopDay
	@MaGV int
AS
	SELECT	DISTINCT h.MaLop,h.TenLop
	FROM	LichDay d, LopHoc h
	WHERE	d.MaLop=h.MaLop
			AND d.MaGV=@MaGV
GO

-- =============================================
-- Example to execute DanhSach LopHoc theo MaGV dạy
-- =============================================
EXECUTE DanhSachLopDay 3
GO

-- =============================================
-- Create DanhSach Mon dạy theo MAGV
-- =============================================

CREATE PROCEDURE DanhSachMonDay
	@MaGV int
AS
	SELECT	DISTINCT M.MaMonHoc,M.TenMonHoc
	FROM	MonHoc M, LichDay D
	WHERE	M.MaMonHoc=D.MaMonHoc
			AND D.MaGV=@MaGV
GO

-- =============================================
-- Example to execute DanhSach LopHoc theo MaGV dạy
-- =============================================
EXECUTE DanhSachMonDay 1
GO

-- =============================================
-- Create DanhSach Mon dạy theo MAGV, theo khối
-- =============================================

CREATE PROCEDURE DanhSachMonDayTheoKhoi
	@MaGV int,
	@Khoi int
AS
	SELECT	DISTINCT M.MaMonHoc,M.TenMonHoc
	FROM	MonHoc M, LichDay D, LopHoc L
	WHERE	M.MaMonHoc=D.MaMonHoc 
			AND L.MaLop=D.MaLop
			AND D.MaGV=@MaGV
			AND L.KhoiLop=@Khoi
GO

-- =============================================
-- Example to execute DanhSach LopHoc theo MaGV, theo khối
-- =============================================
EXECUTE DanhSachMonDayTheoKhoi 3, 12
GO
-- =============================================
-- Create Danh Sách môn học theo khối
-- =============================================

CREATE PROCEDURE DanhSachMonHocTheoKhoi
	@Khoi int
AS
	SELECT	DISTINCT H.MaMonHoc, H.TenMonHoc
	FROM	MonHoc H, PhanCongMonHoc P
	WHERE	H.MaMonHoc=P.MaMonHoc
			AND P.KhoiLop=@Khoi
GO
-- =============================================
-- Example to execute Danh Sách môn học theo khối
-- =============================================
EXECUTE DanhSachMonHocTheoKhoi 11
GO

-- =============================================
-- Create Danh Sách lớp theo khối
-- =============================================

CREATE PROCEDURE DanhSachLopTheoKhoi
	@Khoi int
AS
	SELECT	DISTINCT MaLop,TenLop
	FROM	LopHoc
	WHERE	LopHoc.KhoiLop=@Khoi
GO
-- =============================================
-- Example to execute Danh Sách lớp theo khối
-- =============================================
EXECUTE DanhSachLopTheoKhoi 10
GO

-- =============================================
-- Create Danh Sách học sinh lop
-- =============================================

CREATE PROCEDURE DanhSachHSLop
	@MaLop nchar(9)
AS
	SELECT	H.MaHS,H.HoTenHS,H.NgaySinh
	FROM	LopHoc L, HocSinh H
	WHERE	L.MaLop=H.MaLop
			AND L.MaLop=@MaLop 
GO
-- =============================================
-- Example to execute Danh Sách học sinh lớp
-- =============================================
EXECUTE DanhSachHSLop '20151001' 
GO

-- =============================================
-- Thủ tục xem điểm của lớp theo môn học (CẦN XEM LẠI)
-- =============================================

CREATE PROCEDURE DiemMonHocTheoLop
	@MaLop nchar(9),
	@MaMH int
AS
	SELECT	DS.MaHS,DS.HoTenHS,LD.TenLoaiD, D.Diem
	FROM	Diem D,(SELECT	H.MaHS,H.HoTenHS,H.NgaySinh
					FROM	LopHoc L, HocSinh H
					WHERE	L.MaLop=H.MaLop
					AND L.MaLop=@MaLop ) DS,
			LoaiDiem LD
	WHERE	D.MaHS=DS.MaHS
			AND D.MaMonHoc=@MaMH
			AND D.MaLoaiD=LD.MaLoaiD
			 
GO
-- =============================================
-- Example to execute Danh Sách học sinh lớp
-- =============================================
EXECUTE DiemMonHocTheoLop '20151001',1 
GO

-- =============================================
-- Thủ tục nhập điểm
-- =============================================

CREATE PROCEDURE NhapDiemThanhPhan
	@MaHS int,
	@MaGV int,
	@HocKy int,
	@namhoc nvarchar(10),
	@MaMonHoc int,
	@MaLoaiDiem int,
	@Mieng1 float,
	@Mieng2 float,
	@Mieng3 float,
	@Mieng4 float,
	@15p1 float,
	@15p2 float,
	@15p3 float,
	@45p1 float,
	@45p2 float,
	@45p3 float,
	@thi float
	
AS
	Begin
	INSERT INTO Diem
	VALUES(@MaHS,@MaGV,@MaMonHoc,@HocKy,@namhoc,@MaLoaiDiem,@Mieng1,
	@Mieng2,@Mieng3,@Mieng4,@15p1,@15p2,@15p3,@45p1,@45p2,@45p3,@thi)
	end			 
GO
-- =============================================
-- Example to execute Danh Sách học sinh lớp
-- =============================================
EXECUTE DiemMonHocTheoLop '20151001',1 
GO
--==========================================
CREATE PROCEDURE [dbo].[DanhSachLopDay1]
	@MaGV int
AS
	SELECT	DISTINCT h.MaLop,h.TenLop
	FROM	LichDay d, LopHoc h
	WHERE	d.MaLop=h.MaLop
			AND d.MaGV=1
GO
EXECUTE DanhSachLopDay1 1 
GO

--=============================================
CREATE PROCEDURE [dbo].[DanhSachHSLopNhapDiem]
	@MaLop nchar(9),
	@magv int
AS
	SELECT	H.MaHS,H.HoTenHS,H.NgaySinh
	FROM	LopHoc L, HocSinh H
	WHERE	L.MaLop=H.MaLop
			AND L.MaLop=@MaLop 
			and h.MaHS NOT IN(SELECT d.MaHS
			FROM Diem d
			WHERE d.MaGV=@magv and d.HocKy=1 and d.NamHoc='2015-2016' and d.MaLoaiD=1)	
			
		go
--=====================================
--tao view xem diem thanh phan
--========================================
CREATE VIEW DiemThanhPhan
as

SELECT     dbo.MonHoc.TenMonHoc, dbo.MonHoc.MaMonHoc 
								, CASE 
								WHEN Diem.DiemMieng1=11  THEN null
								Else Diem.DiemMieng1 End as DiemMieng1,
								CASE 
								WHEN dbo.Diem.DiemMieng2=11  THEN null
								Else dbo.Diem.DiemMieng2 End as DiemMieng2,
								CASE 
								WHEN dbo.Diem.DiemMieng3=11  THEN null
								Else dbo.Diem.DiemMieng3 End as DiemMieng3,
								CASE 
								WHEN dbo.Diem.DiemMieng4=11  THEN null
								Else dbo.Diem.DiemMieng4 End as DiemMieng4,
								CASE
								WHEN dbo.Diem.Diem15p1=11  THEN null
								Else dbo.Diem.Diem15p1 End as Diem15p1,
								CASE
								WHEN dbo.Diem.Diem15p2=11  THEN null
								Else dbo.Diem.Diem15p2 End as Diem15p2,
								CASE
								WHEN dbo.Diem.Diem15p3=11  THEN null
								Else dbo.Diem.Diem15p3 End as Diem15p3,
								CASE
								WHEN  dbo.Diem.Diem45p1=11  THEN null
								Else  dbo.Diem.Diem45p1 End as Diem45p1,
								CASE
								WHEN  dbo.Diem.Diem45p2=11  THEN null
								Else  dbo.Diem.Diem45p2 End as Diem45p2,
								CASE
								WHEN  dbo.Diem.Diem45p3=11  THEN null
								Else  dbo.Diem.Diem45p3 End as Diem45p3,
                          dbo.Diem.MaHS, dbo.Diem.HocKy, dbo.Diem.NamHoc, 
              dbo.Diem.MaLoaiD,
              HocSinh.MaLop,HocSinh.HoTenHS
FROM         dbo.Diem INNER JOIN
              dbo.HocSinh ON dbo.Diem.MaHS = dbo.HocSinh.MaHS INNER JOIN
              dbo.MonHoc ON dbo.Diem.MaMonHoc = dbo.MonHoc.MaMonHoc
go

--=====================================
Create proc XemDiemThanhPhan
@mahs int
as
	select *
	from DiemThanhPhan d
	Where MaHS=@mahs and HocKy=1 and NamHoc='2015-2016'
go
--=======================================
Create proc XemDiemTheoMonHoc
@mamh int,
@lop nvarchar(10)
as
	select *
	from DiemThanhPhan d
	Where MaMonHoc=@mamh and MaLop=@lop and HocKy=1 and NamHoc='2015-2016'
go

--===============
create proc LayMonHocTheoLop_GV
@magv int,
@malop nchar(9)
as
	select DISTINCT MaMonHoc
	from LichDay d
	where d.MaGV=1 and MaLop='20151001'
go