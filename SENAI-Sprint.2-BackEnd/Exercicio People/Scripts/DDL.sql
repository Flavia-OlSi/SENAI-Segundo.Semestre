CREATE DATABASE M_Peoples;
GO

USE M_Peoples;
GO

CREATE TABLE Funcionarios(
	idFuncionario		INT PRIMARY KEY IDENTITY,
	Nome				VARCHAR(50) NOT NULL,
	Sobrenome			VARCHAR(150) NOT NULL,
	DataDeNascimento	DATE
);
GO