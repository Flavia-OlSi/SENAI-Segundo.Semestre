-- Selecionando e usando o banco de datas filmes
Use Filmes;

-- Inserindo dados nas tabelas
INSERT INTO Generos	(Nome)
VALUES				('Romance'),
					('Com�dia');

INSERT INTO Filmes	(Titulo, idGenero)
VALUES				('Orgulho e preconceito', 1),
					('As branquelas', 2),
					('Coincid�ncias do amor', 1);

-- Inserindo dados nas tabelas
INSERT INTO Generos	(Nome)
VALUES				('A��o');
					
INSERT INTO Filmes	(Titulo, idGenero)
VALUES				('Shrek', NULL);
										
