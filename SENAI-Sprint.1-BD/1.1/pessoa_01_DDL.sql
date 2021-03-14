-- Criando o banco de dados Pessoa
Create Database Pessoa;

-- Selecionando e usando o banco de datas Pessoas
Use Pessoa;

-- Criando a tabela Pessoa
Create Table Pessoa
(
	idPessoa	INT Primary Key Identity,
	Nome		VARCHAR(100) NOT NULL,
	CNH			INT
);

-- Criando a tabela Telefone
Create Table Telefone 
(
	idTelefone	INT Primary Key Identity,
	Telefone	CHAR(9) NOT NULL,
	idPessoa	INT Foreign Key References Pessoa (idPessoa)
);

-- Criando a tabela Email
Create Table Email 
(
	idEmail		INT Primary Key Identity,
	Email		varchar(150) NOT NULL,
	idPessoa	INT Foreign Key References Pessoa (idPessoa)
);

