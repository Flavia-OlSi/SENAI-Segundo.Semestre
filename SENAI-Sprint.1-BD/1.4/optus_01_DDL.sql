-- Criando o banco de dados optus
Create Database Optus;

-- Selecionando e usando o banco de datas PClinics
Use Optus;

-- Criando a tabela Artista
Create Table Artista
(
	idArtista	INT	Primary Key Identity,
	Nome		varchar(150) NOT NULL
);

-- Criando a tabela Estilo
Create Table Estilo
(
	idEstilo	INT	Primary Key Identity,
	Nome		varchar(150) NOT NULL
);

-- Criando a tabela EstiloAlbum
Create Table EstiloAlbum
(
	idArtista	INT Foreign Key References Artista (idArtista),
	idEstilo	INT Foreign Key References Estilo (idEstilo)
);

-- Criando a tabela Album
Create Table Album
(
	idAlbum				INT	Primary Key Identity,
	Titulo				varchar(150) NOT NULL,
	DataDeLancamento	DATE NOT NULL,
	Localizacao			varchar(350) NOT NULL,
	QtdDeMinutos		TIME NOT NULL,
	StatusAlbum			varchar(50) NOT NULL,
	idArtista			INT Foreign Key References Artista (idArtista)
);