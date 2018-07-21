﻿CREATE TABLE [dbo].[RestTablesID]
(
	[Id] INT Identity(1,1) NOT NULL PRIMARY KEY, 
    [RestaurantName] NVARCHAR(50) NOT NULL, 
    [TableID] UNIQUEIDENTIFIER DEFAULT NEWID() NOT NULL 
)
