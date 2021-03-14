-- Criando o banco de dados PClinics
Create Database PClinics;

-- Selecionando e usando o banco de datas PClinics
Use PClinics;

-- Criando a tabela Tipo
Create Table Tipo
(
	idTipo		INT	Primary Key Identity,
	Nome		VARCHAR(150) NOT NULL
);

-- Criando a tabela Dono
Create Table Dono
(
	idDono		INT	Primary Key Identity,
	Nome		VARCHAR(150) NOT NULL
);

-- Criando a tabela Raça
Create Table Raca
(
	idRaca		INT	Primary Key Identity,
	Nome		VARCHAR(150) NOT NULL,
	idTipo		INT Foreign Key References Tipo (idTipo)
);

-- Criando a tabela Clinica
Create Table Clinica
(
	idClinica	INT	Primary Key Identity,
	Nome		VARCHAR(200) NOT NULL,
	CNPJ		CHAR(18) NOT NULL,
	Endereco	VARCHAR(350) NOT NULL
);

-- Criando a tabela Veteninario
Create Table Veteninario
(
	idVeteninario	INT	Primary Key Identity,
	Nome			VARCHAR(150) NOT NULL,
	idClinica		INT Foreign Key References Clinica (idClinica)
);

-- Criando a tabela Pets
Create Table Pets
(
	idPet				INT	Primary Key Identity,
	Nome				VARCHAR(150) NOT NULL,
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

