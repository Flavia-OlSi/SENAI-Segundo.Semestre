-- Criando o banco de dados Filmes
Create Database Filmes;

-- Selecionando e usando o banco de datas filmes
Use Filmes;

-- Criando a tabela Generos
-- Identity incrementa um número inteiro sequêncial
Create Table Generos
(
	idGenero	INT	Primary Key Identity,
	Nome		varchar(200) NOT NULL -- Não nulo
);

Create table Filmes
(
	idFilme		INT Primary Key Identity,
	idGenero	INT Foreign Key References Generos (idGenero),
	Titulo VARCHAR(150) NOT NULL
);

-- Selecionando e usando o banco de datas filmes
Use Filmes;

-- Inserindo dados nas tabelas
INSERT INTO Generos	(Nome)
VALUES				('Romance'),
					('Comédia');

INSERT INTO Filmes	(Titulo, idGenero)
VALUES				('Orgulho e preconceito', 1),
					('As branquelas', 2),
					('Coincidências do amor', 1);

-- Mostrando dados das tabelas
SELECT * FROM Generos;

SELECT * FROM Filmes;
					
