using SENAI.SPMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.SPMedicalGroup.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório MedicosRepository
    /// </summary>
    interface IMedicosRepository
    {
        /// <summary>
        /// Cadastra um novo médico
        /// </summary>
        /// <param name="novoMedico">Objeto novoMedico que será cadastrado</param>
        void Cadastrar(Medicos novoMedico);

        /// <summary>
        /// Lista todos os médicos
        /// </summary>
        /// <returns>Retorna uma lista de médicos</returns>
        List<Medicos> Listar();
    }
}
