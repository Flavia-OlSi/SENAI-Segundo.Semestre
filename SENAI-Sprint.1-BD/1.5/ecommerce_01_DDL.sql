-- Criando o banco de dados ecommerce
Create Database Ecommerce;

-- Selecionando e usando o banco de datas ecommerce
Use Ecommerce;

-- Criando a tabela Cliente
Create Table Cliente
(
	idCliente	INT	Primary Key Identity,
	Nome		varchar(150) NOT NULL
);

-- Criando a tabela Loja
Create Table Loja
(
	idLoja		INT	Primary Key Identity,
	Nome		varchar(200) NOT NULL,
	Endereco	varchar(350) NOT NULL
);

-- Criando a tabela Categoria
Create Table Categoria
(
	idCategoria	INT	Primary Key Identity,
	Nome		varchar(200) NOT NULL,
	idLoja		INT Foreign Key References Loja (idLoja)
);

-- Criando a tabela Subcategoria
Create Table Subcategoria
(
	idSubcategoria	INT	Primary Key Identity,
	Nome			varchar(200) NOT NULL,
	idCategoria		INT Foreign Key References Categoria (idCategoria)
);

-- Criando a tabela Produto
Create Table Produto
(
	idProduto		INT	Primary Key Identity,
	Identificacao	varchar(200) NOT NULL,
	idSubcategoria	INT Foreign Key References Subcategoria (idSubcategoria)
);

-- Criando a tabela Pedido
Create Table Pedido
(
	idPedido			INT	Primary Key Identity,
	DataPedido			DATE NOT NULL,
	idCliente			INT Foreign Key References Cliente (idCliente),
	idProduto			INT Foreign Key References Produto (idProduto)
);

