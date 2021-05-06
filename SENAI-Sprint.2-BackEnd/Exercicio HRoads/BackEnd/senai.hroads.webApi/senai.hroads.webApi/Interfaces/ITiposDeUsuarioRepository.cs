using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface ITiposDeUsuarioRepository
    {
        /// <summary>
        /// Lista todos os tipos de usuarios
        /// </summary>
        /// <returns>Uma lista de tipos de usuarios</returns>
        List<TiposDeUsuario> Read();

        /// <summary>
        /// Busca um tipo de usuario através de seu id
        /// </summary>
        /// <param name="id">id do tipo de usuario que será buscado</param>
        /// <returns>Um tipo de usuario buscado</returns>
        TiposDeUsuario ReadId(int id);

        /// <summary>
        /// Cadastra um tipo de usuario
        /// </summary>
        /// <param name="novoTipoDeUsuario">Objeto novoTipoDeUsuario que será cadastrado</param>
        void Create(TiposDeUsuario novoTipoDeUsuario);

        /// <summary>
        /// Atualiza o tipo de usuario existente
        /// </summary>
        /// <param name="id">id do tipo de usuario que será atualizado</param>
        /// <param name="tipoDeUsuarioAtualizado">Objeto tipoDeUsuarioAtualizado com as novas informações</param>
        void Update(int id, TiposDeUsuario tipoDeUsuarioAtualizado);

        /// <summary>
        /// Deleta um tipo de usuario
        /// </summary>
        /// <param name="id">id do tipo de usuario que será deletado</param>
        void Delete(int id);

    }
}
