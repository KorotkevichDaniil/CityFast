create database CityFast
go
use CityFast
go
Create table ���������� (
	id���� int primary key NOT NULL IDENTITY(1,1),
	������� nvarchar(50) NOT NULL ,
	������� nvarchar(50) NOT NULL,
	������ nvarchar(50) NOT NULL
)
go
Create table ������� (
	id�� int primary key NOT NULL IDENTITY(1,1),
	����� nvarchar(50) NOT NULL ,
	����� nvarchar(50) NOT NULL,
	������ nvarchar(50) NOT NULL
)
go
Create table �������� (
	id����� int primary key NOT NULL IDENTITY(1,1),
	�������� nvarchar(50) NOT NULL,
	�������� nvarchar(50) NOT NULL,
	������ nvarchar(50) NOT NULL,
	��������� nvarchar(50) NOT NULL,
	��������� nvarchar(50) NOT NULL
)
go
create table ������ (
	id������ int primary key NOT NULL IDENTITY(1,1),
	������������ bit NOT NULL ,
	������������ time NULL,
	������� nvarchar(50) NOT NULL, 
	����� nvarchar(50) NOT NULL, 
	��������� nvarchar(50) NULL, 
	������� nvarchar(50) NOT NULL, 
	����� nvarchar(50) NOT NULL, 
	��������� nvarchar(50) NULL, 
	�������� bit NOT NULL,
	�������� nvarchar(50) NULL, 
	������ nvarchar(50) NULL, 
	���������� nvarchar(50) NULL, 
	��������������� bit NOT NULL,
	����������� bit NOT NULL,
	������������� int NULL,
	���������� bit NOT NULL,
	��������� int NOT NULL,
	id���� int NOT NULL,
	id�� int NOT NULL,
	id����� int NOT NULL,
	CONSTRAINT FK_id���� FOREIGN KEY (id����) REFERENCES ����������(id����),
	CONSTRAINT FK_id�� FOREIGN KEY (id��) REFERENCES �������(id��),
	CONSTRAINT FK_id����� FOREIGN KEY (id�����) REFERENCES ��������(id�����)
)