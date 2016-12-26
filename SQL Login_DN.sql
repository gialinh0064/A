
use Login
go

--select *
--from Login
--go

IF OBJECT_ID ('USP_DANGNHAP','P') IS NOT NULL
	DROP PROC USP_DANGNHAP
GO

CREATE PROC USP_DANGNHAP
	@TK NVARCHAR (50),
	@MK NVARCHAR(50)
AS
	Select COUNT(*) 
	FROM [Login].[dbo].[Login] 
	WHERE TenLogin = @TK and Matkhau = @MK
	--RETURN 1
GO

EXEC  USP_DANGNHAP N'admin',N'12345'