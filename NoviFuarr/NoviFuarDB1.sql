-- Create a new database called 'NoviFuarDB'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'NoviFuarDB'
)
CREATE DATABASE NoviFuarDB
GO
-------------------------------------------------------------
-- Create a new table called '[Users]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Users]', 'U') IS NOT NULL
DROP TABLE [dbo].[Users]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Users]
(
    [UserId] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [UserName] NVARCHAR(50) NOT NULL,
    [UserSurname] NVARCHAR(50) NOT NULL
    -- Specify more columns here
);
GO
----------------------------------------------------------------

-- Create a new table called '[Visitor]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Visitor]', 'U') IS NOT NULL
DROP TABLE [dbo].[Visitor]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Visitor]
(
    [VisitorId] INT NOT NULL PRIMARY KEY, -- Primary Key column
    [VisitorName] NVARCHAR(50) NOT NULL,
    [VisitorSurname] NVARCHAR(50) NOT NULL,
    [VisitorBarCode] IMAGE NOT NULL
    -- Specify more columns here
);
GO
-----------------------------------------------------------------
