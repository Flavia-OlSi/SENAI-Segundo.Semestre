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
    public class EstudiosRepository : IEstudiosRepository
    {
        /// <summary>
        /// String de conexão com o banco de dados que recebe os parâmetros
        /// data Source = Nome do servidor
        /// initial calog = Nome do banco de dados
        /// user e pwd = Faz a autenticação com o usuário do SQL Server, passando o logon e a senha
        /// </summary>
        private string stringConexao = "Data Source = LAPTOP-IUR0PGGG; initial catalog = inlock_games_manha; user Id = sa; pwd = Fiona1997*";

        /// <summary>
        /// Cadastra um novo estudios
        /// </summary>
        /// <param name="novoEstudio">Objeto chamado novoEstudio com as informações que serão cadastradas</param>
        public void Create(EstudiosDomain novoEstudio)
        {
            // Declara a SqlConnection con passando a string de conexão 
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a instrução a ser executada 
                string queryInsert = "INSERT INTO Estudios (nomeEstudios) VALUES (@NomeEstudio)";

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    // Passa os valores para os parâmetros
                    cmd.Parameters.AddWithValue("@NomeEstudio", novoEstudio.nomeEstudio);

                    // Abre a conexão com o banco de dados
                    con.Open();

                    // Executa a query
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Deleta um estudio através de seu id
        /// </summary>
        /// <param name="id">id do estudio que será deletado</param>
        public void Delete(int id)
        {
            // Declara a SqlConnection con passando a string de conexão
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a instrução a ser executada
                string queryDelete = "DELETE FROM Estudios WHERE idEstudio = @ID";

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
        /// Busca um estudio através de seu id
        /// </summary>
        /// <param name="id">id do estudio que será buscado</param>
        /// <returns>um estudio buscado ou null caso não seja encontrado</returns>
        public EstudiosDomain Read(int id)
        {
            // Declara a SqlConnection con passando a string de conexão
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a instrução a ser executada 
                string querySelect = "SELECT * FROM Estudios WHERE idEstudio = @ID";

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
                        // Instancia um objeto estudio do tipo EstudioDomain
                        EstudiosDomain estudio = new EstudiosDomain()
                        {
                            // Atribui à propriedade idEstudio o valor da primeira coluna da tabela do banco de dados
                            idEstudio = Convert.ToInt32(rdr[0]),

                            // Atribui à propiedade nome o valor da segunda coluna da tabela do banco de dados
                            nomeEstudio = rdr[1].ToString()
                        };

                        // Retorna o estudio com os dados obtidos
                        return estudio;
                    }

                    // Se não, retorna null
                    return null;
                }
            }
        }

        /// <summary>
        /// Lista todos os Estudios
        /// </summary>
        /// <returns>Uma lista de estudios</returns>
        public List<EstudiosDomain> ReadAll()
        {
            // Cria uma lista listaEstudios onde serão armazenados os dados
            List<EstudiosDomain> listaEstudios = new List<EstudiosDomain>();

            // Declara a SqlConnection con passando a string de conexão 
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a instrução a ser executada 
                string querySelectAll = "SELECT * FROM Estudios";

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
                        // Instancia um objeto estudio do tipo EstudioDomain
                        EstudiosDomain estudio = new EstudiosDomain()
                        {
                            // Atribui à propriedade idEstudio o valor da primeira coluna da tabela do banco de dados
                            idEstudio = Convert.ToInt32(rdr[0]),

                            // Atribui à propiedade nome o valor da segunda coluna da tabela do banco de dados
                            nomeEstudio = rdr[1].ToString()
                        };

                        // Adiciona o objeto estudio à lista listaEstudios
                        listaEstudios.Add(estudio);
                    }
                }
            }

            // Retorna a lista de Estudios
            return listaEstudios;
        }
    }
}
