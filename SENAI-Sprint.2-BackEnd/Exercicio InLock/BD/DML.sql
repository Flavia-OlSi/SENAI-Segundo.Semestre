-- Usando o banco de dados
USE inlock_games_manha;
GO

-- Inserindo dados na tabela Estudios
INSERT INTO Estudios	(nomeEstudio)
VALUES					('Blizzard'),
						('Rockstar Studios'),
						('Square Enix');
GO

-- Inserindo dados na tabela Jogos
INSERT INTO Jogos	(nomeJogo, descricao, dataLancamento, valor, idEstudio)
VALUES				('Diablo 3', '� um jogo que cont�m bastante a��o e � viciante, seja voc� um novato ou um f�.', '2012-05-15', 99.00, 1),
					('Red Dead Redemption II', 'Jogo eletr�nico de a��o-aventura western.', '2018-10-26', 120.00, 2);
GO

-- Inserindo dados na tabela Tipos
INSERT INTO Tipos	(titulo)
VALUES				('Administrador'),
					('Cliente');
GO

-- Inserindo dados na tabela Usuarios
INSERT INTO Usuarios	(email, senha, idTipoUsuario)
VALUES					('admin@admin.com', 'admin', 1),
						('cliente@cliente.com', 'cliente', 2);
GO