-- Selecionando e usando o banco de datas Locadora
Use Locadora;

-- Relacionando as tabelas
-- Relacionando a tabela Modelo com tabela Marca (todos os modelos e marcas em comum)
SELECT Modelo.Nome AS Modelo, Marca.Nome AS Marca FROM Modelo
INNER JOIN Marca
ON Modelo.idMarca = Marca.idMarca;

-- Relacionando a tabela de Veiculo com a tabela de Empresa (todas os veículos independente da empresa)
SELECT Veiculos.idVeiculo, Empresa.Nome AS Empresa FROM Veiculos
LEFT JOIN Empresa
ON Veiculos.idEmpresa = Empresa.idEmpresa;

-- Relacionando a tabela de Veiculos com a tabela de Modelo (todas os veículos independente da modelo) 
SELECT Veiculos.idVeiculo, Modelo.Nome AS Modelo FROM Veiculos
LEFT JOIN Modelo
ON Veiculos.idModelo = Modelo.idModelo;


