-- Selecionando e usando o banco de datas micromanu
USE Micromanu;

-- Mostrando a tabela Cliente
SELECT * FROM Cliente;

-- Mostrando a tabela Funcionario
SELECT * FROM Funcionario;

-- Mostrando a tabela Item
SELECT * FROM Item;

-- Mostrando a tabela Tipo
SELECT * FROM Tipo;

-- Mostrando a tabela Pedido
SELECT * FROM Pedido;

-- Mostrando a tabela PedidoFuncionario
SELECT * FROM PedidoFuncionario;

-- Relacionando a tabela Pedido com a tabela Cliente
SELECT [Data de ínicio], [Data de término], Cliente.Nome FROM Pedido
INNER JOIN Cliente
ON Pedido.idCliente = Cliente.idCliente;

-- Relacionando a tabela Pedido com a tabela Tipo
SELECT [Data de ínicio], [Data de término], Tipo.Identificação FROM Pedido
INNER JOIN Tipo
ON Pedido.idTipo = Tipo.idTipo;

-- Relacionando a tabela Pedido com a tabela Item
SELECT [Data de ínicio], [Data de término], Item.Descrição FROM Pedido
INNER JOIN Item
ON Pedido.idItem = Item.idItem;