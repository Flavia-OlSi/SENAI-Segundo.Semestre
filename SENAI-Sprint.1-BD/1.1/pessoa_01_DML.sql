-- Selecionando e usando o banco de datas Pessoas
Use Pessoa;

-- Inserindo dados nas tabelas
INSERT INTO Pessoa	(Nome, CNH)
VALUES				('Flávia', 123),
					('Saulo', 456),
					('Caique', 789);

INSERT INTO Telefone	(Telefone, idPessoa)
VALUES					('1010-2020', 1),
						('3030-4040', 1),
						('5050-6060', 2),
						('7070-8080', 3),
						('9090-0000', 2);

INSERT INTO Email	(Email, idPessoa)
VALUES				('flavia@senai.com', 1),
					('saulo@senai.com', 2),
					('caique@senai.com', 3),
					('flavia_gudy@hotmail.com', 1)

