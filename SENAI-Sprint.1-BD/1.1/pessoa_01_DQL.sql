-- Selecionando e usando o banco de datas Pessoas
Use Pessoa;

-- Mostrando dados das tabelas
SELECT * FROM Pessoa;

SELECT * FROM Telefone;

SELECT * FROM Email;

-- Fazendo alteração
UPDATE Email
SET Email = 'gudynha@gmail.com'
WHERE idEmail = 4;

-- Juntando as tabelas
-- Relacionando a tabela Pessoa com Telefone
SELECT Telefone, Nome FROM Telefone
INNER JOIN Pessoa
ON Telefone.idPessoa = Pessoa.idPessoa;

-- Relacionando a tabela Pessoa com Email
SELECT Email, Nome FROM Email
INNER JOIN Pessoa
ON Email.idPessoa = Pessoa.idPessoa;