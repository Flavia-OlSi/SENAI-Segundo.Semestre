using SENAI.SPMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.SPMedicalGroup.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório ClinicasRepository
    /// </summary>
    interface IClinicasRepository
    {
        /// <summary>
        /// Cadastra uma nova clinica
        /// </summary>
        /// <param name="novaClinica">Objeto novaClinica que será cadastrada</param>
        void Cadastrar(Clinicas novaClinica);
    }
}
