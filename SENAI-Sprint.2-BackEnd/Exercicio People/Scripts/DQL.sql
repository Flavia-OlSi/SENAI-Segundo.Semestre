USE M_Peoples;
GO

SELECT * FROM Funcionarios;
GO

-- Busca os funcionários pelo nome
SELECT * FROM Funcionarios
WHERE Nome = 'Catarina';

-- Busca os funcionários trazendo os nomes completos
SELECT CONCAT(Nome, ' ', Sobrenome) AS [Nome completo], DataDeNascimento AS [Data de nascimento] FROM Funcionarios;

-- Ordena os funcionarios em ordem crescente
SELECT Nome, Sobrenome, DataDeNascimento AS [Data de nascimento] FROM Funcionarios
ORDER BY Nome ASC;