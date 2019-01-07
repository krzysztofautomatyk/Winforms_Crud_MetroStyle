﻿CREATE PROCEDURE [dbo].[DodajStudenta]
	@Id int = output,
	@ImieINazwisko NVARCHAR(100),
	@DataUrodzenia VARCHAR(20),
	@Plec BIT,
	@Email VARCHAR(100),
	@Adres NVARCHAR(250),
	@Zdjecie VARCHAR(250)

AS
	INSERT INTO Studenci(ImieINazwisko,DataUrodzenia,Plec,Email,[Adres],Zdjecie)
	VALUES(@ImieINazwisko,@DataUrodzenia,@Plec,@Email,@Adres,@Zdjecie)
	SET @Id=SCOPE_IDENTITY()
