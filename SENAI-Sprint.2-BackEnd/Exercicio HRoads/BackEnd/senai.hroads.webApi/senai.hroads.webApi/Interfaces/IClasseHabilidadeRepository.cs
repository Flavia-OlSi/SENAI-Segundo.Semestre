using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IClasseHabilidadeRepository
    {
        /// <summary>
        /// Lista as classes e habilidades
        /// </summary>
        /// <returns>ma lista de classes habilidade</returns>
        List<ClasseHabilidade> Read();

        /// <summary>
        /// Busca uma classe habilidade atráves de seu id
        /// </summary>
        /// <param name="id">id da classe habilidade</param>
        /// <returns>Uma classe habilidade buscada</returns>
        ClasseHabilidade ReadId(int id);

        /// <summary>
        /// Cadastra uma classe habilidade
        /// </summary>
        /// <param name="novaClasseHabilidade">Objeto novaClasseHabilidade que será cadastrada</param>
        void Create(ClasseHabilidade novaClasseHabilidade);

        /// <summary>
        /// Atualiza uma classe habilidade
        /// </summary>
        /// <param name="id">id da classe habilidade que será atualizada</param>
        /// <param name="classeHabilidadeAtualizada">Objeto classeHabilidade com as novas informações</param>
        void Update(int id, ClasseHabilidade classeHabilidadeAtualizada);

        /// <summary>
        /// Deleta uma classe hablidade
        /// </summary>
        /// <param name="id">id da classe habilidade que será deletada</param>
        void Delete(int id);

        /// <summary>
        /// Lista todas as classesHabilidades com suas respectivas classes
        /// </summary>
        /// <returns>Uma lista de classesHabilidades com suas classes</returns>
        List<Classe> ReadClasse();
        /// <summary>
        /// Lista todas as classesHabilidades com suas respectivas habilidades
        /// </summary>
        /// <returns>Uma lista de classesHabilidades com suas habilidades</returns>
        List<Habilidade> ReadHabilidade();



    }
}
