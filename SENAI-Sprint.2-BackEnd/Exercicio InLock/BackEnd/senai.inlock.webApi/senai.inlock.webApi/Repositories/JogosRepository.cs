using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Repositories
{
    /// <summary>
    /// Classe reponsável pelo repositório dos usuarios
    /// </summary>
    public class JogosRepository : IJogosRepository
    {
        /// <summary>
        /// String de conexão com o banco de dados que recebe os parâmetros
        /// data Source = Nome do servidor
        /// initial calog = Nome do banco de dados
        /// user e pwd = Faz a autenticação com o usuário do SQL Server, passando o logon e a senha
        /// </summary>
        private string stringConexao = "Data Source = LAPTOP-IUR0PGGG; initial catalog = inlock_games_manha; user Id = sa; pwd = Fiona1997*";

        /// <summary>
        /// Cadastra um novo jogo
        /// </summary>
        /// <param name="novoJogo">Objeto chamado novoJogo com as informações que serão cadastradas</param>
        public void Create(JogosDomain novoJogo)
        {
            // Declara a SqlConnection con passando a string de conexão 
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a instrução a ser executada 
                string queryInsert = "INSERT INTO Jogos (nomeJogo, descricao, dataLancamento, valor, idEstudio) VALUES (@nomeJogo, @descricao, @data, @valor, @idEstudio)";

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    // Passa os valores para os parâmetros
                    cmd.Parameters.AddWithValue("@nomeJogo", novoJogo.nomeJogo);
                    cmd.Parameters.AddWithValue("@descricao", novoJogo.descricao);
                    cmd.Parameters.AddWithValue("@data", novoJogo.dataLancamento);
                    cmd.Parameters.AddWithValue("@valor", novoJogo.valor);
                    cmd.Parameters.AddWithValue("@idEstudio", novoJogo.idEstudio);

                    // Abre a cone.xão com o banco de dados
                    con.Open();
                        
                    // Executa a query
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Deleta um jogo através de seu id
        /// </summary>
        /// <param name="id">id do jogo que será deletado</param>
        public void Delete(int id)
        {
            // Declara a SqlConnection con passando a string de conexão
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a instrução a ser executada
                string queryDelete = "DELETE FROM Jogos WHERE idJogo = @ID";

                // Declara o SqlCommand cmd passando a query que será executada e a conexão como parâmetros
                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    // Passa os valores para os parâmetros
                    cmd.Parameters.AddWithValue("@ID", id);

                    // Abre a conexão com o banco de dados
                    con.Open();

                    // Executa a query
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Busca um jogo através de seu id
        /// </summary>
        /// <param name="id">id do jogo que será buscado</param>
        /// <returns>Um jogo buscado ou null caso não seja encontrado</returns>
        public JogosDomain Read(int id)
        {
            // Declara a SqlConnection con passando a string de conexão
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a instrução a ser executada 
                string querySelect = "SELECT * FROM Jogos WHERE idJogo = @ID";

                // Abre a conexão com o banco de dados
                con.Open();

                // Declara o SqlDataReader rdr para receber os valores do banco de dados
                SqlDataReader rdr;

                // Declara o SqlCommand cmd passando a query que será executada e a conexão como parâmetros
                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    // Passa os valores para os parâmetros
                    cmd.Parameters.AddWithValue("@ID", id);

                    // Executa a query e armazena os dadis no rdr
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        // Instancia um objeto jogo do tipo JogosDomain
                        JogosDomain jogo = new JogosDomain()
                        {
                            idJogo = Convert.ToInt32(rdr[0]),
                            nomeJogo = rdr[1].ToString(),
                            descricao = rdr[2].ToString(),
                            dataLancamento = Convert.ToDateTime(rdr[3]),
                            valor = Convert.ToDecimal(rdr[4]),
                            idEstudio = Convert.ToInt32(rdr[5])
                        };

                        // Retorna o jogo com os dados obtidos
                        return jogo;
                    }

                    // Se não, retorna null
                    return null;
                }
            }
        }

        /// <summary>
        /// Lista todos os Jogos
        /// </summary>
        /// <returns>Uma lista de jogos</returns>
        public List<JogosDomain> ReadAll()
        {
            // Cria uma lista listaJogos onde serão armazenados os dados
            List<JogosDomain> listaJogos = new List<JogosDomain>();

            // Declara a SqlConnection con passando a string de conexão 
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a instrução a ser executada
                string querySelectAll = "SELECT * FROM Jogos";

                // Abra a conexão com o banco de dados
                con.Open();

                // Declara o SqlDataReader rdr para percorrer a tabela do banco de dados
                SqlDataReader rdr;

                // Declara o SqlCommand cmd passando a query que será executada e a conexão como parâmetros
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    // Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    // Enquanto houver registros para serem lidos no rdr, o laço se repete
                    while (rdr.Read())
                    {
                        // Instancia um objeto jogo do tipo JogosDomain
                        JogosDomain jogos = new JogosDomain()
                        {
                            idJogo = Convert.ToInt32(rdr[0]),
                            nomeJogo = rdr[1].ToString(),
                            descricao = rdr[2].ToString(),
                            dataLancamento = Convert.ToDateTime(rdr[3]),
                            valor = Convert.ToDecimal(rdr[4]),
                            idEstudio = Convert.ToInt32(rdr[5])
                        };

                        // Adiciona o objeto jogo à lista listaEstudios
                        listaJogos.Add(jogos);
                    }
                }
            }
            // Retorna a lista de jogos
            return listaJogos;
        }

        public void UpdateBody(JogosDomain jogo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Atualiza o jogo passando o id pelo recurso (URL)
        /// </summary>
        /// <param name="id">id do jogo que será atualizado</param>
        /// <param name="jogo">Objeto jogo com as novas informações</param>
        public void UpdateUrl(int id, JogosDomain jogo)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a instrução a ser executada
                string queryUpdateUrl = "UPDATE Estudios SET nomeJogo = @nomeJogo WHERE idJogo = @ID";

                using (SqlCommand cmd = new SqlCommand(queryUpdateUrl, con))
                {
                    // Passa os valores para os parâmetros
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@nomeJogo", jogo.nomeJogo);

                    // Abre a conexão com o banco de dados
                    con.Open();

                    // Executa a query
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
