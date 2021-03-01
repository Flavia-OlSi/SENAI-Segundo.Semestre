-- Criando o banco de dados Locadora
Create Database Locadora;

-- Selecionando e usando o banco de datas Locadora
Use Locadora;

-- Criando a tabela Empresa
Create Table Empresa
(
	idEmpresa	INT Primary Key Identity,
	Nome		VARCHAR(150) NOT NULL,
	CNPJ		INT NOT NULL
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
	idMarca	INT Primary Key Identity,
	Nome		VARCHAR(100) NOT NULL
);

-- Criando a tabela Modelo
Create Table Modelo
(
	idModelo	INT Primary Key Identity,
	Nome		VARCHAR(100) NOT NULL,
	idMarca	INT Foreign Key References Marca (idMarca)
);


-- Criando a tabela Veículos
Create Table Veiculos
(
	idVeiculo	INT Primary Key Identity,
	Placa		INT NOT NULL,
	idEmpresa	INT Foreign Key References Empresa (idEmpresa),
	idModelo	INT Foreign Key References Modelo (idModelo)
);

Create Table Aluguel
(
	idAluguel			INT Primary Key Identity,
	DiaDaRetirada		DATE NOT NULL,
	DiaDaDevolução		DATE NOT NULL,
	idCliente			INT Foreign Key References Cliente (idCliente),
	idVeiculo			INT Foreign Key References Veiculos (idVeiculo)
);

-- Selecionando e usando o banco de datas Locadora
Use Locadora;

-- Inserindo dados nas tabelas
INSERT INTO Empresa (Nome, CNPJ)
VALUES				('Localiza', 16670),
					('Unidas', 04436),
					('Movida', 21314);

INSERT INTO Marca	(Nome)
VALUES				('Honda'),
					('Fiat');

INSERT INTO Cliente (Nome, Idade)
VALUES				('Flávia', 23),
					('Ana', 27),
					('Lucas', 22);

INSERT INTO Modelo	(Nome, idMarca)
VALUES				('Civic', 1),
					('Argo', 2);

INSERT INTO Veiculos	(Placa, idEmpresa, idModelo)
VALUES					(111111, 1, 1),
						(222222, 2, 1),
						(333333, 3, 2),
						(444444, 2, 2);
