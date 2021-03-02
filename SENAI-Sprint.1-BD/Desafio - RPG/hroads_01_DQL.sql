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

-- Selecionando todos os id's das habilidades em ordem crescente
SELECT idHabilidades
FROM Habilidades
ORDER BY idHabilidades ASC;

-- Selecionando todos os tipos de habilidades
SELECT * FROM Tipo;

-- Selecionando todas as habilidades e os tipos de habilidades que elas fazem parte
SELECT * FROM Habilidades;

-- Selecionando todos os personagens e suas respectivas classes
