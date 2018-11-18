CREATE TABLE [dbo].[Member]
(
	[Id] INT IDENTITY PRIMARY KEY, 
    [FirstName] NCHAR(20) NOT NULL, 
    [LastName] NCHAR(20) NOT NULL, 
    [AIUB_ID] NCHAR(10) NOT NULL, 
    [IEEE_ID] NCHAR(10) NOT NULL, 
    [Dept] NCHAR(10) NOT NULL, 
    [Gender] NCHAR(10) NOT NULL, 
    [DOB ] DATETIME NOT NULL, 
    [Password] NCHAR(10) NOT NULL, 
    [Contact] NCHAR(10) NOT NULL, 
    [MembershipType] NCHAR(20) NOT NULL, 
    [Email] NCHAR(20) NOT NULL 


)
