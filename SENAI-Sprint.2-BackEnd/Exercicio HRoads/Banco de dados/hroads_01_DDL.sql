-- Criando o banco de dados
CREATE DATABASE SENAI_HROADS_MANHA;
GO

-- Selecionando o banco de dados
Use SENAI_HROADS_MANHA;
GO

-- Criando a tabela Tipos de usuarios
CREATE TABLE TiposDeUsuarios
(
	idTipoDeUsuario	INT PRIMARY KEY IDENTITY,
	Nome			VARCHAR(150) NOT NULL,
);
GO

-- Ciando a tabela Usuarios
CREATE TABLE Usuarios
(
	idUsuario			INT PRIMARY KEY IDENTITY,
	Email				VARCHAR(100) NOT NULL UNIQUE,
	Senha				VARCHAR(20) NOT NULL,
	idTipoDeUsuario		INT FOREIGN KEY REFERENCES TiposDeUsuarios (idTipoDeUsuario) NOT NULL
);
GO

-- Criando a tabela Tipos de Habilidades
CREATE TABLE TiposDeHabilidades
(
	idTipoDeHabilidade	INT PRIMARY KEY IDENTITY,
	Nome				VARCHAR(50) NOT NULL
);
GO

-- Criando a tabela Habilidades
CREATE TABLE Habilidades
(
	idHabilidades			INT PRIMARY KEY IDENTITY,
	Nome					VARCHAR(150) NOT NULL,
	idTipoDeHabilidade		INT FOREIGN KEY REFERENCES TiposDeHabilidades (idTipoDeHabilidade) NOT NULL
);
GO

-- Criando a tabela Classes
CREATE TABLE Classes
(
	idClasse	INT PRIMARY KEY IDENTITY,
	Nome		VARCHAR(150) NOT NULL
);
GO

-- Criando a tabela Classe Habilidades
CREATE TABLE ClasseHabilidade
(
	idClasse		INT FOREIGN KEY REFERENCES Classes (idClasse),
	idHabilidades	INT FOREIGN KEY REFERENCES Habilidades (idHabilidades)
);
GO

-- Criando a tabela Personagens
CREATE TABLE Personagens
(
	idPersonagem			INT PRIMARY KEY IDENTITY,
	Nome					VARCHAR(150) NOT NULL,
	CapacidadeMaximaVida	INT NOT NULL,
	CapacidadeMaximaMana	INT NOT NULL,
	DataDeAtualizacao		DATE NOT NULL,
	DataDeCriacao			DATE NOT NULL,
	idClasse				INT FOREIGN KEY REFERENCES Classes (idClasse),
	idUsuario				INT FOREIGN KEY REFERENCES Usuarios (idUsuario)
);
GO