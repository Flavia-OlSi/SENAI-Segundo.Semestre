using SENAI_filmes_webApi.Domains;
using SENAI_filmes_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI_filmes_webApi.Repositories
{
    /// <summary>
    /// Classe responsável pelo repositório dos gêneros
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// String de conexão com o banco de dados que recebe os parâmetro
        /// Data Source = Nome do servidor
        /// initial catalog = Nome do banco de dados
        /// user Id = sa; pwd = Fiona1997* = Faz a autenticação com o usuário do SQL Server, passando pelo logon e a senha
        /// integrated security = true = Faz a autenticação com o usuário do sistema (Windows)
        /// </summary>
        private string stringConexao = "Data Source = LAPTOP-IUR0PGGG; initial catalog = Filmes; user Id = sa; pwd = Fiona1997*";
        //private string stringConexão = "Data Source = LAPTOP-IUR0PGGG; integrated securyt = true";
        public void AtualizarIdCorpo(GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int id, GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cadastro um novo gênero
        /// </summary>
        /// <param name="novoGenero">Objeto novoGenero com as informações que serão cadastradas</param>
        public void Cadastrar(GeneroDomain novoGenero)
        {
            // Declara a SqlConnection con passa a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declsra a query que será executada
                // INSERT INTO Generos(Nome) VALUES('Aventura');
                //string queryInsert = "INSERT INTO Generos(Nome) VALUES ('" + novoGenero.nome + "')";
                // Não usar dessa forma pois pode causar o efeito Joana D'Arc
                // Além de permitir SQL Injection
                // Por exemplo
                // "nome" : "') DROP TABLE Filmes--"
                // Ao tentar cadastrar o comando acima, irá deletar a tabela Filmes do banco de dados

                //Declara a query que será executada
                string queryInsert = "INSERT INTO Generos(Nome) VALUES (@Nome)";

                // Declara o SqlCommand cmd passando a query que será executada e a conexão como parâmetros
                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    // Passa o valor para o parâmetro nome
                    cmd.Parameters.AddWithValue("@Nome", novoGenero.nome);

                    // Abre a conexão com o banco de dados
                    con.Open();

                    // Executa query
                    cmd.ExecuteNonQuery();

                }
            }
        }

        /// <summary>
        /// Deleta um gênero através do seu id
        /// </summary>
        /// <param name="id">id do gênero que será deletado</param>
        public void Deletar(int id)
        {
            // Declara a SqlConnection con passa a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a query a ser executada passando o valor como parâmetro
                string queryDelete = "DELETE FROM Generos WHERE idGenero = @ID";

                // Declara a SqlCommand cmd passando a query que será executada e a conexão como parêmetros
                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    // Define o valor do id recebido no método como o valor do parâmetro @ID
                    cmd.Parameters.AddWithValue("@ID", id);

                    // Abre a conexão com o banco de dados
                    con.Open();

                    // Executa a query
                    cmd.ExecuteNonQuery();
                }

            }

        }

        /// <summary>
        /// Lista todos os gêneros
        /// </summary>
        /// <returns>Uma lista de gêneros</returns>
        public List<GeneroDomain> ListarTodos()
        {
            // Cria uma lista listaGeneros onde serão armazenados os dados
            List<GeneroDomain> listaGeneros = new List<GeneroDomain>();

            // Declara a SqlConnection con passa a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a instrução a ser executada
                string querySelectAll = "SELECT idGenero, Nome FROM Generos";

                // Abre a conexão com o banco de dados
                con.Open();

                // Declara o sqlDataReader rdr para percorrer a tabela do banco de dados
                SqlDataReader rdr;

                // Declara a SqlCommand cmd passando a quere que será executada e a conexão como parâmetros
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    // Executa a query e armazena os dados na rdr
                    rdr = cmd.ExecuteReader();

                    // Enquanto houver registros para serem lidos no rdr, o laço se repete
                    while (rdr.Read())
                    {
                        // Instancia um objeto genero do tipo GeneroDomain
                        GeneroDomain genero = new GeneroDomain()
                        {
                            // Atribui à propiedade idGenero o valor da primeira coluna da tabela do banco de dados
                            idGenero = Convert.ToInt32(rdr[0]),

                            // Atribui à propiedade nome o valor da segunda coluna da tabela do banco de dados
                            nome = rdr[1].ToString()
                        };

                        // Adiciona o objeto genero à lista listaGeneros
                        listaGeneros.Add(genero);
                    } 

                }
            }

            // Retorna a lista de generos
            return listaGeneros;
        }
    }
}
