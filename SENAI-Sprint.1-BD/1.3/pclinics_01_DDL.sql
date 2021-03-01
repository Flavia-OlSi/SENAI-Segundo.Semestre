-- Criando o banco de dados PClinics
Create Database PClinics;

-- Selecionando e usando o banco de datas PClinics
Use PClinics;

-- Criando a tabela Tipo
Create Table Tipo
(
	idTipo		INT	Primary Key Identity,
	Nome		varchar(150) NOT NULL
);

-- Criando a tabela Dono
Create Table Dono
(
	idDono		INT	Primary Key Identity,
	Nome		varchar(150) NOT NULL
);

-- Criando a tabela Raça
Create Table Raca
(
	idRaca		INT	Primary Key Identity,
	Nome		varchar(150) NOT NULL,
	idTipo		INT Foreign Key References Tipo (idTipo)
);

-- Criando a tabela Clinica
Create Table Clinica
(
	idClinica	INT	Primary Key Identity,
	Nome		varchar(200) NOT NULL,
	CNPJ		INT NOT NULL,
	Endereco	varchar(350) NOT NULL
);

-- Criando a tabela Veteninario
Create Table Veteninario
(
	idVeteninario	INT	Primary Key Identity,
	Nome			varchar(150) NOT NULL,
	idClinica		INT Foreign Key References Clinica (idClinica)
);

-- Criando a tabela Pets
Create Table Pets
(
	idPet				INT	Primary Key Identity,
	Nome				varchar(150) NOT NULL,
	DataDeNascimento	DATE NOT NULL,
	idRaca				INT Foreign Key References Raca (idRaca)
);

-- Criando a tabela DonosPet
Create Table DonosPet
(
	idPet				INT Foreign Key References Pets (idPet),
	idDono				INT Foreign Key References Dono (idDono)
);

-- Criando a tabela Atendimento
Create Table Atendimento
(
	idAtendimento		INT	Primary Key Identity,
	DataDeAtendimento	DATE NOT NULL,
	idPet				INT Foreign Key References Pets (idPet)
);

-- Selecionando e usando o banco de datas PClinics
Use PClinics;

-- Inserindo dados nas tabelas
INSERT INTO Clinica	(Nome, CNPJ, Endereco)
VALUES				('Pets', 0553346, 'Rua Batuíra, 893 - SBC'),
					('DogMiau', 3067019, 'Av. Lemos Monteiro, 82 - SCS'),
					('Cobasi', 5315260, 'Rua Guilhermina, 550 - SA');

INSERT INTO Veteninario	(Nome, idClinica)
VALUES					('Flávia', 2),
						('Isabella', 1),
						('Gabriel', 3);

select * from Clinica;

