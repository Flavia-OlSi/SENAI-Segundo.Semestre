-- Selecionando e usando o banco de datas ecommerce
Use Ecommerce;

-- Inserindo dados na tabela Cliente
INSERT INTO Cliente	(Nome)
VALUES				('Vanessa'),
					('Carlos'),
					('Bruno');

-- Inserindo dados na tabela Loja
INSERT INTO Loja	(Nome, Endereco)
VALUES				('Casas Bahia', 'R. Mal. Deodoro, 1330 - SBC'),
					('Magazine Luiza', 'R. Mal. Deodoro, 952 - SBC');

-- Inserindo dados na tabela Categoria
INSERT INTO Categoria	(Nome, idLoja)
VALUES					('Eletrodomesticos', 2),
						('Informática', 1),
						('Móveis', 2);

-- Inserindo dados na tabela Subcategoria
INSERT INTO Subcategoria	(Nome, idCategoria)
VALUES						('Quarto', 3),
							('Eletroportáteis', 2),
							('Cozinha', 1);

-- Inserindo dados na tabela Produto
INSERT INTO Produto	(Identificação, idSubcategoria)
VALUES				('Fogão', 3),
					('Geladeira', 3),
					('Notebook', 2),
					('Cama', 1);

-- Inserindo dados na tabela Pedido
INSERT INTO Pedido	([Data], idCliente, idProduto)
VALUES				('05/01/2019', 1, 3),
					('10/05/2020', 2, 2),
					('30/08/2020', 3, 1),
					('23/01/2021', 2, 4);