-- Selecionando e usando o banco de datas PClinics
Use PClinics;

-- Inserindo dados nas tabelas
INSERT INTO Clinica	(Nome, CNPJ, Endereco)
VALUES				('Pets', '05.533.407/0001-06', 'Rua Batuíra, 893 - SBC'),
					('DogMiau', '30.670.539/0001-19', 'Av. Lemos Monteiro, 82 - SCS'),
					('Cobasi', '53.153.938/0012-60', 'Rua Guilhermina, 550 - SA');

INSERT INTO Veteninario	(Nome, idClinica)
VALUES					('Flávia', 2),
						('Isabella', 1),
						('Gabriel', 3);

INSERT INTO Tipo	(Nome)
VALUES				('Cachorro'),
					('Gato');

INSERT INTO Raca	(Nome, idTipo)
VALUES				('Buldogue', 1),
					('Akita', 1),
					('Bernese', 1),
					('Maltês', 1),
					('Persa', 2),
					('Siamês', 2),
					('Sphynx', 2);

INSERT INTO Dono	(Nome)
VALUES				('Roberta'),
					('Fabíola'),
					('Silvio');

INSERT INTO Pets	(Nome, DataDeNascimento, idRaca)
VALUES				('Trovão', '03/02/20', 5),
					('Belinha', '22/07/20', 7),
					('Mandu', '15/09/20', 2),
					('Pucca', '01/02/21', 1);

INSERT INTO DonosPet	(idPet, idDono)
VALUES					(1, 1),
						(2, 2),
						(3, 3),
						(4, 2);

INSERT INTO Atendimento	(DataDeAtendimento, idPet)
VALUES					('20/02/20', 1),
						('25/09/20', 2),
						('30/10/20', 3),
						('15/02/21', 4);


