CREATE TABLE [dbo].Members
(
	[MemberId] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(100) NOT NULL, 
    [MiddleName] VARCHAR(100) NULL, 
    [LastName] VARCHAR(100) NULL, 
    [Email] VARCHAR(100) NULL, 
    [Address] TEXT NULL, 
    [Phone] VARCHAR(20) NULL, 
    [Mobile] VARCHAR(20) NULL
)
