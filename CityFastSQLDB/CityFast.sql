create database CityFast
go
use CityFast
go
Create table ƒиспетчеры (
	idƒисп int primary key NOT NULL IDENTITY(1,1),
	фиоƒисп nvarchar(50) NOT NULL ,
	телƒисп nvarchar(50) NOT NULL,
	пароль nvarchar(50) NOT NULL
)
go
Create table  лиенты (
	id л int primary key NOT NULL IDENTITY(1,1),
	фио л nvarchar(50) NOT NULL ,
	тел л nvarchar(50) NOT NULL,
	пароль nvarchar(50) NOT NULL
)
go
Create table ¬одители (
	id¬одит int primary key NOT NULL IDENTITY(1,1),
	фио¬одит nvarchar(50) NOT NULL,
	тел¬одит nvarchar(50) NOT NULL,
	пароль nvarchar(50) NOT NULL,
	маркајвто nvarchar(50) NOT NULL,
	номерјвто nvarchar(50) NOT NULL
)
go
create table «аказы (
	id«аказа int primary key NOT NULL IDENTITY(1,1),
	срочный«аказ bit NOT NULL ,
	врем€ѕриезда time NULL,
	улицаќт nvarchar(50) NOT NULL, 
	домќт nvarchar(50) NOT NULL, 
	подъездќт nvarchar(50) NULL, 
	улицаƒо nvarchar(50) NOT NULL, 
	домƒо nvarchar(50) NOT NULL, 
	подъездƒо nvarchar(50) NULL, 
	допјдрес bit NOT NULL,
	улицаƒоп nvarchar(50) NULL, 
	домƒоп nvarchar(50) NULL, 
	подъездƒоп nvarchar(50) NULL, 
	перевозка∆ивотн bit NOT NULL,
	детск ресло bit NOT NULL,
	¬озраст–ебЄнка int NULL,
	некур—алон bit NOT NULL,
	—тоимость int NOT NULL,
	idƒисп int NOT NULL,
	id л int NOT NULL,
	id¬одит int NOT NULL,
	CONSTRAINT FK_idƒисп FOREIGN KEY (idƒисп) REFERENCES ƒиспетчеры(idƒисп),
	CONSTRAINT FK_id л FOREIGN KEY (id л) REFERENCES  лиенты(id л),
	CONSTRAINT FK_id¬одит FOREIGN KEY (id¬одит) REFERENCES ¬одители(id¬одит)
)