/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
      ,[Designation]
  FROM [UnitTest].[dbo].[Employees]

INSERT INTO Employees VALUES 
(1,'Dean','CEO'),
(2,'Andri','CTO'),
(3,'Firdaus','CFO'),
(4,'Deandri','Manager1'),
(5,'Firda','Manager2')
;