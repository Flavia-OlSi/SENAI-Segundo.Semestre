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

