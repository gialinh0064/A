

/*Thêm nhân viên vào danh sách*/

IF OBJECT_ID ('USP_THEM_NV','P') IS NOT NULL
	DROP PROC USP_THEM_NV
GO

CREATE PROC USP_THEM_NV
	@manv nvarchar(10),
	@ho nvarchar(50),
	@ten nvarchar(50),
	@qquan nvarchar(50),
	@sdt nvarchar(50)
AS
	INSERT INTO Nhanvien (MaNV,HoNV,Ten,QueQuan,SDT)
	VALUES (@manv,@ho,@ten,@qquan,@sdt)
GO

EXEC USP_THEM_NV N'NV06',N'Phạm Ánh',N'An',N'Cái Bè',N'01697734159'
Go

Select *
from Nhanvien
go

drop PROC USP_THEM_NV
GO	

IF OBJECT_ID ('USP_XOA_NV','P') IS NOT NULL
	DROP PROC USP_XOA_NV
GO

CREATE PROC USP_XOA_NV
	@manv nvarchar(10),
	@ho nvarchar(50),
	@ten nvarchar(50),
	@qquan nvarchar(50),
	@sdt nvarchar(50)
AS
	DELETE Nhanvien
	WHERE MaNV= @manv AND HoNV=@ho AND Ten=@ten AND QueQuan=@qquan AND SDT=@sdt
GO

EXEC USP_XOA_NV N'NV06',N'Nguyễn Ánh',N'My',N'Vĩnh Long',N'01697734159'
Go



IF OBJECT_ID('USP_UPD_NV','P') IS NOT NULL
	DROP PROC USP_UPD_NV
GO

CREATE PROC USP_UPD_NV
	@manv nvarchar(10),
	@ho nvarchar(50),
	@ten nvarchar(50),
	@qquan nvarchar(50),
	@sdt nvarchar(50)
AS
	UPDATE Nhanvien
	SET HoNV = @ho, Ten = @ten, QueQuan = @qquan,SDT =@sdt
	WHERE MaNV = @manv;
GO

EXEC USP_UPD_NV N'NV06',N'Nguyễn Ánh',N'Tuyết',N'Vĩnh Long',N'01697734159'
go