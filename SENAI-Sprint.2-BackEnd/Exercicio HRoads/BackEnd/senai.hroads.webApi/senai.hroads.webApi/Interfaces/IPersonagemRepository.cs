using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IPersonagemRepository
    {
        /// <summary>
        /// Lisata os personagens
        /// </summary>
        /// <returns>Uma lista de personagens</returns>
        List<Personagem> Read();

        /// <summary>
        /// Busca um personagem através de seu id
        /// </summary>
        /// <param name="id">id do personagem buscado</param>
        /// <returns>Um personagem budcado</returns>
        Personagem ReadId(int id);

        /// <summary>
        /// Cadastra um novo personagem
        /// </summary>
        /// <param name="novoPersonagem">Objeto novoPersonagem que será cadastrado</param>
        void Create(Personagem novoPersonagem);

        /// <summary>
        /// Atualiza um personagem existente
        /// </summary>
        /// <param name="id">id do personagem que será atualizado</param>
        /// <param name="personagemAtualizado">Objeto personagemAtualizado com novas informações</param>
        void Update(int id, Personagem personagemAtualizado);

        /// <summary>
        /// Deleta um personagem
        /// </summary>
        /// <param name="id">id do persoangem que será deletado</param>
        void Delete(int id);

        /// <summary>
        /// Lista todos os personagens com suas respectivas classes
        /// </summary>
        /// <returns>Uma lista de persoangem com suas classes</returns>
        List<Classe> ReadClasse();

        /// <summary>
        /// Lista todos os personagens com seus respctivos usuarios
        /// </summary>
        /// <returns>Uma lista de persinagem com seus respectivos usuarios</returns>
        List<Usuario> Readusuario();
    }
}
