using senai.inlock.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Interfaces
{
    interface IJogosRepository
    {
        /// <summary>
        /// Retorna todos os jogos
        /// </summary>
        /// <returns>Uma lista de jogos</returns>
        List<JogosDomain> ReadAll();

        /// <summary>
        /// Busca um jogo atráves do seu id
        /// </summary>
        /// <param name="id">id do jogo que será buscado</param>
        /// <returns>Um objeto do tipo JogosDomain que foi buscado</returns>
        JogosDomain Read(int id);

        /// <summary>
        /// Cadastra um novo jogo
        /// </summary>
        /// <param name="novoJogo">Objeto novoJogo que será cadastrado</param>
        void Create(JogosDomain novoJogo);

        /// <summary>
        /// Deleta um jogo
        /// </summary>
        /// <param name="id">id do jogo que será deletada</param>
        void Delete(int id);
    }
}
