﻿CREATE TABLE [dbo].[dbAdmin]
(
	[IdAdmin] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Email] VARCHAR(200) NOT NULL, 
    [Mdp] VARCHAR(100) NOT NULL, 
    [Num] INT NULL
)