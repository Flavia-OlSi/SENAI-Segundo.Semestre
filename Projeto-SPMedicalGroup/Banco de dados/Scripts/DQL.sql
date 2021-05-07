USE SPMedicalGroup;
GO

-- Vizualizando as tabelas
SELECT * FROM Especialidades;
SELECT * FROM Clinicas;
SELECT * FROM Situacoes;
SELECT * FROM TipoUsuarios;
SELECT * FROM Usuarios;
SELECT * FROM Medicos;
SELECT * FROM Pacientes;
SELECT * FROM Consultas;

-- Visualizando a quantidade de usuários
SELECT COUNT(IdUsuario) FROM Usuarios;

-- Convertendo a data de nascimento do paciente (mm-dd-yyyy) calculando a idade também
SELECT idUsuario, Nome,	convert(varchar, DataDeNascimento, 110) AS [Data de nascimento], DATEDIFF(year, DataDeNascimento, GETDATE()) AS [Idade], Telefone, RG, CPF, Logradouro, Numero, Bairro, Cidade, UF FROM Pacientes;

-- Visualizando a quantidade de médico por especialidade
SELECT COUNT(idMedico) FROM Medicos WHERE idEspecialidade = 17;

-- Visualizando a tabela Usuarios em conjunto com a TipoUsuarios
SELECT idUsuario, Email, Senha, Identicacao FROM Usuarios 
INNER JOIN	TipoUsuarios
ON Usuarios.idTipo = TipoUsuarios.idTipo;

-- Visualizando a tabela Medicos em conjunto com a tabela Especialidade, Clinica e Usuarios
SELECT CRM, Medicos.Nome, Especialidades.Nome, Clinicas.Nome, Email, Senha  FROM Medicos
INNER JOIN	Especialidades
ON Medicos.idEspecialidade = Especialidades.idEspecialidade
INNER JOIN	Clinicas
ON Medicos.idClinica = Clinicas.idClinica
INNER JOIN	Usuarios
ON Medicos.idUsuario = Usuarios.idUsuario;

-- Visualizando a tabela Pacientes em conjunto com a tabela Usuario
SELECT Nome, convert(varchar, DataDeNascimento, 110) AS DataDeNascimento, Telefone, RG, CPF, Logradouro, Numero, Bairro, Cidade, UF, Email, Senha  FROM Pacientes
INNER JOIN	Usuarios
ON Pacientes.idUsuario = Usuarios.idUsuario;

-- Visualizando a tabela de Consultas em conjunto com a tabela Pacientes, Medicos e Situacoes
SELECT Pacientes.Nome, DataDeConsulta, Medicos.Nome, Status FROM Consultas
INNER JOIN	Pacientes
ON Consultas.idPaciente = Pacientes.idPaciente
INNER JOIN	Medicos
ON Consultas.idMedico = Medicos.idMedico
INNER JOIN	Situacoes
ON Consultas.idSituacao = Situacoes.idSituacao;