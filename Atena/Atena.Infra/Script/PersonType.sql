-- Atena.dbo.PersonType definition

-- Drop table

-- DROP TABLE Atena.dbo.PersonType;

CREATE TABLE Atena.dbo.PersonType (
	Id uniqueidentifier NOT NULL,
	Name varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Description varchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Included datetime NOT NULL,
	Updated datetime NULL,
	Status varchar(2) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT PersonType_PK PRIMARY KEY (Id)
);