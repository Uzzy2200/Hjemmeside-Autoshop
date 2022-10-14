USE Master
GO	
IF DB_ID('BILER') IS NOT NULL
	BEGIN
ALTER DATABASE BILER SET SINGLE_USER
DROP DATABASE BILER
	END
CREATE DATABASE BILER 
GO
USE BILER
GO

CREATE TABLE BIL (
Maerke nvarchar (50),
Farve nvarchar(50)
)

INSERT INTO BIL (Maerke,Farve)
VALUES ('Mercedes','Grøn')

INSERT INTO BIL (Maerke,Farve)
VALUES ('BMW','Rød')

INSERT INTO BIL (Maerke,Farve)
VALUES ('Mazda','Hvid')

INSERT INTO BIL (Maerke,Farve)
VALUES ('Toyota','Blå')

SELECT * FROM BIL
