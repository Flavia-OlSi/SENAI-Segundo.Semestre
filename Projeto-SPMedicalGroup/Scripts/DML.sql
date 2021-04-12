USE SPMedicalGroup;
GO

INSERT INTO Especialidades	(Nome)
VALUES						('Acupuntura'),
							('Anestesiologia'),
							('Angiologia'),
							('Cardiologia'),
							('Cirurgia Cardiovascular'),
							('Cirurgia da Mão'),
							('Cirurgia do Aparelho Digestivo'),
							('Cirurgia Geral'),
							('Cirurgia Pediátrica'),
							('Cirurgia Plástica'),
							('Cirurgia Torácica'),
							('Cirurgia Vascular'),
							('Dermatologia'),
							('Radioterapia'),
							('Urologia'),
							('Pediatria'),
							('Psiquiatria');
GO

INSERT INTO Clinicas	(Nome, CNPJ, [Razão social], Logradouro, [Número], Cidade, UF)
VALUES					('Clinica Possarle', '86.400.902/0001-30', 'SP Medical Group', 'Av. Barão Limeira', 532, 'São Paulo', 'SP');
GO

INSERT INTO Situacoes	([Status])
VALUES					('Agendada'),
						('Realizada'),
						('Cancelada');
GO


INSERT INTO TipoUsuarios	([Identificação])
VALUES						('Administrador'),
							('Médico'),
							('Paciente');
GO

INSERT INTO Usuarios	(idTipo, Email, Senha)
VALUES					(1, 'adm@adm.com', 'adm1'),
						(2, 'ricardo.lemos@spmedicalgroup.com.br', 'ricardo1'),
						(2, 'roberto.possarle@spmedicalgroup.com.br', 'roberto1'),
						(2, 'helena.souza@spmedicalgroup.com.br', 'helena1'),
						(3, 'ligia@gmail.com', 'ligia1'),
						(3, 'alexandre@gmail.com', 'alexandre1'),
						(3, 'fernando@gmail.com', 'fernando1'),
						(3, 'henrique@gmail.com', 'henrique1'),
						(3, 'joao@hotmail.com', 'joao1'),
						(3, 'bruno@gmail.com', 'bruno1'),
						(3, 'mariana@outlook.com', 'mariana1');
GO

INSERT INTO Medicos	(idEspecialidade, idClinica, idUsuario, CRM, Nome)
VALUES				(2, 1, 2, '54356-SP', 'Ricardo Lemos'),
					(17, 1, 3, '53452-SP', 'Roberto Possarle'),
					(16, 1, 4, '65463-SP', 'Helena Strada');
GO				

INSERT INTO Pacientes	(idUsuario, Nome, [Data de nascimento], Telefone, RG, CPF, Logradouro, [Número], Bairro, Cidade, UF, CEP)
VALUES				(5, 'Ligia', '13/10/1983', '11 3456-7654', '435225435', '94839859000', 'Rua Estado de Israel', 240, null, 'São Paulo', 'SP', '04022-000'),
					(6, 'Alexandre', '23/07/2001', '11 98765-6543', '326543457', '73556944057', 'Av. Paulista', 1578, 'Bela Vista', 'São Paulo', 'SP', '01310-200'),
					(7, 'Fernanda', '10/10/1978', '11 97208-4453', '546365253', '16839338002', 'Av. Ibirapuera', 2927, 'Indianópolis', 'São Paulo', 'SP', '04029-200'),
					(8, 'Henrique', '13/10/1985', '11 3456-6543', '543663625', '14332654765', 'R. Vitória', 120, 'Vila São Jorge', 'Barueri', 'SP', '06402-030'),
					(9, 'João', '27/08/1975', '11 7656-6377', '432544441', '91305348010', 'R. Ver. Geraldo de Camargo', 66, 'Santa Luzia', 'Riberão Pires', 'SP', '09405-380'),
					(10, 'Bruno', '21/03/1972', '11 95436-8769', '545662667', '79799299004', 'Alameda dos Arapanés', 345, 'Indianópolis', 'São Paulo', 'SP', '04524-001'),
					(11, 'Mariana', '05/03/2018', null, '545662668', '13771913039', 'R Sao Antonio', 232, 'Vila Universal', 'São Paulo', 'SP', '06407-140');
GO

INSERT INTO Consultas	(IdPaciente, IdMedico, IdSituacao, [Data])
VALUES					(7, 3, 2, '20/01/2020  15:00'),
						(2, 2, 3, '06/01/2020  10:00'),
						(3, 2, 2, '07/02/2020  11:00'),
						(2, 2, 2, '06/02/2018  10:00'),
						(4, 1, 3, '07/02/2019  11:00'),
						(7, 3, 1, '08/03/2020  15:00'),
						(4, 1, 1, '09/03/2020  11:00');
GO