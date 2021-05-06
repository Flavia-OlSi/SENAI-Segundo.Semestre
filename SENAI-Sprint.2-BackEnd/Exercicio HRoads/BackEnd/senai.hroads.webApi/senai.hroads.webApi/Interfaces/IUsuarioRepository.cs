using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Lista todos os usuarios
        /// </summary>
        /// <returns>Uma lista de usuarios</returns>
        List<Usuario> Read();

        /// <summary>
        /// Busca um tipo de usuario através de seu id
        /// </summary>
        /// <param name="id">id do usuario buscado</param>
        /// <returns>Um usuario buscado</returns>
        Usuario ReadId(int id);

        /// <summary>
        /// Cadastra um usuario
        /// </summary>
        /// <param name="novoUsuario">Objeto novoUsuario que será cadastrado</param>
        void Create(Usuario novoUsuario);

        /// <summary>
        /// Atualiza um usuario existente
        /// </summary>
        /// <param name="id">id do usuario que será atualizado</param>
        /// <param name="usuarioAtualizado">Objeto usuarioAtualizado com as novas informações</param>
        void Update(int id, Usuario usuarioAtualizado);

        /// <summary>
        /// Deleta um usuario
        /// </summary>
        /// <param name="id">id do usuario que será deletado</param>
        void Delete(int id);

        /// <summary>
        /// Lista todos os usuarios com seus respectivos tipos de usuario
        /// </summary>
        /// <returns>Uma lista de usuarios com seus tipos</returns>
        List<TiposDeUsuario> ReadTiposDeUsuario();
    }
}
