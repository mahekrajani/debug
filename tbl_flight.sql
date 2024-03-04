CREATE TABLE [dbo].[tbl_flight]
(
	[flight id] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [flight name] VARCHAR(50) NOT NULL, 
    [type] VARCHAR(50) NOT NULL, 
    [capacity] INT NOT NULL, 
    [sourse] VARCHAR(50) NOT NULL, 
    [destination] VARCHAR(50) NOT NULL
)
