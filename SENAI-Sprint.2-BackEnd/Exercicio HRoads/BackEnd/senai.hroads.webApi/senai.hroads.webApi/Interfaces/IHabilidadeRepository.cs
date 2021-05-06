using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IHabilidadeRepository
    {
        /// <summary>
        /// Lista todos as habilidades
        /// </summary>
        /// <returns>Uma lista de habilidades</returns>
        List<Habilidade> Read();

        /// <summary>
        /// Busca uma habilidade através de seu id
        /// </summary>
        /// <param name="id">id da habilidade que será buscada</param>
        /// <returns>Uma habilidade buscada</returns>
        Habilidade ReadId(int id);

        /// <summary>
        /// Cadastra uma nova habilidade
        /// </summary>
        /// <param name="novaHabilidade">Objeto novaHabilidade que será cadastrada</param>
        void Create(Habilidade novaHabilidade);

        /// <summary>
        /// Atualiza uma habilidade existente
        /// </summary>
        /// <param name="id">id da habilidade que será atualizada</param>
        /// <param name="habilidadeAtualizada">Objeto habilidadeAtualizada com as novas informações</param>
        void Update(int id, Habilidade habilidadeAtualizada);

        /// <summary>
        /// Deleta uma habilidade
        /// </summary>
        /// <param name="id">id da habilidade que será deletada</param>
        void Delete(int id);

        /// <summary>
        /// Lista todas as habilidades com seus respectivos tipos de habilidades
        /// </summary>
        /// <returns>Uma lista de habilidades com seus tipos</returns>
        List<ClasseHabilidade> ReadClasseHabilidade();

    }
}
