using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface ITiposDeHabilidadeRepository
    {
        /// <summary>
        /// Lista todos os tipos de habilidades
        /// </summary>
        /// <returns>Uma lista de tipos de habilidades</returns>
        List<TiposDeHabilidade> Read();

        /// <summary>
        /// Busca um tipo de habilidade por seu id
        /// </summary>
        /// <param name="id">id do tipo de habilidade que será buscado</param>
        /// <returns>Um tipo de habilidade buscado</returns>
        TiposDeHabilidade ReadId(int id);

        /// <summary>
        /// Cadastra um no tipo de habilidade
        /// </summary>
        /// <param name="novoTiposDeHabilidade">Objeto novoTipoDeHabilidade</param>
        void Create(TiposDeHabilidade novoTipoDeHabilidade);

        /// <summary>
        /// Atualiza um tipo de habilidade existente
        /// </summary>
        /// <param name="id">id do tipo de habilidade que será atualizado</param>
        /// <param name="tipoDeHabilidadeAtualizado">Objeto tipoDeHabilidadeAtulizado com novas informações</param>
        void Update(int id, TiposDeHabilidade tipoDeHabilidadeAtualizado);

        /// <summary>
        /// Deleta um tipo de habilidade
        /// </summary>
        /// <param name="id">id do tipo de habilidade que será deletado</param>
        void Delete(int id);
    }
}
