
-- START UPDATE SCRIPT --

USE [master]
GO

IF NOT EXISTS(SELECT name 
	FROM master.sys.databases 
	WHERE name = 'ems')
BEGIN 
	CREATE DATABASE [ems]
	 CONTAINMENT = NONE
	 ON  PRIMARY 
	( NAME = N'ems', FILENAME = N'G:\Projects\Databases\EMS\ems.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
	 LOG ON 
	( NAME = N'ems_log', FILENAME = N'G:\Projects\Databases\EMS\ems_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
	 WITH CATALOG_COLLATION = DATABASE_DEFAULT
END
GO

USE [ems]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--Checking if Competencies Table exits, if not creating it
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_SCHEMA = 'dbo' 
	AND  TABLE_NAME = 'Competencies')
BEGIN
	CREATE TABLE [dbo].[Competencies](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Name] [varchar](50) NOT NULL,
		[CreatedOn] [datetime] NULL,
		[UpdatedOn] [datetime] NULL,
	 CONSTRAINT [PK_Competencies] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]
	ALTER TABLE [dbo].[Competencies] ADD CONSTRAINT [IX_Competencies] UNIQUE ([Name])
END

--Checking if Departments Table exits, if not creating it
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_SCHEMA = 'dbo' 
	AND  TABLE_NAME = 'Departments')
BEGIN
	CREATE TABLE [dbo].[Departments](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Name] [varchar](50) NOT NULL,
		[CreatedOn] [datetime] NULL,
		[UpdatedOn] [datetime] NULL,
	 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]

	ALTER TABLE [dbo].[Departments] ADD CONSTRAINT [IX_Departments] UNIQUE ([Name])
END
GO

--Checking if Employees Table exits, if not creating it
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_SCHEMA = 'dbo' 
	AND  TABLE_NAME = 'Employees')
BEGIN
	CREATE TABLE [dbo].[Employees](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Name] [varchar](50) NOT NULL,
		[DateOfBirth] [date] NOT NULL,
		[Email] [varchar](50) NOT NULL,
		[DateOfJoining] [date] NOT NULL,
		[DepartmentId] [int] NOT NULL,
		[CompetencyId] [int] NOT NULL,
		[CreatedOn] [datetime] NULL,
		[UpdatedOn] [datetime] NULL,
	 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]

	ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Competencies] FOREIGN KEY([CompetencyId])
	REFERENCES [dbo].[Competencies] ([Id])

	ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Competencies]

	ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Departments] FOREIGN KEY([DepartmentId])
	REFERENCES [dbo].[Departments] ([Id])

	ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Departments]

	ALTER TABLE [dbo].[Employees] ADD CONSTRAINT [IX_Employees] UNIQUE ([Email])
END
GO


INSERT INTO [dbo].[Competencies] ([Name],[CreatedOn],[UpdatedOn]) VALUES ('SAS 1','2022-05-28','2022-05-28')
INSERT INTO [dbo].[Competencies] ([Name],[CreatedOn],[UpdatedOn]) VALUES ('SAS 2','2022-05-28','2022-05-28')
INSERT INTO [dbo].[Competencies] ([Name],[CreatedOn],[UpdatedOn]) VALUES ('SAS 3','2022-05-28','2022-05-28')
INSERT INTO [dbo].[Competencies] ([Name],[CreatedOn],[UpdatedOn]) VALUES ('SAS 4','2022-05-28','2022-05-28')
INSERT INTO [dbo].[Competencies] ([Name],[CreatedOn],[UpdatedOn]) VALUES ('SAS 5','2022-05-28','2022-05-28')
GO
INSERT INTO [dbo].[Departments] ([Name],[CreatedOn],[UpdatedOn]) VALUES ('IT','2022-05-28','2022-05-28')
INSERT INTO [dbo].[Departments] ([Name],[CreatedOn],[UpdatedOn]) VALUES ('Admin','2022-05-28','2022-05-28')
INSERT INTO [dbo].[Departments] ([Name],[CreatedOn],[UpdatedOn]) VALUES ('Payroll','2022-05-28','2022-05-28')
INSERT INTO [dbo].[Departments] ([Name],[CreatedOn],[UpdatedOn]) VALUES ('HR','2022-05-28','2022-05-28')
INSERT INTO [dbo].[Departments] ([Name],[CreatedOn],[UpdatedOn]) VALUES ('Foundation','2022-05-28','2022-05-28')
GO
INSERT INTO [dbo].[Employees] ([Name],[DateOfBirth],[Email],[DateOfJoining],[DepartmentId],[CompetencyId],[CreatedOn],[UpdatedOn]) VALUES
('Sayan Saha','1996-07-14','sayansaha@gmail.com',GETDATE(),1,2,'2022-05-28','2022-05-28')
INSERT INTO [dbo].[Employees] ([Name],[DateOfBirth],[Email],[DateOfJoining],[DepartmentId],[CompetencyId],[CreatedOn],[UpdatedOn]) VALUES
('Elon Musk','1957-01-07','elonmusk@gmail.com',GETDATE(),4,3,'2022-05-28','2022-05-28')
INSERT INTO [dbo].[Employees] ([Name],[DateOfBirth],[Email],[DateOfJoining],[DepartmentId],[CompetencyId],[CreatedOn],[UpdatedOn]) VALUES
('Bill Gates','1923-12-23','billgates@gmail.com',GETDATE(),5,4,'2022-05-28','2022-05-28')
INSERT INTO [dbo].[Employees] ([Name],[DateOfBirth],[Email],[DateOfJoining],[DepartmentId],[CompetencyId],[CreatedOn],[UpdatedOn]) VALUES
('Steve Jobs','1890-03-12','stevejobs@rediff.com',GETDATE(),2,1,'2022-05-28','2022-05-28')
INSERT INTO [dbo].[Employees] ([Name],[DateOfBirth],[Email],[DateOfJoining],[DepartmentId],[CompetencyId],[CreatedOn],[UpdatedOn]) VALUES
('Mukesh Ambani','1965-10-29','mukeshambani@gmail.com',GETDATE(),3,5,'2022-05-28','2022-05-28')
GO

-- END UPDATE SCRIPT --
