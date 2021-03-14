-- Selecionando e usando o banco de datas filmes
Use Filmes;

-- Inserindo dados nas tabelas
INSERT INTO Generos	(Nome)
VALUES				('Romance'),
					('Comédia');

INSERT INTO Filmes	(Titulo, idGenero)
VALUES				('Orgulho e preconceito', 1),
					('As branquelas', 2),
					('Coincidências do amor', 1);

-- Inserindo dados nas tabelas
INSERT INTO Generos	(Nome)
VALUES				('Ação');
					
INSERT INTO Filmes	(Titulo, idGenero)
VALUES				('Shrek', NULL);
										
