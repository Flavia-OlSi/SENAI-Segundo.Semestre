-- Usando o banco de daods
USE Gufi_manha;
GO

INSERT INTO tiposUsuarios	(tituloTipoUsuario)
VALUES						('Administrador'),
							('Comum');
GO

INSERT INTO	usuarios	(idTipoUsuario, nomeUsuario, email, senha)
VALUES					(1, 'Administrador', 'adm@adm.com', 'adm123'),
						(2, 'Caique', 'caique@email.com', 'caique123'),
						(2, 'Saulo', 'saulo@email.com', 'saulo123');
GO

INSERT INTO instituicoes	(cnpj, nomeFantasia, endereco)
VALUES						('999999999999', 'Escola SENAI de Informática', 'Al. Barão de Limeira, 538');
GO

INSERT INTO tiposEventos	(tituloTipoEvento)
VALUES						('C#')