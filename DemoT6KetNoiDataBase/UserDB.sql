CREATE TABLE userRole(
	RoleId int PRIMARY KEY IDENTITY,
	RoleName nvarchar(50)
)
GO
CREATE TABLE Users(
	Username varchar(32) PRIMARY KEY,
	Password varchar(128) NOT NULL,
	FullName nvarchar(250) NOT NULL,
	Email varchar(500) NULL,
	RoleId int FOREIGN KEY REFERENCES UserRole(RoleId),
	Active bit NOT NULL,
)
GO

INSERT INTO userRole(RoleName) VALUES ('Admin'),('Mod'),('User'),('VIP');
GO
INSERT INTO Users VALUES ('admin', 'admin', 'ADMIN', 'cris@gmail.com',1,1), ('thang', 'Thang123', 'DaoThang', 'cris1@gmail.com',3,1), ('test', 'test1', 'TEST USer', 'cris3@gmail.com',3,0)
