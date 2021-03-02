-- Criando o banco de dados
Create Database SENAI_HROADS_MANHA;

-- Selecionando o banco de dados
Use SENAI_HROADS_MANHA;

-- Criando a tabela Tipo de Habilidade
Create Table Tipo
(
	idTipo	INT Primary Key Identity,
	Nome	Varchar(50) NOT NULL
);

-- Criando a tabela Habilidades
Create table Habilidades
(
	idHabilidades	INT Primary Key Identity,
	Nome			Varchar(150) NOT NULL,
	idTipo			INT Foreign Key References Tipo (idTipo) NOT NULL
);

-- Criando a tabela Classes
Create table Classes
(
	idClasse	INT Primary Key Identity,
	Nome		Varchar(150) NOT NULL
);

-- Criando a tabela Classe Habilidades
Create table ClasseHabilidade
(
	idClasse		INT	Foreign Key References Classes (idClasse),
	idHabilidades	INT	Foreign Key References Habilidades (idHabilidades)
);

-- Criando a tabela Personagens
Create table Personagens
(
	idPersonagem				INT Primary Key Identity,
	Nome						Varchar(150) NOT NULL,
	[Capacidade maxima Vida]	INT NOT NULL,
	[Capacidade maxima Mana]	INT NOT NULL,
	[Data de Atualização]		DATE NOT NULL,
	[Data de criação]			DATE NOT NULL,
	idClasse					INT Foreign Key References Classes (idClasse)
);
