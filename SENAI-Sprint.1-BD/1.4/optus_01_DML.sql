-- Selecionando e usando o banco de datas PClinics
USE Optus;

-- Inserindo valores na tabela Artista
INSERT INTO Artista	(Nome)
VALUES				('The Drums'),
					('Aerosmith'),
					('Taylor Swift');

-- Inserindo valores na tabela Estilo
INSERT INTO Estilo	(Nome)
VALUES				('Indie'),
					('Rock'),
					('Pop');

-- Insert valores na tabela Album
INSERT INTO Album	(Titulo, [Data de lancamento], Localizacao, [Quantidade de minutos], [Status], idArtista)
VALUES				('Chronicles', '05/02/2005', 'Boston', 60, 'Ativo', 2),
					('Big ones', '12/01/1994', 'Boston', 75, 'Ativo', 2),
					('Evermore', '20/07/2020', 'Pensilvânia', 55, 'Ativo', 3),
					('Lover', '30/04/2019', 'Pensilvânia', 42, 'Ativo', 3),
					('Portamento', '19/09/2011', 'Nova Iorque', 50, 'Ativo', 1);


-- Inserindo valores na tabela EstiloAlbum
INSERT INTO EstiloAlbum	(idAlbum, idEstilo)
VALUES					(1, 2),
						(1, 3),
						(2, 2),
						(3, 3),
						(4, 3),
						(5, 1),
						(5, 3);

-- Inserindo valores na tabela Usuario 						
INSERT INTO Usuario	(Nome, Email, Senha, [Tipo de permissão])
VALUES				('Flávia', 'flavia@email.com', '123', 'Administrador'),
					('Fabíola', 'fabiola@email.com', '456', 'Comum');
				