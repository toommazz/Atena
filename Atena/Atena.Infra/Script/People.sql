-- Atena.dbo.TbPeople definition

-- Drop table

-- DROP TABLE Atena.dbo.TbPeople;

CREATE TABLE Atena.dbo.TbPeople (
	Id uniqueidentifier NOT NULL,
	Name varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Lastname varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Included datetime NOT NULL,
	Updated datetime NULL,
	Status varchar(2) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT People_PK PRIMARY KEY (Id)
);