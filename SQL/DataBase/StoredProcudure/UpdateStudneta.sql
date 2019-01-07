CREATE PROCEDURE [dbo].[UpdateStudneta]
	@Id int = output,
	@ImieINazwisko NVARCHAR(100),
	@DataUrodzenia VARCHAR(20),
	@Plec BIT,
	@Email VARCHAR(100),
	@Adres NVARCHAR(250),
	@Zdjecie VARCHAR(250)

AS
	UPDATE Studenci SET 
	ImieINazwisko=@ImieINazwisko,
	DataUrodzenia=@DataUrodzenia,
	Plec=@Plec,
	Email=@Email,
	[Adres]=@Adres,
	Zdjecie=@Zdjecie
	
	WHERE Id=@Id
