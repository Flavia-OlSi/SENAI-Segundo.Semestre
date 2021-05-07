using SENAI.SPMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.SPMedicalGroup.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório PacientesRepository
    /// </summary>
    interface IPacientesRepository
    {
        /// <summary>
        /// Cadastra um novo paciente
        /// </summary>
        /// <param name="novoPaciente">Objeto novoPaciente que será cadastrado</param>
        void Cadastrar(Pacientes novoPaciente);
    }
}
