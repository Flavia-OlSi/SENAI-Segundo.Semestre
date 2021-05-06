using senai.inlock.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Interfaces
{
    interface IEstudiosRepository
    {
        /// <summary>
        /// Retorna todos os estúdios
        /// </summary>
        /// <returns>Uma lista de estúdios</returns>
        List<EstudiosDomain> ReadAll();

        /// <summary>
        /// Busca um estudio atráves do seu id
        /// </summary>
        /// <param name="id">id do estudio que será buscado</param>
        /// <returns>Um objeto do tipo EstudiosDomain que foi buscado</returns>
        EstudiosDomain Read(int id);

        /// <summary>
        /// Cadastra um novo estudio
        /// </summary>
        /// <param name="novoEstudio">Objeto novoEstudio que será cadastrado</param>
        void Create(EstudiosDomain novoEstudio);

        /// <summary>
        /// Deleta um estudio
        /// </summary>
        /// <param name="id">id do estudio que será deletada</param>
        void Delete(int id);
    }
}
