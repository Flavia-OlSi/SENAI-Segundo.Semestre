-- Criando o banco de dados micromanu
Create Database Micromanu;

-- Selecionando e usando o banco de datas micromanu
Use Micromanu;

-- Criando a tabela Cliente
Create Table Cliente
(
	idCliente	INT	Primary Key Identity,
	Nome		varchar(150) NOT NULL,
	CPF			INT NOT NULL
);

-- Criando a tabela Funcionario
Create Table Funcionario
(
	idFuncionario	INT	Primary Key Identity,
	Nome			varchar(150) NOT NULL,
);

-- Criando a tabela Item
Create Table Item
(
	idItem		INT	Primary Key Identity,
	Descricao	varchar(250) NOT NULL,
);

-- Criando a tabela Tipo
Create Table Tipo
(
	idTipo			INT	Primary Key Identity,
	Identificacao	varchar(250) NOT NULL,
);

-- Criando a tabela Pedido
Create Table Pedido
(
	idPedido			INT	Primary Key Identity,
	DataInicio			DATE NOT NULL,
	DataTermino			DATE NOT NULL,
	idCliente			INT Foreign Key References Cliente (idCliente),
	idTipo				INT Foreign Key References Tipo (idTipo),
	idItem				INT Foreign Key References Item (idItem)
);

-- Criando a tabela PedidoFuncionario
Create Table PedidoFuncionario
(
	idPedido			INT Foreign Key References Pedido (idPedido),
	idFuncionario		INT Foreign Key References Funcionario (idFuncionario)
);

-- Selecionando e usando o banco de datas micromanu
Use Micromanu;

-- Inserindo dados na tabela Cliente
INSERT INTO Cliente (Nome, CPF)
VALUES				('José', 11122233344),
					('Luiz', 44455566677),
					('Marcos', 77788899900);