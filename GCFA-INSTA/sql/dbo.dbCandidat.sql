CREATE TABLE [dbo].[dbCandidat]
(
	[IdCandidat] INT NOT NULL PRIMARY KEY IDENTITY(10, 1), 
    [LastName] VARCHAR(100) NOT NULL, 
    [FirstName] VARCHAR(100) NOT NULL, 
    [Age] INT NOT NULL, 
    [Birthday] DATETIME NOT NULL, 
    [City] VARCHAR(100) NOT NULL, 
    [Postcode] INT NOT NULL, 
    [Email] VARCHAR(100) NOT NULL, 
    [OvrAverage] VARCHAR(100) NOT NULL, 
    [PhoneNumber] INT NOT NULL, 
    [Status] BIT NULL
)
