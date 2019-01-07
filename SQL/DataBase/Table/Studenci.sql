CREATE TABLE [dbo].[Studenci]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ImieINazwisko] NVARCHAR(100) NULL, 
	[DataUrodzenia] VARCHAR(20) NULL,
    [Plec] BIT NULL, 
    [Email] VARCHAR(100) NULL, 
    [Adres] NVARCHAR(250) NULL, 
    [Zdjecie] VARCHAR(250) NULL

)
