use master
create database Login
go

use Login
go

CREATE TABLE [dbo].[Login](
	[TenLogin] [nvarchar] (10) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	
	
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[TenLogin]
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO