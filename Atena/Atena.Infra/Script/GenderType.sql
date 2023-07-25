-- Atena.dbo.GenderType definition

-- Drop table

-- DROP TABLE Atena.dbo.GenderType;

CREATE TABLE Atena.dbo.GenderType (
	Id uniqueidentifier NOT NULL,
	Name varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Description varchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Included datetime NOT NULL,
	Updated datetime NULL,
	Status varchar(2) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT GenderType_PK PRIMARY KEY (Id)
);