USE master
GO
IF NOT EXISTS (
   SELECT name
   FROM sys.databases
   WHERE name = N'TesteDB'
)
CREATE DATABASE [TesteDB]
GO