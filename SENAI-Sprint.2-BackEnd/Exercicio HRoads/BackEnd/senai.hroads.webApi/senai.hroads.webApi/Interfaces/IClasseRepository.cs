using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IClasseRepository
    {
        /// <summary>
        /// Listar todos as classes
        /// </summary>
        /// <returns>Uma lista de classes</returns>
        List<Classe> Read();

        /// <summary>
        /// Busca uma classe através de seu id
        /// </summary>
        /// <param name="id">id da classe que será buscada</param>
        /// <returns>Uma classe buscada</returns>
        Classe ReadId(int id);

        /// <summary>
        /// Cadastra uma nova classe
        /// </summary>
        /// <param name="novaClasse">Onjeto novaClasse que será cadastrada</param>
        void Create(Classe novaClasse);

        /// <summary>
        /// Atualiza uma classe existente
        /// </summary>
        /// <param name="id">id da classe que será atualizada</param>
        /// <param name="classeAtualizada">Objeto classeAtualizada com as novas informações</param>
        void Update(int id, Classe classeAtualizada);

        /// <summary>
        /// Deleta uma classe existente
        /// </summary>
        /// <param name="id">id da classe que será deletada</param>
        void Delete(int id);
    }
}
