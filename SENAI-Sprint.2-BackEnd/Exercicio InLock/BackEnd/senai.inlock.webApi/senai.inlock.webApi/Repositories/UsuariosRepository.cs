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
    public class UsuariosRepository : IUsuariosRepository
    {
        /// <summary>
        /// String de conexão com o banco de dados que recebe os parâmetros
        /// data Source = Nome do servidor
        /// initial calog = Nome do banco de dados
        /// user e pwd = Faz a autenticação com o usuário do SQL Server, passando o logon e a senha
        /// </summary>
        private string stringConexao = "Data Source = LAPTOP-IUR0PGGG; initial catalog = inlock_games_manha; user Id = sa; pwd = Fiona1997*";

        /// <summary>
        /// Cadastra um novo usuarios
        /// </summary>
        /// <param name="novoUsuario">Objeto chamado novoUsuario com as informações que serão cadastradas</param>
        public void Create(UsuariosDomain novoUsuario)
        {
            // Declara a SqlConnection con passando a string de conexão 
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a instrução a ser executada 
                string queryInsert = "INSERT INTO Usuarios (email, senha, idTipoUsuario) VALUES (@email, @senha, @tipo)";

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    // Passa os valores para os parâmetros
                    cmd.Parameters.AddWithValue("@email", novoUsuario.email);
                    cmd.Parameters.AddWithValue("@senha", novoUsuario.senha);
                    cmd.Parameters.AddWithValue("@tipo", novoUsuario.idTipoUsurio);

                    // Abre a cone.xão com o banco de dados
                    con.Open();

                    // Executa a query
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Deleta um usuario através de seu id
        /// </summary>
        /// <param name="id">id do usuario que será deletado</param>
        public void Delete(int id)
        {
            // Declara a SqlConnection con passando a string de conexão
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a instrução a ser executada
                string queryDelete = "DELETE FROM Usuarios WHERE idUsuario = @ID";

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
        /// Busca um usuario através de seu id
        /// </summary>
        /// <param name="id">id do usuario que será buscado</param>
        /// <returns>Um usuario buscado ou null caso não seja encontrado</returns>
        public UsuariosDomain Read(int id)
        {
            // Declara a SqlConnection con passando a string de conexão
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a instrução a ser executada 
                string querySelect = "SELECT * FROM Usuarios WHERE idUsuario = @ID";

                // Abre a conexão com o banco de dados
                con.Open();

                // Declara o SqlDataReader rdr para receber os valores do banco de dados
                SqlDataReader rdr;

                // Declara o SqlCommand cmd passando a query que será executada e a conexão como parâmetros
                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    // Passa os valores para os parâmetros
                    cmd.Parameters.AddWithValue("@ID", id);

                    // Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        // Instancia um objeto usuario do tipo UsuariosDomain
                        UsuariosDomain usuario = new UsuariosDomain()
                        {
                            idUsuario = Convert.ToInt32(rdr[0]),
                            email = rdr[1].ToString(),
                            senha = rdr[2].ToString(),
                            idTipoUsurio = Convert.ToInt32(rdr[3])
                        };

                        // Retorna o usuario com os dados obtidos
                        return usuario;
                    }

                    // Se não, retorna null
                    return null;
                }
            }
        }

        /// <summary>
        /// Lista todos os Usuarios
        /// </summary>
        /// <returns>Uma lista de usuarios</returns>
        public List<UsuariosDomain> ReadAll()
        {
            // Cria uma lista listaEstudios onde serão armazenados os dados
            List<UsuariosDomain> listaUsuarios = new List<UsuariosDomain>();

            // Declara a SqlConnection con passando a string de conexão 
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a instrução a ser executada 
                string querySelectAll = "SELECT * FROM Usuarios";

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
                        // Instancia um objeto usuario do tipo UsuariosDomain
                        UsuariosDomain usuario = new UsuariosDomain()
                        {
                            idUsuario = Convert.ToInt32(rdr[0]),
                            email = rdr[1].ToString(),
                            senha = rdr[2].ToString(),
                            idTipoUsurio = Convert.ToInt32(rdr[3])
                        };

                        // Adiciona o objeto usuario à lista listaUsuarios
                        listaUsuarios.Add(usuario);
                    }
                }
            }
            // Retorna a lista de usuario
            return listaUsuarios;
        }

        public void UpdateBody(UsuariosDomain usuario)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Atualiza o usuario passando o id pelo recurso (URL)
        /// </summary>
        /// <param name="id">id do usuario que será atualizado</param>
        /// <param name="usuario">Objeto usuario com as novas informações</param>
        public void UpdateUrl(int id, UsuariosDomain usuario)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a instrução a ser executada
                string queryUpdateUrl = "UPDATE Estudios SET email = @email WHERE idUsuario = @ID";

                using (SqlCommand cmd = new SqlCommand(queryUpdateUrl, con))
                {
                    // Passa os valores para os parâmetros
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@email", usuario.email);

                    // Abre a conexão com o banco de dados
                    con.Open();

                    // Executa a query
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
