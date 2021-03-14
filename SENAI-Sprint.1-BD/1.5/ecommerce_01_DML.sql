-- Selecionando e usando o banco de datas ecommerce
Use Ecommerce;

-- Mostrando a tabela Cliente
SELECT * FROM Cliente;

-- Mostrando a tabela Loja
SELECT * FROM Loja;

-- Mostrando a tabela Categoria
SELECT * FROM Categoria;

-- Mostrando a tabela Subcategoria
SELECT * FROM Subcategoria;

-- Mostrando a tabela Produto
SELECT * FROM Produto;

-- Mostrando a tabela Pedido
SELECT * FROM Pedido;

-- Relacionando a tabela Categoria com a tabela Loja
SELECT Categoria.Nome AS Categoria, Loja.Nome AS Loja, Endereco AS [Endereço] FROM Categoria
INNER JOIN Loja
ON Categoria.idLoja = Loja.idLoja;

-- Relacionando a tabela Subcategoria com a tabela Categoria
SELECT Subcategoria.Nome AS Subcategoria, Categoria.Nome AS Categoria FROM Subcategoria
INNER JOIN Categoria
ON Subcategoria.idCategoria = Categoria.idCategoria;

-- Relacionando a tabela Produto com a tabela Subcategoria
SELECT [Identificação] AS Produto, Subcategoria.Nome AS Subcategoria FROM Produto
LEFT JOIN Subcategoria
ON Produto.idSubcategoria = Subcategoria.idSubcategoria;