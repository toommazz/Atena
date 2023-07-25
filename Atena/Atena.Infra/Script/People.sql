-- Atena.dbo.TbPeople definition

-- Drop table

-- DROP TABLE Atena.dbo.TbPeople;

CREATE TABLE Atena.dbo.TbPeople (
	Id uniqueidentifier NOT NULL,
	Name varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Status varchar(2) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	PersonTypeId uniqueidentifier NOT NULL,
	GenderTypeId uniqueidentifier NOT NULL,
	MaritalStatusTypeId uniqueidentifier NOT NULL,
	Lastname varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Included datetime NOT NULL,
	Updated datetime NULL
	CONSTRAINT People_PK PRIMARY KEY (Id)
);


-- Atena.dbo.TbPeople foreign keys

ALTER TABLE Atena.dbo.TbPeople ADD CONSTRAINT TbPeople_FK FOREIGN KEY (PersonTypeId) REFERENCES Atena.dbo.PersonType(Id);
ALTER TABLE Atena.dbo.TbPeople ADD CONSTRAINT TbPeople_GenderTypeFK FOREIGN KEY (GenderTypeId) REFERENCES Atena.dbo.GenderType(Id);
ALTER TABLE Atena.dbo.TbPeople ADD CONSTRAINT TbPeople_MaritalStatus_FK FOREIGN KEY (MaritalStatusTypeId) REFERENCES Atena.dbo.MaritalStatusType(Id);