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
	Telefone	INT NOT NULL,
	idPessoa	INT Foreign Key References Pessoa (idPessoa)
);

-- Criando a tabela Email
Create Table Email 
(
	idEmail		INT Primary Key Identity,
	Email		varchar(150) NOT NULL,
	idPessoa	INT Foreign Key References Pessoa (idPessoa)
);

-- Selecionando e usando o banco de datas Pessoas
Use Pessoa;

-- Inserindo dados nas tabelas
INSERT INTO Pessoa	(Nome, CNH)
VALUES				('Flávia', 123),
					('Saulo', 456),
					('Caique', 789);

INSERT INTO Telefone	(Telefone, idPessoa)
VALUES					(10102020, 1),
						(30304040, 1),
						(50506060, 2),
						(70708080, 3),
						(90900000, 2);

INSERT INTO Email	(Email, idPessoa)
VALUES				('flavia@senai.com', 1),
					('saulo@senai.com', 2),
					('caique@senai.com', 3),
					('flavia_gudy@hotmail.com', 1)

-- Mostrando dados das tabelas
SELECT * FROM Pessoa;

SELECT * FROM Telefone;

SELECT * FROM Email;