CREATE TABLE [dbo].[flight]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [flight name] VARCHAR(50) NOT NULL, 
    [type] VARCHAR(50) NOT NULL, 
    [capacity] INT NOT NULL, 
    [source] VARCHAR(50) NOT NULL, 
    [destination] VARCHAR(50) NOT NULL
)
