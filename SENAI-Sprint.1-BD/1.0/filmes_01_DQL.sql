-- Selecionando e usando o banco de datas filmes
Use Filmes;

-- Mostrando dados das tabelas
SELECT * FROM Generos;

SELECT * FROM Filmes;

-- Juntando as tabelas
-- Para mostrar apenas os que as duas tabelas tem em comum
SELECT idFilme AS [Código], Titulo AS Filme, Nome AS Genero FROM Filmes
INNER JOIN Generos
ON Filmes.idGenero = Generos.idGenero;

-- Para mostrar todas da tabela que esta na linha do select
SELECT idFilme AS [Código], Titulo AS Filme, Nome AS Genero FROM Filmes
LEFT JOIN Generos
ON Filmes.idGenero = Generos.idGenero;

-- Para mostrar todos da tabela que esta na linha do JOIN
SELECT idFilme AS [Código], Titulo AS Filme, Nome AS Genero FROM Filmes
RIGHT JOIN Generos
ON Filmes.idGenero = Generos.idGenero;

-- Para mostrar tudo das tabelas mencionadas
SELECT idFilme AS [Código], Titulo AS Filme, Nome AS Genero FROM Filmes
FULL OUTER JOIN Generos
ON Filmes.idGenero = Generos.idGenero;
