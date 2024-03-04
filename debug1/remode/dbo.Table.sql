CREATE TABLE [dbo].[tbl_flight]
(
	[flightid] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [flightname] VARCHAR(50) NOT NULL, 
    [type] VARCHAR(50) NOT NULL, 
    [capacity] INT NOT NULL, 
    [sourse] VARCHAR(50) NOT NULL, 
    [destination] NCHAR(10) NOT NULL
)
