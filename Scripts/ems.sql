-- START UPDATE SCRIPT --

USE [ems]
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