-- Selecionando e usando o banco de datas PClinics
Use PClinics;

-- Mostrando a tabela Clinica
SELECT * FROM Clinica;

-- Mostrando a tabela Veteninario
SELECT * FROM Veteninario;

-- Mostrando a tabela Tipo
SELECT * FROM Tipo;

-- Mostrando a tabela Raca
SELECT * FROM Raca;

-- Mostrando a tabela Dono
SELECT * FROM Dono;

-- Mostrando a tabela Pets
SELECT Nome, DataDeNascimento AS [Data de nascimento], idRaca FROM Pets;

-- Mostrando a tabela DonosPet
SELECT * FROM DonosPet;

-- Mostrando a tabela Atendimento
SELECT idAtendimento, DataDeAtendimento AS [Data de atendimento], idPet FROM Atendimento;

-- Relacionando a tabela Raca com a tabela Tipo (todos os da tabela Raca independente da tabela Tipo)
SELECT idRaca, Raca.Nome AS [Raça], Tipo.Nome AS [Tipo de animal] FROM Raca
LEFT JOIN Tipo
ON Raca.idTipo = Tipo.idTipo;

-- Relacionando a tabela Pets com a tabela Raca (todos os Pets e todos as Raças)
SELECT idPet, Pets.Nome AS [Nome do pet], DataDeNascimento AS [Data de nascimento], Raca.Nome AS [Raça] FROM Pets
FULL OUTER JOIN Raca
ON Pets.idRaca = Raca.idRaca;

-- Relacionando a tabela Atendimento com a tabela Pets
SELECT idAtendimento, DataDeAtendimento AS [Data de atendimento], Pets.Nome FROM Atendimento
INNER JOIN Pets
ON Atendimento.idPet = Pets.idPet;