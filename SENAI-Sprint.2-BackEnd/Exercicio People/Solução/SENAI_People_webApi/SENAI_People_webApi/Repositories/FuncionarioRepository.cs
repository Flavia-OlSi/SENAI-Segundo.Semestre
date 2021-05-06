using SENAI_People_webApi.Domains;
using SENAI_People_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI_People_webApi.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        /// <summary>
        /// String de conexão 
        /// </summary>
        private string stringConexao = "Data Source = LAPTOP-IUR0PGGG; initial catalog = M_Peoples; user Id = sa; pwd = Fiona1997*";

        /// <summary>
        /// Atualiza um funcionário existente
        /// </summary>
        /// <param name="id">ID do funcionário que será atualizado</param>
        /// <param name="funcionarioAtualizado">Objeto funcionarioAtualizado que será atualizado</param>
        public void Atualizar(int id, FuncionarioDomain funcionarioAtualizado)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Busca um funcionário pelo ID
        /// </summary>
        /// <param name="id">ID do funcionário que será buscado</param>
        /// <returns>Retorna o funcionário buscado conforme o id</returns>
        public FuncionarioDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Busca funcionários pelo nome
        /// </summary>
        /// <param name="nome">Objeto nome que será buscado</param>
        /// <returns>Retorna uma lista de funcionários com o nome especifico buscado</returns>
        public List<FuncionarioDomain> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deleta um funcionário
        /// </summary>
        /// <param name="id">ID do funcionário que será deletado</param>
        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Insere/cadastra um novo funcionario
        /// </summary>
        /// <param name="novoFuncionario">Objeto novoFuncionario que será inserido/cadastrado</param>
        public void Inserir(FuncionarioDomain novoFuncionario)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista todos os funcionários
        /// </summary>
        /// <returns>Retorna uma lista de funcionários</returns>
        public List<FuncionarioDomain> Listar()
        {
            List<FuncionarioDomain> funcionarios = new List<FuncionarioDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string queryReadAll = "SELECT * FROM Funcionarios";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryReadAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FuncionarioDomain funcionario = new FuncionarioDomain
                        {
                            idFuncionario = Convert.ToInt32(rdr["idFuncionario"]),
                            nome = rdr["Nome"].ToString(),
                            sobrenome = rdr["Sobrenome"].ToString(),
                            dataDeNascimento = Convert.ToDateTime(rdr["DataDeNascimento"])
                        };

                        funcionarios.Add(funcionario);
                    }

                    return funcionarios;
                }
            }
        }

        /// <summary>
        /// Lista os funcionários de forma que retorne seus nomes completos
        /// </summary>
        public List<FuncionarioDomain> ListarNomeCompleto()
        {
            List<FuncionarioDomain> funcionarios = new List<FuncionarioDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string queryReadAll = "SELECT CONCAT(Nome, ' ', Sobrenome) AS [Nome completo], DataDeNascimento FROM Funcionarios;";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryReadAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FuncionarioDomain funcionario = new FuncionarioDomain
                        {
                            idFuncionario = Convert.ToInt32(rdr["idFuncionario"]),
                            nome = rdr[1].ToString(),
                            dataDeNascimento = Convert.ToDateTime(rdr["DataDeNascimento"])
                        };

                        funcionarios.Add(funcionario);
                    }

                    return funcionarios;
                }
            }
        }

        /// <summary>
        /// Lista os funcionários de maneira ordenada
        /// </summary>
        /// <param name="ordem">String que define a ordenação</param>
        /// <returns>Retorna uma lista ordenada de de funcionários</returns>
        public List<FuncionarioDomain> ListarPorOrdem(string ordem)
        {
            List<FuncionarioDomain> funcionarios = new List<FuncionarioDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string queryReadAll = "SELECT Nome, Sobrenome, [Data de nascimento] FROM Funcionario ORDER BY Nome @ordem; ";

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryReadAll, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("ordem", ordem);

                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FuncionarioDomain funcionario = new FuncionarioDomain
                        {
                            idFuncionario = Convert.ToInt32(rdr["idFuncionario"]),
                            nome = rdr["nome"].ToString(),
                            sobrenome = rdr["sobrenome"].ToString(),
                            dataDeNascimento = Convert.ToDateTime(rdr["Data de Nascimento"])
                        };

                        funcionarios.Add(funcionario);
                    }

                    return funcionarios;
                }
            }
        }
    }
   
}
