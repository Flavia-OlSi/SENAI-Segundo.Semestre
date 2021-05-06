-- Usando o banco de dados
USE inlock_games_manha;
GO

-- Listando a tabela Tipos
SELECT * FROM Tipos;

-- Listando a tabela Usuarios
SELECT * FROM Usuarios;

-- Listando a tabela Estudios
SELECT * FROM Estudios;

-- Listando a tabela Jogos
SELECT * FROM Jogos;

-- Listando todos os jogos e seus respectivos estudios
SELECT idJogo, nomeJogo AS [Nome do jogo], descricao AS [Descrição], dataLancamento AS [Data de lançamento], valor AS Valor, nomeEstudio AS [Nome do Estúdio] FROM Jogos
LEFT JOIN Estudios
ON Jogos.idEstudio = Estudios.idEstudio;

-- Listando todos os estúdios com os respectivos jogos
SELECT * FROM Estudios
LEFT JOIN Jogos
ON Estudios.idEstudio = Jogos.idEstudio;

-- Buscar um usuario por e-mail e senha
SELECT * FROM Usuarios WHERE email = 'admin@admin.com' AND senha = 'admin';

-- Buscar um jogo por idJogo
SELECT * FROM Jogos	WHERE idJogo = 1;

-- Buscar um estudio por idEstudio
SELECT * FROM Estudios	WHERE idEstudio = 1;

