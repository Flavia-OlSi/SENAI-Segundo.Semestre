-- Criando o banco de dados micromanu
CREATE DATABASE Micromanu;

-- Selecionando e usando o banco de datas micromanu
USE Micromanu;

-- Criando a tabela Cliente
CREATE TABLE Cliente
(
	idCliente	INT	Primary Key Identity,
	Nome		VARCHAR(150) NOT NULL,
	Cpf			VARCHAR(20) NOT NULL
);

-- Criando a tabela Funcionario
CREATE TABLE Funcionario
(
	idFuncionario	INT	Primary Key Identity,
	Nome			VARCHAR(150) NOT NULL,
);

-- Criando a tabela Item
CREATE TABLE Item
(
	idItem		INT	Primary Key Identity,
	[Descrição]	VARCHAR(250) NOT NULL,
);

-- Criando a tabela Tipo
CREATE TABLE Tipo
(
	idTipo			INT	Primary Key Identity,
	[Identificação]	VARCHAR(250) NOT NULL,
);

-- Criando a tabela Pedido
CREATE TABLE Pedido
(
	idPedido			INT	Primary Key Identity,
	[Data de ínicio]	DATE NOT NULL,
	[Data de término]	DATE NOT NULL,
	idCliente			INT Foreign Key References Cliente (idCliente),
	idTipo				INT Foreign Key References Tipo (idTipo),
	idItem				INT Foreign Key References Item (idItem)
);

-- Criando a tabela PedidoFuncionario
CREATE TABLE PedidoFuncionario
(
	idPedido			INT Foreign Key References Pedido (idPedido),
	idFuncionario		INT Foreign Key References Funcionario (idFuncionario)
);

