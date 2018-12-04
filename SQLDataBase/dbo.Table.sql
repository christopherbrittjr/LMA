CREATE TABLE [dbo].[Registered_Users]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(MAX) NOT NULL, 
    [Address1] NVARCHAR(MAX) NOT NULL, 
    [Address2] NVARCHAR(MAX) NULL, 
    [City] NVARCHAR(MAX) NOT NULL, 
    [State] VARCHAR(50) NOT NULL, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(MAX) NOT NULL, 
    [IsVaild] BIT NULL
)
