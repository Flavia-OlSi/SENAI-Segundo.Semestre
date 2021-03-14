-- Selecionando e usando o banco de datas Locadora
Use Locadora;

-- Inserindo dados nas tabelas
INSERT INTO Empresa (Nome, CNPJ)
VALUES				('Localiza', '16.670.085/0001-55'),
					('Unidas', '04.437.534/0001-30'),
					('Movida', '21.314.559/0001-66');

INSERT INTO Cliente (Nome, Idade)
VALUES				('Flávia', 23),
					('Ana', 27),
					('Lucas', 22);

INSERT INTO Marca	(Nome)
VALUES				('Honda'),
					('Fiat');

INSERT INTO Modelo	(Nome, idMarca)
VALUES				('Civic', 1),
					('Argo', 2);

INSERT INTO Veiculos	(Placa, idEmpresa, idModelo)
VALUES					('FKL205', 1, 1),
						('GTH879', 2, 1),
						('QXR341', 3, 2),
						('POZ608', 2, 2);

INSERT INTO Aluguel		([Dia da retirada], [Dia da devolução], idCliente, idVeiculo)
VALUES					('03/02/20', '04/02/20', 1, 4),
						('22/07/20', '25/07/20', 2, 2),
						('15/09/20', '15/09/20', 3, 3),
						('01/02/21', '10/02/21', 2, 1);

-- Inserindo mais uma marca
INSERT INTO	Marca (Nome)
VALUES		('Toyota');
