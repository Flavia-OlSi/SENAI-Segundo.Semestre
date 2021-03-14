-- Selecionando e usando o banco de datas PClinics
USE Optus;

-- Mostrando a tabela Artista
SELECT * FROM Artista;

-- Mostrando a tabela Estilo
SELECT * FROM Estilo;

-- Mostrando a Album
SELECT * FROM Album;

-- Mostrando a EstiloAlbum
SELECT * FROM EstiloAlbum;

-- Mostrando a tabela Usuario
SELECT * FROM Usuario;

-- Relacionando a tabela album com artista (todos os albuns independente da tabela artista)
SELECT Titulo, Nome FROM Album
LEFT JOIN Artista
ON Album.idArtista = Artista.idArtista;