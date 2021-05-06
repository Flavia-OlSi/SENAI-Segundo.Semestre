-- Criando o banco de dados
CREATE DATABASE inlock_games_manha;
GO

-- Usando o banco de dados
USE inlock_games_manha;
GO

-- Criando tabela Estudios
CREATE TABLE Estudios (
	idEstudio	INT PRIMARY KEY IDENTITY,
	nomeEstudio	VARCHAR(50)
);
GO

-- Criando tabela Jogos
CREATE TABLE Jogos (
	idJogo			INT PRIMARY KEY IDENTITY,
	nomeJogo		VARCHAR(100),
	descricao		VARCHAR(400),
	dataLancamento	DATE,
	valor			DECIMAL(5,2),
	idEstudio		INT FOREIGN KEY REFERENCES Estudios (idEstudio)
);
GO

-- Criando tabela Tipos
CREATE TABLE Tipos (
	idTipoUsuario	INT PRIMARY KEY IDENTITY,
	titulo			VARCHAR(50)
);
GO

-- Criando tabela Usuarios
CREATE TABLE Usuarios (
	idUsuario		INT PRIMARY KEY IDENTITY,
	email			VARCHAR(100),
	senha			VARCHAR(15),
	idTipoUsuario	INT FOREIGN KEY REFERENCES Tipos (idTipoUsuario)
);
GO
