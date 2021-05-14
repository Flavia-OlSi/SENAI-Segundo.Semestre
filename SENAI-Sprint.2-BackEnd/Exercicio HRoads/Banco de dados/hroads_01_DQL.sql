-- Selecionando o banco de dados
Use SENAI_HROADS_MANHA;

-- Selecionando todos os personagens
SELECT * FROM Personagens;

-- Selecionando todas as classes
SELECT * FROM Classes;

-- Selecinonando somente o nome das classes
SELECT Nome AS Classes
FROM Classes;

-- Selecionando todas as habilidade
SELECT Nome AS Habilidades
FROM Habilidades;

-- Realizando a contagem de quantas habilidades estão cadastradas
SELECT COUNT(idPersonagem) FROM Personagens;

-- Selecionando todos os id's das habilidades em ordem crescente
SELECT idHabilidades
FROM Habilidades
ORDER BY idHabilidades ASC;

-- Selecionando todos os tipos de habilidades
SELECT * FROM TiposDeHabilidades;

-- Selecionando todas as habilidades e os tipos de habilidades que elas fazem parte
SELECT Habilidades.Nome AS Habilidades, TiposDeHabilidades.Nome AS [Tipos de Habilidades] FROM Habilidades
LEFT JOIN TiposDeHabilidades
ON Habilidades.idTipoDeHabilidade = TiposDeHabilidades.idTipoDeHabilidade;

-- Selecionando todos os personagens e suas respectivas classes
SELECT Personagens.Nome AS Personagem, CapacidadeMaximaVida AS [Capacidade maxima Vida], CapaciadadeMaximaMana AS [Capacidade maxima Mana], DataDeAtualizacao AS [Data de Atualização], DataDeCriacao AS [Data de criação], Classes.Nome AS Classe FROM Personagens
LEFT JOIN Classes
ON Personagens.idClasse = Classes.idClasse;

-- Selecionando todos os personagens e as classes (mesmo que elas não tenham correspondência em personagens)
SELECT Personagens.Nome AS Personagem, Classes.Nome AS Classe FROM Personagens
FULL OUTER JOIN Classes
ON Personagens.idClasse = Classes.idClasse;

-- Selecionando todas as classes e suas respectivas habilidades
SELECT Classes.Nome AS Classe, Habilidades.Nome AS Habilidades FROM ClasseHabilidade
LEFT JOIN Classes
ON Classes.idClasse = ClasseHabilidade.idClasse
LEFT JOIN Habilidades
ON Habilidades.idHabilidades = ClasseHabilidade.idHabilidades;

-- Selecionar todas as habilidades e suas classes (somente as que possuem correspondência)
SELECT Habilidades.Nome AS Habilidades, Classes.Nome AS Classe FROM ClasseHabilidade
INNER JOIN Habilidades
ON Habilidades.idHabilidades = ClasseHabilidade.idHabilidades
INNER JOIN Classes
ON Classes.idClasse = ClasseHabilidade.idClasse;

-- Selecionar todas as habilidades e suas classes (mesmo que elas não tenham correspondência)
SELECT Habilidades.Nome AS Habilidades, Classes.Nome AS Classe FROM ClasseHabilidade
FULL OUTER JOIN Habilidades
ON Habilidades.idHabilidades = ClasseHabilidade.idHabilidades
FULL OUTER JOIN Classes
ON Classes.idClasse = ClasseHabilidade.idClasse;



