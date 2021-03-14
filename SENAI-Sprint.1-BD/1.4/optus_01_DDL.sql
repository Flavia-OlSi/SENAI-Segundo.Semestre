-- Criando o banco de dados optus
CREATE DATABASE Optus;

-- Selecionando e usando o banco de datas PClinics
USE Optus;

-- Criando a tabela Artista
CREATE TABLE Artista
(
	idArtista	INT	Primary Key Identity,
	Nome		VARCHAR(150) NOT NULL
);

-- Criando a tabela Estilo
CREATE TABLE Estilo
(
	idEstilo	INT	Primary Key Identity,
	Nome		VARCHAR(150) NOT NULL
);

-- Criando a tabela EstiloAlbum
CREATE TABLE EstiloAlbum
(
	idAlbum		INT Foreign Key References Album (idAlbum),
	idEstilo	INT Foreign Key References Estilo (idEstilo)
);

-- Criando a tabela Album
CREATE TABLE Album
(
	idAlbum					INT	Primary Key Identity,
	Titulo					VARCHAR(150) NOT NULL,
	[Data de lancamento]	DATE NOT NULL,
	Localizacao				VARCHAR(350) NOT NULL,
	[Quantidade de minutos]	INT NOT NULL,
	[Status]				VARCHAR(50) NOT NULL,
	idArtista				INT Foreign Key References Artista (idArtista)
);

-- Criando a tablea Usuario
CREATE TABLE Usuario
(
	idUsuario			INT Primary Key Identity,
	Nome				VARCHAR(50) NOT NULL,
	Email				VARCHAR(100) NOT NULL,
	Senha				VARCHAR(10) NOT NULL,
	[Tipo de permissão]	VARCHAR(20) NOT NULL
);