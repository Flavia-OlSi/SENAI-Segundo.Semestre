-- Criando o banco de dados Locadora
Create Database Locadora;

-- Selecionando e usando o banco de datas Locadora
Use Locadora;

-- Criando a tabela Empresa
Create Table Empresa
(
	idEmpresa	INT Primary Key Identity,
	Nome		VARCHAR(150) NOT NULL,
	CNPJ		CHAR(18) NOT NULL
);

-- Criando a tabela Cliente
Create Table Cliente
(
	idCliente	INT Primary Key Identity,
	Nome		VARCHAR(150) NOT NULL,
	Idade		INT NOT NULL
);

-- Criando a tabela Marca
Create Table Marca
(
	idMarca		INT Primary Key Identity,
	Nome		VARCHAR(100) NOT NULL
);

-- Criando a tabela Modelo
Create Table Modelo
(
	idModelo	INT Primary Key Identity,
	Nome		VARCHAR(100) NOT NULL,
	idMarca		INT Foreign Key References Marca (idMarca)
);


-- Criando a tabela Veículos
Create Table Veiculos
(
	idVeiculo	INT Primary Key Identity,
	Placa		CHAR(6) NOT NULL,
	idEmpresa	INT Foreign Key References Empresa (idEmpresa),
	idModelo	INT Foreign Key References Modelo (idModelo)
);

-- Criando a tabela Aluguel
Create Table Aluguel
(
	idAluguel			INT Primary Key Identity,
	[Dia da retirada]	DATE NOT NULL,
	[Dia da devolução]	DATE NOT NULL,
	idCliente			INT Foreign Key References Cliente (idCliente),
	idVeiculo			INT Foreign Key References Veiculos (idVeiculo)
);

