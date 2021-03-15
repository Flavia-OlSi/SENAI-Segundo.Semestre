-- Selecionando e usando o banco de datas micromanu
USE Micromanu;

-- Inserindo dados na tabela Cliente
INSERT INTO Cliente (Nome, Cpf)
VALUES				('José', '111.222.333-44'),
					('Luiz', '444.555.666-77'),
					('Marcos', '444.555.666-77');

-- Inserindo dados na tabela Funcionario
INSERT INTO Funcionario (Nome)
VALUES					('Victor'),
						('Daniela');

-- Inserindo dados na tabela Item
INSERT INTO	Item	([Descrição])
VALUES				('Notebook'),
					('Celular'),
					('Tablet'),
					('Video game');

-- Inserindo dados na tabela Tipo
INSERT INTO Tipo	([Identificação])
VALUES				('Manutenção'),
					('Limpeza'),
					('Formatação');

-- Inserindo dados na tabela Pedido
INSERT INTO Pedido	([Data de ínicio], [Data de término], idCliente, idTipo, idItem)
VALUES				('05/01/2019', '05/01/2019', 3, 2, 4),
					('10/05/2020', '12/05/2020', 2, 1, 3),
					('30/08/2020', '05/09/2020', 1, 1, 2),
					('23/01/2021', '01/02/2021', 3, 3, 1);

-- Inserindo dados na tabela PedidoFuncionario
INSERT INTO PedidoFuncionario	(idPedido, idFuncionario)
VALUES							(1, 1),
								(2, 2),
								(3, 2),
								(4, 1);