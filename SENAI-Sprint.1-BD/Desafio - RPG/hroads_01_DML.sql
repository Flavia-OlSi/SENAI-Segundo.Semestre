-- Selecionando o banco de dados
Use SENAI_HROADS_MANHA;

-- Inserindo dados na tabela Tipo
INSERT INTO Tipo	(Nome)
VALUES				('Ataque'),
					('Defesa'),
					('Cura'),
					('Magia');

-- Inserindo dados na tabela Habilidades
INSERT INTO Habilidades	(Nome, idTipo)
VALUES					('Lança Mortal', 1),
						('Escudo Supremo', 2),
						('Recuperar Vida', 3);

-- Inserindo dados na tabela Classes
INSERT INTO Classes	(Nome)
VALUES				('Bárbaro'),
					('Cruzado'),
					('Caçadora de demônios'),
					('Monge'),
					('Necromante'),
					('Feiticeiro'),
					('Arcanista');

-- Inserindo dados na tabela ClasseHabilidade
INSERT INTO ClasseHabilidade	(idClasse,	idHabilidades)
VALUES							(1, 1),
								(1, 2),
								(2, 2),
								(3, 1),
								(4, 2),
								(4, 3),
								(6, 3);


-- Inserindo dados na tabela Personagens
INSERT INTO Personagens	(Nome, [Capacidade maxima Vida], [Capacidade maxima Mana], [Data de Atualização], [Data de criação], idClasse)
VALUES					('DeuBug', 100, 80, '01/03/2021', '18/01/2019', 1),
						('BitBug', 70, 100, '01/03/2021', '17/03/2016', 4),
						('Fer8', 75, 60, '01/03/2021', '18/03/2019', 7);


-- Atualizando o nome do personagem
UPDATE Personagens
SET Nome = 'Fer7'
WHERE idPersonagem = 3;

-- Atualizando o nome da classe
UPDATE Classes
SET Nome = 'Necromancer'
WHERE idClasse = 5;

