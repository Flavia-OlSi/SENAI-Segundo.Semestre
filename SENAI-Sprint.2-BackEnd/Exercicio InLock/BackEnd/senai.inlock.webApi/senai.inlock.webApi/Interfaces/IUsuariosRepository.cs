using senai.inlock.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Interfaces
{
    interface IUsuariosRepository
    {
        /// <summary>
        /// Retorna todos os usuários
        /// </summary>
        /// <returns>Uma lista de usuários</returns>
        List<UsuariosDomain> ReadAll();

        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="novoUsuario">Objeto novoUsuario que será cadastrado</param>
        void Create(UsuariosDomain novoUsuario);

        /// <summary>
        /// Deleta um usuário
        /// </summary>
        /// <param name="id">id do usuário que será deletada</param>
        void Delete(int id);
    }
}
