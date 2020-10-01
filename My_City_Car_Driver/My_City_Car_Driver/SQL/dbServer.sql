CREATE DATABASE [dbServis]

USE [dbServis]

GO

CREATE TABLE [Computer] (

	[ID]		INT IDENTITY(0, 1),
	[CPU]			NVARCHAR(MAX)		NOT NULL,
	[GPU]			NVARCHAR(MAX)		NOT NULL,
	[PowerSupply]	NVARCHAR(MAX)		NOT NULL,
	[RAM]			NVARCHAR(MAX)		NOT NULL,
	[Motherboard]	NVARCHAR(MAX)		NOT NULL,
	[Housing]		NVARCHAR(MAX)		NOT NULL,

	CONSTRAINT PK_Computer_ID PRIMARY KEY ([ID])

	)

	GO

	CREATE TABLE [Role] (

		[RoleID]	NCHAR(1)		NOT NULL,
		[Title]		NVARCHAR(MAX)	NOT NULL,

		CONSTRAINT PK_Role_RoleID PRIMARY KEY ([RoleID])

	)

	GO

	CREATE TABLE [Signin]	(

		[ID]		INT IDENTITY(0, 1),
		[Username]	NVARCHAR(MAX)		NOT NULL,
		[Password]	NVARCHAR(MAX)		NOT NULL,
		[IDRole]	NCHAR(1)	CONSTRAINT FK_Signin_IDRole_Role_RoleID FOREIGN KEY REFERENCES [Role]([RoleID]) NOT NULL,
		CONSTRAINT PK_Signin_ID PRIMARY KEY ([ID])

	)

	GO

	CREATE TABLE [Product] (

		[ID] INT IDENTITY(0 ,1),
		[IDComputer]			INT CONSTRAINT FK_Product_IDComputer_Computer_ID FOREIGN KEY REFERENCES [Computer]([ID])	NOT NULL,
		[IDCoutryManufacture]	NCHAR(3) CONSTRAINT FK_Product_IDCountryManufacture_CoutryManufacture_CoutryID FOREIGN KEY REFERENCES [CoutryManufacture]([CoutryID])		NOT NULL,
		CONSTRAINT PK_Product_ID PRIMARY KEY ([ID])

	)

	GO

	CREATE TABLE [CoutryManufacture] (

		[CoutryID]	NCHAR(3)		NOT NULL,
		[Title]		NVARCHAR(MAX)	NOT NULL,
		CONSTRAINT PK_CoutryManufacture_CoutryID PRIMARY KEY ([CoutryID])


	)

	GO